
namespace TourExplorer {
    partial class AddTourForUser {
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddTour = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Klient:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa wycieczki:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAddTour
            // 
            this.buttonAddTour.Location = new System.Drawing.Point(96, 134);
            this.buttonAddTour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTour.Name = "buttonAddTour";
            this.buttonAddTour.Size = new System.Drawing.Size(79, 29);
            this.buttonAddTour.TabIndex = 14;
            this.buttonAddTour.Text = "Dodaj";
            this.buttonAddTour.UseVisualStyleBackColor = true;
            this.buttonAddTour.Click += new System.EventHandler(this.buttonAddTour_Click);
            // 
            // comboBoxTourName
            // 
            this.comboBoxTourName.FormattingEnabled = true;
            this.comboBoxTourName.Location = new System.Drawing.Point(148, 42);
            this.comboBoxTourName.Name = "comboBoxTourName";
            this.comboBoxTourName.Size = new System.Drawing.Size(124, 21);
            this.comboBoxTourName.TabIndex = 21;
            this.comboBoxTourName.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxTourName_Format);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(148, 73);
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
            // AddTourForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(376, 176);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxTourName);
            this.Controls.Add(this.labelEmptyComboBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddTourForUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTourForUser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTour;
        private System.Windows.Forms.ComboBox comboBoxTourName;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelEmptyComboBox;
    }
}