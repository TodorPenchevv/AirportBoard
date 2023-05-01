namespace AirportBoard
{
    partial class Form1
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
            this.airlinesButton = new System.Windows.Forms.Button();
            this.citiesButton = new System.Windows.Forms.Button();
            this.countriesButton = new System.Windows.Forms.Button();
            this.destinationsButton = new System.Windows.Forms.Button();
            this.flightsButton = new System.Windows.Forms.Button();
            this.flightStatusesButton = new System.Windows.Forms.Button();
            this.gatesButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arrivalTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDestinations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // airlinesButton
            // 
            this.airlinesButton.Location = new System.Drawing.Point(143, 572);
            this.airlinesButton.Name = "airlinesButton";
            this.airlinesButton.Size = new System.Drawing.Size(116, 33);
            this.airlinesButton.TabIndex = 0;
            this.airlinesButton.Text = "Airlines";
            this.airlinesButton.UseVisualStyleBackColor = true;
            this.airlinesButton.Click += new System.EventHandler(this.airlinesButton_Click);
            // 
            // citiesButton
            // 
            this.citiesButton.Location = new System.Drawing.Point(265, 572);
            this.citiesButton.Name = "citiesButton";
            this.citiesButton.Size = new System.Drawing.Size(116, 33);
            this.citiesButton.TabIndex = 1;
            this.citiesButton.Text = "Cities";
            this.citiesButton.UseVisualStyleBackColor = true;
            this.citiesButton.Click += new System.EventHandler(this.citiesButton_Click);
            // 
            // countriesButton
            // 
            this.countriesButton.Location = new System.Drawing.Point(387, 572);
            this.countriesButton.Name = "countriesButton";
            this.countriesButton.Size = new System.Drawing.Size(116, 33);
            this.countriesButton.TabIndex = 2;
            this.countriesButton.Text = "Countries";
            this.countriesButton.UseVisualStyleBackColor = true;
            this.countriesButton.Click += new System.EventHandler(this.countriesButton_Click);
            // 
            // destinationsButton
            // 
            this.destinationsButton.Location = new System.Drawing.Point(509, 572);
            this.destinationsButton.Name = "destinationsButton";
            this.destinationsButton.Size = new System.Drawing.Size(116, 33);
            this.destinationsButton.TabIndex = 3;
            this.destinationsButton.Text = "Destinations";
            this.destinationsButton.UseVisualStyleBackColor = true;
            this.destinationsButton.Click += new System.EventHandler(this.destinationsButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.Location = new System.Drawing.Point(631, 572);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(116, 33);
            this.flightsButton.TabIndex = 4;
            this.flightsButton.Text = "Flights";
            this.flightsButton.UseVisualStyleBackColor = true;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // flightStatusesButton
            // 
            this.flightStatusesButton.Location = new System.Drawing.Point(753, 572);
            this.flightStatusesButton.Name = "flightStatusesButton";
            this.flightStatusesButton.Size = new System.Drawing.Size(116, 33);
            this.flightStatusesButton.TabIndex = 5;
            this.flightStatusesButton.Text = "Flight Statuses";
            this.flightStatusesButton.UseVisualStyleBackColor = true;
            this.flightStatusesButton.Click += new System.EventHandler(this.flightStatusesButton_Click);
            // 
            // gatesButton
            // 
            this.gatesButton.Location = new System.Drawing.Point(875, 572);
            this.gatesButton.Name = "gatesButton";
            this.gatesButton.Size = new System.Drawing.Size(116, 33);
            this.gatesButton.TabIndex = 6;
            this.gatesButton.Text = "Gates";
            this.gatesButton.UseVisualStyleBackColor = true;
            this.gatesButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arrivalTimes,
            this.arrivalDestinations,
            this.arrivalFlight,
            this.arrivalGate,
            this.arrivalStatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(537, 491);
            this.dataGridView1.TabIndex = 7;
            // 
            // arrivalTimes
            // 
            this.arrivalTimes.HeaderText = "TIME";
            this.arrivalTimes.Name = "arrivalTimes";
            // 
            // arrivalDestinations
            // 
            this.arrivalDestinations.HeaderText = "DESTINATION";
            this.arrivalDestinations.Name = "arrivalDestinations";
            // 
            // arrivalFlight
            // 
            this.arrivalFlight.HeaderText = "FLIGHT";
            this.arrivalFlight.Name = "arrivalFlight";
            // 
            // arrivalGate
            // 
            this.arrivalGate.HeaderText = "GATE";
            this.arrivalGate.Name = "arrivalGate";
            // 
            // arrivalStatus
            // 
            this.arrivalStatus.HeaderText = "STATUS";
            this.arrivalStatus.Name = "arrivalStatus";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureTime,
            this.departureDestination,
            this.departureFlight,
            this.departureGate,
            this.departureStatus});
            this.dataGridView2.Location = new System.Drawing.Point(555, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(537, 491);
            this.dataGridView2.TabIndex = 8;
            // 
            // departureTime
            // 
            this.departureTime.HeaderText = "TIME";
            this.departureTime.Name = "departureTime";
            // 
            // departureDestination
            // 
            this.departureDestination.HeaderText = "DESTINATION";
            this.departureDestination.Name = "departureDestination";
            // 
            // departureFlight
            // 
            this.departureFlight.HeaderText = "FLIGHT";
            this.departureFlight.Name = "departureFlight";
            // 
            // departureGate
            // 
            this.departureGate.HeaderText = "GATE";
            this.departureGate.Name = "departureGate";
            // 
            // departureStatus
            // 
            this.departureStatus.HeaderText = "STATUS";
            this.departureStatus.Name = "departureStatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ARRIVALS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(555, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "DEPARTURES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 617);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gatesButton);
            this.Controls.Add(this.flightStatusesButton);
            this.Controls.Add(this.flightsButton);
            this.Controls.Add(this.destinationsButton);
            this.Controls.Add(this.countriesButton);
            this.Controls.Add(this.citiesButton);
            this.Controls.Add(this.airlinesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button airlinesButton;
        private Button citiesButton;
        private Button countriesButton;
        private Button destinationsButton;
        private Button flightsButton;
        private Button flightStatusesButton;
        private Button gatesButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn arrivalTimes;
        private DataGridViewTextBoxColumn arrivalDestinations;
        private DataGridViewTextBoxColumn arrivalFlight;
        private DataGridViewTextBoxColumn arrivalGate;
        private DataGridViewTextBoxColumn arrivalStatus;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn departureTime;
        private DataGridViewTextBoxColumn departureDestination;
        private DataGridViewTextBoxColumn departureFlight;
        private DataGridViewTextBoxColumn departureGate;
        private DataGridViewTextBoxColumn departureStatus;
        private Label label1;
        private Label label2;
    }
}