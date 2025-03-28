using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    }
}