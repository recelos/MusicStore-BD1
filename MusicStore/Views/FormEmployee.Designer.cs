
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.instrumentsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.instrumentsDataGridView);
            this.panel1.Location = new System.Drawing.Point(322, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 717);
            this.panel1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(650, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(138, 32);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete product";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(433, 19);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(138, 32);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update product";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update product";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(315, 25);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 43);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // instrumentsDataGridView
            // 
            this.instrumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentsDataGridView.Location = new System.Drawing.Point(3, 67);
            this.instrumentsDataGridView.Name = "instrumentsDataGridView";
            this.instrumentsDataGridView.RowTemplate.Height = 25;
            this.instrumentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instrumentsDataGridView.Size = new System.Drawing.Size(966, 463);
            this.instrumentsDataGridView.TabIndex = 0;
            this.instrumentsDataGridView.SelectionChanged += new System.EventHandler(this.instrumentsDataGridView_SelectionChanged);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 785);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView instrumentsDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button buttonOrder;
    }
}