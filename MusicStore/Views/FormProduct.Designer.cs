
namespace MusicStore.Views
{
    partial class FormProduct
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(80, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(180, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(259, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(180, 94);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(259, 23);
            this.priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(80, 97);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 15);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(80, 155);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(38, 15);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.Text = "Brand";
            // 
            // brandComboBox
            // 
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(180, 152);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(259, 23);
            this.brandComboBox.TabIndex = 5;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(180, 213);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(259, 23);
            this.typeComboBox.TabIndex = 7;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(80, 216);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 15);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type";
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Location = new System.Drawing.Point(180, 275);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(259, 23);
            this.conditionComboBox.TabIndex = 9;
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(80, 278);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(60, 15);
            this.conditionLabel.TabIndex = 8;
            this.conditionLabel.Text = "Condition";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(180, 339);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(259, 23);
            this.countryComboBox.TabIndex = 11;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(80, 342);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(50, 15);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Country";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(80, 420);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(133, 26);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 420);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 26);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 482);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.conditionComboBox);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}