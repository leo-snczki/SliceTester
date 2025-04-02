using System;
using System.IO;
using System.Windows.Forms;

namespace SliceTester.Classes
{
    public class LogManager
    {
        private TextBox logTextBox;

        public LogManager(TextBox txtLog)
        {
            logTextBox = txtLog;
        }

        public void Log(string message)
        {
            // No Windows Forms, os controles da interface só podem ser acessados e manipulados na thread principal,
            // Se você tentar acessar ou modificar um controle da UI a partir de outra thread, o.NET lançará uma exceção.
            if (logTextBox.InvokeRequired)
                logTextBox.Invoke(new Action(() => AppendLog(message)));           
            else
                AppendLog(message);           
        }

        private void AppendLog(string message)
        {
            logTextBox.AppendText(message + Environment.NewLine); // Adiciona o texto da mensagem ao final do conteúdo atual do TextBox
            logTextBox.ScrollToCaret(); // Rola a barra de rolagem para a última linha inserida no TextBox

        }
        public void ExportLogToFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "ficheiros TXT (*.txt)|*.txt|Todos os ficheiros (*.*)|*.*";
                saveFileDialog.Title = "Salvar Log";
                saveFileDialog.FileName = "Log.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    File.WriteAllLines(saveFileDialog.FileName, logTextBox.Lines);                
            }
        }
    }
}
