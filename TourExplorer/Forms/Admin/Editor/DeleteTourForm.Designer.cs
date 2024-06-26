﻿
namespace TourExplorer {
    partial class DeleteTourForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTourForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteTour = new System.Windows.Forms.Button();
            this.comboBoxTourName = new System.Windows.Forms.ComboBox();
            this.labelEmptyComboBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(194, 99);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 29);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Anuluj\r\n";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa wycieczki:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDeleteTour
            // 
            this.buttonDeleteTour.Location = new System.Drawing.Point(97, 99);
            this.buttonDeleteTour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteTour.Name = "buttonDeleteTour";
            this.buttonDeleteTour.Size = new System.Drawing.Size(79, 29);
            this.buttonDeleteTour.TabIndex = 14;
            this.buttonDeleteTour.Text = "Usuń";
            this.buttonDeleteTour.UseVisualStyleBackColor = true;
            this.buttonDeleteTour.Click += new System.EventHandler(this.buttonDeleteTour_Click);
            // 
            // comboBoxTourName
            // 
            this.comboBoxTourName.FormattingEnabled = true;
            this.comboBoxTourName.Location = new System.Drawing.Point(149, 30);
            this.comboBoxTourName.Name = "comboBoxTourName";
            this.comboBoxTourName.Size = new System.Drawing.Size(124, 21);
            this.comboBoxTourName.TabIndex = 19;
            this.comboBoxTourName.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxTourName_Format);
            // 
            // labelEmptyComboBox
            // 
            this.labelEmptyComboBox.ForeColor = System.Drawing.Color.Red;
            this.labelEmptyComboBox.Location = new System.Drawing.Point(0, 63);
            this.labelEmptyComboBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmptyComboBox.Name = "labelEmptyComboBox";
            this.labelEmptyComboBox.Size = new System.Drawing.Size(378, 24);
            this.labelEmptyComboBox.TabIndex = 21;
            this.labelEmptyComboBox.Text = "Wybierz wycieczkę z listy";
            this.labelEmptyComboBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEmptyComboBox.Visible = false;
            // 
            // DeleteTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(378, 139);
            this.Controls.Add(this.labelEmptyComboBox);
            this.Controls.Add(this.comboBoxTourName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DeleteTourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuwanie wycieczki";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteTour;
        private System.Windows.Forms.ComboBox comboBoxTourName;
        private System.Windows.Forms.Label labelEmptyComboBox;
    }
}