namespace Autosaloon
{
    partial class AddNewCarMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addCarButton = new CustomBox.RJControls.RJButton();
            this.removeCarButton = new CustomBox.RJControls.RJButton();
            this.tableCarsGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoBrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoSeriesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.autoIDTextBox = new CustomBox.RJControls.RJTextBox();
            this.autoBrandTextBox = new CustomBox.RJControls.RJTextBox();
            this.autoModelTextBox = new CustomBox.RJControls.RJTextBox();
            this.autoSeriesTextBox = new CustomBox.RJControls.RJTextBox();
            this.cityLocationTextBox = new CustomBox.RJControls.RJTextBox();
            this.backToLoginButton = new CustomBox.RJControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCarsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Autosaloon.Properties.Resources.dealership_icon_21;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(402, 487);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(402, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-1, 473);
            this.label4.MaximumSize = new System.Drawing.Size(402, 292);
            this.label4.MinimumSize = new System.Drawing.Size(402, 292);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(105, 93, 90, 91);
            this.label4.Size = new System.Drawing.Size(402, 292);
            this.label4.TabIndex = 6;
            this.label4.Text = "Auto House";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(442, 29);
            this.label1.MaximumSize = new System.Drawing.Size(294, 53);
            this.label1.MinimumSize = new System.Drawing.Size(294, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add new car:";
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.Gold;
            this.addCarButton.BackgroundColor = System.Drawing.Color.Gold;
            this.addCarButton.BorderColor = System.Drawing.Color.Black;
            this.addCarButton.BorderRadius = 20;
            this.addCarButton.BorderSize = 1;
            this.addCarButton.FlatAppearance.BorderSize = 0;
            this.addCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCarButton.ForeColor = System.Drawing.Color.Black;
            this.addCarButton.Location = new System.Drawing.Point(442, 655);
            this.addCarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCarButton.MaximumSize = new System.Drawing.Size(128, 45);
            this.addCarButton.MinimumSize = new System.Drawing.Size(128, 45);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(128, 45);
            this.addCarButton.TabIndex = 8;
            this.addCarButton.Text = "Add";
            this.addCarButton.TextColor = System.Drawing.Color.Black;
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // removeCarButton
            // 
            this.removeCarButton.BackColor = System.Drawing.Color.Gold;
            this.removeCarButton.BackgroundColor = System.Drawing.Color.Gold;
            this.removeCarButton.BorderColor = System.Drawing.Color.Black;
            this.removeCarButton.BorderRadius = 20;
            this.removeCarButton.BorderSize = 1;
            this.removeCarButton.FlatAppearance.BorderSize = 0;
            this.removeCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCarButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeCarButton.ForeColor = System.Drawing.Color.Black;
            this.removeCarButton.Location = new System.Drawing.Point(608, 655);
            this.removeCarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeCarButton.MaximumSize = new System.Drawing.Size(128, 45);
            this.removeCarButton.MinimumSize = new System.Drawing.Size(128, 45);
            this.removeCarButton.Name = "removeCarButton";
            this.removeCarButton.Size = new System.Drawing.Size(128, 45);
            this.removeCarButton.TabIndex = 9;
            this.removeCarButton.Text = "Remove";
            this.removeCarButton.TextColor = System.Drawing.Color.Black;
            this.removeCarButton.UseVisualStyleBackColor = false;
            this.removeCarButton.Click += new System.EventHandler(this.RemoveCarButton_Click);
            // 
            // tableCarsGridView
            // 
            this.tableCarsGridView.AllowUserToAddRows = false;
            this.tableCarsGridView.AllowUserToDeleteRows = false;
            this.tableCarsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCarsGridView.BackgroundColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCarsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableCarsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCarsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.autoIDColumn,
            this.autoBrandColumn,
            this.autoModelColumn,
            this.autoSeriesColumn,
            this.cityLocationColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCarsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableCarsGridView.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.tableCarsGridView.Location = new System.Drawing.Point(442, 279);
            this.tableCarsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableCarsGridView.MaximumSize = new System.Drawing.Size(906, 333);
            this.tableCarsGridView.MinimumSize = new System.Drawing.Size(906, 333);
            this.tableCarsGridView.Name = "tableCarsGridView";
            this.tableCarsGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCarsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableCarsGridView.RowHeadersWidth = 51;
            this.tableCarsGridView.RowTemplate.Height = 25;
            this.tableCarsGridView.Size = new System.Drawing.Size(906, 333);
            this.tableCarsGridView.TabIndex = 10;
            this.tableCarsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCarsGridView_CellDoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 125;
            // 
            // autoIDColumn
            // 
            this.autoIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoIDColumn.DataPropertyName = "AutoID";
            this.autoIDColumn.HeaderText = "Auto ID";
            this.autoIDColumn.MinimumWidth = 6;
            this.autoIDColumn.Name = "autoIDColumn";
            this.autoIDColumn.ReadOnly = true;
            // 
            // autoBrandColumn
            // 
            this.autoBrandColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoBrandColumn.DataPropertyName = "AutoBrand";
            this.autoBrandColumn.HeaderText = "Auto Brand";
            this.autoBrandColumn.MinimumWidth = 6;
            this.autoBrandColumn.Name = "autoBrandColumn";
            this.autoBrandColumn.ReadOnly = true;
            // 
            // autoModelColumn
            // 
            this.autoModelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoModelColumn.DataPropertyName = "AutoModel";
            this.autoModelColumn.HeaderText = "Auto Model";
            this.autoModelColumn.MinimumWidth = 6;
            this.autoModelColumn.Name = "autoModelColumn";
            this.autoModelColumn.ReadOnly = true;
            // 
            // autoSeriesColumn
            // 
            this.autoSeriesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoSeriesColumn.DataPropertyName = "AutoSeries";
            this.autoSeriesColumn.HeaderText = "Auto Series";
            this.autoSeriesColumn.MinimumWidth = 6;
            this.autoSeriesColumn.Name = "autoSeriesColumn";
            this.autoSeriesColumn.ReadOnly = true;
            // 
            // cityLocationColumn
            // 
            this.cityLocationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityLocationColumn.DataPropertyName = "CityLocation";
            this.cityLocationColumn.HeaderText = "City Location";
            this.cityLocationColumn.MinimumWidth = 6;
            this.cityLocationColumn.Name = "cityLocationColumn";
            this.cityLocationColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(714, 107);
            this.label2.MaximumSize = new System.Drawing.Size(121, 36);
            this.label2.MinimumSize = new System.Drawing.Size(121, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Auto Brand:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(442, 109);
            this.label3.MaximumSize = new System.Drawing.Size(121, 36);
            this.label3.MinimumSize = new System.Drawing.Size(121, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Auto ID:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1035, 109);
            this.label5.MaximumSize = new System.Drawing.Size(121, 36);
            this.label5.MinimumSize = new System.Drawing.Size(121, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Auto Model:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(442, 197);
            this.label6.MaximumSize = new System.Drawing.Size(121, 36);
            this.label6.MinimumSize = new System.Drawing.Size(121, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Auto Series:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(763, 197);
            this.label7.MaximumSize = new System.Drawing.Size(136, 36);
            this.label7.MinimumSize = new System.Drawing.Size(136, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "City Location:";
            // 
            // autoIDTextBox
            // 
            this.autoIDTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.autoIDTextBox.BorderColor = System.Drawing.Color.Gold;
            this.autoIDTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.autoIDTextBox.BorderRadius = 0;
            this.autoIDTextBox.BorderSize = 2;
            this.autoIDTextBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoIDTextBox.ForeColor = System.Drawing.Color.White;
            this.autoIDTextBox.Location = new System.Drawing.Point(522, 104);
            this.autoIDTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.autoIDTextBox.MaximumSize = new System.Drawing.Size(184, 39);
            this.autoIDTextBox.MinimumSize = new System.Drawing.Size(184, 39);
            this.autoIDTextBox.Multiline = false;
            this.autoIDTextBox.Name = "autoIDTextBox";
            this.autoIDTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.autoIDTextBox.PasswordChar = false;
            this.autoIDTextBox.PlaceholderColor = System.Drawing.Color.White;
            this.autoIDTextBox.PlaceholderText = "";
            this.autoIDTextBox.Size = new System.Drawing.Size(184, 39);
            this.autoIDTextBox.TabIndex = 17;
            this.autoIDTextBox.Texts = "";
            this.autoIDTextBox.UnderlinedStyle = true;
            // 
            // autoBrandTextBox
            // 
            this.autoBrandTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.autoBrandTextBox.BorderColor = System.Drawing.Color.Gold;
            this.autoBrandTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.autoBrandTextBox.BorderRadius = 0;
            this.autoBrandTextBox.BorderSize = 2;
            this.autoBrandTextBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoBrandTextBox.ForeColor = System.Drawing.Color.White;
            this.autoBrandTextBox.Location = new System.Drawing.Point(843, 104);
            this.autoBrandTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.autoBrandTextBox.MaximumSize = new System.Drawing.Size(184, 39);
            this.autoBrandTextBox.MinimumSize = new System.Drawing.Size(184, 39);
            this.autoBrandTextBox.Multiline = false;
            this.autoBrandTextBox.Name = "autoBrandTextBox";
            this.autoBrandTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.autoBrandTextBox.PasswordChar = false;
            this.autoBrandTextBox.PlaceholderColor = System.Drawing.Color.White;
            this.autoBrandTextBox.PlaceholderText = "";
            this.autoBrandTextBox.Size = new System.Drawing.Size(184, 39);
            this.autoBrandTextBox.TabIndex = 18;
            this.autoBrandTextBox.Texts = "";
            this.autoBrandTextBox.UnderlinedStyle = true;
            // 
            // autoModelTextBox
            // 
            this.autoModelTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.autoModelTextBox.BorderColor = System.Drawing.Color.Gold;
            this.autoModelTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.autoModelTextBox.BorderRadius = 0;
            this.autoModelTextBox.BorderSize = 2;
            this.autoModelTextBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoModelTextBox.ForeColor = System.Drawing.Color.White;
            this.autoModelTextBox.Location = new System.Drawing.Point(1165, 104);
            this.autoModelTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.autoModelTextBox.MaximumSize = new System.Drawing.Size(184, 39);
            this.autoModelTextBox.MinimumSize = new System.Drawing.Size(184, 39);
            this.autoModelTextBox.Multiline = false;
            this.autoModelTextBox.Name = "autoModelTextBox";
            this.autoModelTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.autoModelTextBox.PasswordChar = false;
            this.autoModelTextBox.PlaceholderColor = System.Drawing.Color.White;
            this.autoModelTextBox.PlaceholderText = "";
            this.autoModelTextBox.Size = new System.Drawing.Size(184, 39);
            this.autoModelTextBox.TabIndex = 19;
            this.autoModelTextBox.Texts = "";
            this.autoModelTextBox.UnderlinedStyle = true;
            // 
            // autoSeriesTextBox
            // 
            this.autoSeriesTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.autoSeriesTextBox.BorderColor = System.Drawing.Color.Gold;
            this.autoSeriesTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.autoSeriesTextBox.BorderRadius = 0;
            this.autoSeriesTextBox.BorderSize = 2;
            this.autoSeriesTextBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoSeriesTextBox.ForeColor = System.Drawing.Color.White;
            this.autoSeriesTextBox.Location = new System.Drawing.Point(571, 195);
            this.autoSeriesTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.autoSeriesTextBox.MaximumSize = new System.Drawing.Size(184, 39);
            this.autoSeriesTextBox.MinimumSize = new System.Drawing.Size(184, 39);
            this.autoSeriesTextBox.Multiline = false;
            this.autoSeriesTextBox.Name = "autoSeriesTextBox";
            this.autoSeriesTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.autoSeriesTextBox.PasswordChar = false;
            this.autoSeriesTextBox.PlaceholderColor = System.Drawing.Color.White;
            this.autoSeriesTextBox.PlaceholderText = "";
            this.autoSeriesTextBox.Size = new System.Drawing.Size(184, 39);
            this.autoSeriesTextBox.TabIndex = 20;
            this.autoSeriesTextBox.Texts = "";
            this.autoSeriesTextBox.UnderlinedStyle = true;
            // 
            // cityLocationTextBox
            // 
            this.cityLocationTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cityLocationTextBox.BorderColor = System.Drawing.Color.Gold;
            this.cityLocationTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cityLocationTextBox.BorderRadius = 0;
            this.cityLocationTextBox.BorderSize = 2;
            this.cityLocationTextBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLocationTextBox.ForeColor = System.Drawing.Color.White;
            this.cityLocationTextBox.Location = new System.Drawing.Point(907, 197);
            this.cityLocationTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cityLocationTextBox.MaximumSize = new System.Drawing.Size(184, 39);
            this.cityLocationTextBox.MinimumSize = new System.Drawing.Size(184, 39);
            this.cityLocationTextBox.Multiline = false;
            this.cityLocationTextBox.Name = "cityLocationTextBox";
            this.cityLocationTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cityLocationTextBox.PasswordChar = false;
            this.cityLocationTextBox.PlaceholderColor = System.Drawing.Color.White;
            this.cityLocationTextBox.PlaceholderText = "";
            this.cityLocationTextBox.Size = new System.Drawing.Size(184, 39);
            this.cityLocationTextBox.TabIndex = 21;
            this.cityLocationTextBox.Texts = "";
            this.cityLocationTextBox.UnderlinedStyle = true;
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
            this.backToLoginButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToLoginButton.ForeColor = System.Drawing.Color.Black;
            this.backToLoginButton.Location = new System.Drawing.Point(1186, 655);
            this.backToLoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backToLoginButton.MaximumSize = new System.Drawing.Size(162, 45);
            this.backToLoginButton.MinimumSize = new System.Drawing.Size(162, 45);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(162, 45);
            this.backToLoginButton.TabIndex = 22;
            this.backToLoginButton.Text = "Back to login";
            this.backToLoginButton.TextColor = System.Drawing.Color.Black;
            this.backToLoginButton.UseVisualStyleBackColor = false;
            this.backToLoginButton.Click += new System.EventHandler(this.BackToLoginButton_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(777, 661);
            this.label8.MaximumSize = new System.Drawing.Size(205, 77);
            this.label8.MinimumSize = new System.Drawing.Size(205, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 77);
            this.label8.TabIndex = 23;
            this.label8.Text = "Double click on cell for editing";
            // 
            // AddNewCarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1392, 764);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.cityLocationTextBox);
            this.Controls.Add(this.autoSeriesTextBox);
            this.Controls.Add(this.autoModelTextBox);
            this.Controls.Add(this.autoBrandTextBox);
            this.Controls.Add(this.autoIDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableCarsGridView);
            this.Controls.Add(this.removeCarButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1392, 764);
            this.MinimumSize = new System.Drawing.Size(1392, 764);
            this.Name = "AddNewCarMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewCarMenu";
            this.Load += new System.EventHandler(this.AddNewCarMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCarsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomBox.RJControls.RJButton addCarButton;
        private CustomBox.RJControls.RJButton removeCarButton;
        private System.Windows.Forms.DataGridView tableCarsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomBox.RJControls.RJTextBox autoIDTextBox;
        private CustomBox.RJControls.RJTextBox autoBrandTextBox;
        private CustomBox.RJControls.RJTextBox autoModelTextBox;
        private CustomBox.RJControls.RJTextBox autoSeriesTextBox;
        private CustomBox.RJControls.RJTextBox cityLocationTextBox;
        private CustomBox.RJControls.RJButton backToLoginButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoBrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoSeriesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityLocationColumn;
        private System.Windows.Forms.Label label8;
    }
}