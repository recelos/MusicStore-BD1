
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
            this.instrumentsDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.instrumentsDataGridView);
            this.panel1.Location = new System.Drawing.Point(282, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 538);
            this.panel1.TabIndex = 1;
            // 
            // instrumentsDataGridView
            // 
            this.instrumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentsDataGridView.Location = new System.Drawing.Point(3, 67);
            this.instrumentsDataGridView.Name = "instrumentsDataGridView";
            this.instrumentsDataGridView.RowTemplate.Height = 25;
            this.instrumentsDataGridView.Size = new System.Drawing.Size(966, 463);
            this.instrumentsDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(214, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(138, 32);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update product";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete product";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 589);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView instrumentsDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
    }
}