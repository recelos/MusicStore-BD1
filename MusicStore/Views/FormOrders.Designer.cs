
namespace MusicStore.Views
{
    partial class FormOrders
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(687, 356);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 26);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(414, 356);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(133, 26);
            this.finalizeButton.TabIndex = 14;
            this.finalizeButton.Text = "Finalize";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ordersDataGridView.Location = new System.Drawing.Point(18, 10);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ordersDataGridView.RowTemplate.Height = 25;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(1183, 323);
            this.ordersDataGridView.TabIndex = 16;
            this.ordersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellDoubleClick);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 406);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.finalizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOrders";
            this.Text = "All orders";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
    }
}