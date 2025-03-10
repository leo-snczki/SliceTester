using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using WindowsInput;
using WindowsInput.Native;

public class MacroRecorder
{
    private IKeyboardMouseEvents globalHook; // Responsável por capturar eventos globais de teclado e mouse.
    private List<MacroEvent> recordedEvents = new List<MacroEvent>();
    private Stopwatch stopwatch = new Stopwatch(); // Cronômetro para medir o tempo e delay entre eventos.

    public void StartRecording()
    {
        recordedEvents.Clear();
        stopwatch.Restart(); // Se você usasse apenas Start(), o tempo poderia acumular de gravações anteriores.
        globalHook = Hook.GlobalEvents();

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
        };
    }

    public void StopRecording()
    {
        globalHook.Dispose(); // Adiciona os detalhes da tecla a lista de eventos gravados.
        stopwatch.Stop();
    }

    public void Play()
    {
        var inputSimulator = new InputSimulator();
        // Timestamp é um valor que representa um ponto específico no tempo.
        long lastTimestamp = 0;
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
                    break;
                case MacroEventType.KeyUp:
                    inputSimulator.Keyboard.KeyUp((VirtualKeyCode)ev.Key);
                    break;
                case MacroEventType.MouseDown:
                    // a multiplicação por 65535 é o ajuste da posição do mouse referente a API do InputSimulator.
                    // O windows mede por pixels.
                    // O inputSimulator mede usando base 2^16 com máximo até 65535.
                    inputSimulator.Mouse.MoveMouseTo(ev.MousePosition.X * 65535 / Screen.PrimaryScreen.Bounds.Width,
                                                     ev.MousePosition.Y * 65535 / Screen.PrimaryScreen.Bounds.Height); 
                    inputSimulator.Mouse.LeftButtonDown();
                    break;
                case MacroEventType.MouseUp:
                    inputSimulator.Mouse.LeftButtonUp();
                    break;
            }
        }
    }
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
