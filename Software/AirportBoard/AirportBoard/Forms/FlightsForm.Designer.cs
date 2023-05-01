namespace AirportBoard.Forms
{
    partial class FlightsForm
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
            this.flightDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteFlight = new System.Windows.Forms.Button();
            this.updateFlight = new System.Windows.Forms.Button();
            this.addFlight = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.airlinesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flightsGridView = new System.Windows.Forms.DataGridView();
            this.flightIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightGateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightToDestinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightFromDestinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightAirlineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flightDateTimePicker
            // 
            this.flightDateTimePicker.Location = new System.Drawing.Point(869, 312);
            this.flightDateTimePicker.Name = "flightDateTimePicker";
            this.flightDateTimePicker.Size = new System.Drawing.Size(201, 23);
            this.flightDateTimePicker.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(867, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Time";
            // 
            // deleteFlight
            // 
            this.deleteFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteFlight.Location = new System.Drawing.Point(867, 538);
            this.deleteFlight.Name = "deleteFlight";
            this.deleteFlight.Size = new System.Drawing.Size(203, 36);
            this.deleteFlight.TabIndex = 29;
            this.deleteFlight.Text = "Delete";
            this.deleteFlight.UseVisualStyleBackColor = true;
            // 
            // updateFlight
            // 
            this.updateFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateFlight.Location = new System.Drawing.Point(867, 496);
            this.updateFlight.Name = "updateFlight";
            this.updateFlight.Size = new System.Drawing.Size(203, 36);
            this.updateFlight.TabIndex = 28;
            this.updateFlight.Text = "Update";
            this.updateFlight.UseVisualStyleBackColor = true;
            // 
            // addFlight
            // 
            this.addFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addFlight.Location = new System.Drawing.Point(865, 454);
            this.addFlight.Name = "addFlight";
            this.addFlight.Size = new System.Drawing.Size(203, 36);
            this.addFlight.TabIndex = 27;
            this.addFlight.Text = "Add";
            this.addFlight.UseVisualStyleBackColor = true;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(867, 254);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(201, 23);
            this.statusComboBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(867, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status";
            // 
            // airlinesComboBox
            // 
            this.airlinesComboBox.FormattingEnabled = true;
            this.airlinesComboBox.Location = new System.Drawing.Point(869, 200);
            this.airlinesComboBox.Name = "airlinesComboBox";
            this.airlinesComboBox.Size = new System.Drawing.Size(201, 23);
            this.airlinesComboBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(867, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Airline";
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(867, 146);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(201, 23);
            this.toComboBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(867, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "To";
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(867, 91);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(201, 23);
            this.fromComboBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(867, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "From";
            // 
            // gateComboBox
            // 
            this.gateComboBox.FormattingEnabled = true;
            this.gateComboBox.Location = new System.Drawing.Point(867, 35);
            this.gateComboBox.Name = "gateComboBox";
            this.gateComboBox.Size = new System.Drawing.Size(201, 23);
            this.gateComboBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(867, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gate";
            // 
            // flightsGridView
            // 
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIdColumn,
            this.flightGateColumn,
            this.flightToDestinationColumn,
            this.flightFromDestinationColumn,
            this.flightAirlineColumn,
            this.flightStatusColumn,
            this.flightTimeColumn});
            this.flightsGridView.Location = new System.Drawing.Point(12, 12);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.RowTemplate.Height = 25;
            this.flightsGridView.Size = new System.Drawing.Size(849, 562);
            this.flightsGridView.TabIndex = 16;
            // 
            // flightIdColumn
            // 
            this.flightIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightIdColumn.HeaderText = "ID";
            this.flightIdColumn.Name = "flightIdColumn";
            // 
            // flightGateColumn
            // 
            this.flightGateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightGateColumn.HeaderText = "GATE";
            this.flightGateColumn.Name = "flightGateColumn";
            // 
            // flightToDestinationColumn
            // 
            this.flightToDestinationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightToDestinationColumn.HeaderText = "TO";
            this.flightToDestinationColumn.Name = "flightToDestinationColumn";
            // 
            // flightFromDestinationColumn
            // 
            this.flightFromDestinationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightFromDestinationColumn.HeaderText = "FROM";
            this.flightFromDestinationColumn.Name = "flightFromDestinationColumn";
            // 
            // flightAirlineColumn
            // 
            this.flightAirlineColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightAirlineColumn.HeaderText = "AIRLINE";
            this.flightAirlineColumn.Name = "flightAirlineColumn";
            // 
            // flightStatusColumn
            // 
            this.flightStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.flightStatusColumn.HeaderText = "STATUS";
            this.flightStatusColumn.Name = "flightStatusColumn";
            this.flightStatusColumn.Width = 70;
            // 
            // flightTimeColumn
            // 
            this.flightTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightTimeColumn.HeaderText = "TIME";
            this.flightTimeColumn.Name = "flightTimeColumn";
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 585);
            this.Controls.Add(this.flightDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteFlight);
            this.Controls.Add(this.updateFlight);
            this.Controls.Add(this.addFlight);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.airlinesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gateComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightsGridView);
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker flightDateTimePicker;
        private Label label6;
        private Button deleteFlight;
        private Button updateFlight;
        private Button addFlight;
        private ComboBox statusComboBox;
        private Label label5;
        private ComboBox airlinesComboBox;
        private Label label4;
        private ComboBox toComboBox;
        private Label label3;
        private ComboBox fromComboBox;
        private Label label2;
        private ComboBox gateComboBox;
        private Label label1;
        private DataGridView flightsGridView;
        private DataGridViewTextBoxColumn flightIdColumn;
        private DataGridViewTextBoxColumn flightGateColumn;
        private DataGridViewTextBoxColumn flightToDestinationColumn;
        private DataGridViewTextBoxColumn flightFromDestinationColumn;
        private DataGridViewTextBoxColumn flightAirlineColumn;
        private DataGridViewTextBoxColumn flightStatusColumn;
        private DataGridViewTextBoxColumn flightTimeColumn;
    }
}