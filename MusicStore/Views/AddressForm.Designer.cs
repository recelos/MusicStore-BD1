
namespace MusicStore.Views
{
    partial class AddressForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelVoivodeship = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelPostal = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxVoivodeship = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(121, 372);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(133, 26);
            this.confirmButton.TabIndex = 19;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(399, 372);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 26);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(168, 48);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(50, 15);
            this.labelCountry.TabIndex = 21;
            this.labelCountry.Text = "Country";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(326, 45);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(167, 23);
            this.comboBoxCountry.TabIndex = 22;
            // 
            // labelVoivodeship
            // 
            this.labelVoivodeship.AutoSize = true;
            this.labelVoivodeship.Location = new System.Drawing.Point(165, 307);
            this.labelVoivodeship.Name = "labelVoivodeship";
            this.labelVoivodeship.Size = new System.Drawing.Size(71, 15);
            this.labelVoivodeship.TabIndex = 23;
            this.labelVoivodeship.Text = "Voivodeship";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(181, 173);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(37, 15);
            this.labelStreet.TabIndex = 24;
            this.labelStreet.Text = "Street";
            // 
            // labelPostal
            // 
            this.labelPostal.AutoSize = true;
            this.labelPostal.Location = new System.Drawing.Point(165, 241);
            this.labelPostal.Name = "labelPostal";
            this.labelPostal.Size = new System.Drawing.Size(70, 15);
            this.labelPostal.TabIndex = 25;
            this.labelPostal.Text = "Postal Code";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(181, 112);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(28, 15);
            this.labelCity.TabIndex = 26;
            this.labelCity.Text = "City";
            // 
            // textBoxVoivodeship
            // 
            this.textBoxVoivodeship.Location = new System.Drawing.Point(326, 307);
            this.textBoxVoivodeship.Name = "textBoxVoivodeship";
            this.textBoxVoivodeship.Size = new System.Drawing.Size(167, 23);
            this.textBoxVoivodeship.TabIndex = 27;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(326, 170);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(167, 23);
            this.textBoxStreet.TabIndex = 28;
            // 
            // textBoxPostal
            // 
            this.textBoxPostal.Location = new System.Drawing.Point(326, 238);
            this.textBoxPostal.Name = "textBoxPostal";
            this.textBoxPostal.Size = new System.Drawing.Size(167, 23);
            this.textBoxPostal.TabIndex = 29;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(326, 104);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(167, 23);
            this.textBoxCity.TabIndex = 30;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPostal);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxVoivodeship);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPostal);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelVoivodeship);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelVoivodeship;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelPostal;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxVoivodeship;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.TextBox textBoxCity;
    }
}