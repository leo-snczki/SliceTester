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
            this.btnMouseTest.Location = new System.Drawing.Point(188, 111);
            this.btnMouseTest.Name = "btnMouseTest";
            this.btnMouseTest.Size = new System.Drawing.Size(90, 23);
            this.btnMouseTest.TabIndex = 1;
            this.btnMouseTest.Text = "Testar Mouse";
            this.btnMouseTest.Click += new System.EventHandler(this.btnMouseTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.btnMouseTest);
            this.Controls.Add(this.btnKeyboardTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKeyboardTest;
        private DevExpress.XtraEditors.SimpleButton btnMouseTest;
    }
}

