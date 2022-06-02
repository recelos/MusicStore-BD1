﻿
namespace MusicStore.Views
{
    partial class FormEmployee
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
            this.instrumentsDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ordersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // instrumentsDataGridView
            // 
            this.instrumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.instrumentsDataGridView.Location = new System.Drawing.Point(70, 120);
            this.instrumentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instrumentsDataGridView.MultiSelect = false;
            this.instrumentsDataGridView.Name = "instrumentsDataGridView";
            this.instrumentsDataGridView.ReadOnly = true;
            this.instrumentsDataGridView.RowTemplate.Height = 25;
            this.instrumentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instrumentsDataGridView.Size = new System.Drawing.Size(845, 347);
            this.instrumentsDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(232, 47);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(155, 48);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(620, 47);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 48);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete product";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.instrumentsDataGridView);
            this.panel1.Location = new System.Drawing.Point(260, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 538);
            this.panel1.TabIndex = 1;
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(59, 185);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(127, 274);
            this.ordersButton.TabIndex = 4;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 589);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployee";
            this.Text = "Music Store (employee)";
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.DataGridView instrumentsDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ordersButton;
    }
}