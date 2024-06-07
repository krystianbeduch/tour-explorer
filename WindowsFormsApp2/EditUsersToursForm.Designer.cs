
namespace TourExplorer {
    partial class EditUsersToursForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUsersToursForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.toolStripSessionInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDataBaseCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabelDataBase = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSessionInfo = new System.Windows.Forms.ToolStripLabel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.toolStripSessionInfo.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::TourExplorer.Properties.Resources.chmury;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 113);
            this.panelHeader.TabIndex = 6;
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Flubber", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelHeader.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(800, 113);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "EDYTOR WYCIECZEK KLIENTA";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.UseMnemonic = false;
            // 
            // toolStripSessionInfo
            // 
            this.toolStripSessionInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripSessionInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDataBaseCheck,
            this.toolStripStatusLabelDataBase,
            this.toolStripLabelSessionInfo});
            this.toolStripSessionInfo.Location = new System.Drawing.Point(0, 425);
            this.toolStripSessionInfo.Name = "toolStripSessionInfo";
            this.toolStripSessionInfo.Size = new System.Drawing.Size(800, 25);
            this.toolStripSessionInfo.TabIndex = 11;
            this.toolStripSessionInfo.Text = "toolStrip1";
            // 
            // toolStripButtonDataBaseCheck
            // 
            this.toolStripButtonDataBaseCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDataBaseCheck.ForeColor = System.Drawing.Color.Green;
            this.toolStripButtonDataBaseCheck.Image = global::TourExplorer.Properties.Resources.databaseIcon;
            this.toolStripButtonDataBaseCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDataBaseCheck.Name = "toolStripButtonDataBaseCheck";
            this.toolStripButtonDataBaseCheck.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDataBaseCheck.Text = "Sprawdź połączenie z bazą danych Oracle";
            this.toolStripButtonDataBaseCheck.Click += new System.EventHandler(this.toolStripButtonDataBaseCheck_Click);
            // 
            // toolStripStatusLabelDataBase
            // 
            this.toolStripStatusLabelDataBase.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabelDataBase.Name = "toolStripStatusLabelDataBase";
            this.toolStripStatusLabelDataBase.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabelSessionInfo
            // 
            this.toolStripLabelSessionInfo.Name = "toolStripLabelSessionInfo";
            this.toolStripLabelSessionInfo.Size = new System.Drawing.Size(0, 22);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(153, 381);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(525, 41);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Wyjdź z edytora";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridViewTours);
            this.panelTable.Controls.Add(this.buttonSaveChanges);
            this.panelTable.Location = new System.Drawing.Point(153, 151);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(525, 189);
            this.panelTable.TabIndex = 12;
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.AllowUserToAddRows = false;
            this.dataGridViewTours.AllowUserToDeleteRows = false;
            this.dataGridViewTours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTours.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.Size = new System.Drawing.Size(525, 150);
            this.dataGridViewTours.TabIndex = 7;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.AutoSize = true;
            this.buttonSaveChanges.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(0, 148);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(525, 41);
            this.buttonSaveChanges.TabIndex = 9;
            this.buttonSaveChanges.Text = "Zapisz zmiany";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // EditUsersToursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.toolStripSessionInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditUsersToursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytor wycieczek klientów";
            this.panelHeader.ResumeLayout(false);
            this.toolStripSessionInfo.ResumeLayout(false);
            this.toolStripSessionInfo.PerformLayout();
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ToolStrip toolStripSessionInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonDataBaseCheck;
        private System.Windows.Forms.ToolStripLabel toolStripStatusLabelDataBase;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSessionInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}