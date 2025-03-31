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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRecord = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnPlay = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.listFiles = new System.Windows.Forms.ListView();
            this.columnNameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblMacroRecorder = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStartLoop = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewer = new DevExpress.XtraGrid.GridControl();
            this.gridViewerFormMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.txtLoopBox = new System.Windows.Forms.TextBox();
            this.lblLoop = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF1 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF2 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF3 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF4 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF5 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF6 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF7 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF8 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(527, 39);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(76, 23);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(616, 39);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Parar";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(527, 79);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(76, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Iniciar";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtLog);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 236);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(695, 86);
            this.panelControl1.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(2, 2);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(691, 82);
            this.txtLog.TabIndex = 0;
            // 
            // listFiles
            // 
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameFile});
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(372, 21);
            this.listFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(144, 204);
            this.listFiles.TabIndex = 1;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            this.listFiles.ItemActivate += new System.EventHandler(this.ListFiles_ItemActivate);
            // 
            // columnNameFile
            // 
            this.columnNameFile.Text = "Ficheiros";
            this.columnNameFile.Width = 231;
            // 
            // lblMacroRecorder
            // 
            this.lblMacroRecorder.Location = new System.Drawing.Point(569, 3);
            this.lblMacroRecorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblMacroRecorder.Name = "lblMacroRecorder";
            this.lblMacroRecorder.Size = new System.Drawing.Size(73, 13);
            this.lblMacroRecorder.TabIndex = 6;
            this.lblMacroRecorder.Text = "MacroRecorder";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(616, 79);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Enabled = false;
            this.btnExportJson.Location = new System.Drawing.Point(527, 118);
            this.btnExportJson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(76, 23);
            this.btnExportJson.TabIndex = 8;
            this.btnExportJson.Text = "Exportar";
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // btnImportJson
            // 
            this.btnImportJson.Location = new System.Drawing.Point(616, 118);
            this.btnImportJson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportJson.Name = "btnImportJson";
            this.btnImportJson.Size = new System.Drawing.Size(67, 23);
            this.btnImportJson.TabIndex = 8;
            this.btnImportJson.Text = "Importar";
            this.btnImportJson.Click += new System.EventHandler(this.btnImportJson_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(616, 201);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStartLoop
            // 
            this.btnStartLoop.Enabled = false;
            this.btnStartLoop.Location = new System.Drawing.Point(527, 159);
            this.btnStartLoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartLoop.Name = "btnStartLoop";
            this.btnStartLoop.Size = new System.Drawing.Size(76, 21);
            this.btnStartLoop.TabIndex = 21;
            this.btnStartLoop.Text = "Iniciar Loop";
            this.btnStartLoop.Click += new System.EventHandler(this.BtnStartLoop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(527, 201);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridViewer
            // 
            this.gridViewer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gridViewer.Location = new System.Drawing.Point(10, 0);
            this.gridViewer.MainView = this.gridViewerFormMain;
            this.gridViewer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gridViewer.Name = "gridViewer";
            this.gridViewer.Size = new System.Drawing.Size(352, 224);
            this.gridViewer.TabIndex = 24;
            this.gridViewer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewerFormMain});
            // 
            // gridViewerFormMain
            // 
            this.gridViewerFormMain.DetailHeight = 112;
            this.gridViewerFormMain.GridControl = this.gridViewer;
            this.gridViewerFormMain.Name = "gridViewerFormMain";
            this.gridViewerFormMain.OptionsBehavior.Editable = false;
            this.gridViewerFormMain.OptionsEditForm.PopupEditFormWidth = 288;
            this.gridViewerFormMain.OptionsView.ShowGroupPanel = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(372, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 18);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtLoopBox
            // 
            this.txtLoopBox.Enabled = false;
            this.txtLoopBox.Location = new System.Drawing.Point(617, 161);
            this.txtLoopBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoopBox.Name = "txtLoopBox";
            this.txtLoopBox.Size = new System.Drawing.Size(68, 21);
            this.txtLoopBox.TabIndex = 28;
            // 
            // lblLoop
            // 
            this.lblLoop.Location = new System.Drawing.Point(635, 144);
            this.lblLoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblLoop.Name = "lblLoop";
            this.lblLoop.Size = new System.Drawing.Size(23, 13);
            this.lblLoop.TabIndex = 29;
            this.lblLoop.Text = "Loop";
            // 
            // lblHotKeyF1
            // 
            this.lblHotKeyF1.Location = new System.Drawing.Point(543, 24);
            this.lblHotKeyF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF1.Name = "lblHotKeyF1";
            this.lblHotKeyF1.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF1.TabIndex = 30;
            this.lblHotKeyF1.Text = "Ctrl + F1";
            // 
            // lblHotKeyF2
            // 
            this.lblHotKeyF2.Location = new System.Drawing.Point(626, 24);
            this.lblHotKeyF2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF2.Name = "lblHotKeyF2";
            this.lblHotKeyF2.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF2.TabIndex = 30;
            this.lblHotKeyF2.Text = "Ctrl + F2";
            // 
            // lblHotKeyF3
            // 
            this.lblHotKeyF3.Location = new System.Drawing.Point(543, 65);
            this.lblHotKeyF3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF3.Name = "lblHotKeyF3";
            this.lblHotKeyF3.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF3.TabIndex = 30;
            this.lblHotKeyF3.Text = "Ctrl + F3";
            // 
            // lblHotKeyF4
            // 
            this.lblHotKeyF4.Location = new System.Drawing.Point(626, 65);
            this.lblHotKeyF4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF4.Name = "lblHotKeyF4";
            this.lblHotKeyF4.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF4.TabIndex = 30;
            this.lblHotKeyF4.Text = "Ctrl + F4";
            // 
            // lblHotKeyF5
            // 
            this.lblHotKeyF5.Location = new System.Drawing.Point(543, 105);
            this.lblHotKeyF5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF5.Name = "lblHotKeyF5";
            this.lblHotKeyF5.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF5.TabIndex = 30;
            this.lblHotKeyF5.Text = "Ctrl + F5";
            // 
            // lblHotKeyF6
            // 
            this.lblHotKeyF6.Location = new System.Drawing.Point(626, 105);
            this.lblHotKeyF6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF6.Name = "lblHotKeyF6";
            this.lblHotKeyF6.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF6.TabIndex = 30;
            this.lblHotKeyF6.Text = "Ctrl + F6";
            // 
            // lblHotKeyF7
            // 
            this.lblHotKeyF7.Location = new System.Drawing.Point(543, 144);
            this.lblHotKeyF7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF7.Name = "lblHotKeyF7";
            this.lblHotKeyF7.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF7.TabIndex = 30;
            this.lblHotKeyF7.Text = "Ctrl + F7";
            // 
            // lblHotKeyF8
            // 
            this.lblHotKeyF8.Location = new System.Drawing.Point(543, 185);
            this.lblHotKeyF8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF8.Name = "lblHotKeyF8";
            this.lblHotKeyF8.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF8.TabIndex = 30;
            this.lblHotKeyF8.Text = "Ctrl + F8";
            // 
            // lblHotKeyF9
            // 
            this.lblHotKeyF9.Location = new System.Drawing.Point(626, 185);
            this.lblHotKeyF9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblHotKeyF9.Name = "lblHotKeyF9";
            this.lblHotKeyF9.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF9.TabIndex = 30;
            this.lblHotKeyF9.Text = "Ctrl + F9";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 322);
            this.Controls.Add(this.lblHotKeyF2);
            this.Controls.Add(this.lblHotKeyF4);
            this.Controls.Add(this.lblHotKeyF6);
            this.Controls.Add(this.lblHotKeyF9);
            this.Controls.Add(this.lblHotKeyF8);
            this.Controls.Add(this.lblHotKeyF7);
            this.Controls.Add(this.lblHotKeyF5);
            this.Controls.Add(this.lblHotKeyF3);
            this.Controls.Add(this.lblHotKeyF1);
            this.Controls.Add(this.lblLoop);
            this.Controls.Add(this.txtLoopBox);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridViewer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.btnStartLoop);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnImportJson);
            this.Controls.Add(this.btnExportJson);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMacroRecorder);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SliceTester";
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
        private DevExpress.XtraEditors.SimpleButton btnImportJson;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnStartLoop;
        private System.Windows.Forms.ListView listFiles;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridViewer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewerFormMain;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ColumnHeader columnNameFile;
        private System.Windows.Forms.TextBox txtLoopBox;
        private DevExpress.XtraEditors.LabelControl lblLoop;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF1;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF2;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF3;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF4;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF5;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF6;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF7;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF8;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF9;
    }
}

