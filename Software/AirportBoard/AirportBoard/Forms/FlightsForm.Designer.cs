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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.flightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightToDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightFromDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightAirline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightGateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightToDestinationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightFromDestinationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightAirlineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
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
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Date";
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
            this.deleteFlight.Click += new System.EventHandler(this.deleteFlight_Click);
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
            this.updateFlight.Click += new System.EventHandler(this.updateFlight_Click);
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
            this.addFlight.Click += new System.EventHandler(this.addFlight_Click);
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
            this.flightsGridView.AllowUserToAddRows = false;
            this.flightsGridView.AllowUserToDeleteRows = false;
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightId,
            this.flightTime,
            this.flightGate,
            this.flightToDestination,
            this.flightFromDestination,
            this.flightAirline,
            this.flightStatus,
            this.flightGateId,
            this.flightToDestinationId,
            this.flightFromDestinationId,
            this.flightAirlineId,
            this.flightStatusId});
            this.flightsGridView.Location = new System.Drawing.Point(12, 12);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.ReadOnly = true;
            this.flightsGridView.RowTemplate.Height = 25;
            this.flightsGridView.Size = new System.Drawing.Size(849, 562);
            this.flightsGridView.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(869, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(973, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Minutes";
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(869, 372);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(95, 23);
            this.hourNumericUpDown.TabIndex = 34;
            // 
            // minutesNumericUpDown
            // 
            this.minutesNumericUpDown.Location = new System.Drawing.Point(973, 372);
            this.minutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumericUpDown.Name = "minutesNumericUpDown";
            this.minutesNumericUpDown.Size = new System.Drawing.Size(97, 23);
            this.minutesNumericUpDown.TabIndex = 35;
            // 
            // flightId
            // 
            this.flightId.HeaderText = "ID";
            this.flightId.Name = "flightId";
            this.flightId.ReadOnly = true;
            this.flightId.Width = 50;
            // 
            // flightTime
            // 
            this.flightTime.HeaderText = "TIME";
            this.flightTime.Name = "flightTime";
            this.flightTime.ReadOnly = true;
            this.flightTime.Width = 150;
            // 
            // flightGate
            // 
            this.flightGate.HeaderText = "GATE";
            this.flightGate.Name = "flightGate";
            this.flightGate.ReadOnly = true;
            // 
            // flightToDestination
            // 
            this.flightToDestination.HeaderText = "TO";
            this.flightToDestination.Name = "flightToDestination";
            this.flightToDestination.ReadOnly = true;
            this.flightToDestination.Width = 150;
            // 
            // flightFromDestination
            // 
            this.flightFromDestination.HeaderText = "FROM";
            this.flightFromDestination.Name = "flightFromDestination";
            this.flightFromDestination.ReadOnly = true;
            this.flightFromDestination.Width = 150;
            // 
            // flightAirline
            // 
            this.flightAirline.HeaderText = "AIRLINE";
            this.flightAirline.Name = "flightAirline";
            this.flightAirline.ReadOnly = true;
            this.flightAirline.Width = 150;
            // 
            // flightStatus
            // 
            this.flightStatus.HeaderText = "STATUS";
            this.flightStatus.Name = "flightStatus";
            this.flightStatus.ReadOnly = true;
            this.flightStatus.Width = 150;
            // 
            // flightGateId
            // 
            this.flightGateId.HeaderText = "GATE_ID";
            this.flightGateId.Name = "flightGateId";
            this.flightGateId.ReadOnly = true;
            this.flightGateId.Width = 60;
            // 
            // flightToDestinationId
            // 
            this.flightToDestinationId.HeaderText = "TO_ID";
            this.flightToDestinationId.Name = "flightToDestinationId";
            this.flightToDestinationId.ReadOnly = true;
            this.flightToDestinationId.Width = 60;
            // 
            // flightFromDestinationId
            // 
            this.flightFromDestinationId.HeaderText = "FROM_ID";
            this.flightFromDestinationId.Name = "flightFromDestinationId";
            this.flightFromDestinationId.ReadOnly = true;
            this.flightFromDestinationId.Width = 60;
            // 
            // flightAirlineId
            // 
            this.flightAirlineId.HeaderText = "AIRLINE_ID";
            this.flightAirlineId.Name = "flightAirlineId";
            this.flightAirlineId.ReadOnly = true;
            // 
            // flightStatusId
            // 
            this.flightStatusId.HeaderText = "STATUS_ID";
            this.flightStatusId.Name = "flightStatusId";
            this.flightStatusId.ReadOnly = true;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 585);
            this.Controls.Add(this.minutesNumericUpDown);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
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
        private Label label7;
        private Label label8;
        private NumericUpDown hourNumericUpDown;
        private NumericUpDown minutesNumericUpDown;
        private DataGridViewTextBoxColumn flightId;
        private DataGridViewTextBoxColumn flightTime;
        private DataGridViewTextBoxColumn flightGate;
        private DataGridViewTextBoxColumn flightToDestination;
        private DataGridViewTextBoxColumn flightFromDestination;
        private DataGridViewTextBoxColumn flightAirline;
        private DataGridViewTextBoxColumn flightStatus;
        private DataGridViewTextBoxColumn flightGateId;
        private DataGridViewTextBoxColumn flightToDestinationId;
        private DataGridViewTextBoxColumn flightFromDestinationId;
        private DataGridViewTextBoxColumn flightAirlineId;
        private DataGridViewTextBoxColumn flightStatusId;
    }
}