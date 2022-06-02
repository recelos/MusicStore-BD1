
namespace MusicStore.Views
{
    partial class FormOrderItems
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
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.RowTemplate.Height = 25;
            this.itemsDataGridView.Size = new System.Drawing.Size(776, 426);
            this.itemsDataGridView.TabIndex = 0;
            // 
            // FormOrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemsDataGridView);
            this.Name = "FormOrderItems";
            this.Text = "FormOrderItems";
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsDataGridView;
    }
}