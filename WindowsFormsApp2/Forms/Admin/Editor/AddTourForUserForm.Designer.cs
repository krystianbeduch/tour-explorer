
namespace TourExplorer {
    partial class AddTourForUserForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTourForUserForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelTourName = new System.Windows.Forms.Label();
            this.buttonAddForTour = new System.Windows.Forms.Button();
            this.comboBoxTourName = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelEmptyComboBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(193, 134);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 29);
            this.buttonCancel.TabIndex = 19;
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
            this.labelClient.TabIndex = 17;
            this.labelClient.Text = "Klient:";
            this.labelClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTourName
            // 
            this.labelTourName.Location = new System.Drawing.Point(4, 76);
            this.labelTourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTourName.Name = "labelTourName";
            this.labelTourName.Size = new System.Drawing.Size(142, 13);
            this.labelTourName.TabIndex = 15;
            this.labelTourName.Text = "Nazwa wycieczki:";
            this.labelTourName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAddForTour
            // 
            this.buttonAddForTour.Location = new System.Drawing.Point(96, 134);
            this.buttonAddForTour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddForTour.Name = "buttonAddForTour";
            this.buttonAddForTour.Size = new System.Drawing.Size(79, 29);
            this.buttonAddForTour.TabIndex = 14;
            this.buttonAddForTour.Text = "Dodaj";
            this.buttonAddForTour.UseVisualStyleBackColor = true;
            this.buttonAddForTour.Click += new System.EventHandler(this.buttonAddTourForUser_Click);
            // 
            // comboBoxTourName
            // 
            this.comboBoxTourName.FormattingEnabled = true;
            this.comboBoxTourName.Location = new System.Drawing.Point(148, 73);
            this.comboBoxTourName.Name = "comboBoxTourName";
            this.comboBoxTourName.Size = new System.Drawing.Size(124, 21);
            this.comboBoxTourName.TabIndex = 21;
            this.comboBoxTourName.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxTourName_Format);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(148, 42);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(124, 21);
            this.comboBoxClient.TabIndex = 22;
            this.comboBoxClient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxClient_Format);
            // 
            // labelEmptyComboBox
            // 
            this.labelEmptyComboBox.ForeColor = System.Drawing.Color.Red;
            this.labelEmptyComboBox.Location = new System.Drawing.Point(2, 97);
            this.labelEmptyComboBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmptyComboBox.Name = "labelEmptyComboBox";
            this.labelEmptyComboBox.Size = new System.Drawing.Size(378, 24);
            this.labelEmptyComboBox.TabIndex = 20;
            this.labelEmptyComboBox.Text = "Wybierz wycieczkę i klienta z listy";
            this.labelEmptyComboBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEmptyComboBox.Visible = false;
            // 
            // AddTourForUserForm
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
            this.Controls.Add(this.buttonAddForTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddTourForUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie wycieczki dla klienta";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelTourName;
        private System.Windows.Forms.Button buttonAddForTour;
        private System.Windows.Forms.ComboBox comboBoxTourName;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelEmptyComboBox;
    }
}