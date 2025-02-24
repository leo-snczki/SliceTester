namespace SliceTester
{
    partial class Form1
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
            this.btnKeyboardTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnMouseTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddStep = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateTest = new DevExpress.XtraEditors.SimpleButton();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.btnStepCount = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.btnPlayTest = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKeyboardTest
            // 
            this.btnKeyboardTest.Location = new System.Drawing.Point(309, 111);
            this.btnKeyboardTest.Name = "btnKeyboardTest";
            this.btnKeyboardTest.Size = new System.Drawing.Size(90, 23);
            this.btnKeyboardTest.TabIndex = 1;
            this.btnKeyboardTest.Text = "Testar Teclado";
            this.btnKeyboardTest.Click += new System.EventHandler(this.btnKeyboardTest_Click);
            // 
            // btnMouseTest
            // 
            this.btnMouseTest.Location = new System.Drawing.Point(201, 111);
            this.btnMouseTest.Name = "btnMouseTest";
            this.btnMouseTest.Size = new System.Drawing.Size(90, 23);
            this.btnMouseTest.TabIndex = 1;
            this.btnMouseTest.Text = "Testar Mouse";
            this.btnMouseTest.Click += new System.EventHandler(this.btnMouseTest_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.Location = new System.Drawing.Point(417, 111);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(103, 23);
            this.btnAddStep.TabIndex = 2;
            this.btnAddStep.Text = "Adicionar etapa";
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Location = new System.Drawing.Point(526, 111);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(94, 23);
            this.btnCreateTest.TabIndex = 3;
            this.btnCreateTest.Text = "Criar Teste";
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(526, 140);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(94, 21);
            this.txtTestName.TabIndex = 4;
            // 
            // btnStepCount
            // 
            this.btnStepCount.Location = new System.Drawing.Point(417, 61);
            this.btnStepCount.Name = "btnStepCount";
            this.btnStepCount.Size = new System.Drawing.Size(203, 44);
            this.btnStepCount.TabIndex = 2;
            this.btnStepCount.Text = "Contar quantidades de etapa";
            this.btnStepCount.Click += new System.EventHandler(this.btnStepCount_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(432, 143);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Nome do teste:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(98, 164);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(522, 106);
            this.xtraTabControl1.TabIndex = 6;
            // 
            // btnPlayTest
            // 
            this.btnPlayTest.Location = new System.Drawing.Point(417, 32);
            this.btnPlayTest.Name = "btnPlayTest";
            this.btnPlayTest.Size = new System.Drawing.Size(203, 23);
            this.btnPlayTest.TabIndex = 3;
            this.btnPlayTest.Text = "Iniciar Teste";
            this.btnPlayTest.Click += new System.EventHandler(this.btnPlayTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.btnPlayTest);
            this.Controls.Add(this.btnCreateTest);
            this.Controls.Add(this.btnStepCount);
            this.Controls.Add(this.btnAddStep);
            this.Controls.Add(this.btnMouseTest);
            this.Controls.Add(this.btnKeyboardTest);
            this.Name = "Form1";
            this.Text = "SliceTester";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKeyboardTest;
        private DevExpress.XtraEditors.SimpleButton btnMouseTest;
        private DevExpress.XtraEditors.SimpleButton btnAddStep;
        private DevExpress.XtraEditors.SimpleButton btnCreateTest;
        private System.Windows.Forms.TextBox txtTestName;
        private DevExpress.XtraEditors.SimpleButton btnStepCount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SimpleButton btnPlayTest;
    }
}

