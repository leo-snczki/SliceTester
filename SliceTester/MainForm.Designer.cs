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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(39, 152);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(6);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(126, 40);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(200, 152);
            this.btnStop.Margin = new System.Windows.Forms.Padding(6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Parar";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(364, 152);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(6);
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
            this.panelControl1.Location = new System.Drawing.Point(0, 223);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1053, 269);
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
            this.txtLog.Size = new System.Drawing.Size(1047, 263);
            this.txtLog.TabIndex = 0;
            // 
            // lblMacroRecorder
            // 
            this.lblMacroRecorder.Location = new System.Drawing.Point(493, 68);
            this.lblMacroRecorder.Margin = new System.Windows.Forms.Padding(6);
            this.lblMacroRecorder.Name = "lblMacroRecorder";
            this.lblMacroRecorder.Size = new System.Drawing.Size(127, 23);
            this.lblMacroRecorder.TabIndex = 6;
            this.lblMacroRecorder.Text = "MacroRecorder";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(537, 152);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Enabled = false;
            this.btnSaveJson.Location = new System.Drawing.Point(704, 152);
            this.btnSaveJson.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(126, 40);
            this.btnSaveJson.TabIndex = 8;
            this.btnSaveJson.Text = "Exportar";
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(874, 152);
            this.btnLoadJson.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(126, 40);
            this.btnLoadJson.TabIndex = 8;
            this.btnLoadJson.Text = "Importar";
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ctrl + F1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ctrl + F2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ctrl + F3";
            // 
            // lblHotKeyF4
            // 
            this.lblHotKeyF4.AutoSize = true;
            this.lblHotKeyF4.Location = new System.Drawing.Point(557, 124);
            this.lblHotKeyF4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHotKeyF4.Name = "lblHotKeyF4";
            this.lblHotKeyF4.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF4.TabIndex = 14;
            this.lblHotKeyF4.Text = "Ctrl + F4";
            // 
            // lblHotKeyF5
            // 
            this.lblHotKeyF5.AutoSize = true;
            this.lblHotKeyF5.Location = new System.Drawing.Point(724, 124);
            this.lblHotKeyF5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHotKeyF5.Name = "lblHotKeyF5";
            this.lblHotKeyF5.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF5.TabIndex = 15;
            this.lblHotKeyF5.Text = "Ctrl + F5";
            // 
            // lblHotKeyF6
            // 
            this.lblHotKeyF6.AutoSize = true;
            this.lblHotKeyF6.Location = new System.Drawing.Point(894, 124);
            this.lblHotKeyF6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHotKeyF6.Name = "lblHotKeyF6";
            this.lblHotKeyF6.Size = new System.Drawing.Size(89, 24);
            this.lblHotKeyF6.TabIndex = 16;
            this.lblHotKeyF6.Text = "Ctrl + F6";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(874, 68);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 40);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 492);
            this.Controls.Add(this.lblHotKeyF6);
            this.Controls.Add(this.lblHotKeyF5);
            this.Controls.Add(this.lblHotKeyF4);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
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
    }
}

