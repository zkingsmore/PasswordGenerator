namespace PasswordGenerator
{
    partial class GeneratePasswordForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateLbl = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.passwordNameLbl = new System.Windows.Forms.Label();
            this.passwordNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generateLbl
            // 
            this.generateLbl.AutoSize = true;
            this.generateLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateLbl.Location = new System.Drawing.Point(320, 157);
            this.generateLbl.Name = "generateLbl";
            this.generateLbl.Size = new System.Drawing.Size(299, 41);
            this.generateLbl.TabIndex = 0;
            this.generateLbl.Text = "Generate A Password";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(339, 213);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(86, 33);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.Location = new System.Drawing.Point(339, 61);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(0, 41);
            this.passwordLbl.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(513, 213);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 33);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // passwordNameLbl
            // 
            this.passwordNameLbl.AutoSize = true;
            this.passwordNameLbl.Location = new System.Drawing.Point(329, 269);
            this.passwordNameLbl.Name = "passwordNameLbl";
            this.passwordNameLbl.Size = new System.Drawing.Size(182, 20);
            this.passwordNameLbl.TabIndex = 4;
            this.passwordNameLbl.Text = "What is this password for?";
            // 
            // passwordNameBox
            // 
            this.passwordNameBox.Location = new System.Drawing.Point(339, 303);
            this.passwordNameBox.Name = "passwordNameBox";
            this.passwordNameBox.Size = new System.Drawing.Size(260, 27);
            this.passwordNameBox.TabIndex = 5;
            // 
            // GeneratePasswordForm
            // 
            this.ClientSize = new System.Drawing.Size(1025, 562);
            this.Controls.Add(this.passwordNameBox);
            this.Controls.Add(this.passwordNameLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.generateLbl);
            this.Name = "GeneratePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label generateLbl;
        private Button generateBtn;
        private Label passwordLbl;
        private Button saveBtn;
        private Label passwordNameLbl;
        private TextBox passwordNameBox;
    }
}