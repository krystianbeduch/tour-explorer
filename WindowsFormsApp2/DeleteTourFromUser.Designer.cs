
namespace TourExplorer {
    partial class DeleteTourFromUser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTourFromUser));
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxTourName = new System.Windows.Forms.ComboBox();
            this.labelEmptyComboBox = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelTourName = new System.Windows.Forms.Label();
            this.buttonDeleteUserTour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(148, 42);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(124, 21);
            this.comboBoxClient.TabIndex = 29;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
            this.comboBoxClient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxClient_Format);
            // 
            // comboBoxTourName
            // 
            this.comboBoxTourName.FormattingEnabled = true;
            this.comboBoxTourName.Location = new System.Drawing.Point(148, 73);
            this.comboBoxTourName.Name = "comboBoxTourName";
            this.comboBoxTourName.Size = new System.Drawing.Size(124, 21);
            this.comboBoxTourName.TabIndex = 28;
            this.comboBoxTourName.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxTourName_Format);
            // 
            // labelEmptyComboBox
            // 
            this.labelEmptyComboBox.ForeColor = System.Drawing.Color.Red;
            this.labelEmptyComboBox.Location = new System.Drawing.Point(2, 97);
            this.labelEmptyComboBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmptyComboBox.Name = "labelEmptyComboBox";
            this.labelEmptyComboBox.Size = new System.Drawing.Size(378, 24);
            this.labelEmptyComboBox.TabIndex = 27;
            this.labelEmptyComboBox.Text = "Wybierz wycieczkę i klienta z listy";
            this.labelEmptyComboBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEmptyComboBox.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(193, 134);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 29);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Anuluj\r\n";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelClient
            // 
            this.labelClient.Location = new System.Drawing.Point(4, 45);
            this.labelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(139, 13);
            this.labelClient.TabIndex = 25;
            this.labelClient.Text = "Klient:";
            this.labelClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTourName
            // 
            this.labelTourName.Location = new System.Drawing.Point(4, 76);
            this.labelTourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTourName.Name = "labelTourName";
            this.labelTourName.Size = new System.Drawing.Size(142, 13);
            this.labelTourName.TabIndex = 24;
            this.labelTourName.Text = "Nazwa wycieczki:";
            this.labelTourName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDeleteUserTour
            // 
            this.buttonDeleteUserTour.Location = new System.Drawing.Point(96, 134);
            this.buttonDeleteUserTour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteUserTour.Name = "buttonDeleteUserTour";
            this.buttonDeleteUserTour.Size = new System.Drawing.Size(79, 29);
            this.buttonDeleteUserTour.TabIndex = 23;
            this.buttonDeleteUserTour.Text = "Usuń";
            this.buttonDeleteUserTour.UseVisualStyleBackColor = true;
            this.buttonDeleteUserTour.Click += new System.EventHandler(this.buttonDeleteUserTour_Click);
            // 
            // DeleteTourFromUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(376, 176);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxTourName);
            this.Controls.Add(this.labelEmptyComboBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelTourName);
            this.Controls.Add(this.buttonDeleteUserTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteTourFromUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuń wycieczkę klienta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxTourName;
        private System.Windows.Forms.Label labelEmptyComboBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelTourName;
        private System.Windows.Forms.Button buttonDeleteUserTour;
    }
}