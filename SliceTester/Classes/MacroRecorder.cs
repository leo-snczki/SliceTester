using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using WindowsInput;
using WindowsInput.Native;
using SliceTester.Classes;
using Newtonsoft.Json;
using SliceTester;

public class MacroRecorder
{
    public enum MacroEventType { KeyDown, KeyUp, MouseDown, MouseUp }

    private IKeyboardMouseEvents _globalHook; // Responsável por capturar eventos globais de teclado e mouse.
    private List<MacroEvent> _recordedEvents = new List<MacroEvent>();
    private Stopwatch _stopwatch = new Stopwatch(); // Cronômetro para medir o tempo e delay entre eventos.
    private LogManager _logManager;
    private bool _isRecording = false;
    private bool _isPlaying = false;


    public MacroRecorder(LogManager logger)
    {
        _logManager = logger;
    }
    public ref readonly bool IsRecording() => ref _isRecording;

    public void StartRecording()
    {
        try
        {
            _recordedEvents.Clear();
            _stopwatch.Restart();
            _globalHook = Hook.GlobalEvents();

            _logManager.Log("[INFO] Iniciando gravação...");
            _isRecording = true;
            bool firstKeyDown = false;  // Flag para garantir que um KeyDown ocorra antes de um KeyUp.
            bool firstMouseDown = false; // Flag para garantir que um MouseDown ocorra antes de um MouseUp.

            // Captura eventos de pressionamento de tecla.
            _globalHook.KeyDown += (sender, e) =>
            {
                firstKeyDown = true; // Marca que um KeyDown ocorreu.

                _recordedEvents.Add(new MacroEvent
                {
                    EventType = MacroEventType.KeyDown,
                    Key = e.KeyCode,
                    Timestamp = _stopwatch.ElapsedMilliseconds
                });
                _logManager.Log($"[RECORD] KeyDown: {e.KeyCode} ({_stopwatch.ElapsedMilliseconds}ms)");
            };

            // Captura eventos de soltura de tecla.
            _globalHook.KeyUp += (sender, e) =>
            {
                if (firstKeyDown) // Só registra KeyUp se já tiver ocorrido um KeyDown.
                {
                    _recordedEvents.Add(new MacroEvent
                    {
                        EventType = MacroEventType.KeyUp,
                        Key = e.KeyCode,
                        Timestamp = _stopwatch.ElapsedMilliseconds
                    });
                    _logManager.Log($"[RECORD] KeyUp: {e.KeyCode} ({_stopwatch.ElapsedMilliseconds}ms)");
                }
            };

            // Captura eventos de clique do mouse.
            _globalHook.MouseDown += (sender, e) =>
            {
                firstMouseDown = true; // Marca que um MouseDown ocorreu.

                _recordedEvents.Add(new MacroEvent
                {
                    EventType = MacroEventType.MouseDown,
                    MouseButton = e.Button,
                    MousePosition = e.Location,
                    Timestamp = _stopwatch.ElapsedMilliseconds
                });
                _logManager.Log($"[RECORD] MouseDown: {e.Button} em {e.Location} ({_stopwatch.ElapsedMilliseconds}ms)");
            };

            // Captura eventos de soltura do botão do mouse.
            _globalHook.MouseUp += (sender, e) =>
            {
                if (firstMouseDown) // Só registra MouseUp se já tiver ocorrido um MouseDown.
                {
                    _recordedEvents.Add(new MacroEvent
                    {
                        EventType = MacroEventType.MouseUp,
                        MouseButton = e.Button,
                        MousePosition = e.Location,
                        Timestamp = _stopwatch.ElapsedMilliseconds
                    });
                    _logManager.Log($"[RECORD] MouseUp: {e.Button} em {e.Location} ({_stopwatch.ElapsedMilliseconds}ms)");
                }
            };
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro na gravação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _logManager.Log($"[ERROR] (RECORD): {ex.Message}");
        }
    }

    public void StopRecording()
    {
        List<int> indexesToRemove = new List<int>();

        for (int i = 0; i < _recordedEvents.Count - 1; i++)
        {
            if (_recordedEvents[i].EventType == MacroEventType.KeyDown && _recordedEvents[i].Key == Keys.LControlKey)
            {
                // Procura pelo próximo KeyDown de F2 após Ctrl.
                for (int j = i + 1; j < _recordedEvents.Count; j++)
                {
                    if (_recordedEvents[j].EventType == MacroEventType.KeyDown && _recordedEvents[j].Key == Keys.F2)
                    {
                        // Marca para remoção
                        indexesToRemove.Add(i); // KeyDown de Ctrl.
                        indexesToRemove.Add(j); // KeyDown de F2.
                        break;
                    }
                }
            }
        }

        // Remove os eventos KeyDown de Ctrl e F2.
        _recordedEvents.RemoveAll(e =>
            indexesToRemove.Contains(_recordedEvents.IndexOf(e)) // Remove KeyDowns encontrados.
        );

        _globalHook.Dispose();
        _stopwatch.Stop();
        _isRecording = false;
        _logManager.Log("[INFO] Gravação encerrada.");
    }

