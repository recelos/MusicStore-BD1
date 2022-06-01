
namespace MusicStore.Views
{
    partial class FormBucket
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
            this.bucketDataGridView = new System.Windows.Forms.DataGridView();
            this.orderButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bucketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bucketDataGridView
            // 
            this.bucketDataGridView.AllowUserToAddRows = false;
            this.bucketDataGridView.AllowUserToDeleteRows = false;
            this.bucketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bucketDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bucketDataGridView.Location = new System.Drawing.Point(14, 59);
            this.bucketDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bucketDataGridView.Name = "bucketDataGridView";
            this.bucketDataGridView.ReadOnly = true;
            this.bucketDataGridView.RowHeadersWidth = 51;
            this.bucketDataGridView.RowTemplate.Height = 25;
            this.bucketDataGridView.Size = new System.Drawing.Size(879, 368);
            this.bucketDataGridView.TabIndex = 17;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(74, 484);
            this.orderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(152, 35);
            this.orderButton.TabIndex = 18;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(374, 484);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(166, 35);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "Remove from bucket";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(659, 484);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(152, 35);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormBucket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.bucketDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBucket";
            this.Text = "FormBucket";
            ((System.ComponentModel.ISupportInitialize)(this.bucketDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bucketDataGridView;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}