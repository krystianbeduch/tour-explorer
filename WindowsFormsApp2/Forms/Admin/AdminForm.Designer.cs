
namespace TourExplorer {
    partial class AdminForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.toolStripSessionInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDataBaseCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabelDataBase = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSessionInfo = new System.Windows.Forms.ToolStripLabel();
            this.buttonEditTourCatalog = new System.Windows.Forms.Button();
            this.buttonLogoutAdmin = new System.Windows.Forms.Button();
            this.buttonEditClientsTours = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.toolStripSessionInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSessionInfo
            // 
            this.toolStripSessionInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripSessionInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDataBaseCheck,
            this.toolStripStatusLabelDataBase,
            this.toolStripLabelSessionInfo});
            this.toolStripSessionInfo.Location = new System.Drawing.Point(0, 357);
            this.toolStripSessionInfo.Name = "toolStripSessionInfo";
            this.toolStripSessionInfo.Size = new System.Drawing.Size(800, 25);
            this.toolStripSessionInfo.TabIndex = 3;
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
            // buttonEditTourCatalog
            // 
            this.buttonEditTourCatalog.AutoSize = true;
            this.buttonEditTourCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditTourCatalog.Location = new System.Drawing.Point(158, 84);
            this.buttonEditTourCatalog.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.buttonEditTourCatalog.Name = "buttonEditTourCatalog";
            this.buttonEditTourCatalog.Size = new System.Drawing.Size(498, 41);
            this.buttonEditTourCatalog.TabIndex = 8;
            this.buttonEditTourCatalog.Text = "Edytuj katalog wycieczek";
            this.buttonEditTourCatalog.UseVisualStyleBackColor = true;
            this.buttonEditTourCatalog.Click += new System.EventHandler(this.buttonEditTourCatalog_Click);
            // 
            // buttonLogoutAdmin
            // 
            this.buttonLogoutAdmin.AutoSize = true;
            this.buttonLogoutAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogoutAdmin.Location = new System.Drawing.Point(158, 148);
            this.buttonLogoutAdmin.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.buttonLogoutAdmin.Name = "buttonLogoutAdmin";
            this.buttonLogoutAdmin.Size = new System.Drawing.Size(498, 41);
            this.buttonLogoutAdmin.TabIndex = 11;
            this.buttonLogoutAdmin.Text = "Wyloguj z panelu administracyjnego";
            this.buttonLogoutAdmin.UseVisualStyleBackColor = true;
            this.buttonLogoutAdmin.Click += new System.EventHandler(this.buttonLogoutAdmin_Click);
            // 
            // buttonEditClientsTours
            // 
            this.buttonEditClientsTours.AutoSize = true;
            this.buttonEditClientsTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditClientsTours.Location = new System.Drawing.Point(158, 20);
            this.buttonEditClientsTours.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.buttonEditClientsTours.Name = "buttonEditClientsTours";
            this.buttonEditClientsTours.Size = new System.Drawing.Size(498, 41);
            this.buttonEditClientsTours.TabIndex = 12;
            this.buttonEditClientsTours.Text = "Edytuj wycieczki klientów";
            this.buttonEditClientsTours.UseVisualStyleBackColor = true;
            this.buttonEditClientsTours.Click += new System.EventHandler(this.buttonEditClientsTours_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonEditClientsTours);
            this.flowLayoutPanel1.Controls.Add(this.buttonEditTourCatalog);
            this.flowLayoutPanel1.Controls.Add(this.buttonLogoutAdmin);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(155, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 210);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::TourExplorer.Properties.Resources.chmury;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 113);
            this.panelHeader.TabIndex = 4;
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Flubber", 42.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(800, 113);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "PANEL ADMINISTRACYJNY";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.UseMnemonic = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.toolStripSessionInfo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel administracyjny";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.toolStripSessionInfo.ResumeLayout(false);
            this.toolStripSessionInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripSessionInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonDataBaseCheck;
        private System.Windows.Forms.ToolStripLabel toolStripStatusLabelDataBase;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSessionInfo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonEditTourCatalog;
        private System.Windows.Forms.Button buttonLogoutAdmin;
        private System.Windows.Forms.Button buttonEditClientsTours;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}