    public void Play()
    {
        try
        {
            if (_isPlaying) // Sem mensagem de log porque o panel já vai estar sendo usado com a execução.
                return;

            if (_recordedEvents.Count == 0)
            {
                _logManager.Log("[INFO] Reprodução não iniciada: A lista de eventos está vazia!");
                MessageBox.Show("Reprodução não iniciada: A lista de eventos está vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _isPlaying = true;

            var inputSimulator = new InputSimulator();
            // Timestamp é um valor que representa um ponto específico no tempo.
            long lastTimestamp = 0;

            _logManager.Log("[INFO] Reprodução iniciada.");
            foreach (var ev in _recordedEvents)
            {
                long delay = ev.Timestamp - lastTimestamp; // Calcula o tempo de atraso entre o evento atual e o anterior.
                if (delay < 0)
                    throw new Exception("Delay menor que zero!");

                Thread.Sleep((int)delay); // Espera pelo tempo de atraso antes de executar o próximo evento.
                lastTimestamp = ev.Timestamp; // Atualiza o timestamp do último evento.

                // Simula o evento de acordo com o tipo.
                switch (ev.EventType)
                {
                    case MacroEventType.KeyDown:
                        inputSimulator.Keyboard.KeyDown((VirtualKeyCode)ev.Key);
                        _logManager.Log($"[PLAY] KeyDown: {ev.Key} ({ev.Timestamp}ms)");
                        break;

                    case MacroEventType.KeyUp:
                        inputSimulator.Keyboard.KeyUp((VirtualKeyCode)ev.Key);
                        _logManager.Log($"[PLAY] KeyUp: {ev.Key} ({ev.Timestamp}ms)");
                        break;

                    case MacroEventType.MouseDown:
                        // a multiplicação por 65535 é o ajuste da posição do mouse referente a API do InputSimulator.
                        // O windows mede por pixels.
                        // O inputSimulator mede usando base 2^16 com máximo até 65535.
                        inputSimulator.Mouse.MoveMouseTo(ev.MousePosition.X * 65535 / Screen.PrimaryScreen.Bounds.Width,
                                                         ev.MousePosition.Y * 65535 / Screen.PrimaryScreen.Bounds.Height);

                        switch (ev.MouseButton)
                        {
                            case MouseButtons.Left:
                                inputSimulator.Mouse.LeftButtonDown();
                                break;
                            case MouseButtons.Right:
                                inputSimulator.Mouse.RightButtonDown();
                                break;
                            // Botões 1 e 2 são laterais do rato.
                            case MouseButtons.XButton1:
                                inputSimulator.Mouse.XButtonDown(1);
                                break;
                            case MouseButtons.XButton2:
                                inputSimulator.Mouse.XButtonDown(2);
                                break;
                        }

                        _logManager.Log($"[PLAY] MouseDown: {ev.MouseButton} em {ev.MousePosition} ({ev.Timestamp}ms)");
                        break;

                    case MacroEventType.MouseUp:

                        switch (ev.MouseButton)
                        {
                            case MouseButtons.Left:
                                inputSimulator.Mouse.LeftButtonUp();
                                break;
                            case MouseButtons.Right:
                                inputSimulator.Mouse.RightButtonUp();
                                break;
                            // Botões 1 e 2 são laterais do rato.
                            case MouseButtons.XButton1:
                                inputSimulator.Mouse.XButtonUp(1);
                                break;
                            case MouseButtons.XButton2:
                                inputSimulator.Mouse.XButtonUp(2);
                                break;
                        }

                        _logManager.Log($"[PLAY] MouseUp: {ev.MouseButton} em {ev.MousePosition} ({ev.Timestamp}ms)");
                        break;

                }
            }
            _isPlaying = false;
            _logManager.Log("[INFO] Reprodução finalizada.");
        }
        catch (Exception ex)
        {
            _logManager.Log($"[ERROR] (PLAY): {ex.Message}");
            MessageBox.Show("Erro na reprodução: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    public void ClearEvents()
    {
        _recordedEvents.Clear();
        _logManager.Log("[INFO] Eventos gravados apagados.");

    }

    public List<MacroEvent> GetRecordedEvents() => _recordedEvents;

    // SaveEvent e LoadEvents sem confirmação porque a mesma está no form com try catch.
    // SaveEvent e LoadEvents Serializa ou desserializa a lista de eventos ou um arquivo JSON, respetivamente.

    public void SaveEvents(string path)
    {
        var json = JsonConvert.SerializeObject(_recordedEvents);
        System.IO.File.WriteAllText(path, json);
    }

    public void LoadEvents(string path)
    {
        var json = System.IO.File.ReadAllText(path);
        _recordedEvents = JsonConvert.DeserializeObject<List<MacroEvent>>(json);
    }

    public void EditRecordedEvents()
    {
        var editor = new MacroModifierForm(_recordedEvents);
        editor.ShowDialog();
    }

    public class MacroEvent // Classe aninhada.
    {
        public MacroEventType EventType { get; set; }
        public Keys Key { get; set; }
        public MouseButtons MouseButton { get; set; }
        public System.Drawing.Point MousePosition { get; set; }
        public long Timestamp { get; set; }
    }
}
