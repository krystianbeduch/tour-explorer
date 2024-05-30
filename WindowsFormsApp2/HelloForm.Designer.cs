namespace WindowsFormsApp2
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
            this.buttonDataBaseCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoginAsGuest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoginAsUser = new System.Windows.Forms.Button();
            this.buttonLoginAsAdmin = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.statusStripSessionInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSessionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSessionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDataBaseCheck
            // 
            resources.ApplyResources(this.buttonDataBaseCheck, "buttonDataBaseCheck");
            this.buttonDataBaseCheck.Name = "buttonDataBaseCheck";
            this.buttonDataBaseCheck.UseVisualStyleBackColor = true;
            this.buttonDataBaseCheck.Click += new System.EventHandler(this.buttonDataBaseCheck_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonLoginAsGuest
            // 
            resources.ApplyResources(this.buttonLoginAsGuest, "buttonLoginAsGuest");
            this.buttonLoginAsGuest.Name = "buttonLoginAsGuest";
            this.buttonLoginAsGuest.UseVisualStyleBackColor = true;
            this.buttonLoginAsGuest.Click += new System.EventHandler(this.buttonLoginAsGuest_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Name = "label2";
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
            // statusStripSessionInfo
            // 
            this.statusStripSessionInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDataBase,
            this.toolStripStatusLabelSessionInfo});
            resources.ApplyResources(this.statusStripSessionInfo, "statusStripSessionInfo");
            this.statusStripSessionInfo.Name = "statusStripSessionInfo";
            this.statusStripSessionInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabelDataBase
            // 
            this.toolStripStatusLabelDataBase.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripStatusLabelDataBase.Name = "toolStripStatusLabelDataBase";
            resources.ApplyResources(this.toolStripStatusLabelDataBase, "toolStripStatusLabelDataBase");
            // 
            // toolStripStatusLabelSessionInfo
            // 
            this.toolStripStatusLabelSessionInfo.Name = "toolStripStatusLabelSessionInfo";
            resources.ApplyResources(this.toolStripStatusLabelSessionInfo, "toolStripStatusLabelSessionInfo");
            // 
            // HelloForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStripSessionInfo);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonLoginAsAdmin);
            this.Controls.Add(this.buttonLoginAsUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoginAsGuest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDataBaseCheck);
            this.Name = "HelloForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStripSessionInfo.ResumeLayout(false);
            this.statusStripSessionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDataBaseCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoginAsGuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoginAsUser;
        private System.Windows.Forms.Button buttonLoginAsAdmin;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.StatusStrip statusStripSessionInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDataBase;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSessionInfo;
    }
}

