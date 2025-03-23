
namespace SliceTester
{
    partial class SaveForm
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
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNewTestName = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(300, 83);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(167, 41);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 30);
            this.textBox1.TabIndex = 2;
            // 
            // lblNewTestName
            // 
            this.lblNewTestName.AutoSize = true;
            this.lblNewTestName.Location = new System.Drawing.Point(21, 25);
            this.lblNewTestName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNewTestName.Name = "lblNewTestName";
            this.lblNewTestName.Size = new System.Drawing.Size(62, 24);
            this.lblNewTestName.TabIndex = 3;
            this.lblNewTestName.Text = "Nome";
            this.lblNewTestName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 83);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 41);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Fechar";
            this.btnCancel.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 160);
            this.Controls.Add(this.lblNewTestName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SaveForm";
            this.Text = "Salvar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNewTestName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}