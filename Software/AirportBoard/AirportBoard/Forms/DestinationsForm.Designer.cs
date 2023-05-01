namespace AirportBoard.Forms
{
    partial class DestinationsForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.airportNameTextBox = new System.Windows.Forms.TextBox();
            this.airportCityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteDestination = new System.Windows.Forms.Button();
            this.updateDestination = new System.Windows.Forms.Button();
            this.addDestination = new System.Windows.Forms.Button();
            this.destinationsGridView = new System.Windows.Forms.DataGridView();
            this.destinationIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAirportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(867, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "City";
            // 
            // airportNameTextBox
            // 
            this.airportNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airportNameTextBox.Location = new System.Drawing.Point(867, 35);
            this.airportNameTextBox.Name = "airportNameTextBox";
            this.airportNameTextBox.Size = new System.Drawing.Size(199, 27);
            this.airportNameTextBox.TabIndex = 27;
            // 
            // airportCityComboBox
            // 
            this.airportCityComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airportCityComboBox.FormattingEnabled = true;
            this.airportCityComboBox.Location = new System.Drawing.Point(867, 98);
            this.airportCityComboBox.Name = "airportCityComboBox";
            this.airportCityComboBox.Size = new System.Drawing.Size(201, 28);
            this.airportCityComboBox.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(867, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Airport Name";
            // 
            // deleteDestination
            // 
            this.deleteDestination.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteDestination.Location = new System.Drawing.Point(867, 538);
            this.deleteDestination.Name = "deleteDestination";
            this.deleteDestination.Size = new System.Drawing.Size(203, 36);
            this.deleteDestination.TabIndex = 24;
            this.deleteDestination.Text = "Delete";
            this.deleteDestination.UseVisualStyleBackColor = true;
            // 
            // updateDestination
            // 
            this.updateDestination.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateDestination.Location = new System.Drawing.Point(867, 496);
            this.updateDestination.Name = "updateDestination";
            this.updateDestination.Size = new System.Drawing.Size(203, 36);
            this.updateDestination.TabIndex = 23;
            this.updateDestination.Text = "Update";
            this.updateDestination.UseVisualStyleBackColor = true;
            // 
            // addDestination
            // 
            this.addDestination.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDestination.Location = new System.Drawing.Point(865, 454);
            this.addDestination.Name = "addDestination";
            this.addDestination.Size = new System.Drawing.Size(203, 36);
            this.addDestination.TabIndex = 22;
            this.addDestination.Text = "Add";
            this.addDestination.UseVisualStyleBackColor = true;
            // 
            // destinationsGridView
            // 
            this.destinationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destinationsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destinationIdColumn,
            this.destinationAirportColumn,
            this.destinationCityColumn});
            this.destinationsGridView.Location = new System.Drawing.Point(12, 12);
            this.destinationsGridView.Name = "destinationsGridView";
            this.destinationsGridView.RowTemplate.Height = 25;
            this.destinationsGridView.Size = new System.Drawing.Size(849, 562);
            this.destinationsGridView.TabIndex = 21;
            // 
            // destinationIdColumn
            // 
            this.destinationIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinationIdColumn.HeaderText = "ID";
            this.destinationIdColumn.Name = "destinationIdColumn";
            // 
            // destinationAirportColumn
            // 
            this.destinationAirportColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinationAirportColumn.HeaderText = "AIRPORT";
            this.destinationAirportColumn.Name = "destinationAirportColumn";
            // 
            // destinationCityColumn
            // 
            this.destinationCityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinationCityColumn.HeaderText = "CITY";
            this.destinationCityColumn.Name = "destinationCityColumn";
            // 
            // DestinationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 587);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.airportNameTextBox);
            this.Controls.Add(this.airportCityComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteDestination);
            this.Controls.Add(this.updateDestination);
            this.Controls.Add(this.addDestination);
            this.Controls.Add(this.destinationsGridView);
            this.Name = "DestinationsForm";
            this.Text = "DestinationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.destinationsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private TextBox airportNameTextBox;
        private ComboBox airportCityComboBox;
        private Label label7;
        private Button deleteDestination;
        private Button updateDestination;
        private Button addDestination;
        private DataGridView destinationsGridView;
        private DataGridViewTextBoxColumn destinationIdColumn;
        private DataGridViewTextBoxColumn destinationAirportColumn;
        private DataGridViewTextBoxColumn destinationCityColumn;
    }
}