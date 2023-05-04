namespace AirportBoard.Forms
{
    partial class GatesForm
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
            this.gateNumberTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.deleteGate = new System.Windows.Forms.Button();
            this.updateGate = new System.Windows.Forms.Button();
            this.addGate = new System.Windows.Forms.Button();
            this.gateZoneTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gatesGridView = new System.Windows.Forms.DataGridView();
            this.gateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gateZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gatesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gateNumberTextBox
            // 
            this.gateNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gateNumberTextBox.Location = new System.Drawing.Point(867, 92);
            this.gateNumberTextBox.Name = "gateNumberTextBox";
            this.gateNumberTextBox.Size = new System.Drawing.Size(199, 27);
            this.gateNumberTextBox.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(865, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 44;
            this.label15.Text = "Number";
            // 
            // deleteGate
            // 
            this.deleteGate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteGate.Location = new System.Drawing.Point(867, 538);
            this.deleteGate.Name = "deleteGate";
            this.deleteGate.Size = new System.Drawing.Size(203, 36);
            this.deleteGate.TabIndex = 43;
            this.deleteGate.Text = "Delete";
            this.deleteGate.UseVisualStyleBackColor = true;
            this.deleteGate.Click += new System.EventHandler(this.deleteGate_Click);
            // 
            // updateGate
            // 
            this.updateGate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateGate.Location = new System.Drawing.Point(867, 496);
            this.updateGate.Name = "updateGate";
            this.updateGate.Size = new System.Drawing.Size(203, 36);
            this.updateGate.TabIndex = 42;
            this.updateGate.Text = "Update";
            this.updateGate.UseVisualStyleBackColor = true;
            this.updateGate.Click += new System.EventHandler(this.updateGate_Click);
            // 
            // addGate
            // 
            this.addGate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addGate.Location = new System.Drawing.Point(867, 454);
            this.addGate.Name = "addGate";
            this.addGate.Size = new System.Drawing.Size(203, 36);
            this.addGate.TabIndex = 41;
            this.addGate.Text = "Add";
            this.addGate.UseVisualStyleBackColor = true;
            this.addGate.Click += new System.EventHandler(this.addGate_Click);
            // 
            // gateZoneTextBox
            // 
            this.gateZoneTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gateZoneTextBox.Location = new System.Drawing.Point(867, 35);
            this.gateZoneTextBox.Name = "gateZoneTextBox";
            this.gateZoneTextBox.Size = new System.Drawing.Size(199, 27);
            this.gateZoneTextBox.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(865, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Zone";
            // 
            // gatesGridView
            // 
            this.gatesGridView.AllowUserToAddRows = false;
            this.gatesGridView.AllowUserToDeleteRows = false;
            this.gatesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gatesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gateId,
            this.gateZone,
            this.gateNumber});
            this.gatesGridView.Location = new System.Drawing.Point(12, 12);
            this.gatesGridView.Name = "gatesGridView";
            this.gatesGridView.ReadOnly = true;
            this.gatesGridView.RowTemplate.Height = 25;
            this.gatesGridView.Size = new System.Drawing.Size(849, 562);
            this.gatesGridView.TabIndex = 38;
            // 
            // gateId
            // 
            this.gateId.HeaderText = "ID";
            this.gateId.Name = "gateId";
            this.gateId.ReadOnly = true;
            this.gateId.Width = 50;
            // 
            // gateZone
            // 
            this.gateZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gateZone.HeaderText = "ZONE";
            this.gateZone.Name = "gateZone";
            this.gateZone.ReadOnly = true;
            // 
            // gateNumber
            // 
            this.gateNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gateNumber.HeaderText = "NUMBER";
            this.gateNumber.Name = "gateNumber";
            this.gateNumber.ReadOnly = true;
            // 
            // GatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 586);
            this.Controls.Add(this.gateNumberTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.deleteGate);
            this.Controls.Add(this.updateGate);
            this.Controls.Add(this.addGate);
            this.Controls.Add(this.gateZoneTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gatesGridView);
            this.Name = "GatesForm";
            this.Text = "GatesForm";
            this.Load += new System.EventHandler(this.GatesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gatesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox gateNumberTextBox;
        private Label label15;
        private Button deleteGate;
        private Button updateGate;
        private Button addGate;
        private TextBox gateZoneTextBox;
        private Label label14;
        private DataGridView gatesGridView;
        private DataGridViewTextBoxColumn gateId;
        private DataGridViewTextBoxColumn gateZone;
        private DataGridViewTextBoxColumn gateNumber;
    }
}