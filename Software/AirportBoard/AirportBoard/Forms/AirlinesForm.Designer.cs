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
            this.airlineIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineCountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.airlinesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airlinesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airlineIdColumn,
            this.airlineNameColumn,
            this.airlineCountryColumn});
            this.airlinesGridView.Location = new System.Drawing.Point(12, 12);
            this.airlinesGridView.Name = "airlinesGridView";
            this.airlinesGridView.RowTemplate.Height = 25;
            this.airlinesGridView.Size = new System.Drawing.Size(849, 562);
            this.airlinesGridView.TabIndex = 34;
            // 
            // airlineIdColumn
            // 
            this.airlineIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.airlineIdColumn.HeaderText = "ID";
            this.airlineIdColumn.Name = "airlineIdColumn";
            // 
            // airlineNameColumn
            // 
            this.airlineNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.airlineNameColumn.HeaderText = "NAME";
            this.airlineNameColumn.Name = "airlineNameColumn";
            // 
            // airlineCountryColumn
            // 
            this.airlineCountryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.airlineCountryColumn.HeaderText = "COUNTRY";
            this.airlineCountryColumn.Name = "airlineCountryColumn";
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
        private DataGridViewTextBoxColumn airlineIdColumn;
        private DataGridViewTextBoxColumn airlineNameColumn;
        private DataGridViewTextBoxColumn airlineCountryColumn;
    }
}