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
            generateLbl = new Label();
            generateBtn = new Button();
            passwordLbl = new Label();
            saveBtn = new Button();
            passwordNameLbl = new Label();
            passwordNameBox = new TextBox();
            showAllBtn = new Button();
            SuspendLayout();
            // 
            // generateLbl
            // 
            generateLbl.AutoSize = true;
            generateLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            generateLbl.Location = new Point(324, 162);
            generateLbl.Name = "generateLbl";
            generateLbl.Size = new Size(299, 32);
            generateLbl.TabIndex = 0;
            generateLbl.Text = "Generate Unique Password";
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(339, 213);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(86, 33);
            generateBtn.TabIndex = 1;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLbl.Location = new Point(339, 61);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(0, 32);
            passwordLbl.TabIndex = 2;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(513, 213);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(86, 33);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // passwordNameLbl
            // 
            passwordNameLbl.AutoSize = true;
            passwordNameLbl.Location = new Point(339, 271);
            passwordNameLbl.Name = "passwordNameLbl";
            passwordNameLbl.Size = new Size(144, 15);
            passwordNameLbl.TabIndex = 4;
            passwordNameLbl.Text = "What is this password for?";
            // 
            // passwordNameBox
            // 
            passwordNameBox.Location = new Point(339, 303);
            passwordNameBox.Name = "passwordNameBox";
            passwordNameBox.Size = new Size(260, 23);
            passwordNameBox.TabIndex = 5;
            // 
            // showAllBtn
            // 
            showAllBtn.Location = new Point(339, 352);
            showAllBtn.Name = "showAllBtn";
            showAllBtn.Size = new Size(86, 33);
            showAllBtn.TabIndex = 6;
            showAllBtn.Text = "Passwords";
            showAllBtn.UseVisualStyleBackColor = true;
            showAllBtn.Click += showAllBtn_Click;
            // 
            // GeneratePasswordForm
            // 
            ClientSize = new Size(1025, 562);
            Controls.Add(showAllBtn);
            Controls.Add(passwordNameBox);
            Controls.Add(passwordNameLbl);
            Controls.Add(saveBtn);
            Controls.Add(passwordLbl);
            Controls.Add(generateBtn);
            Controls.Add(generateLbl);
            Name = "GeneratePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label generateLbl;
        private Button generateBtn;
        private Label passwordLbl;
        private Button saveBtn;
        private Label passwordNameLbl;
        private TextBox passwordNameBox;
        private Button showAllBtn;
    }
}