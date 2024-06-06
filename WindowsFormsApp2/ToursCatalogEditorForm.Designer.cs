
namespace TourExplorer {
    partial class ToursCatalogEditorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToursCatalogEditorForm));
            this.toolStripStatusLabelDataBase = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSessionInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSessionInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDataBaseCheck = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEditTours = new System.Windows.Forms.Button();
            this.buttonAddTourToCatalog = new System.Windows.Forms.Button();
            this.buttonDeleteTourFromCatalog = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.toolStripSessionInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
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
            // toolStripSessionInfo
            // 
            this.toolStripSessionInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripSessionInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDataBaseCheck,
            this.toolStripStatusLabelDataBase,
            this.toolStripLabelSessionInfo});
            this.toolStripSessionInfo.Location = new System.Drawing.Point(0, 386);
            this.toolStripSessionInfo.Name = "toolStripSessionInfo";
            this.toolStripSessionInfo.Size = new System.Drawing.Size(800, 25);
            this.toolStripSessionInfo.TabIndex = 6;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonEditTours);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddTourToCatalog);
            this.flowLayoutPanel1.Controls.Add(this.buttonDeleteTourFromCatalog);
            this.flowLayoutPanel1.Controls.Add(this.buttonExit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(155, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 247);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // buttonEditTours
            // 
            this.buttonEditTours.AutoSize = true;
            this.buttonEditTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditTours.Location = new System.Drawing.Point(155, 20);
            this.buttonEditTours.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.buttonEditTours.Name = "buttonEditTours";
            this.buttonEditTours.Size = new System.Drawing.Size(498, 41);
            this.buttonEditTours.TabIndex = 12;
            this.buttonEditTours.Text = "Edytuj wycieczkę z katalogu";
            this.buttonEditTours.UseVisualStyleBackColor = true;
            this.buttonEditTours.Click += new System.EventHandler(this.buttonEditTours_Click);
            // 
            // buttonAddTourToCatalog
            // 
            this.buttonAddTourToCatalog.AutoSize = true;
            this.buttonAddTourToCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddTourToCatalog.Location = new System.Drawing.Point(155, 81);
            this.buttonAddTourToCatalog.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.buttonAddTourToCatalog.Name = "buttonAddTourToCatalog";
            this.buttonAddTourToCatalog.Size = new System.Drawing.Size(498, 41);
            this.buttonAddTourToCatalog.TabIndex = 8;
            this.buttonAddTourToCatalog.Text = "Dodaj wycieczkę do katalogu";
            this.buttonAddTourToCatalog.UseVisualStyleBackColor = true;
            this.buttonAddTourToCatalog.Click += new System.EventHandler(this.buttonAddTourToCatalog_Click);
            // 
            // buttonDeleteTourFromCatalog
            // 
            this.buttonDeleteTourFromCatalog.AutoSize = true;
            this.buttonDeleteTourFromCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteTourFromCatalog.Location = new System.Drawing.Point(155, 142);
            this.buttonDeleteTourFromCatalog.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.buttonDeleteTourFromCatalog.Name = "buttonDeleteTourFromCatalog";
            this.buttonDeleteTourFromCatalog.Size = new System.Drawing.Size(498, 41);
            this.buttonDeleteTourFromCatalog.TabIndex = 13;
            this.buttonDeleteTourFromCatalog.Text = "Usuń wycieczkę z katalogu";
            this.buttonDeleteTourFromCatalog.UseVisualStyleBackColor = true;
            this.buttonDeleteTourFromCatalog.Click += new System.EventHandler(this.buttonDeleteTourFromCatalog_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(155, 203);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(498, 41);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Wyjdź z edytora katalogu";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::TourExplorer.Properties.Resources.chmury;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 113);
            this.panelHeader.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Flubber", 57.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(800, 113);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "EDYTOR KATALOGU";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.UseMnemonic = false;
            // 
            // ToursCatalogEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStripSessionInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToursCatalogEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytor katalogu";
            this.toolStripSessionInfo.ResumeLayout(false);
            this.toolStripSessionInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ToolStripButton toolStripButtonDataBaseCheck;
        private System.Windows.Forms.ToolStripLabel toolStripStatusLabelDataBase;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSessionInfo;
        private System.Windows.Forms.ToolStrip toolStripSessionInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonEditTours;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddTourToCatalog;
        private System.Windows.Forms.Button buttonDeleteTourFromCatalog;
    }
}