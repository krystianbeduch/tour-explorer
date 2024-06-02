namespace TourExplorer
{
    partial class HelloForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloForm));
            this.buttonLoginAsGuest = new System.Windows.Forms.Button();
            this.buttonLoginAsUser = new System.Windows.Forms.Button();
            this.buttonLoginAsAdmin = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonLoginHelp = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.toolStripSessionInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDataBaseCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabelDataBase = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSessionInfo = new System.Windows.Forms.ToolStripLabel();
            this.panelHeader.SuspendLayout();
            this.toolStripSessionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginAsGuest
            // 
            resources.ApplyResources(this.buttonLoginAsGuest, "buttonLoginAsGuest");
            this.buttonLoginAsGuest.Name = "buttonLoginAsGuest";
            this.buttonLoginAsGuest.UseVisualStyleBackColor = true;
            this.buttonLoginAsGuest.Click += new System.EventHandler(this.buttonLoginAsGuest_Click);
            // 
            // buttonLoginAsUser
            // 
            resources.ApplyResources(this.buttonLoginAsUser, "buttonLoginAsUser");
            this.buttonLoginAsUser.Name = "buttonLoginAsUser";
            this.buttonLoginAsUser.UseVisualStyleBackColor = true;
            this.buttonLoginAsUser.Click += new System.EventHandler(this.buttonLoginAsUser_Click);
            // 
            // buttonLoginAsAdmin
            // 
            resources.ApplyResources(this.buttonLoginAsAdmin, "buttonLoginAsAdmin");
            this.buttonLoginAsAdmin.Name = "buttonLoginAsAdmin";
            this.buttonLoginAsAdmin.UseVisualStyleBackColor = true;
            this.buttonLoginAsAdmin.Click += new System.EventHandler(this.buttonLoginAsAdmin_Click);
            // 
            // buttonContinue
            // 
            resources.ApplyResources(this.buttonContinue, "buttonContinue");
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonLoginHelp
            // 
            resources.ApplyResources(this.buttonLoginHelp, "buttonLoginHelp");
            this.buttonLoginHelp.Name = "buttonLoginHelp";
            this.buttonLoginHelp.UseVisualStyleBackColor = true;
            this.buttonLoginHelp.Click += new System.EventHandler(this.buttonLoginHelp_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::TourExplorer.Properties.Resources.chmury;
            this.panelHeader.Controls.Add(this.labelHeader);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelHeader, "labelHeader");
            this.labelHeader.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.UseMnemonic = false;
            // 
            // toolStripSessionInfo
            // 
            resources.ApplyResources(this.toolStripSessionInfo, "toolStripSessionInfo");
            this.toolStripSessionInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDataBaseCheck,
            this.toolStripStatusLabelDataBase,
            this.toolStripLabelSessionInfo});
            this.toolStripSessionInfo.Name = "toolStripSessionInfo";
            // 
            // toolStripButtonDataBaseCheck
            // 
            this.toolStripButtonDataBaseCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDataBaseCheck.ForeColor = System.Drawing.Color.Green;
            this.toolStripButtonDataBaseCheck.Image = global::TourExplorer.Properties.Resources.databaseIcon;
            resources.ApplyResources(this.toolStripButtonDataBaseCheck, "toolStripButtonDataBaseCheck");
            this.toolStripButtonDataBaseCheck.Name = "toolStripButtonDataBaseCheck";
            this.toolStripButtonDataBaseCheck.Click += new System.EventHandler(this.toolStripButtonDataBaseCheck_Click);
            // 
            // toolStripStatusLabelDataBase
            // 
            this.toolStripStatusLabelDataBase.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabelDataBase.Name = "toolStripStatusLabelDataBase";
            resources.ApplyResources(this.toolStripStatusLabelDataBase, "toolStripStatusLabelDataBase");
            // 
            // toolStripLabelSessionInfo
            // 
            this.toolStripLabelSessionInfo.Name = "toolStripLabelSessionInfo";
            resources.ApplyResources(this.toolStripLabelSessionInfo, "toolStripLabelSessionInfo");
            // 
            // HelloForm
            // 
            this.AcceptButton = this.buttonContinue;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.toolStripSessionInfo);
            this.Controls.Add(this.buttonLoginHelp);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonLoginAsAdmin);
            this.Controls.Add(this.buttonLoginAsUser);
            this.Controls.Add(this.buttonLoginAsGuest);
            this.Name = "HelloForm";
            this.panelHeader.ResumeLayout(false);
            this.toolStripSessionInfo.ResumeLayout(false);
            this.toolStripSessionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoginAsGuest;
        private System.Windows.Forms.Button buttonLoginAsUser;
        private System.Windows.Forms.Button buttonLoginAsAdmin;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonLoginHelp;
        private System.Windows.Forms.ToolStrip toolStripSessionInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonDataBaseCheck;
        private System.Windows.Forms.ToolStripLabel toolStripStatusLabelDataBase;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSessionInfo;
    }
}

