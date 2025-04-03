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
            this.btnExportLog = new DevExpress.XtraEditors.SimpleButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblLoop = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF1 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF2 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF3 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF4 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF5 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF6 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF7 = new DevExpress.XtraEditors.LabelControl();
            this.lblHotKeyF8 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameProgram = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.listFiles = new System.Windows.Forms.ListView();
            this.columnNameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewerFormMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumLoopBox = new System.Windows.Forms.NumericUpDown();
            this.btnRenameTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteTest = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLoopBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRecord.ImageOptions.SvgImage")));
            this.btnRecord.Location = new System.Drawing.Point(948, 80);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(272, 64);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStop.ImageOptions.SvgImage")));
            this.btnStop.Location = new System.Drawing.Point(1253, 80);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(272, 64);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Parar";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPlay.ImageOptions.SvgImage")));
            this.btnPlay.Location = new System.Drawing.Point(948, 179);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(137, 64);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Iniciar";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExportLog);
            this.panelControl1.Controls.Add(this.txtLog);
            this.panelControl1.Location = new System.Drawing.Point(932, 455);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(605, 161);
            this.panelControl1.TabIndex = 3;
            // 
            // btnExportLog
            // 
            this.btnExportLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportLog.ImageOptions.Image")));
            this.btnExportLog.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportLog.Location = new System.Drawing.Point(536, 124);
            this.btnExportLog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(29, 29);
            this.btnExportLog.TabIndex = 1;
            this.btnExportLog.Text = "Exportar Log";
            this.btnExportLog.Click += new System.EventHandler(this.btnExportLog_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(603, 160);
            this.txtLog.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClear.ImageOptions.SvgImage")));
            this.btnClear.Location = new System.Drawing.Point(1253, 179);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(272, 64);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Enabled = false;
            this.btnExportJson.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportJson.ImageOptions.SvgImage")));
            this.btnExportJson.Location = new System.Drawing.Point(948, 280);
            this.btnExportJson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(272, 64);
            this.btnExportJson.TabIndex = 6;
            this.btnExportJson.Text = "Exportar";
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // btnImportJson
            // 
            this.btnImportJson.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportJson.ImageOptions.SvgImage")));
            this.btnImportJson.Location = new System.Drawing.Point(1253, 280);
            this.btnImportJson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportJson.Name = "btnImportJson";
            this.btnImportJson.Size = new System.Drawing.Size(272, 64);
            this.btnImportJson.TabIndex = 7;
            this.btnImportJson.Text = "Importar";
            this.btnImportJson.Click += new System.EventHandler(this.btnImportJson_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModify.ImageOptions.SvgImage")));
            this.btnModify.Location = new System.Drawing.Point(1253, 382);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(272, 64);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modificar";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(948, 380);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 64);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLoop
            // 
            this.lblLoop.Location = new System.Drawing.Point(1145, 179);
            this.lblLoop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLoop.Name = "lblLoop";
            this.lblLoop.Size = new System.Drawing.Size(40, 23);
            this.lblLoop.TabIndex = 29;
            this.lblLoop.Text = "Loop";
            // 
            // lblHotKeyF1
            // 
            this.lblHotKeyF1.Location = new System.Drawing.Point(1058, 50);
            this.lblHotKeyF1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF1.Name = "lblHotKeyF1";
            this.lblHotKeyF1.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF1.TabIndex = 30;
            this.lblHotKeyF1.Text = "Ctrl + F1";
            // 
            // lblHotKeyF2
            // 
            this.lblHotKeyF2.Location = new System.Drawing.Point(1353, 50);
            this.lblHotKeyF2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF2.Name = "lblHotKeyF2";
            this.lblHotKeyF2.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF2.TabIndex = 30;
            this.lblHotKeyF2.Text = "Ctrl + F2";
            // 
            // lblHotKeyF3
            // 
            this.lblHotKeyF3.Location = new System.Drawing.Point(982, 149);
            this.lblHotKeyF3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF3.Name = "lblHotKeyF3";
            this.lblHotKeyF3.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF3.TabIndex = 30;
            this.lblHotKeyF3.Text = "Ctrl + F3";
            // 
            // lblHotKeyF4
            // 
            this.lblHotKeyF4.Location = new System.Drawing.Point(1353, 149);
            this.lblHotKeyF4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF4.Name = "lblHotKeyF4";
            this.lblHotKeyF4.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF4.TabIndex = 30;
            this.lblHotKeyF4.Text = "Ctrl + F4";
            // 
            // lblHotKeyF5
            // 
            this.lblHotKeyF5.Location = new System.Drawing.Point(1058, 249);
            this.lblHotKeyF5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF5.Name = "lblHotKeyF5";
            this.lblHotKeyF5.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF5.TabIndex = 30;
            this.lblHotKeyF5.Text = "Ctrl + F5";
            // 
            // lblHotKeyF6
            // 
            this.lblHotKeyF6.Location = new System.Drawing.Point(1353, 249);
            this.lblHotKeyF6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF6.Name = "lblHotKeyF6";
            this.lblHotKeyF6.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF6.TabIndex = 30;
            this.lblHotKeyF6.Text = "Ctrl + F6";
            // 
            // lblHotKeyF7
            // 
            this.lblHotKeyF7.Location = new System.Drawing.Point(1058, 350);
            this.lblHotKeyF7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF7.Name = "lblHotKeyF7";
            this.lblHotKeyF7.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF7.TabIndex = 30;
            this.lblHotKeyF7.Text = "Ctrl + F7";
            // 
            // lblHotKeyF8
            // 
            this.lblHotKeyF8.Location = new System.Drawing.Point(1353, 352);
            this.lblHotKeyF8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHotKeyF8.Name = "lblHotKeyF8";
            this.lblHotKeyF8.Size = new System.Drawing.Size(74, 23);
            this.lblHotKeyF8.TabIndex = 30;
            this.lblHotKeyF8.Text = "Ctrl + F8";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(83)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNameProgram);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 53);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseUp);
            // 
            // lblNameProgram
            // 
            this.lblNameProgram.Appearance.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProgram.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblNameProgram.Appearance.Options.UseFont = true;
            this.lblNameProgram.Appearance.Options.UseForeColor = true;
            this.lblNameProgram.Location = new System.Drawing.Point(13, 4);
            this.lblNameProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNameProgram.Name = "lblNameProgram";
            this.lblNameProgram.Size = new System.Drawing.Size(183, 40);
            this.lblNameProgram.TabIndex = 0;
            this.lblNameProgram.Text = "SliceTester";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(59)))));
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Location = new System.Drawing.Point(1498, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(59)))));
            this.btnMinimize.Appearance.Options.UseBackColor = true;
            this.btnMinimize.Location = new System.Drawing.Point(1448, 7);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 41);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(632, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 55);
            this.btnRefresh.TabIndex = 11;
            // 
            // listFiles
            // 
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameFile});
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(630, 80);
            this.listFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(292, 533);
            this.listFiles.TabIndex = 14;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            this.listFiles.ItemActivate += new System.EventHandler(this.ListFiles_ItemActivate);
            // 
            // columnNameFile
            // 
            this.columnNameFile.Text = "Ficheiros";
            this.columnNameFile.Width = 231;
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl.Location = new System.Drawing.Point(12, 18);
            this.gridControl.MainView = this.gridViewerFormMain;
            this.gridControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(613, 598);
            this.gridControl.TabIndex = 15;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewerFormMain,
            this.gridView1});
            // 
            // gridViewerFormMain
            // 
            this.gridViewerFormMain.DetailHeight = 198;
            this.gridViewerFormMain.GridControl = this.gridControl;
            this.gridViewerFormMain.Name = "gridViewerFormMain";
            this.gridViewerFormMain.OptionsBehavior.Editable = false;
            this.gridViewerFormMain.OptionsEditForm.PopupEditFormWidth = 480;
            this.gridViewerFormMain.OptionsView.ShowGroupPanel = false;
            this.gridViewerFormMain.OptionsView.ShowIndicator = false;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 619;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1333;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(174)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NumLoopBox);
            this.panel2.Controls.Add(this.gridControl);
            this.panel2.Controls.Add(this.lblHotKeyF2);
            this.panel2.Controls.Add(this.listFiles);
            this.panel2.Controls.Add(this.lblHotKeyF4);
            this.panel2.Controls.Add(this.btnRenameTest);
            this.panel2.Controls.Add(this.btnDeleteTest);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lblHotKeyF6);
            this.panel2.Controls.Add(this.btnRecord);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.lblLoop);
            this.panel2.Controls.Add(this.lblHotKeyF8);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnExportJson);
            this.panel2.Controls.Add(this.btnImportJson);
            this.panel2.Controls.Add(this.lblHotKeyF7);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Controls.Add(this.lblHotKeyF5);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lblHotKeyF3);
            this.panel2.Controls.Add(this.lblHotKeyF1);
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1544, 619);
            this.panel2.TabIndex = 0;
            // 
            // NumLoopBox
            // 
            this.NumLoopBox.Enabled = false;
            this.NumLoopBox.Location = new System.Drawing.Point(1113, 205);
            this.NumLoopBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NumLoopBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLoopBox.Name = "NumLoopBox";
            this.NumLoopBox.Size = new System.Drawing.Size(107, 30);
            this.NumLoopBox.TabIndex = 4;
            this.NumLoopBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRenameTest
            // 
            this.btnRenameTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRenameTest.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRenameTest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRenameTest.ImageOptions.SvgImage")));
            this.btnRenameTest.Location = new System.Drawing.Point(832, 18);
            this.btnRenameTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRenameTest.Name = "btnRenameTest";
            this.btnRenameTest.Size = new System.Drawing.Size(93, 55);
            this.btnRenameTest.TabIndex = 13;
            this.btnRenameTest.Click += new System.EventHandler(this.btnRenameTest_Click);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteTest.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDeleteTest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteTest.ImageOptions.SvgImage")));
            this.btnDeleteTest.Location = new System.Drawing.Point(732, 18);
            this.btnDeleteTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(93, 55);
            this.btnDeleteTest.TabIndex = 12;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SliceTester";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLoopBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRecord;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnPlay;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnExportJson;
        private DevExpress.XtraEditors.SimpleButton btnImportJson;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblLoop;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF1;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF2;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF3;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF4;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF5;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF6;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF7;
        private DevExpress.XtraEditors.LabelControl lblHotKeyF8;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader columnNameFile;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewerFormMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblNameProgram;
        private System.Windows.Forms.NumericUpDown NumLoopBox;
        private DevExpress.XtraEditors.SimpleButton btnRenameTest;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTest;
        private DevExpress.XtraEditors.SimpleButton btnExportLog;
    }
}

