namespace Autosaloon
{
    partial class LoginScreen
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
            this.signInButton = new CustomBox.RJControls.RJButton();
            this.clearButton = new CustomBox.RJControls.RJButton();
            this.userIDTextBox = new CustomBox.RJControls.RJTextBox();
            this.passwordTextBox = new CustomBox.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Gold;
            this.signInButton.BackgroundColor = System.Drawing.Color.Gold;
            this.signInButton.BorderColor = System.Drawing.Color.Black;
            this.signInButton.BorderRadius = 20;
            this.signInButton.BorderSize = 1;
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInButton.ForeColor = System.Drawing.Color.Black;
            this.signInButton.Location = new System.Drawing.Point(550, 475);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(143, 37);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.TextColor = System.Drawing.Color.Black;
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gold;
            this.clearButton.BackgroundColor = System.Drawing.Color.Gold;
            this.clearButton.BorderColor = System.Drawing.Color.Black;
            this.clearButton.BorderRadius = 20;
            this.clearButton.BorderSize = 1;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(719, 475);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 37);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.TextColor = System.Drawing.Color.Black;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.userIDTextBox.BorderColor = System.Drawing.Color.Gold;
            this.userIDTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userIDTextBox.BorderRadius = 0;
            this.userIDTextBox.BorderSize = 2;
            this.userIDTextBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userIDTextBox.ForeColor = System.Drawing.Color.White;
            this.userIDTextBox.Location = new System.Drawing.Point(550, 139);
            this.userIDTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userIDTextBox.MaximumSize = new System.Drawing.Size(312, 36);
            this.userIDTextBox.MinimumSize = new System.Drawing.Size(312, 36);
            this.userIDTextBox.Multiline = false;
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userIDTextBox.PasswordChar = false;
            this.userIDTextBox.PlaceholderColor = System.Drawing.Color.White;
            this.userIDTextBox.PlaceholderText = "";
            this.userIDTextBox.Size = new System.Drawing.Size(312, 36);
            this.userIDTextBox.TabIndex = 2;
            this.userIDTextBox.Texts = "";
            this.userIDTextBox.UnderlinedStyle = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Gold;
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderRadius = 0;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(550, 221);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passwordTextBox.MaximumSize = new System.Drawing.Size(312, 36);
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(312, 36);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTextBox.PasswordChar = false;
            this.passwordTextBox.PlaceholderColor = System.Drawing.Color.White;
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(312, 36);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(550, 72);
            this.label1.MaximumSize = new System.Drawing.Size(264, 28);
            this.label1.MinimumSize = new System.Drawing.Size(264, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please login to application";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(435, 139);
            this.label2.MaximumSize = new System.Drawing.Size(105, 28);
            this.label2.MinimumSize = new System.Drawing.Size(105, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "AdminID";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(435, 221);
            this.label3.MaximumSize = new System.Drawing.Size(105, 28);
            this.label3.MinimumSize = new System.Drawing.Size(105, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Autosaloon.Properties.Resources.dealership_icon_21;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(414, 367);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(414, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 355);
            this.label4.MaximumSize = new System.Drawing.Size(414, 237);
            this.label4.MinimumSize = new System.Drawing.Size(414, 237);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(105, 93, 90, 91);
            this.label4.Size = new System.Drawing.Size(414, 237);
            this.label4.TabIndex = 3;
            this.label4.Text = "Auto House";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(977, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.signInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(977, 593);
            this.MinimumSize = new System.Drawing.Size(977, 593);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomBox.RJControls.RJButton signInButton;
        private CustomBox.RJControls.RJButton clearButton;
        private CustomBox.RJControls.RJTextBox userIDTextBox;
        private CustomBox.RJControls.RJTextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}