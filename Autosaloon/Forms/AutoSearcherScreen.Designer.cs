namespace Autosaloon
{
    partial class AutoSearcherScreen
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
            this.showButton = new CustomBox.RJControls.RJButton();
            this.brandComboBox = new CustomBox.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelComboBox = new CustomBox.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seriesComboBox = new CustomBox.RJControls.RJComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationComboBox = new CustomBox.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countProgressBar = new CustomBox.RJControls.RJProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backToLoginButton = new CustomBox.RJControls.RJButton();
            this.closeButtonInSearcher = new CustomBox.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Gold;
            this.showButton.BackgroundColor = System.Drawing.Color.Gold;
            this.showButton.BorderColor = System.Drawing.Color.Black;
            this.showButton.BorderRadius = 20;
            this.showButton.BorderSize = 1;
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showButton.ForeColor = System.Drawing.Color.Black;
            this.showButton.Location = new System.Drawing.Point(690, 394);
            this.showButton.MaximumSize = new System.Drawing.Size(143, 37);
            this.showButton.MinimumSize = new System.Drawing.Size(143, 37);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(143, 37);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.TextColor = System.Drawing.Color.Black;
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // brandComboBox
            // 
            this.brandComboBox.BackColor = System.Drawing.Color.Gold;
            this.brandComboBox.BorderColor = System.Drawing.Color.Gold;
            this.brandComboBox.BorderSize = 1;
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.brandComboBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandComboBox.ForeColor = System.Drawing.Color.Black;
            this.brandComboBox.IconColor = System.Drawing.Color.Black;
            this.brandComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.brandComboBox.ListTextColor = System.Drawing.Color.WhiteSmoke;
            this.brandComboBox.Location = new System.Drawing.Point(731, -1);
            this.brandComboBox.MaximumSize = new System.Drawing.Size(341, 54);
            this.brandComboBox.MinimumSize = new System.Drawing.Size(341, 54);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.brandComboBox.Size = new System.Drawing.Size(341, 54);
            this.brandComboBox.TabIndex = 1;
            this.brandComboBox.Texts = "";
            this.brandComboBox.OnSelectedIndexChanged += new System.EventHandler(this.BrandComboBox_OnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(418, -1);
            this.label1.MaximumSize = new System.Drawing.Size(307, 54);
            this.label1.MinimumSize = new System.Drawing.Size(307, 54);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(13);
            this.label1.Size = new System.Drawing.Size(307, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose the car brand";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelComboBox
            // 
            this.modelComboBox.BackColor = System.Drawing.Color.Gold;
            this.modelComboBox.BorderColor = System.Drawing.Color.Gold;
            this.modelComboBox.BorderSize = 1;
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.modelComboBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelComboBox.ForeColor = System.Drawing.Color.Black;
            this.modelComboBox.IconColor = System.Drawing.Color.Black;
            this.modelComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.modelComboBox.ListTextColor = System.Drawing.Color.WhiteSmoke;
            this.modelComboBox.Location = new System.Drawing.Point(731, 53);
            this.modelComboBox.MaximumSize = new System.Drawing.Size(341, 54);
            this.modelComboBox.MinimumSize = new System.Drawing.Size(341, 54);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.modelComboBox.Size = new System.Drawing.Size(341, 54);
            this.modelComboBox.TabIndex = 1;
            this.modelComboBox.Texts = "";
            this.modelComboBox.OnSelectedIndexChanged += new System.EventHandler(this.ModelComboBox_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(418, 161);
            this.label2.MaximumSize = new System.Drawing.Size(307, 54);
            this.label2.MinimumSize = new System.Drawing.Size(307, 54);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(13);
            this.label2.Size = new System.Drawing.Size(307, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please choose location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seriesComboBox
            // 
            this.seriesComboBox.BackColor = System.Drawing.Color.Gold;
            this.seriesComboBox.BorderColor = System.Drawing.Color.Gold;
            this.seriesComboBox.BorderSize = 1;
            this.seriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.seriesComboBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seriesComboBox.ForeColor = System.Drawing.Color.Black;
            this.seriesComboBox.IconColor = System.Drawing.Color.Black;
            this.seriesComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.seriesComboBox.ListTextColor = System.Drawing.Color.WhiteSmoke;
            this.seriesComboBox.Location = new System.Drawing.Point(731, 107);
            this.seriesComboBox.MinimumSize = new System.Drawing.Size(341, 54);
            this.seriesComboBox.Name = "seriesComboBox";
            this.seriesComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.seriesComboBox.Size = new System.Drawing.Size(341, 54);
            this.seriesComboBox.TabIndex = 1;
            this.seriesComboBox.Texts = "";
            this.seriesComboBox.OnSelectedIndexChanged += new System.EventHandler(this.SeriesComboBox_OnSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(418, 53);
            this.label3.MaximumSize = new System.Drawing.Size(307, 54);
            this.label3.MinimumSize = new System.Drawing.Size(307, 54);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(13);
            this.label3.Size = new System.Drawing.Size(307, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please choose the model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationComboBox
            // 
            this.locationComboBox.BackColor = System.Drawing.Color.Gold;
            this.locationComboBox.BorderColor = System.Drawing.Color.Gold;
            this.locationComboBox.BorderSize = 1;
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.locationComboBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationComboBox.ForeColor = System.Drawing.Color.Black;
            this.locationComboBox.IconColor = System.Drawing.Color.Black;
            this.locationComboBox.ListBackColor = System.Drawing.Color.DarkSlateBlue;
            this.locationComboBox.ListTextColor = System.Drawing.Color.WhiteSmoke;
            this.locationComboBox.Location = new System.Drawing.Point(731, 161);
            this.locationComboBox.MaximumSize = new System.Drawing.Size(341, 54);
            this.locationComboBox.MinimumSize = new System.Drawing.Size(341, 54);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.locationComboBox.Size = new System.Drawing.Size(341, 54);
            this.locationComboBox.TabIndex = 1;
            this.locationComboBox.Texts = "";
            this.locationComboBox.OnSelectedIndexChanged += new System.EventHandler(this.LocationComboBox_OnSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(418, 107);
            this.label4.MaximumSize = new System.Drawing.Size(307, 54);
            this.label4.MinimumSize = new System.Drawing.Size(307, 54);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(13);
            this.label4.Size = new System.Drawing.Size(307, 54);
            this.label4.TabIndex = 2;
            this.label4.Text = "Please choose series";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countProgressBar
            // 
            this.countProgressBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.countProgressBar.ChannelColor = System.Drawing.Color.Gold;
            this.countProgressBar.ChannelHeight = 6;
            this.countProgressBar.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
            this.countProgressBar.ForeColor = System.Drawing.Color.Black;
            this.countProgressBar.Location = new System.Drawing.Point(418, 288);
            this.countProgressBar.Maximum = 20;
            this.countProgressBar.MaximumSize = new System.Drawing.Size(654, 32);
            this.countProgressBar.MinimumSize = new System.Drawing.Size(654, 32);
            this.countProgressBar.Name = "countProgressBar";
            this.countProgressBar.ShowMaximun = true;
            this.countProgressBar.ShowValue = CustomBox.RJControls.TextPosition.Right;
            this.countProgressBar.Size = new System.Drawing.Size(654, 32);
            this.countProgressBar.SliderColor = System.Drawing.Color.Red;
            this.countProgressBar.SliderHeight = 6;
            this.countProgressBar.Step = 1;
            this.countProgressBar.SymbolAfter = "";
            this.countProgressBar.SymbolBefore = "";
            this.countProgressBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Autosaloon.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(413, 394);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(413, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-1, 377);
            this.label5.MaximumSize = new System.Drawing.Size(413, 253);
            this.label5.MinimumSize = new System.Drawing.Size(413, 253);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(104, 100, 90, 100);
            this.label5.Size = new System.Drawing.Size(413, 253);
            this.label5.TabIndex = 7;
            this.label5.Text = "Auto House";
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.BackColor = System.Drawing.Color.Gold;
            this.backToLoginButton.BackgroundColor = System.Drawing.Color.Gold;
            this.backToLoginButton.BorderColor = System.Drawing.Color.Black;
            this.backToLoginButton.BorderRadius = 20;
            this.backToLoginButton.BorderSize = 1;
            this.backToLoginButton.FlatAppearance.BorderSize = 0;
            this.backToLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToLoginButton.ForeColor = System.Drawing.Color.Black;
            this.backToLoginButton.Location = new System.Drawing.Point(690, 468);
            this.backToLoginButton.MaximumSize = new System.Drawing.Size(143, 37);
            this.backToLoginButton.MinimumSize = new System.Drawing.Size(143, 37);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(143, 37);
            this.backToLoginButton.TabIndex = 8;
            this.backToLoginButton.Text = "Back to login";
            this.backToLoginButton.TextColor = System.Drawing.Color.Black;
            this.backToLoginButton.UseVisualStyleBackColor = false;
            this.backToLoginButton.Click += new System.EventHandler(this.BackToLoginButton_Click);
            // 
            // closeButtonInSearcher
            // 
            this.closeButtonInSearcher.BackColor = System.Drawing.Color.Gold;
            this.closeButtonInSearcher.BackgroundColor = System.Drawing.Color.Gold;
            this.closeButtonInSearcher.BorderColor = System.Drawing.Color.Black;
            this.closeButtonInSearcher.BorderRadius = 20;
            this.closeButtonInSearcher.BorderSize = 1;
            this.closeButtonInSearcher.FlatAppearance.BorderSize = 0;
            this.closeButtonInSearcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonInSearcher.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButtonInSearcher.ForeColor = System.Drawing.Color.Black;
            this.closeButtonInSearcher.Location = new System.Drawing.Point(690, 543);
            this.closeButtonInSearcher.MaximumSize = new System.Drawing.Size(143, 37);
            this.closeButtonInSearcher.MinimumSize = new System.Drawing.Size(143, 37);
            this.closeButtonInSearcher.Name = "closeButtonInSearcher";
            this.closeButtonInSearcher.Size = new System.Drawing.Size(143, 37);
            this.closeButtonInSearcher.TabIndex = 9;
            this.closeButtonInSearcher.Text = "Close";
            this.closeButtonInSearcher.TextColor = System.Drawing.Color.Black;
            this.closeButtonInSearcher.UseVisualStyleBackColor = false;
            this.closeButtonInSearcher.Click += new System.EventHandler(this.CloseButtonInSearcher_Click);
            // 
            // AutoSearcherScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1072, 625);
            this.Controls.Add(this.closeButtonInSearcher);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countProgressBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.seriesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.showButton);
            this.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1072, 625);
            this.MinimumSize = new System.Drawing.Size(1072, 625);
            this.Name = "AutoSearcherScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autosaloon";
            this.TransparencyKey = System.Drawing.Color.DarkOliveGreen;
            this.Load += new System.EventHandler(this.AutoSearcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomBox.RJControls.RJButton showButton;
        private CustomBox.RJControls.RJComboBox brandComboBox;
        private System.Windows.Forms.Label label1;
        private CustomBox.RJControls.RJComboBox modelComboBox;
        private System.Windows.Forms.Label label2;
        private CustomBox.RJControls.RJComboBox seriesComboBox;
        private System.Windows.Forms.Label label3;
        private CustomBox.RJControls.RJComboBox locationComboBox;
        private System.Windows.Forms.Label label4;
        private CustomBox.RJControls.RJProgressBar countProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private CustomBox.RJControls.RJButton backToLoginButton;
        private CustomBox.RJControls.RJButton closeButtonInSearcher;
    }
}
