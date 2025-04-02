
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveForm));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.lblNewTestName = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(180, 47);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(56, 12);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.Size = new System.Drawing.Size(226, 21);
            this.txtSaveFile.TabIndex = 0;
            // 
            // lblNewTestName
            // 
            this.lblNewTestName.AutoSize = true;
            this.lblNewTestName.Location = new System.Drawing.Point(13, 14);
            this.lblNewTestName.Name = "lblNewTestName";
            this.lblNewTestName.Size = new System.Drawing.Size(34, 13);
            this.lblNewTestName.TabIndex = 3;
            this.lblNewTestName.Text = "Nome";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 47);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Fechar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 90);
            this.Controls.Add(this.lblNewTestName);
            this.Controls.Add(this.txtSaveFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SaveForm.IconOptions.LargeImage")));
            this.Name = "SaveForm";
            this.Text = "Salvar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.Label lblNewTestName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}