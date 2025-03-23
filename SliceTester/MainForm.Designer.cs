﻿namespace SliceTester
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
            this.btnSaveJson = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadJson = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHotKeyF4 = new System.Windows.Forms.Label();
            this.lblHotKeyF5 = new System.Windows.Forms.Label();
            this.lblHotKeyF6 = new System.Windows.Forms.Label();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateLoop = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewer = new DevExpress.XtraGrid.GridControl();
            this.gridViewerFormMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewerFormMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(878, 58);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(126, 40);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(977, 58);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Parar";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(878, 106);
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
            this.panelControl1.Location = new System.Drawing.Point(0, 298);
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
            this.txtLog.Size = new System.Drawing.Size(1155, 148);
            this.txtLog.TabIndex = 0;
            // 
            // listView1
            // 
            this.panelControl1.Controls.Add(this.listView1);
            this.listView1.Location = new System.Drawing.Point(620, 38);
            this.listView1.Size = new System.Drawing.Size(237, 254); 
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Columns.Add("File Name", 250);
            this.listView1.Columns.Add("Full Path", 350);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.ListView1_ItemActivate);
            // 
            // lblMacroRecorder
            // 
            this.lblMacroRecorder.Location = new System.Drawing.Point(933, 12);
            this.lblMacroRecorder.Name = "lblMacroRecorder";
            this.lblMacroRecorder.Size = new System.Drawing.Size(127, 23);
            this.lblMacroRecorder.TabIndex = 6;
            this.lblMacroRecorder.Text = "MacroRecorder";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(977, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Enabled = false;
            this.btnSaveJson.Location = new System.Drawing.Point(878, 154);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(126, 40);
            this.btnSaveJson.TabIndex = 8;
            this.btnSaveJson.Text = "Export";
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(977, 154);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(126, 40);
            this.btnLoadJson.TabIndex = 8;
            this.btnLoadJson.Text = "Importar";
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ctrl + F1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(996, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ctrl + F2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(897, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ctrl + F3";
            // 
            // lblHotKeyF4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(998, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "F4";
            // 
            // lblHotKeyF5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(896, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "F5";
            // 
            // lblHotKeyF6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(997, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "F6";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(977, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 40);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(905, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "F8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(998, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "F9";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(878, 202);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Start Loop";
            this.simpleButton1.Click += new System.EventHandler(this.BtnStartLoop_Click);
            // 
            // btnCreateLoop
            // 
            this.btnCreateLoop.Location = new System.Drawing.Point(977, 202);
            this.btnCreateLoop.Name = "btnCreateLoop";
            this.btnCreateLoop.Size = new System.Drawing.Size(75, 23);
            this.btnCreateLoop.TabIndex = 22;
            this.btnCreateLoop.Text = "Create Loop";
            this.btnCreateLoop.Click += new System.EventHandler(this.btnCreateLoop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(878, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridViewer
            // 
            this.gridViewer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewer.Location = new System.Drawing.Point(30, 38);
            this.gridViewer.MainView = this.gridViewerFormMain;
            this.gridViewer.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewer.Name = "gridViewer";
            this.gridViewer.Size = new System.Drawing.Size(554, 252);
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
            this.btnRefresh.Location = new System.Drawing.Point(620, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(237, 20);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridViewer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCreateLoop);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMacroRecorder);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecord);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "JSON Files";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
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
        private DevExpress.XtraEditors.SimpleButton btnSaveJson;
        private DevExpress.XtraEditors.SimpleButton btnLoadJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHotKeyF4;
        private System.Windows.Forms.Label lblHotKeyF5;
        private System.Windows.Forms.Label lblHotKeyF6;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnCreateLoop;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl gridViewer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewerFormMain;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}

