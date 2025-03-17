using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SliceTester
{
    public partial class MacroEventForm : DevExpress.XtraEditors.XtraForm
    {
        private List<MacroRecorder.MacroEvent> events;
        public MacroEventForm(List<MacroRecorder.MacroEvent> recordedEvents)
        {
            events = recordedEvents;

            InitializeComponent();
            LoadEvents();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedEvent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void DeleteSelectedEvent()
        {
            // Iterar de trás para frente para evitar problemas com índices durante a remoção
            foreach (DataGridViewRow row in dgvEvents.SelectedRows.Cast<DataGridViewRow>().OrderByDescending(r => r.Index))
            {
                events.RemoveAt(row.Index);
            }

            // Ainda falta resolver a difenreça de tempo de delay entre o evento selecionado e o evento removido
            // Não consigo resolver isso ainda

            LoadEvents();
        }

        private void LoadEvents()
        {
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = events;
        }

        private void AddEvent()
        {
            using (var form = new AddEventForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    events.Add(form.NewEvent);
                    LoadEvents();
                }
            }
        }
    }
}