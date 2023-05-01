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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.board_tab = new System.Windows.Forms.TabPage();
            this.flights_tab = new System.Windows.Forms.TabPage();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.destinations_tab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.airportNameTextBox = new System.Windows.Forms.TextBox();
            this.airportCityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteDestination = new System.Windows.Forms.Button();
            this.updateDestination = new System.Windows.Forms.Button();
            this.addDestination = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cities_tab = new System.Windows.Forms.TabPage();
            this.deleteCity = new System.Windows.Forms.Button();
            this.updateCity = new System.Windows.Forms.Button();
            this.addCity = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.cityCoutnryComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.countries_tab = new System.Windows.Forms.TabPage();
            this.deleteCountry = new System.Windows.Forms.Button();
            this.updateCountry = new System.Windows.Forms.Button();
            this.addCountry = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.airlines_tab = new System.Windows.Forms.TabPage();
            this.deleteAirline = new System.Windows.Forms.Button();
            this.updateAirline = new System.Windows.Forms.Button();
            this.addAirline = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.airlineCountryComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.gates_tab = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.flight_status_tab = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.flights_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.destinations_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.cities_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.countries_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.airlines_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.gates_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.flight_status_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.board_tab);
            this.tabControl1.Controls.Add(this.flights_tab);
            this.tabControl1.Controls.Add(this.destinations_tab);
            this.tabControl1.Controls.Add(this.cities_tab);
            this.tabControl1.Controls.Add(this.countries_tab);
            this.tabControl1.Controls.Add(this.airlines_tab);
            this.tabControl1.Controls.Add(this.gates_tab);
            this.tabControl1.Controls.Add(this.flight_status_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 602);
            this.tabControl1.TabIndex = 0;
            // 
            // board_tab
            // 
            this.board_tab.Location = new System.Drawing.Point(4, 24);
            this.board_tab.Name = "board_tab";
            this.board_tab.Padding = new System.Windows.Forms.Padding(3);
            this.board_tab.Size = new System.Drawing.Size(1070, 574);
            this.board_tab.TabIndex = 0;
            this.board_tab.Text = "Board";
            this.board_tab.UseVisualStyleBackColor = true;
            // 
            // flights_tab
            // 
            this.flights_tab.Controls.Add(this.flightDateTimePicker);
            this.flights_tab.Controls.Add(this.label6);
            this.flights_tab.Controls.Add(this.deleteFlight);
            this.flights_tab.Controls.Add(this.updateFlight);
            this.flights_tab.Controls.Add(this.addFlight);
            this.flights_tab.Controls.Add(this.statusComboBox);
            this.flights_tab.Controls.Add(this.label5);
            this.flights_tab.Controls.Add(this.airlinesComboBox);
            this.flights_tab.Controls.Add(this.label4);
            this.flights_tab.Controls.Add(this.toComboBox);
            this.flights_tab.Controls.Add(this.label3);
            this.flights_tab.Controls.Add(this.fromComboBox);
            this.flights_tab.Controls.Add(this.label2);
            this.flights_tab.Controls.Add(this.gateComboBox);
            this.flights_tab.Controls.Add(this.label1);
            this.flights_tab.Controls.Add(this.dataGridView1);
            this.flights_tab.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flights_tab.Location = new System.Drawing.Point(4, 24);
            this.flights_tab.Name = "flights_tab";
            this.flights_tab.Padding = new System.Windows.Forms.Padding(3);
            this.flights_tab.Size = new System.Drawing.Size(1070, 574);
            this.flights_tab.TabIndex = 1;
            this.flights_tab.Text = "Flights";
            this.flights_tab.UseVisualStyleBackColor = true;
            // 
            // flightDateTimePicker
            // 
            this.flightDateTimePicker.Location = new System.Drawing.Point(863, 306);
            this.flightDateTimePicker.Name = "flightDateTimePicker";
            this.flightDateTimePicker.Size = new System.Drawing.Size(201, 27);
            this.flightDateTimePicker.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(861, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time";
            // 
            // deleteFlight
            // 
            this.deleteFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteFlight.Location = new System.Drawing.Point(861, 532);
            this.deleteFlight.Name = "deleteFlight";
            this.deleteFlight.Size = new System.Drawing.Size(203, 36);
            this.deleteFlight.TabIndex = 13;
            this.deleteFlight.Text = "Delete";
            this.deleteFlight.UseVisualStyleBackColor = true;
            this.deleteFlight.Click += new System.EventHandler(this.deleteFlight_Click);
            // 
            // updateFlight
            // 
            this.updateFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateFlight.Location = new System.Drawing.Point(861, 490);
            this.updateFlight.Name = "updateFlight";
            this.updateFlight.Size = new System.Drawing.Size(203, 36);
            this.updateFlight.TabIndex = 12;
            this.updateFlight.Text = "Update";
            this.updateFlight.UseVisualStyleBackColor = true;
            this.updateFlight.Click += new System.EventHandler(this.updateFlight_Click);
            // 
            // addFlight
            // 
            this.addFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addFlight.Location = new System.Drawing.Point(859, 448);
            this.addFlight.Name = "addFlight";
            this.addFlight.Size = new System.Drawing.Size(203, 36);
            this.addFlight.TabIndex = 11;
            this.addFlight.Text = "Add";
            this.addFlight.UseVisualStyleBackColor = true;
            this.addFlight.Click += new System.EventHandler(this.addFlight_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(861, 248);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(201, 28);
            this.statusComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(861, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // airlinesComboBox
            // 
            this.airlinesComboBox.FormattingEnabled = true;
            this.airlinesComboBox.Location = new System.Drawing.Point(863, 194);
            this.airlinesComboBox.Name = "airlinesComboBox";
            this.airlinesComboBox.Size = new System.Drawing.Size(201, 28);
            this.airlinesComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(861, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Airline";
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(861, 140);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(201, 28);
            this.toComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(861, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(861, 85);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(201, 28);
            this.fromComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(861, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // gateComboBox
            // 
            this.gateComboBox.FormattingEnabled = true;
            this.gateComboBox.Location = new System.Drawing.Point(861, 29);
            this.gateComboBox.Name = "gateComboBox";
            this.gateComboBox.Size = new System.Drawing.Size(201, 28);
            this.gateComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(861, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(849, 562);
            this.dataGridView1.TabIndex = 0;
            // 
            // destinations_tab
            // 
            this.destinations_tab.Controls.Add(this.label8);
            this.destinations_tab.Controls.Add(this.airportNameTextBox);
            this.destinations_tab.Controls.Add(this.airportCityComboBox);
            this.destinations_tab.Controls.Add(this.label7);
            this.destinations_tab.Controls.Add(this.deleteDestination);
            this.destinations_tab.Controls.Add(this.updateDestination);
            this.destinations_tab.Controls.Add(this.addDestination);
            this.destinations_tab.Controls.Add(this.dataGridView2);
            this.destinations_tab.Location = new System.Drawing.Point(4, 24);
            this.destinations_tab.Name = "destinations_tab";
            this.destinations_tab.Padding = new System.Windows.Forms.Padding(3);
            this.destinations_tab.Size = new System.Drawing.Size(1070, 574);
            this.destinations_tab.TabIndex = 2;
            this.destinations_tab.Text = "Destinations";
            this.destinations_tab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(861, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "City";
            // 
            // airportNameTextBox
            // 
            this.airportNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airportNameTextBox.Location = new System.Drawing.Point(861, 29);
            this.airportNameTextBox.Name = "airportNameTextBox";
            this.airportNameTextBox.Size = new System.Drawing.Size(199, 27);
            this.airportNameTextBox.TabIndex = 19;
            // 
            // airportCityComboBox
            // 
            this.airportCityComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airportCityComboBox.FormattingEnabled = true;
            this.airportCityComboBox.Location = new System.Drawing.Point(861, 92);
            this.airportCityComboBox.Name = "airportCityComboBox";
            this.airportCityComboBox.Size = new System.Drawing.Size(201, 28);
            this.airportCityComboBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(861, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Airport Name";
            // 
            // deleteDestination
            // 
            this.deleteDestination.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteDestination.Location = new System.Drawing.Point(861, 532);
            this.deleteDestination.Name = "deleteDestination";
            this.deleteDestination.Size = new System.Drawing.Size(203, 36);
            this.deleteDestination.TabIndex = 16;
            this.deleteDestination.Text = "Delete";
            this.deleteDestination.UseVisualStyleBackColor = true;
            this.deleteDestination.Click += new System.EventHandler(this.deleteDestination_Click);
            // 
            // updateDestination
            // 
            this.updateDestination.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateDestination.Location = new System.Drawing.Point(861, 490);
            this.updateDestination.Name = "updateDestination";
            this.updateDestination.Size = new System.Drawing.Size(203, 36);
            this.updateDestination.TabIndex = 15;
            this.updateDestination.Text = "Update";
            this.updateDestination.UseVisualStyleBackColor = true;
            this.updateDestination.Click += new System.EventHandler(this.updateDestination_Click);
            // 
            // addDestination
            // 
            this.addDestination.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addDestination.Location = new System.Drawing.Point(859, 448);
            this.addDestination.Name = "addDestination";
            this.addDestination.Size = new System.Drawing.Size(203, 36);
            this.addDestination.TabIndex = 14;
            this.addDestination.Text = "Add";
            this.addDestination.UseVisualStyleBackColor = true;
            this.addDestination.Click += new System.EventHandler(this.addDestination_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(849, 562);
            this.dataGridView2.TabIndex = 1;
            // 
            // cities_tab
            // 
            this.cities_tab.Controls.Add(this.deleteCity);
            this.cities_tab.Controls.Add(this.updateCity);
            this.cities_tab.Controls.Add(this.addCity);
            this.cities_tab.Controls.Add(this.label9);
            this.cities_tab.Controls.Add(this.cityNameTextBox);
            this.cities_tab.Controls.Add(this.cityCoutnryComboBox);
            this.cities_tab.Controls.Add(this.label10);
            this.cities_tab.Controls.Add(this.dataGridView3);
            this.cities_tab.Location = new System.Drawing.Point(4, 24);
            this.cities_tab.Name = "cities_tab";
            this.cities_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cities_tab.Size = new System.Drawing.Size(1070, 574);
            this.cities_tab.TabIndex = 3;
            this.cities_tab.Text = "Cities";
            this.cities_tab.UseVisualStyleBackColor = true;
            // 
            // deleteCity
            // 
            this.deleteCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCity.Location = new System.Drawing.Point(861, 531);
            this.deleteCity.Name = "deleteCity";
            this.deleteCity.Size = new System.Drawing.Size(203, 36);
            this.deleteCity.TabIndex = 27;
            this.deleteCity.Text = "Delete";
            this.deleteCity.UseVisualStyleBackColor = true;
            this.deleteCity.Click += new System.EventHandler(this.deleteCity_Click);
            // 
            // updateCity
            // 
            this.updateCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCity.Location = new System.Drawing.Point(861, 489);
            this.updateCity.Name = "updateCity";
            this.updateCity.Size = new System.Drawing.Size(203, 36);
            this.updateCity.TabIndex = 26;
            this.updateCity.Text = "Update";
            this.updateCity.UseVisualStyleBackColor = true;
            this.updateCity.Click += new System.EventHandler(this.updateCity_Click);
            // 
            // addCity
            // 
            this.addCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCity.Location = new System.Drawing.Point(861, 447);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(203, 36);
            this.addCity.TabIndex = 25;
            this.addCity.Text = "Add";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(859, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Country";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityNameTextBox.Location = new System.Drawing.Point(861, 30);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(199, 27);
            this.cityNameTextBox.TabIndex = 23;
            // 
            // cityCoutnryComboBox
            // 
            this.cityCoutnryComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityCoutnryComboBox.FormattingEnabled = true;
            this.cityCoutnryComboBox.Location = new System.Drawing.Point(861, 93);
            this.cityCoutnryComboBox.Name = "cityCoutnryComboBox";
            this.cityCoutnryComboBox.Size = new System.Drawing.Size(201, 28);
            this.cityCoutnryComboBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(859, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "City";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(849, 562);
            this.dataGridView3.TabIndex = 2;
            // 
            // countries_tab
            // 
            this.countries_tab.Controls.Add(this.deleteCountry);
            this.countries_tab.Controls.Add(this.updateCountry);
            this.countries_tab.Controls.Add(this.addCountry);
            this.countries_tab.Controls.Add(this.countryTextBox);
            this.countries_tab.Controls.Add(this.label11);
            this.countries_tab.Controls.Add(this.dataGridView4);
            this.countries_tab.Location = new System.Drawing.Point(4, 24);
            this.countries_tab.Name = "countries_tab";
            this.countries_tab.Padding = new System.Windows.Forms.Padding(3);
            this.countries_tab.Size = new System.Drawing.Size(1070, 574);
            this.countries_tab.TabIndex = 4;
            this.countries_tab.Text = "Countries";
            this.countries_tab.UseVisualStyleBackColor = true;
            // 
            // deleteCountry
            // 
            this.deleteCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteCountry.Location = new System.Drawing.Point(861, 532);
            this.deleteCountry.Name = "deleteCountry";
            this.deleteCountry.Size = new System.Drawing.Size(203, 36);
            this.deleteCountry.TabIndex = 30;
            this.deleteCountry.Text = "Delete";
            this.deleteCountry.UseVisualStyleBackColor = true;
            this.deleteCountry.Click += new System.EventHandler(this.deleteCountry_Click);
            // 
            // updateCountry
            // 
            this.updateCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateCountry.Location = new System.Drawing.Point(861, 490);
            this.updateCountry.Name = "updateCountry";
            this.updateCountry.Size = new System.Drawing.Size(203, 36);
            this.updateCountry.TabIndex = 29;
            this.updateCountry.Text = "Update";
            this.updateCountry.UseVisualStyleBackColor = true;
            this.updateCountry.Click += new System.EventHandler(this.updateCountry_Click);
            // 
            // addCountry
            // 
            this.addCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCountry.Location = new System.Drawing.Point(861, 448);
            this.addCountry.Name = "addCountry";
            this.addCountry.Size = new System.Drawing.Size(203, 36);
            this.addCountry.TabIndex = 28;
            this.addCountry.Text = "Add";
            this.addCountry.UseVisualStyleBackColor = true;
            this.addCountry.Click += new System.EventHandler(this.addCountry_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryTextBox.Location = new System.Drawing.Point(861, 29);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(199, 27);
            this.countryTextBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(859, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Country";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(849, 562);
            this.dataGridView4.TabIndex = 2;
            // 
            // airlines_tab
            // 
            this.airlines_tab.Controls.Add(this.deleteAirline);
            this.airlines_tab.Controls.Add(this.updateAirline);
            this.airlines_tab.Controls.Add(this.addAirline);
            this.airlines_tab.Controls.Add(this.label12);
            this.airlines_tab.Controls.Add(this.airlineTextBox);
            this.airlines_tab.Controls.Add(this.airlineCountryComboBox);
            this.airlines_tab.Controls.Add(this.label13);
            this.airlines_tab.Controls.Add(this.dataGridView5);
            this.airlines_tab.Location = new System.Drawing.Point(4, 24);
            this.airlines_tab.Name = "airlines_tab";
            this.airlines_tab.Padding = new System.Windows.Forms.Padding(3);
            this.airlines_tab.Size = new System.Drawing.Size(1070, 574);
            this.airlines_tab.TabIndex = 5;
            this.airlines_tab.Text = "Airlines";
            this.airlines_tab.UseVisualStyleBackColor = true;
            // 
            // deleteAirline
            // 
            this.deleteAirline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAirline.Location = new System.Drawing.Point(861, 532);
            this.deleteAirline.Name = "deleteAirline";
            this.deleteAirline.Size = new System.Drawing.Size(203, 36);
            this.deleteAirline.TabIndex = 33;
            this.deleteAirline.Text = "Delete";
            this.deleteAirline.UseVisualStyleBackColor = true;
            this.deleteAirline.Click += new System.EventHandler(this.deleteAirline_Click);
            // 
            // updateAirline
            // 
            this.updateAirline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateAirline.Location = new System.Drawing.Point(861, 490);
            this.updateAirline.Name = "updateAirline";
            this.updateAirline.Size = new System.Drawing.Size(203, 36);
            this.updateAirline.TabIndex = 32;
            this.updateAirline.Text = "Update";
            this.updateAirline.UseVisualStyleBackColor = true;
            this.updateAirline.Click += new System.EventHandler(this.updateAirline_Click);
            // 
            // addAirline
            // 
            this.addAirline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAirline.Location = new System.Drawing.Point(861, 448);
            this.addAirline.Name = "addAirline";
            this.addAirline.Size = new System.Drawing.Size(203, 36);
            this.addAirline.TabIndex = 31;
            this.addAirline.Text = "Add";
            this.addAirline.UseVisualStyleBackColor = true;
            this.addAirline.Click += new System.EventHandler(this.addAirline_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(859, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Country";
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airlineTextBox.Location = new System.Drawing.Point(861, 28);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(199, 27);
            this.airlineTextBox.TabIndex = 27;
            // 
            // airlineCountryComboBox
            // 
            this.airlineCountryComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airlineCountryComboBox.FormattingEnabled = true;
            this.airlineCountryComboBox.Location = new System.Drawing.Point(861, 91);
            this.airlineCountryComboBox.Name = "airlineCountryComboBox";
            this.airlineCountryComboBox.Size = new System.Drawing.Size(201, 28);
            this.airlineCountryComboBox.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(859, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Airline Name";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(849, 562);
            this.dataGridView5.TabIndex = 2;
            // 
            // gates_tab
            // 
            this.gates_tab.Controls.Add(this.dataGridView6);
            this.gates_tab.Location = new System.Drawing.Point(4, 24);
            this.gates_tab.Name = "gates_tab";
            this.gates_tab.Size = new System.Drawing.Size(1070, 574);
            this.gates_tab.TabIndex = 6;
            this.gates_tab.Text = "Gates";
            this.gates_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(6, 6);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.Size = new System.Drawing.Size(849, 562);
            this.dataGridView6.TabIndex = 2;
            // 
            // flight_status_tab
            // 
            this.flight_status_tab.Controls.Add(this.dataGridView7);
            this.flight_status_tab.Location = new System.Drawing.Point(4, 24);
            this.flight_status_tab.Name = "flight_status_tab";
            this.flight_status_tab.Size = new System.Drawing.Size(1070, 574);
            this.flight_status_tab.TabIndex = 7;
            this.flight_status_tab.Text = "Flight Statuses";
            this.flight_status_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(6, 6);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowTemplate.Height = 25;
            this.dataGridView7.Size = new System.Drawing.Size(849, 562);
            this.dataGridView7.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 617);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.flights_tab.ResumeLayout(false);
            this.flights_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.destinations_tab.ResumeLayout(false);
            this.destinations_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.cities_tab.ResumeLayout(false);
            this.cities_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.countries_tab.ResumeLayout(false);
            this.countries_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.airlines_tab.ResumeLayout(false);
            this.airlines_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.gates_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.flight_status_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage board_tab;
        private TabPage flights_tab;
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
        private DataGridView dataGridView1;
        private TabPage destinations_tab;
        private TabPage cities_tab;
        private TabPage countries_tab;
        private TabPage airlines_tab;
        private TabPage gates_tab;
        private TabPage flight_status_tab;
        private DateTimePicker flightDateTimePicker;
        private Label label6;
        private Label label8;
        private TextBox airportNameTextBox;
        private ComboBox airportCityComboBox;
        private Label label7;
        private Button deleteDestination;
        private Button updateDestination;
        private Button addDestination;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label9;
        private TextBox cityNameTextBox;
        private ComboBox cityCoutnryComboBox;
        private Label label10;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private DataGridView dataGridView7;
        private Button deleteCity;
        private Button updateCity;
        private Button addCity;
        private TextBox countryTextBox;
        private Label label11;
        private Button deleteCountry;
        private Button updateCountry;
        private Button addCountry;
        private Button deleteAirline;
        private Button updateAirline;
        private Button addAirline;
        private Label label12;
        private TextBox airlineTextBox;
        private ComboBox airlineCountryComboBox;
        private Label label13;
    }
}