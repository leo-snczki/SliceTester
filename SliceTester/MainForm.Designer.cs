namespace SliceTester
{
    partial class MainForm
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
            this.btnRecord = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlay = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblMacroRecorder = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadJson = new DevExpress.XtraEditors.SimpleButton();
            this.lblHotKeyF1 = new System.Windows.Forms.Label();
            this.lblHotKeyF2 = new System.Windows.Forms.Label();
            this.lblHotKeyF3 = new System.Windows.Forms.Label();
            this.lblHotKeyF4 = new System.Windows.Forms.Label();
            this.lblHotKeyF5 = new System.Windows.Forms.Label();
            this.lblHotKeyF6 = new System.Windows.Forms.Label();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lblHotKeyF8 = new System.Windows.Forms.Label();
            this.lblHotKeyF9 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateLoop = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewer = new DevExpress.XtraGrid.GridControl();
            this.gridViewerFormMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lblHotKeyF7 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF10 = new DevExpress.XtraEditors.LabelControl();
            this.columnNameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(878, 69);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(126, 40);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(1027, 69);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Parar";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(878, 139);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(126, 40);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Iniciar";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtLog);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 417);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1159, 152);
            this.panelControl1.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Margin = new System.Windows.Forms.Padding(6);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1153, 146);
            this.txtLog.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameFile});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(620, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(237, 358);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.ListView1_ItemActivate);
            // 
            // lblMacroRecorder
            // 
            this.lblMacroRecorder.Location = new System.Drawing.Point(948, 5);
            this.lblMacroRecorder.Name = "lblMacroRecorder";
            this.lblMacroRecorder.Size = new System.Drawing.Size(127, 23);
            this.lblMacroRecorder.TabIndex = 6;
            this.lblMacroRecorder.Text = "MacroRecorder";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(1027, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Enabled = false;
            this.btnExportJson.Location = new System.Drawing.Point(878, 209);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(126, 40);
            this.btnExportJson.TabIndex = 8;
            this.btnExportJson.Text = "Exportar";
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(1027, 209);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(111, 40);
            this.btnLoadJson.TabIndex = 8;
            this.btnLoadJson.Text = "Importar";
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // lblHotKeyF1
            // 
            this.lblHotKeyF1.AutoSize = true;
            this.lblHotKeyF1.Location = new System.Drawing.Point(901, 42);
            this.lblHotKeyF1.Name = "lblHotKeyF1";
            this.lblHotKeyF1.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF1.TabIndex = 11;
            this.lblHotKeyF1.Text = "Ctrl + F1";
            // 
            // lblHotKeyF2
            // 
            this.lblHotKeyF2.AutoSize = true;
            this.lblHotKeyF2.Location = new System.Drawing.Point(1039, 42);
            this.lblHotKeyF2.Name = "lblHotKeyF2";
            this.lblHotKeyF2.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF2.TabIndex = 12;
            this.lblHotKeyF2.Text = "Ctrl + F2";
            // 
            // lblHotKeyF3
            // 
            this.lblHotKeyF3.AutoSize = true;
            this.lblHotKeyF3.Location = new System.Drawing.Point(901, 112);
            this.lblHotKeyF3.Name = "lblHotKeyF3";
            this.lblHotKeyF3.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF3.TabIndex = 13;
            this.lblHotKeyF3.Text = "Ctrl + F3";
            // 
            // lblHotKeyF4
            // 
            this.lblHotKeyF4.AutoSize = true;
            this.lblHotKeyF4.Location = new System.Drawing.Point(1039, 112);
            this.lblHotKeyF4.Name = "lblHotKeyF4";
            this.lblHotKeyF4.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF4.TabIndex = 14;
            this.lblHotKeyF4.Text = "Ctrl + F4";
            // 
            // lblHotKeyF5
            // 
            this.lblHotKeyF5.AutoSize = true;
            this.lblHotKeyF5.Location = new System.Drawing.Point(901, 182);
            this.lblHotKeyF5.Name = "lblHotKeyF5";
            this.lblHotKeyF5.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF5.TabIndex = 15;
            this.lblHotKeyF5.Text = "Ctrl + F5";
            // 
            // lblHotKeyF6
            // 
            this.lblHotKeyF6.AutoSize = true;
            this.lblHotKeyF6.Location = new System.Drawing.Point(1039, 182);
            this.lblHotKeyF6.Name = "lblHotKeyF6";
            this.lblHotKeyF6.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF6.TabIndex = 16;
            this.lblHotKeyF6.Text = "Ctrl + F6";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(1027, 356);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 40);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblHotKeyF8
            // 
            this.lblHotKeyF8.AutoSize = true;
            this.lblHotKeyF8.Location = new System.Drawing.Point(1039, 252);
            this.lblHotKeyF8.Name = "lblHotKeyF8";
            this.lblHotKeyF8.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF8.TabIndex = 18;
            this.lblHotKeyF8.Text = "Ctrl + F8";
            // 
            // lblHotKeyF9
            // 
            this.lblHotKeyF9.AutoSize = true;
            this.lblHotKeyF9.Location = new System.Drawing.Point(901, 322);
            this.lblHotKeyF9.Name = "lblHotKeyF9";
            this.lblHotKeyF9.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF9.TabIndex = 20;
            this.lblHotKeyF9.Text = "Ctrl + F9";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(878, 281);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(126, 37);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Start Loop";
            this.simpleButton1.Click += new System.EventHandler(this.BtnStartLoop_Click);
            // 
            // btnCreateLoop
            // 
            this.btnCreateLoop.Location = new System.Drawing.Point(1027, 281);
            this.btnCreateLoop.Name = "btnCreateLoop";
            this.btnCreateLoop.Size = new System.Drawing.Size(111, 37);
            this.btnCreateLoop.TabIndex = 22;
            this.btnCreateLoop.Text = "Create Loop";
            this.btnCreateLoop.Click += new System.EventHandler(this.btnCreateLoop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(878, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridViewer
            // 
            this.gridViewer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewer.Location = new System.Drawing.Point(30, 0);
            this.gridViewer.MainView = this.gridViewerFormMain;
            this.gridViewer.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewer.Name = "gridViewer";
            this.gridViewer.Size = new System.Drawing.Size(554, 396);
            this.gridViewer.TabIndex = 24;
            this.gridViewer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewerFormMain});
            // 
            // gridViewerFormMain
            // 
            this.gridViewerFormMain.DetailHeight = 198;
            this.gridViewerFormMain.GridControl = this.gridViewer;
            this.gridViewerFormMain.Name = "gridViewerFormMain";
            this.gridViewerFormMain.OptionsEditForm.PopupEditFormWidth = 480;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(620, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(237, 32);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHotKeyF7
            // 
            this.lblHotKeyF7.Location = new System.Drawing.Point(905, 252);
            this.lblHotKeyF7.Name = "lblHotKeyF7";
            this.lblHotKeyF7.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF7.TabIndex = 26;
            this.lblHotKeyF7.Text = "Ctrl + F7";
            // 
            // lblHotKeyF10
            // 
            this.lblHotKeyF10.Location = new System.Drawing.Point(1043, 323);
            this.lblHotKeyF10.Name = "lblHotKeyF10";
            this.lblHotKeyF10.Size = new System.Drawing.Size(84, 23);
            this.lblHotKeyF10.TabIndex = 27;
            this.lblHotKeyF10.Text = "Ctrl + F10";
            // 
            // columnNameFile
            // 
            this.columnNameFile.Text = "Ficheiro";
            this.columnNameFile.Width = 231;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 569);
            this.Controls.Add(this.lblHotKeyF10);
            this.Controls.Add(this.lblHotKeyF7);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridViewer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCreateLoop);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblHotKeyF9);
            this.Controls.Add(this.lblHotKeyF8);
            this.Controls.Add(this.lblHotKeyF6);
            this.Controls.Add(this.lblHotKeyF5);
            this.Controls.Add(this.lblHotKeyF4);
            this.Controls.Add(this.lblHotKeyF3);
            this.Controls.Add(this.lblHotKeyF2);
            this.Controls.Add(this.lblHotKeyF1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.btnExportJson);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMacroRecorder);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecord);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "JSON Files";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRecord;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnPlay;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraEditors.LabelControl lblMacroRecorder;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnExportJson;
        private DevExpress.XtraEditors.SimpleButton btnLoadJson;
        private System.Windows.Forms.Label lblHotKeyF1;
        private System.Windows.Forms.Label lblHotKeyF2;
        private System.Windows.Forms.Label lblHotKeyF3;
        private System.Windows.Forms.Label lblHotKeyF4;
        private System.Windows.Forms.Label lblHotKeyF5;
        private System.Windows.Forms.Label lblHotKeyF6;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Label lblHotKeyF8;
        private System.Windows.Forms.Label lblHotKeyF9;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnCreateLoop;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridViewer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewerFormMain;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF7;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF10;
        private System.Windows.Forms.ColumnHeader columnNameFile;
    }
}

