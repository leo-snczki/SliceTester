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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblMacroRecorder = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStartLoop = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.listFiles = new System.Windows.Forms.ListView();
            this.columnNameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridViewer = new DevExpress.XtraGrid.GridControl();
            this.gridViewerFormMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(569, 61);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(145, 23);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(771, 61);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Parar";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(569, 101);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(145, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Iniciar";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtLog);
            this.panelControl1.Location = new System.Drawing.Point(559, 257);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(363, 91);
            this.panelControl1.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(362, 90);
            this.txtLog.TabIndex = 0;
            // 
            // lblMacroRecorder
            // 
            this.lblMacroRecorder.Appearance.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacroRecorder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblMacroRecorder.Appearance.Options.UseFont = true;
            this.lblMacroRecorder.Appearance.Options.UseForeColor = true;
            this.lblMacroRecorder.Location = new System.Drawing.Point(668, 10);
            this.lblMacroRecorder.Margin = new System.Windows.Forms.Padding(2);
            this.lblMacroRecorder.Name = "lblMacroRecorder";
            this.lblMacroRecorder.Size = new System.Drawing.Size(143, 25);
            this.lblMacroRecorder.TabIndex = 6;
            this.lblMacroRecorder.Text = "MacroRecorder";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(771, 101);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Enabled = false;
            this.btnExportJson.Location = new System.Drawing.Point(569, 140);
            this.btnExportJson.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(145, 23);
            this.btnExportJson.TabIndex = 8;
            this.btnExportJson.Text = "Exportar";
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // btnImportJson
            // 
            this.btnImportJson.Location = new System.Drawing.Point(771, 140);
            this.btnImportJson.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportJson.Name = "btnImportJson";
            this.btnImportJson.Size = new System.Drawing.Size(145, 23);
            this.btnImportJson.TabIndex = 8;
            this.btnImportJson.Text = "Importar";
            this.btnImportJson.Click += new System.EventHandler(this.btnImportJson_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(771, 223);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStartLoop
            // 
            this.btnStartLoop.Enabled = false;
            this.btnStartLoop.Location = new System.Drawing.Point(569, 181);
            this.btnStartLoop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartLoop.Name = "btnStartLoop";
            this.btnStartLoop.Size = new System.Drawing.Size(145, 21);
            this.btnStartLoop.TabIndex = 21;
            this.btnStartLoop.Text = "Iniciar Loop";
            this.btnStartLoop.Click += new System.EventHandler(this.BtnStartLoop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(569, 223);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLoopBox
            // 
            this.txtLoopBox.Enabled = false;
            this.txtLoopBox.Location = new System.Drawing.Point(770, 181);
            this.txtLoopBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoopBox.Name = "txtLoopBox";
            this.txtLoopBox.Size = new System.Drawing.Size(145, 21);
            this.txtLoopBox.TabIndex = 28;
            // 
            // lblLoop
            // 
            this.lblLoop.Location = new System.Drawing.Point(830, 167);
            this.lblLoop.Margin = new System.Windows.Forms.Padding(2);
            this.lblLoop.Name = "lblLoop";
            this.lblLoop.Size = new System.Drawing.Size(23, 13);
            this.lblLoop.TabIndex = 29;
            this.lblLoop.Text = "Loop";
            // 
            // lblHotKeyF1
            // 
            this.lblHotKeyF1.Location = new System.Drawing.Point(620, 46);
            this.lblHotKeyF1.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF1.Name = "lblHotKeyF1";
            this.lblHotKeyF1.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF1.TabIndex = 30;
            this.lblHotKeyF1.Text = "Ctrl + F1";
            // 
            // lblHotKeyF2
            // 
            this.lblHotKeyF2.Location = new System.Drawing.Point(820, 46);
            this.lblHotKeyF2.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF2.Name = "lblHotKeyF2";
            this.lblHotKeyF2.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF2.TabIndex = 30;
            this.lblHotKeyF2.Text = "Ctrl + F2";
            // 
            // lblHotKeyF3
            // 
            this.lblHotKeyF3.Location = new System.Drawing.Point(620, 88);
            this.lblHotKeyF3.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF3.Name = "lblHotKeyF3";
            this.lblHotKeyF3.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF3.TabIndex = 30;
            this.lblHotKeyF3.Text = "Ctrl + F3";
            // 
            // lblHotKeyF4
            // 
            this.lblHotKeyF4.Location = new System.Drawing.Point(820, 88);
            this.lblHotKeyF4.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF4.Name = "lblHotKeyF4";
            this.lblHotKeyF4.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF4.TabIndex = 30;
            this.lblHotKeyF4.Text = "Ctrl + F4";
            // 
            // lblHotKeyF5
            // 
            this.lblHotKeyF5.Location = new System.Drawing.Point(620, 127);
            this.lblHotKeyF5.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF5.Name = "lblHotKeyF5";
            this.lblHotKeyF5.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF5.TabIndex = 30;
            this.lblHotKeyF5.Text = "Ctrl + F5";
            // 
            // lblHotKeyF6
            // 
            this.lblHotKeyF6.Location = new System.Drawing.Point(820, 127);
            this.lblHotKeyF6.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF6.Name = "lblHotKeyF6";
            this.lblHotKeyF6.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF6.TabIndex = 30;
            this.lblHotKeyF6.Text = "Ctrl + F6";
            // 
            // lblHotKeyF7
            // 
            this.lblHotKeyF7.Location = new System.Drawing.Point(620, 164);
            this.lblHotKeyF7.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF7.Name = "lblHotKeyF7";
            this.lblHotKeyF7.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF7.TabIndex = 30;
            this.lblHotKeyF7.Text = "Ctrl + F7";
            // 
            // lblHotKeyF8
            // 
            this.lblHotKeyF8.Location = new System.Drawing.Point(620, 206);
            this.lblHotKeyF8.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF8.Name = "lblHotKeyF8";
            this.lblHotKeyF8.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF8.TabIndex = 30;
            this.lblHotKeyF8.Text = "Ctrl + F8";
            // 
            // lblHotKeyF9
            // 
            this.lblHotKeyF9.Location = new System.Drawing.Point(820, 208);
            this.lblHotKeyF9.Margin = new System.Windows.Forms.Padding(2);
            this.lblHotKeyF9.Name = "lblHotKeyF9";
            this.lblHotKeyF9.Size = new System.Drawing.Size(43, 13);
            this.lblHotKeyF9.TabIndex = 30;
            this.lblHotKeyF9.Text = "Ctrl + F9";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(83)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 31);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseUp);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(59)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(899, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(24, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "X";
            this.simpleButton1.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(59)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(869, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(24, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "_";
            this.simpleButton2.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(378, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(177, 22);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listFiles
            // 
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameFile});
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(378, 34);
            this.listFiles.Margin = new System.Windows.Forms.Padding(2);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(177, 314);
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
            // gridViewer
            // 
            this.gridViewer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridViewer.Location = new System.Drawing.Point(7, 10);
            this.gridViewer.MainView = this.gridViewerFormMain;
            this.gridViewer.Margin = new System.Windows.Forms.Padding(1);
            this.gridViewer.Name = "gridViewer";
            this.gridViewer.Size = new System.Drawing.Size(368, 338);
            this.gridViewer.TabIndex = 24;
            this.gridViewer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewerFormMain,
            this.gridView1});
            // 
            // gridViewerFormMain
            // 
            this.gridViewerFormMain.DetailHeight = 112;
            this.gridViewerFormMain.GridControl = this.gridViewer;
            this.gridViewerFormMain.Name = "gridViewerFormMain";
            this.gridViewerFormMain.OptionsBehavior.Editable = false;
            this.gridViewerFormMain.OptionsEditForm.PopupEditFormWidth = 288;
            this.gridViewerFormMain.OptionsView.ShowGroupPanel = false;
            this.gridViewerFormMain.OptionsView.ShowIndicator = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridViewer;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gridViewer);
            this.panel2.Controls.Add(this.lblHotKeyF2);
            this.panel2.Controls.Add(this.listFiles);
            this.panel2.Controls.Add(this.lblHotKeyF4);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lblHotKeyF6);
            this.panel2.Controls.Add(this.btnRecord);
            this.panel2.Controls.Add(this.lblHotKeyF9);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.lblLoop);
            this.panel2.Controls.Add(this.lblMacroRecorder);
            this.panel2.Controls.Add(this.txtLoopBox);
            this.panel2.Controls.Add(this.lblHotKeyF8);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnExportJson);
            this.panel2.Controls.Add(this.btnImportJson);
            this.panel2.Controls.Add(this.lblHotKeyF7);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnStartLoop);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Controls.Add(this.lblHotKeyF5);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblHotKeyF3);
            this.panel2.Controls.Add(this.lblHotKeyF1);
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 351);
            this.panel2.TabIndex = 32;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(2, 2);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 25);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "SliceTester";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 382);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SliceTester";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private DevExpress.XtraEditors.SimpleButton btnSave;
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
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader columnNameFile;
        private DevExpress.XtraGrid.GridControl gridViewer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewerFormMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

