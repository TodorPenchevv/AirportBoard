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
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
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
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(12, 12);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.Size = new System.Drawing.Size(849, 562);
            this.dataGridView6.TabIndex = 38;
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
            this.Controls.Add(this.dataGridView6);
            this.Name = "GatesForm";
            this.Text = "GatesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
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
        private DataGridView dataGridView6;
    }
}