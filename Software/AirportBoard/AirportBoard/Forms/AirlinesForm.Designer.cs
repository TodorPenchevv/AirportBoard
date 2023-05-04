namespace AirportBoard.Forms
{
    partial class AirlinesForm
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
            this.deleteAirline = new System.Windows.Forms.Button();
            this.updateAirline = new System.Windows.Forms.Button();
            this.addAirline = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.airlineCountryComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.airlinesGridView = new System.Windows.Forms.DataGridView();
            this.airlineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineCountryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteAirline
            // 
            this.deleteAirline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAirline.Location = new System.Drawing.Point(867, 538);
            this.deleteAirline.Name = "deleteAirline";
            this.deleteAirline.Size = new System.Drawing.Size(203, 36);
            this.deleteAirline.TabIndex = 41;
            this.deleteAirline.Text = "Delete";
            this.deleteAirline.UseVisualStyleBackColor = true;
            this.deleteAirline.Click += new System.EventHandler(this.deleteAirline_Click);
            // 
            // updateAirline
            // 
            this.updateAirline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateAirline.Location = new System.Drawing.Point(867, 496);
            this.updateAirline.Name = "updateAirline";
            this.updateAirline.Size = new System.Drawing.Size(203, 36);
            this.updateAirline.TabIndex = 40;
            this.updateAirline.Text = "Update";
            this.updateAirline.UseVisualStyleBackColor = true;
            this.updateAirline.Click += new System.EventHandler(this.updateAirline_Click);
            // 
            // addAirline
            // 
            this.addAirline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAirline.Location = new System.Drawing.Point(867, 454);
            this.addAirline.Name = "addAirline";
            this.addAirline.Size = new System.Drawing.Size(203, 36);
            this.addAirline.TabIndex = 39;
            this.addAirline.Text = "Add";
            this.addAirline.UseVisualStyleBackColor = true;
            this.addAirline.Click += new System.EventHandler(this.addAirline_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(865, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Country";
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airlineTextBox.Location = new System.Drawing.Point(867, 34);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(199, 27);
            this.airlineTextBox.TabIndex = 37;
            // 
            // airlineCountryComboBox
            // 
            this.airlineCountryComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.airlineCountryComboBox.FormattingEnabled = true;
            this.airlineCountryComboBox.Location = new System.Drawing.Point(867, 97);
            this.airlineCountryComboBox.Name = "airlineCountryComboBox";
            this.airlineCountryComboBox.Size = new System.Drawing.Size(201, 28);
            this.airlineCountryComboBox.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(865, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Airline Name";
            // 
            // airlinesGridView
            // 
            this.airlinesGridView.AllowUserToAddRows = false;
            this.airlinesGridView.AllowUserToDeleteRows = false;
            this.airlinesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airlinesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airlineId,
            this.airlineName,
            this.airlineCountryId,
            this.airlineCountry});
            this.airlinesGridView.Location = new System.Drawing.Point(12, 12);
            this.airlinesGridView.Name = "airlinesGridView";
            this.airlinesGridView.ReadOnly = true;
            this.airlinesGridView.RowTemplate.Height = 25;
            this.airlinesGridView.Size = new System.Drawing.Size(849, 562);
            this.airlinesGridView.TabIndex = 34;
            // 
            // airlineId
            // 
            this.airlineId.HeaderText = "ID";
            this.airlineId.Name = "airlineId";
            this.airlineId.ReadOnly = true;
            this.airlineId.Width = 50;
            // 
            // airlineName
            // 
            this.airlineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.airlineName.HeaderText = "NAME";
            this.airlineName.Name = "airlineName";
            this.airlineName.ReadOnly = true;
            // 
            // airlineCountryId
            // 
            this.airlineCountryId.HeaderText = "COUNTRY_ID";
            this.airlineCountryId.Name = "airlineCountryId";
            this.airlineCountryId.ReadOnly = true;
            this.airlineCountryId.Width = 150;
            // 
            // airlineCountry
            // 
            this.airlineCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.airlineCountry.HeaderText = "COUNTRY";
            this.airlineCountry.Name = "airlineCountry";
            this.airlineCountry.ReadOnly = true;
            // 
            // AirlinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 587);
            this.Controls.Add(this.deleteAirline);
            this.Controls.Add(this.updateAirline);
            this.Controls.Add(this.addAirline);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.airlineTextBox);
            this.Controls.Add(this.airlineCountryComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.airlinesGridView);
            this.Name = "AirlinesForm";
            this.Text = "AirlinesForm";
            this.Load += new System.EventHandler(this.AirlinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteAirline;
        private Button updateAirline;
        private Button addAirline;
        private Label label12;
        private TextBox airlineTextBox;
        private ComboBox airlineCountryComboBox;
        private Label label13;
        private DataGridView airlinesGridView;
        private DataGridViewTextBoxColumn airlineId;
        private DataGridViewTextBoxColumn airlineName;
        private DataGridViewTextBoxColumn airlineCountryId;
        private DataGridViewTextBoxColumn airlineCountry;
    }
}