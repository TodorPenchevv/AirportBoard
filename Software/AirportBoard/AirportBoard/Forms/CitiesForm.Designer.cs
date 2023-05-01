namespace AirportBoard.Forms
{
    partial class CitiesForm
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
            this.deleteCity = new System.Windows.Forms.Button();
            this.updateCity = new System.Windows.Forms.Button();
            this.addCity = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.cityCountryComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.citiesGridView = new System.Windows.Forms.DataGridView();
            this.cityIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteCity
            // 
            this.deleteCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCity.Location = new System.Drawing.Point(867, 537);
            this.deleteCity.Name = "deleteCity";
            this.deleteCity.Size = new System.Drawing.Size(203, 36);
            this.deleteCity.TabIndex = 35;
            this.deleteCity.Text = "Delete";
            this.deleteCity.UseVisualStyleBackColor = true;
            this.deleteCity.Click += new System.EventHandler(this.deleteCity_Click);
            // 
            // updateCity
            // 
            this.updateCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCity.Location = new System.Drawing.Point(867, 495);
            this.updateCity.Name = "updateCity";
            this.updateCity.Size = new System.Drawing.Size(203, 36);
            this.updateCity.TabIndex = 34;
            this.updateCity.Text = "Update";
            this.updateCity.UseVisualStyleBackColor = true;
            this.updateCity.Click += new System.EventHandler(this.updateCity_Click);
            // 
            // addCity
            // 
            this.addCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCity.Location = new System.Drawing.Point(867, 453);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(203, 36);
            this.addCity.TabIndex = 33;
            this.addCity.Text = "Add";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(865, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Country";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityNameTextBox.Location = new System.Drawing.Point(867, 36);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(199, 27);
            this.cityNameTextBox.TabIndex = 31;
            // 
            // cityCountryComboBox
            // 
            this.cityCountryComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityCountryComboBox.FormattingEnabled = true;
            this.cityCountryComboBox.Location = new System.Drawing.Point(867, 99);
            this.cityCountryComboBox.Name = "cityCountryComboBox";
            this.cityCountryComboBox.Size = new System.Drawing.Size(201, 28);
            this.cityCountryComboBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(865, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "City";
            // 
            // citiesGridView
            // 
            this.citiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIdColumn,
            this.cityNameColumn,
            this.cityCountryColumn});
            this.citiesGridView.Location = new System.Drawing.Point(12, 12);
            this.citiesGridView.Name = "citiesGridView";
            this.citiesGridView.RowTemplate.Height = 25;
            this.citiesGridView.Size = new System.Drawing.Size(849, 562);
            this.citiesGridView.TabIndex = 28;
            // 
            // cityIdColumn
            // 
            this.cityIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityIdColumn.HeaderText = "ID";
            this.cityIdColumn.Name = "cityIdColumn";
            // 
            // cityNameColumn
            // 
            this.cityNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityNameColumn.HeaderText = "CITY";
            this.cityNameColumn.Name = "cityNameColumn";
            // 
            // cityCountryColumn
            // 
            this.cityCountryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityCountryColumn.HeaderText = "COUNTRY";
            this.cityCountryColumn.Name = "cityCountryColumn";
            // 
            // CitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 586);
            this.Controls.Add(this.deleteCity);
            this.Controls.Add(this.updateCity);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(this.cityCountryComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.citiesGridView);
            this.Name = "CitiesForm";
            this.Text = "CitiesForm";
            this.Load += new System.EventHandler(this.CitiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteCity;
        private Button updateCity;
        private Button addCity;
        private Label label9;
        private TextBox cityNameTextBox;
        private ComboBox cityCountryComboBox;
        private Label label10;
        private DataGridView citiesGridView;
        private DataGridViewTextBoxColumn cityIdColumn;
        private DataGridViewTextBoxColumn cityNameColumn;
        private DataGridViewTextBoxColumn cityCountryColumn;
    }
}