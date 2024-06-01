
namespace TourExplorer {
    partial class MainForm {
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
            this.toolStripSessionInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripStatusLabelDataBase = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSessionInfo = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBrowseTourCatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNoTripsFound = new System.Windows.Forms.Panel();
            this.toolStripButtonDataBaseCheck = new System.Windows.Forms.ToolStripButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.toolStripSessionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelNoTripsFound.SuspendLayout();
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
            this.toolStripSessionInfo.Location = new System.Drawing.Point(0, 736);
            this.toolStripSessionInfo.Name = "toolStripSessionInfo";
            this.toolStripSessionInfo.Size = new System.Drawing.Size(1064, 25);
            this.toolStripSessionInfo.TabIndex = 2;
            this.toolStripSessionInfo.Text = "toolStrip1";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 669);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 64);
            this.dataGridView1.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 119);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1040, 40);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // buttonBrowseTourCatalog
            // 
            this.buttonBrowseTourCatalog.AutoSize = true;
            this.buttonBrowseTourCatalog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBrowseTourCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowseTourCatalog.Location = new System.Drawing.Point(0, 54);
            this.buttonBrowseTourCatalog.Name = "buttonBrowseTourCatalog";
            this.buttonBrowseTourCatalog.Size = new System.Drawing.Size(498, 66);
            this.buttonBrowseTourCatalog.TabIndex = 5;
            this.buttonBrowseTourCatalog.Text = "Przeglądaj katalog wycieczek";
            this.buttonBrowseTourCatalog.UseVisualStyleBackColor = true;
            this.buttonBrowseTourCatalog.Click += new System.EventHandler(this.buttonBrowseTourCatalog_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nie jesteś zapisany na żadną wycieczkę";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNoTripsFound
            // 
            this.panelNoTripsFound.AutoSize = true;
            this.panelNoTripsFound.Controls.Add(this.label1);
            this.panelNoTripsFound.Controls.Add(this.buttonBrowseTourCatalog);
            this.panelNoTripsFound.Location = new System.Drawing.Point(289, 179);
            this.panelNoTripsFound.Name = "panelNoTripsFound";
            this.panelNoTripsFound.Size = new System.Drawing.Size(498, 120);
            this.panelNoTripsFound.TabIndex = 6;
            this.panelNoTripsFound.Visible = false;
            // 
            // toolStripButtonDataBaseCheck
            // 
            this.toolStripButtonDataBaseCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDataBaseCheck.ForeColor = System.Drawing.Color.Green;
            this.toolStripButtonDataBaseCheck.Image = global::TourExplorer.Properties.Resources.databaseIcon1;
            this.toolStripButtonDataBaseCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDataBaseCheck.Name = "toolStripButtonDataBaseCheck";
            this.toolStripButtonDataBaseCheck.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDataBaseCheck.Text = "Sprawdź połączenie z bazą danych Oracle";
            this.toolStripButtonDataBaseCheck.Click += new System.EventHandler(this.toolStripButtonDataBaseCheck_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::TourExplorer.Properties.Resources.chmury;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1064, 113);
            this.panelHeader.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Flubber", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1064, 113);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "WITAMY PONOWNIE";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.UseMnemonic = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.panelNoTripsFound);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripSessionInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripSessionInfo.ResumeLayout(false);
            this.toolStripSessionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelNoTripsFound.ResumeLayout(false);
            this.panelNoTripsFound.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ToolStrip toolStripSessionInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSessionInfo;
        private System.Windows.Forms.ToolStripLabel toolStripStatusLabelDataBase;
        private System.Windows.Forms.ToolStripButton toolStripButtonDataBaseCheck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonBrowseTourCatalog;
        private System.Windows.Forms.Panel panelNoTripsFound;
        private System.Windows.Forms.Label label1;
    }
}