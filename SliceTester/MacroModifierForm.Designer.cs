namespace SliceTester
{
    partial class MacroModifierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroModifierForm));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.GridMacroEvents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvEvents = new DevExpress.XtraGrid.GridControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.checkAjustTimeStamp = new DevExpress.XtraEditors.CheckEdit();
            this.numIntervarsTimeStamp = new System.Windows.Forms.NumericUpDown();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridMacroEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAjustTimeStamp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervarsTimeStamp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(853, 731);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Fechar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GridMacroEvents
            // 
            this.GridMacroEvents.DetailHeight = 619;
            this.GridMacroEvents.GridControl = this.dgvEvents;
            this.GridMacroEvents.Name = "GridMacroEvents";
            this.GridMacroEvents.OptionsEditForm.PopupEditFormWidth = 1333;
            this.GridMacroEvents.OptionsView.ShowGroupPanel = false;
            // 
            // dgvEvents
            // 
            this.dgvEvents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.dgvEvents.Location = new System.Drawing.Point(68, 21);
            this.dgvEvents.MainView = this.GridMacroEvents;
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(5);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(883, 633);
            this.dgvEvents.TabIndex = 4;
            this.dgvEvents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridMacroEvents});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(547, 731);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(688, 731);
            this.btnSaveClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(150, 41);
            this.btnSaveClose.TabIndex = 6;
            this.btnSaveClose.Text = "Fechar e Salvar";
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // checkAjustTimeStamp
            // 
            this.checkAjustTimeStamp.Location = new System.Drawing.Point(64, 734);
            this.checkAjustTimeStamp.Margin = new System.Windows.Forms.Padding(5);
            this.checkAjustTimeStamp.Name = "checkAjustTimeStamp";
            this.checkAjustTimeStamp.Properties.Caption = "Ajustar timestamp em:";
            this.checkAjustTimeStamp.Size = new System.Drawing.Size(229, 35);
            this.checkAjustTimeStamp.TabIndex = 7;
            this.checkAjustTimeStamp.CheckedChanged += new System.EventHandler(this.checkAjustTimeStamp_CheckedChanged_);
            // 
            // numIntervarsTimeStamp
            // 
            this.numIntervarsTimeStamp.Enabled = false;
            this.numIntervarsTimeStamp.Location = new System.Drawing.Point(291, 737);
            this.numIntervarsTimeStamp.Margin = new System.Windows.Forms.Padding(5);
            this.numIntervarsTimeStamp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numIntervarsTimeStamp.Name = "numIntervarsTimeStamp";
            this.numIntervarsTimeStamp.Size = new System.Drawing.Size(102, 30);
            this.numIntervarsTimeStamp.TabIndex = 8;
            this.numIntervarsTimeStamp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(407, 731);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 41);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remover";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // MacroModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 816);
            this.Controls.Add(this.numIntervarsTimeStamp);
            this.Controls.Add(this.checkAjustTimeStamp);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.btnClose);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MacroModifierForm.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MacroModifierForm";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.GridMacroEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAjustTimeStamp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervarsTimeStamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Views.Grid.GridView GridMacroEvents;
        private DevExpress.XtraGrid.GridControl dgvEvents;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
        private DevExpress.XtraEditors.CheckEdit checkAjustTimeStamp;
        private System.Windows.Forms.NumericUpDown numIntervarsTimeStamp;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
    }
}