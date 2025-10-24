namespace _05_lab_exer_2
{
    partial class FrmStudentRecord
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Record";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(69, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(496, 213);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(607, 134);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 42);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(607, 221);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(138, 42);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(607, 305);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(138, 42);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
    }
}