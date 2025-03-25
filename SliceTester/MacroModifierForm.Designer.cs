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
            ((System.ComponentModel.ISupportInitialize)(this.GridMacroEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(827, 731);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 41);
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
            this.btnSave.Location = new System.Drawing.Point(492, 731);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(647, 731);
            this.btnSaveClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(150, 41);
            this.btnSaveClose.TabIndex = 6;
            this.btnSaveClose.Text = "Fechar e Salvar";
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // MacroModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 816);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.btnClose);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MacroModifierForm.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MacroModifierForm";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.GridMacroEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.Views.Grid.GridView GridMacroEvents;
        private DevExpress.XtraGrid.GridControl dgvEvents;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
    }
}