
namespace MusicStore.Views
{
    partial class FormUser
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.conditionsLabel = new System.Windows.Forms.Label();
            this.conditionsComboBox = new System.Windows.Forms.ComboBox();
            this.typesLabel = new System.Windows.Forms.Label();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.brandsLabel = new System.Windows.Forms.Label();
            this.brandsComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.instrumentsDataGridView = new System.Windows.Forms.DataGridView();
            this.userCredentialsLabel = new System.Windows.Forms.Label();
            this.addToBucketButton = new System.Windows.Forms.Button();
            this.showBucketButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.conditionsLabel);
            this.panel1.Controls.Add(this.conditionsComboBox);
            this.panel1.Controls.Add(this.typesLabel);
            this.panel1.Controls.Add(this.typesComboBox);
            this.panel1.Controls.Add(this.brandsLabel);
            this.panel1.Controls.Add(this.brandsComboBox);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.instrumentsDataGridView);
            this.panel1.Location = new System.Drawing.Point(237, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 717);
            this.panel1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(844, 44);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(152, 35);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // conditionsLabel
            // 
            this.conditionsLabel.AutoSize = true;
            this.conditionsLabel.Location = new System.Drawing.Point(659, 27);
            this.conditionsLabel.Name = "conditionsLabel";
            this.conditionsLabel.Size = new System.Drawing.Size(80, 20);
            this.conditionsLabel.TabIndex = 8;
            this.conditionsLabel.Text = "Conditions";
            // 
            // conditionsComboBox
            // 
            this.conditionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionsComboBox.FormattingEnabled = true;
            this.conditionsComboBox.Location = new System.Drawing.Point(629, 51);
            this.conditionsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.conditionsComboBox.Name = "conditionsComboBox";
            this.conditionsComboBox.Size = new System.Drawing.Size(138, 28);
            this.conditionsComboBox.TabIndex = 7;
            this.conditionsComboBox.SelectedIndexChanged += new System.EventHandler(this.conditionsComboBox_SelectedIndexChanged);
            // 
            // typesLabel
            // 
            this.typesLabel.AutoSize = true;
            this.typesLabel.Location = new System.Drawing.Point(463, 23);
            this.typesLabel.Name = "typesLabel";
            this.typesLabel.Size = new System.Drawing.Size(46, 20);
            this.typesLabel.TabIndex = 6;
            this.typesLabel.Text = "Types";
            // 
            // typesComboBox
            // 
            this.typesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Location = new System.Drawing.Point(422, 47);
            this.typesComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(138, 28);
            this.typesComboBox.TabIndex = 5;
            this.typesComboBox.SelectedIndexChanged += new System.EventHandler(this.typesComboBox_SelectedIndexChanged);
            // 
            // brandsLabel
            // 
            this.brandsLabel.AutoSize = true;
            this.brandsLabel.Location = new System.Drawing.Point(265, 23);
            this.brandsLabel.Name = "brandsLabel";
            this.brandsLabel.Size = new System.Drawing.Size(54, 20);
            this.brandsLabel.TabIndex = 4;
            this.brandsLabel.Text = "Brands";
            // 
            // brandsComboBox
            // 
            this.brandsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandsComboBox.FormattingEnabled = true;
            this.brandsComboBox.Location = new System.Drawing.Point(224, 47);
            this.brandsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brandsComboBox.Name = "brandsComboBox";
            this.brandsComboBox.Size = new System.Drawing.Size(138, 28);
            this.brandsComboBox.TabIndex = 3;
            this.brandsComboBox.SelectedIndexChanged += new System.EventHandler(this.brandsComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(78, 23);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(53, 20);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(34, 47);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(138, 27);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // instrumentsDataGridView
            // 
            this.instrumentsDataGridView.AllowUserToAddRows = false;
            this.instrumentsDataGridView.AllowUserToDeleteRows = false;
            this.instrumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentsDataGridView.Location = new System.Drawing.Point(3, 89);
            this.instrumentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.instrumentsDataGridView.Name = "instrumentsDataGridView";
            this.instrumentsDataGridView.ReadOnly = true;
            this.instrumentsDataGridView.RowHeadersWidth = 51;
            this.instrumentsDataGridView.RowTemplate.Height = 25;
            this.instrumentsDataGridView.Size = new System.Drawing.Size(1104, 617);
            this.instrumentsDataGridView.TabIndex = 0;
            // 
            // userCredentialsLabel
            // 
            this.userCredentialsLabel.AutoSize = true;
            this.userCredentialsLabel.Location = new System.Drawing.Point(9, 20);
            this.userCredentialsLabel.Name = "userCredentialsLabel";
            this.userCredentialsLabel.Size = new System.Drawing.Size(0, 20);
            this.userCredentialsLabel.TabIndex = 1;
            // 
            // addToBucketButton
            // 
            this.addToBucketButton.Location = new System.Drawing.Point(34, 144);
            this.addToBucketButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addToBucketButton.Name = "addToBucketButton";
            this.addToBucketButton.Size = new System.Drawing.Size(152, 35);
            this.addToBucketButton.TabIndex = 15;
            this.addToBucketButton.Text = "Add to bucket";
            this.addToBucketButton.UseVisualStyleBackColor = true;
            this.addToBucketButton.Click += new System.EventHandler(this.addToBucketButton_Click);
            // 
            // showBucketButton
            // 
            this.showBucketButton.Location = new System.Drawing.Point(34, 235);
            this.showBucketButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showBucketButton.Name = "showBucketButton";
            this.showBucketButton.Size = new System.Drawing.Size(152, 35);
            this.showBucketButton.TabIndex = 16;
            this.showBucketButton.Text = "Show bucket";
            this.showBucketButton.UseVisualStyleBackColor = true;
            this.showBucketButton.Click += new System.EventHandler(this.showBucketButton_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 749);
            this.Controls.Add(this.showBucketButton);
            this.Controls.Add(this.addToBucketButton);
            this.Controls.Add(this.userCredentialsLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUser";
            this.Text = "Music Store (user)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView instrumentsDataGridView;
        private System.Windows.Forms.Label userCredentialsLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox brandsComboBox;
        private System.Windows.Forms.Label conditionsLabel;
        private System.Windows.Forms.ComboBox conditionsComboBox;
        private System.Windows.Forms.Label typesLabel;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.Label brandsLabel;
        private System.Windows.Forms.Button addToBucketButton;
        private System.Windows.Forms.Button showBucketButton;
        private System.Windows.Forms.Button buttonRefresh;
    }
}