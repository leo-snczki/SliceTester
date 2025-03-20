using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using WindowsInput;
using WindowsInput.Native;
using SliceTester.Classes;
using Newtonsoft.Json;
using SliceTester;

public class MacroRecorder
{
    private IKeyboardMouseEvents globalHook; // Responsável por capturar eventos globais de teclado e mouse.
    private List<MacroEvent> recordedEvents = new List<MacroEvent>();
    private Stopwatch stopwatch = new Stopwatch(); // Cronômetro para medir o tempo e delay entre eventos.
    private LogManager logManager;

    public MacroRecorder(LogManager logger)
    {
        logManager = logger;
    }

    public void StartRecording()
    {
        recordedEvents.Clear();
        stopwatch.Restart(); // Se você usasse apenas Start(), o tempo poderia acumular de gravações anteriores.
        globalHook = Hook.GlobalEvents();

        logManager.Log("[INFO] Iniciando gravação...");

        // Captura eventos de pressionamento de tecla.
        globalHook.KeyDown += (sender, e) =>
        {
            // Adiciona os detalhes da tecla a lista de eventos gravados.
            recordedEvents.Add(new MacroEvent
            {
                EventType = MacroEventType.KeyDown,
                Key = e.KeyCode,
                Timestamp = stopwatch.ElapsedMilliseconds
            });
            logManager.Log($"[RECORD] KeyDown: {e.KeyCode} ({stopwatch.ElapsedMilliseconds}ms)");
        };

        // Captura eventos de soltura de tecla.
        globalHook.KeyUp += (sender, e) =>
        {
            recordedEvents.Add(new MacroEvent
            {
                // Adiciona os detalhes da tecla a lista de eventos gravados.
                EventType = MacroEventType.KeyUp,
                Key = e.KeyCode,
                Timestamp = stopwatch.ElapsedMilliseconds
            });
            logManager.Log($"[RECORD] KeyUp: {e.KeyCode} ({stopwatch.ElapsedMilliseconds}ms)");
        };

        // Captura eventos de clique do mouse.
        globalHook.MouseDown += (sender, e) =>
        {
            recordedEvents.Add(new MacroEvent
            {
                // Adiciona os detalhes do clique a lista de eventos gravados.
                EventType = MacroEventType.MouseDown,
                MouseButton = e.Button,
                MousePosition = e.Location,
                Timestamp = stopwatch.ElapsedMilliseconds
            });
            logManager.Log($"[RECORD] MouseDown: {e.Button} em {e.Location} ({stopwatch.ElapsedMilliseconds}ms)");
        };

        // Captura eventos de soltura do botão do mouse.
        globalHook.MouseUp += (sender, e) =>
        {
            // Adiciona os detalhes do clique a lista de eventos gravados.
            recordedEvents.Add(new MacroEvent
            {
                EventType = MacroEventType.MouseUp,
                MouseButton = e.Button,
                MousePosition = e.Location,
                Timestamp = stopwatch.ElapsedMilliseconds
            });
            logManager.Log($"[RECORD] MouseUp: {e.Button} em {e.Location} ({stopwatch.ElapsedMilliseconds}ms)");

        };
    }

    public void StopRecording()
    {
        globalHook.Dispose();
        stopwatch.Stop();
        logManager.Log("[INFO] Gravação encerrada.");
    }

    public void Play()
    {
        var inputSimulator = new InputSimulator();
        // Timestamp é um valor que representa um ponto específico no tempo.
        long lastTimestamp = 0;
        logManager.Log("[INFO] Reprodução iniciada.");
        foreach (var ev in recordedEvents)
        {
            long delay = ev.Timestamp - lastTimestamp; // Calcula o tempo de atraso entre o evento atual e o anterior.
            Thread.Sleep((int)delay); // Espera pelo tempo de atraso antes de executar o próximo evento.
            lastTimestamp = ev.Timestamp; // Atualiza o timestamp do último evento

            // Simula o evento de acordo com o tipo.
            switch (ev.EventType)
            {
                case MacroEventType.KeyDown:
                    inputSimulator.Keyboard.KeyDown((VirtualKeyCode)ev.Key);
                    logManager.Log($"[PLAY] KeyDown: {ev.Key} ({ev.Timestamp}ms)");

                    break;

                case MacroEventType.KeyUp:
                    inputSimulator.Keyboard.KeyUp((VirtualKeyCode)ev.Key);
                    logManager.Log($"[PLAY] KeyUp: {ev.Key} ({ev.Timestamp}ms)");
                    break;

                case MacroEventType.MouseDown:
                    // a multiplicação por 65535 é o ajuste da posição do mouse referente a API do InputSimulator.
                    // O windows mede por pixels.
                    // O inputSimulator mede usando base 2^16 com máximo até 65535.
                    inputSimulator.Mouse.MoveMouseTo(ev.MousePosition.X * 65535 / Screen.PrimaryScreen.Bounds.Width,
                                                     ev.MousePosition.Y * 65535 / Screen.PrimaryScreen.Bounds.Height);
                    inputSimulator.Mouse.LeftButtonDown();
                    logManager.Log($"[PLAY] MouseDown: {ev.MouseButton} em {ev.MousePosition} ({ev.Timestamp}ms)");
                    break;

                case MacroEventType.MouseUp:
                    inputSimulator.Mouse.LeftButtonUp();
                    logManager.Log($"[PLAY] MouseUp: {ev.MouseButton} em {ev.MousePosition} ({ev.Timestamp}ms)");
                    break;
            }
        }
        logManager.Log("[INFO] Reprodução finalizada.");
    }
    public void ClearEvents()
    {
        recordedEvents.Clear();
        logManager.Log("[INFO] Eventos gravados apagados.");

    }
    public List<MacroEvent> GetRecordedEvents()
    {
        return recordedEvents;
    }
    
     public void SaveEvents(string path)
    {
        // Serializa a lista de eventos gravados em um arquivo JSON.
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(recordedEvents);
        System.IO.File.WriteAllText(path, json);
        logManager.Log($"[INFO] Eventos gravados salvos em {path}");
    }
    public void LoadEvents(string path)
    {
        // Lê o arquivo JSON e desserializa a lista de eventos gravados.
        var json = System.IO.File.ReadAllText(path);
        recordedEvents = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MacroEvent>>(json);
        logManager.Log($"[INFO] Eventos gravados carregados de {path}");
    }

    public void EditRecordedEvents()
    {
        var editor = new MacroEventForm(recordedEvents);
        editor.ShowDialog();       
    }

    public enum MacroEventType { KeyDown, KeyUp, MouseDown, MouseUp }

    public class MacroEvent
    {
        public MacroEventType EventType { get; set; }
        public Keys Key { get; set; }
        public MouseButtons MouseButton { get; set; }
        public System.Drawing.Point MousePosition { get; set; }
        public long Timestamp { get; set; }
    }
}
