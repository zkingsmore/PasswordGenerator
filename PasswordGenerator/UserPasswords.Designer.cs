namespace PasswordGenerator
{
    partial class UserPasswords
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
            passwordList = new ListView();
            passwordNameCol = new ColumnHeader();
            passwordCol = new ColumnHeader();
            SuspendLayout();
            // 
            // passwordList
            // 
            passwordList.BackColor = SystemColors.Control;
            passwordList.BorderStyle = BorderStyle.None;
            passwordList.Columns.AddRange(new ColumnHeader[] { passwordNameCol, passwordCol });
            passwordList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            passwordList.Location = new Point(259, 72);
            passwordList.Name = "passwordList";
            passwordList.Size = new Size(240, 233);
            passwordList.TabIndex = 0;
            passwordList.UseCompatibleStateImageBehavior = false;
            passwordList.View = View.Details;
            // 
            // passwordNameCol
            // 
            passwordNameCol.Text = "Name";
            passwordNameCol.Width = 120;
            // 
            // passwordCol
            // 
            passwordCol.Text = "Password";
            passwordCol.Width = 120;
            // 
            // UserPasswords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordList);
            Name = "UserPasswords";
            Text = "UserPasswords";
            ResumeLayout(false);
        }

        #endregion

        private ListView passwordList;
        private ColumnHeader passwordNameCol;
        private ColumnHeader passwordCol;
    }
}