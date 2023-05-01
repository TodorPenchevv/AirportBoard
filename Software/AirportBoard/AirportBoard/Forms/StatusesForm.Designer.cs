﻿namespace AirportBoard.Forms
{
    partial class StatusesForm
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
            this.deleteStatus = new System.Windows.Forms.Button();
            this.updateStatus = new System.Windows.Forms.Button();
            this.addStatus = new System.Windows.Forms.Button();
            this.statusNameTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.statusesGridView = new System.Windows.Forms.DataGridView();
            this.statusIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statusesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteStatus
            // 
            this.deleteStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteStatus.Location = new System.Drawing.Point(867, 538);
            this.deleteStatus.Name = "deleteStatus";
            this.deleteStatus.Size = new System.Drawing.Size(203, 36);
            this.deleteStatus.TabIndex = 48;
            this.deleteStatus.Text = "Delete";
            this.deleteStatus.UseVisualStyleBackColor = true;
            // 
            // updateStatus
            // 
            this.updateStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateStatus.Location = new System.Drawing.Point(867, 496);
            this.updateStatus.Name = "updateStatus";
            this.updateStatus.Size = new System.Drawing.Size(203, 36);
            this.updateStatus.TabIndex = 47;
            this.updateStatus.Text = "Update";
            this.updateStatus.UseVisualStyleBackColor = true;
            // 
            // addStatus
            // 
            this.addStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addStatus.Location = new System.Drawing.Point(867, 454);
            this.addStatus.Name = "addStatus";
            this.addStatus.Size = new System.Drawing.Size(203, 36);
            this.addStatus.TabIndex = 46;
            this.addStatus.Text = "Add";
            this.addStatus.UseVisualStyleBackColor = true;
            // 
            // statusNameTextBox
            // 
            this.statusNameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusNameTextBox.Location = new System.Drawing.Point(867, 35);
            this.statusNameTextBox.Name = "statusNameTextBox";
            this.statusNameTextBox.Size = new System.Drawing.Size(199, 27);
            this.statusNameTextBox.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(865, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Status";
            // 
            // statusesGridView
            // 
            this.statusesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusIdColumn,
            this.statusNameColumn});
            this.statusesGridView.Location = new System.Drawing.Point(12, 12);
            this.statusesGridView.Name = "statusesGridView";
            this.statusesGridView.RowTemplate.Height = 25;
            this.statusesGridView.Size = new System.Drawing.Size(849, 562);
            this.statusesGridView.TabIndex = 43;
            // 
            // statusIdColumn
            // 
            this.statusIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusIdColumn.HeaderText = "ID";
            this.statusIdColumn.Name = "statusIdColumn";
            // 
            // statusNameColumn
            // 
            this.statusNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusNameColumn.HeaderText = "STATUS";
            this.statusNameColumn.Name = "statusNameColumn";
            // 
            // StatusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 587);
            this.Controls.Add(this.deleteStatus);
            this.Controls.Add(this.updateStatus);
            this.Controls.Add(this.addStatus);
            this.Controls.Add(this.statusNameTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.statusesGridView);
            this.Name = "StatusesForm";
            this.Text = "StatusesForm";
            ((System.ComponentModel.ISupportInitialize)(this.statusesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteStatus;
        private Button updateStatus;
        private Button addStatus;
        private TextBox statusNameTextBox;
        private Label label17;
        private DataGridView statusesGridView;
        private DataGridViewTextBoxColumn statusIdColumn;
        private DataGridViewTextBoxColumn statusNameColumn;
    }
}