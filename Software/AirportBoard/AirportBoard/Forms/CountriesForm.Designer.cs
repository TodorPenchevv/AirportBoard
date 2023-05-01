namespace AirportBoard.Forms
{
    partial class CountriesForm
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
            this.deleteCountry = new System.Windows.Forms.Button();
            this.updateCountry = new System.Windows.Forms.Button();
            this.addCountry = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.countriesGridView = new System.Windows.Forms.DataGridView();
            this.countryIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.countriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteCountry
            // 
            this.deleteCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCountry.Location = new System.Drawing.Point(867, 538);
            this.deleteCountry.Name = "deleteCountry";
            this.deleteCountry.Size = new System.Drawing.Size(203, 36);
            this.deleteCountry.TabIndex = 36;
            this.deleteCountry.Text = "Delete";
            this.deleteCountry.UseVisualStyleBackColor = true;
            this.deleteCountry.Click += new System.EventHandler(this.deleteCountry_Click);
            // 
            // updateCountry
            // 
            this.updateCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCountry.Location = new System.Drawing.Point(867, 496);
            this.updateCountry.Name = "updateCountry";
            this.updateCountry.Size = new System.Drawing.Size(203, 36);
            this.updateCountry.TabIndex = 35;
            this.updateCountry.Text = "Update";
            this.updateCountry.UseVisualStyleBackColor = true;
            this.updateCountry.Click += new System.EventHandler(this.updateCountry_Click);
            // 
            // addCountry
            // 
            this.addCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCountry.Location = new System.Drawing.Point(867, 454);
            this.addCountry.Name = "addCountry";
            this.addCountry.Size = new System.Drawing.Size(203, 36);
            this.addCountry.TabIndex = 34;
            this.addCountry.Text = "Add";
            this.addCountry.UseVisualStyleBackColor = true;
            this.addCountry.Click += new System.EventHandler(this.addCountry_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryTextBox.Location = new System.Drawing.Point(867, 35);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(199, 27);
            this.countryTextBox.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(865, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Country";
            // 
            // countriesGridView
            // 
            this.countriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryIdColumn,
            this.countryNameColumn});
            this.countriesGridView.Location = new System.Drawing.Point(12, 12);
            this.countriesGridView.Name = "countriesGridView";
            this.countriesGridView.RowTemplate.Height = 25;
            this.countriesGridView.Size = new System.Drawing.Size(849, 562);
            this.countriesGridView.TabIndex = 31;
            // 
            // countryIdColumn
            // 
            this.countryIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryIdColumn.HeaderText = "ID";
            this.countryIdColumn.Name = "countryIdColumn";
            // 
            // countryNameColumn
            // 
            this.countryNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryNameColumn.HeaderText = "COUNTRY";
            this.countryNameColumn.Name = "countryNameColumn";
            // 
            // CountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 585);
            this.Controls.Add(this.deleteCountry);
            this.Controls.Add(this.updateCountry);
            this.Controls.Add(this.addCountry);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.countriesGridView);
            this.Name = "CountriesForm";
            this.Text = "CountriesForm";
            this.Load += new System.EventHandler(this.CountriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteCountry;
        private Button updateCountry;
        private Button addCountry;
        private TextBox countryTextBox;
        private Label label11;
        private DataGridView countriesGridView;
        private DataGridViewTextBoxColumn countryIdColumn;
        private DataGridViewTextBoxColumn countryNameColumn;
    }
}