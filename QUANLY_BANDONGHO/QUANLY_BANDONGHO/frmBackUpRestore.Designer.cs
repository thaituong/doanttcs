
namespace QUANLY_BANDONGHO
{
    partial class frmBackUpRestore
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "location:";
            // 
            // txtBackUp
            // 
            this.txtBackUp.Location = new System.Drawing.Point(152, 105);
            this.txtBackUp.Name = "txtBackUp";
            this.txtBackUp.Size = new System.Drawing.Size(246, 23);
            this.txtBackUp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "location:";
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(152, 284);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(246, 23);
            this.txtRestore.TabIndex = 1;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(423, 100);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(116, 32);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(423, 150);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(116, 32);
            this.btnBackUp.TabIndex = 2;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(423, 279);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(116, 32);
            this.btnBrowse2.TabIndex = 2;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(423, 329);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(116, 32);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // frmBackUpRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 483);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBackUp);
            this.Controls.Add(this.label1);
            this.Name = "frmBackUpRestore";
            this.Text = "BACKUP AND RESTORE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBackUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnRestore;
    }
}