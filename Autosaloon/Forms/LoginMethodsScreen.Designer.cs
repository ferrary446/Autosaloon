namespace Autosaloon
{
    partial class LoginMethodsScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminButton = new CustomBox.RJControls.RJButton();
            this.customerButton = new CustomBox.RJControls.RJButton();
            this.exitButton = new CustomBox.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Autosaloon.Properties.Resources.dealership_icon_21;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(414, 345);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(414, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-1, 333);
            this.label4.MaximumSize = new System.Drawing.Size(414, 237);
            this.label4.MinimumSize = new System.Drawing.Size(414, 237);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(105, 93, 90, 91);
            this.label4.Size = new System.Drawing.Size(414, 237);
            this.label4.TabIndex = 6;
            this.label4.Text = "Auto House";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(499, 44);
            this.label1.MaximumSize = new System.Drawing.Size(351, 42);
            this.label1.MinimumSize = new System.Drawing.Size(351, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome to Auto House!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(542, 124);
            this.label2.MaximumSize = new System.Drawing.Size(251, 29);
            this.label2.MinimumSize = new System.Drawing.Size(251, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please choose your role:";
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.Gold;
            this.adminButton.BackgroundColor = System.Drawing.Color.Gold;
            this.adminButton.BorderColor = System.Drawing.Color.Black;
            this.adminButton.BorderRadius = 20;
            this.adminButton.BorderSize = 1;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminButton.ForeColor = System.Drawing.Color.Black;
            this.adminButton.Location = new System.Drawing.Point(593, 208);
            this.adminButton.MaximumSize = new System.Drawing.Size(143, 37);
            this.adminButton.MinimumSize = new System.Drawing.Size(143, 37);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(143, 37);
            this.adminButton.TabIndex = 9;
            this.adminButton.Text = "I\'m Admin";
            this.adminButton.TextColor = System.Drawing.Color.Black;
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.Gold;
            this.customerButton.BackgroundColor = System.Drawing.Color.Gold;
            this.customerButton.BorderColor = System.Drawing.Color.Black;
            this.customerButton.BorderRadius = 20;
            this.customerButton.BorderSize = 1;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerButton.ForeColor = System.Drawing.Color.Black;
            this.customerButton.Location = new System.Drawing.Point(593, 265);
            this.customerButton.MaximumSize = new System.Drawing.Size(143, 37);
            this.customerButton.MinimumSize = new System.Drawing.Size(143, 37);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(143, 37);
            this.customerButton.TabIndex = 10;
            this.customerButton.Text = "I\'m Customer";
            this.customerButton.TextColor = System.Drawing.Color.Black;
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gold;
            this.exitButton.BackgroundColor = System.Drawing.Color.Gold;
            this.exitButton.BorderColor = System.Drawing.Color.Black;
            this.exitButton.BorderRadius = 20;
            this.exitButton.BorderSize = 1;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(593, 481);
            this.exitButton.MaximumSize = new System.Drawing.Size(143, 37);
            this.exitButton.MinimumSize = new System.Drawing.Size(143, 37);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 37);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.TextColor = System.Drawing.Color.Black;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginMethodsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(915, 568);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(915, 568);
            this.MinimumSize = new System.Drawing.Size(915, 568);
            this.Name = "LoginMethodsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginMethodsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomBox.RJControls.RJButton adminButton;
        private CustomBox.RJControls.RJButton customerButton;
        private CustomBox.RJControls.RJButton exitButton;
    }
}