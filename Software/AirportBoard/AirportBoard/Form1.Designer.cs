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
            this.arrivalGridView = new System.Windows.Forms.DataGridView();
            this.arrivalTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDestinations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureGridView = new System.Windows.Forms.DataGridView();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airlinesButton
            // 
            this.airlinesButton.Location = new System.Drawing.Point(12, 572);
            this.airlinesButton.Name = "airlinesButton";
            this.airlinesButton.Size = new System.Drawing.Size(116, 33);
            this.airlinesButton.TabIndex = 0;
            this.airlinesButton.Text = "Airlines";
            this.airlinesButton.UseVisualStyleBackColor = true;
            this.airlinesButton.Click += new System.EventHandler(this.airlinesButton_Click);
            // 
            // citiesButton
            // 
            this.citiesButton.Location = new System.Drawing.Point(134, 572);
            this.citiesButton.Name = "citiesButton";
            this.citiesButton.Size = new System.Drawing.Size(116, 33);
            this.citiesButton.TabIndex = 1;
            this.citiesButton.Text = "Cities";
            this.citiesButton.UseVisualStyleBackColor = true;
            this.citiesButton.Click += new System.EventHandler(this.citiesButton_Click);
            // 
            // countriesButton
            // 
            this.countriesButton.Location = new System.Drawing.Point(256, 572);
            this.countriesButton.Name = "countriesButton";
            this.countriesButton.Size = new System.Drawing.Size(116, 33);
            this.countriesButton.TabIndex = 2;
            this.countriesButton.Text = "Countries";
            this.countriesButton.UseVisualStyleBackColor = true;
            this.countriesButton.Click += new System.EventHandler(this.countriesButton_Click);
            // 
            // destinationsButton
            // 
            this.destinationsButton.Location = new System.Drawing.Point(378, 572);
            this.destinationsButton.Name = "destinationsButton";
            this.destinationsButton.Size = new System.Drawing.Size(116, 33);
            this.destinationsButton.TabIndex = 3;
            this.destinationsButton.Text = "Destinations";
            this.destinationsButton.UseVisualStyleBackColor = true;
            this.destinationsButton.Click += new System.EventHandler(this.destinationsButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.Location = new System.Drawing.Point(500, 572);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(116, 33);
            this.flightsButton.TabIndex = 4;
            this.flightsButton.Text = "Flights";
            this.flightsButton.UseVisualStyleBackColor = true;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // flightStatusesButton
            // 
            this.flightStatusesButton.Location = new System.Drawing.Point(622, 572);
            this.flightStatusesButton.Name = "flightStatusesButton";
            this.flightStatusesButton.Size = new System.Drawing.Size(116, 33);
            this.flightStatusesButton.TabIndex = 5;
            this.flightStatusesButton.Text = "Flight Statuses";
            this.flightStatusesButton.UseVisualStyleBackColor = true;
            this.flightStatusesButton.Click += new System.EventHandler(this.flightStatusesButton_Click);
            // 
            // arrivalGridView
            // 
            this.arrivalGridView.AllowUserToAddRows = false;
            this.arrivalGridView.AllowUserToDeleteRows = false;
            this.arrivalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrivalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arrivalTimes,
            this.arrivalDestinations,
            this.arrivalFlight,
            this.arrivalGate,
            this.arrivalStatus});
            this.arrivalGridView.Location = new System.Drawing.Point(12, 62);
            this.arrivalGridView.Name = "arrivalGridView";
            this.arrivalGridView.ReadOnly = true;
            this.arrivalGridView.RowTemplate.Height = 25;
            this.arrivalGridView.Size = new System.Drawing.Size(537, 491);
            this.arrivalGridView.TabIndex = 7;
            // 
            // arrivalTimes
            // 
            this.arrivalTimes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalTimes.HeaderText = "TIME";
            this.arrivalTimes.Name = "arrivalTimes";
            this.arrivalTimes.ReadOnly = true;
            // 
            // arrivalDestinations
            // 
            this.arrivalDestinations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalDestinations.HeaderText = "FROM";
            this.arrivalDestinations.Name = "arrivalDestinations";
            this.arrivalDestinations.ReadOnly = true;
            // 
            // arrivalFlight
            // 
            this.arrivalFlight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalFlight.HeaderText = "FLIGHT";
            this.arrivalFlight.Name = "arrivalFlight";
            this.arrivalFlight.ReadOnly = true;
            // 
            // arrivalGate
            // 
            this.arrivalGate.HeaderText = "GATE";
            this.arrivalGate.Name = "arrivalGate";
            this.arrivalGate.ReadOnly = true;
            this.arrivalGate.Width = 50;
            // 
            // arrivalStatus
            // 
            this.arrivalStatus.HeaderText = "STATUS";
            this.arrivalStatus.Name = "arrivalStatus";
            this.arrivalStatus.ReadOnly = true;
            // 
            // departureGridView
            // 
            this.departureGridView.AllowUserToAddRows = false;
            this.departureGridView.AllowUserToDeleteRows = false;
            this.departureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departureGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureTime,
            this.departureDestination,
            this.departureFlight,
            this.departureGate,
            this.departureStatus});
            this.departureGridView.Location = new System.Drawing.Point(555, 62);
            this.departureGridView.Name = "departureGridView";
            this.departureGridView.ReadOnly = true;
            this.departureGridView.RowTemplate.Height = 25;
            this.departureGridView.Size = new System.Drawing.Size(537, 491);
            this.departureGridView.TabIndex = 8;
            // 
            // departureTime
            // 
            this.departureTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureTime.HeaderText = "TIME";
            this.departureTime.Name = "departureTime";
            this.departureTime.ReadOnly = true;
            // 
            // departureDestination
            // 
            this.departureDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureDestination.HeaderText = "TO";
            this.departureDestination.Name = "departureDestination";
            this.departureDestination.ReadOnly = true;
            // 
            // departureFlight
            // 
            this.departureFlight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureFlight.HeaderText = "FLIGHT";
            this.departureFlight.Name = "departureFlight";
            this.departureFlight.ReadOnly = true;
            // 
            // departureGate
            // 
            this.departureGate.HeaderText = "GATE";
            this.departureGate.Name = "departureGate";
            this.departureGate.ReadOnly = true;
            this.departureGate.Width = 50;
            // 
            // departureStatus
            // 
            this.departureStatus.HeaderText = "STATUS";
            this.departureStatus.Name = "departureStatus";
            this.departureStatus.ReadOnly = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(976, 572);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(116, 33);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 617);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departureGridView);
            this.Controls.Add(this.arrivalGridView);
            this.Controls.Add(this.flightStatusesButton);
            this.Controls.Add(this.flightsButton);
            this.Controls.Add(this.destinationsButton);
            this.Controls.Add(this.countriesButton);
            this.Controls.Add(this.citiesButton);
            this.Controls.Add(this.airlinesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrivalGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureGridView)).EndInit();
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
        private DataGridView arrivalGridView;
        private DataGridView departureGridView;
        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridViewTextBoxColumn arrivalTimes;
        private DataGridViewTextBoxColumn arrivalDestinations;
        private DataGridViewTextBoxColumn arrivalFlight;
        private DataGridViewTextBoxColumn arrivalGate;
        private DataGridViewTextBoxColumn arrivalStatus;
        private DataGridViewTextBoxColumn departureTime;
        private DataGridViewTextBoxColumn departureDestination;
        private DataGridViewTextBoxColumn departureFlight;
        private DataGridViewTextBoxColumn departureGate;
        private DataGridViewTextBoxColumn departureStatus;
        private Button refreshButton;
    }
}