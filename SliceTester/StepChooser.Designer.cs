namespace SliceTester
{
    partial class StepChooser
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
            this.btnSaveStep = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelStep = new DevExpress.XtraEditors.SimpleButton();
            this.btnMoveClick = new DevExpress.XtraEditors.SimpleButton();
            this.btnWriteText = new DevExpress.XtraEditors.SimpleButton();
            this.btnPressKey = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnSaveStep
            // 
            this.btnSaveStep.Location = new System.Drawing.Point(156, 233);
            this.btnSaveStep.Name = "btnSaveStep";
            this.btnSaveStep.Size = new System.Drawing.Size(107, 23);
            this.btnSaveStep.TabIndex = 0;
            this.btnSaveStep.Text = "Salvar";
            this.btnSaveStep.Click += new System.EventHandler(this.btnSaveStep_Click);
            // 
            // btnCancelStep
            // 
            this.btnCancelStep.Location = new System.Drawing.Point(30, 233);
            this.btnCancelStep.Name = "btnCancelStep";
            this.btnCancelStep.Size = new System.Drawing.Size(105, 23);
            this.btnCancelStep.TabIndex = 0;
            this.btnCancelStep.Text = "Cancelar";
            this.btnCancelStep.Click += new System.EventHandler(this.btnCancelStep_Click);
            // 
            // btnMoveClick
            // 
            this.btnMoveClick.Location = new System.Drawing.Point(30, 24);
            this.btnMoveClick.Name = "btnMoveClick";
            this.btnMoveClick.Size = new System.Drawing.Size(233, 23);
            this.btnMoveClick.TabIndex = 1;
            this.btnMoveClick.Text = "MoveClick";
            this.btnMoveClick.Click += new System.EventHandler(this.btnMoveClick_Click);
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(30, 70);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(233, 23);
            this.btnWriteText.TabIndex = 2;
            this.btnWriteText.Text = "WriteText";
            // 
            // btnPressKey
            // 
            this.btnPressKey.Location = new System.Drawing.Point(30, 116);
            this.btnPressKey.Name = "btnPressKey";
            this.btnPressKey.Size = new System.Drawing.Size(233, 23);
            this.btnPressKey.TabIndex = 3;
            this.btnPressKey.Text = "PressKey";
            // 
            // StepChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.btnPressKey);
            this.Controls.Add(this.btnWriteText);
            this.Controls.Add(this.btnMoveClick);
            this.Controls.Add(this.btnCancelStep);
            this.Controls.Add(this.btnSaveStep);
            this.Name = "StepChooser";
            this.Text = "StepChooser";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSaveStep;
        private DevExpress.XtraEditors.SimpleButton btnCancelStep;
        private DevExpress.XtraEditors.SimpleButton btnMoveClick;
        private DevExpress.XtraEditors.SimpleButton btnWriteText;
        private DevExpress.XtraEditors.SimpleButton btnPressKey;
    }
}