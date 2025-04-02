using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;


namespace SliceTester
{
    public partial class MacroModifierForm : DevExpress.XtraEditors.XtraForm
    {
        private List<MacroRecorder.MacroEvent> originalEvents; // Referência aos eventos originais.
        private List<MacroRecorder.MacroEvent> tempEvents; // Cópia temporária para edição.

        public MacroModifierForm(List<MacroRecorder.MacroEvent> recordedEvents)
        {
            originalEvents = recordedEvents;
            tempEvents = new List<MacroRecorder.MacroEvent>(); // Inicializa a lista vazia.
            InitializeComponent();
            LoadEvents();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Obter o GridView associado ao DataGridView
            var gridView = dgvEvents.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                // Verificar se há alguma linha selecionada
                if (gridView.SelectedRowsCount > 0)
                {
                    // Obter o índice da primeira linha selecionada
                    int selectedIndex = gridView.GetSelectedRows()[0];

                    // Verificar se o índice está dentro do intervalo válido
                    if (selectedIndex >= 0 && selectedIndex < tempEvents.Count)
                    {
                        // Remover o evento selecionado da lista temporária
                        tempEvents.RemoveAt(selectedIndex);

                        if (checkAjustTimeStamp.Checked)
                            AdjustTimestamps(selectedIndex);


                        // Atualizar a DataGridView para refletir as mudanças
                        dgvEvents.DataSource = null;
                        dgvEvents.DataSource = tempEvents;
                        dgvEvents.RefreshDataSource();
                    }
                }
                else
                    MessageBox.Show("Por favor, selecione uma linha para remover.");

            }
        }


        private void VerificationTimeStamp()
        {

            for (int i = 1; i < tempEvents.Count; i++)
            {
                if (tempEvents[i - 1].Timestamp > tempEvents[i].Timestamp)
                {
                    MessageBox.Show("Um evento possui um timestamp menor que o anterior!", "Erro de Ordenação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
        }

        private void LoadEvents()
        {
            tempEvents.Clear();

            // Adicionar os eventos originais à lista temporária.
            tempEvents.AddRange(originalEvents.Select(e => new MacroRecorder.MacroEvent
            {
                EventType = e.EventType,
                Key = e.Key,
                MouseButton = e.MouseButton,
                MousePosition = e.MousePosition,
                Timestamp = e.Timestamp
            }));

            dgvEvents.DataSource = tempEvents;
            dgvEvents.RefreshDataSource(); // Garante que os dados sejam recarregados corretamente.

            loadDataGridConfig();

        }

        private void ApplyChanges()
        {
            VerificationTimeStamp();
            originalEvents.Clear();
            originalEvents.AddRange(tempEvents);
        }

        private void loadDataGridConfig()
        {
            // Obter a GridView associada ao GridControl.
            var gridView = dgvEvents.MainView as GridView;

            if (gridView != null)
            {
                // Nome das colunas.
                string[] columns = { "EventType", "Key", "MouseButton", "Timestamp" };

                foreach (var columnName in columns)
                {
                    var eventTypeColumn = gridView.Columns[columnName];

                    // Desabilitar o sort para essa coluna.
                    if (eventTypeColumn != null)
                        eventTypeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                }
            }
        }

        private void AdjustTimestamps(int removedEventIndex) // diminuir o timestamp dos proximos eventos do evento removido.
        {
            if (removedEventIndex < 0 || removedEventIndex >= tempEvents.Count)
                return;

            // Ajustar os timestamps de todos os eventos após o removido
            for (int i = removedEventIndex; i < tempEvents.Count; i++)
            {
                tempEvents[i].Timestamp -= Convert.ToInt32(numIntervarsTimeStamp.Value);
            }
        }

        private void checkAjustTimeStamp_CheckedChanged_(object sender, EventArgs e)
        {
            numIntervarsTimeStamp.Enabled = checkAjustTimeStamp.Checked;
        }
    }
}