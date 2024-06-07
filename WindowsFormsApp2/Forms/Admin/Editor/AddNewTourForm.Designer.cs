
namespace TourExplorer {
    partial class AddNewTourForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTourForm));
            this.labelEmptyTextBox = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTourName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddTour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmptyTextBox
            // 
            this.labelEmptyTextBox.ForeColor = System.Drawing.Color.Red;
            this.labelEmptyTextBox.Location = new System.Drawing.Point(-1, 99);
            this.labelEmptyTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmptyTextBox.Name = "labelEmptyTextBox";
            this.labelEmptyTextBox.Size = new System.Drawing.Size(378, 24);
            this.labelEmptyTextBox.TabIndex = 13;
            this.labelEmptyTextBox.Text = "Wpisz nazwę i cenę wycieczki";
            this.labelEmptyTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEmptyTextBox.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(193, 140);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 29);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Anuluj\r\n";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(148, 77);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(124, 20);
            this.textBoxPrice.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cena:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTourName
            // 
            this.textBoxTourName.Location = new System.Drawing.Point(148, 46);
            this.textBoxTourName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTourName.Name = "textBoxTourName";
            this.textBoxTourName.Size = new System.Drawing.Size(124, 20);
            this.textBoxTourName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwa wycieczki:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAddTour
            // 
            this.buttonAddTour.Location = new System.Drawing.Point(96, 140);
            this.buttonAddTour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTour.Name = "buttonAddTour";
            this.buttonAddTour.Size = new System.Drawing.Size(79, 29);
            this.buttonAddTour.TabIndex = 7;
            this.buttonAddTour.Text = "Dodaj";
            this.buttonAddTour.UseVisualStyleBackColor = true;
            this.buttonAddTour.Click += new System.EventHandler(this.buttonAddTour_Click);
            // 
            // AddNewTourForm
            // 
            this.AcceptButton = this.buttonAddTour;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(378, 176);
            this.Controls.Add(this.labelEmptyTextBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTourName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewTourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowej wycieczki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmptyTextBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTourName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTour;
    }
}