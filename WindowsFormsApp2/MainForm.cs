using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class MainForm : Form {
        private Session _session;
        public MainForm(Session session) {
            InitializeComponent();
            _session = session;
            toolStripLabelSessionInfo.Text = Convert.ToString(_session);
            //toolStripStatusLabelDataBase.Text = 
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void labelHeader_Click(object sender, EventArgs e) {

        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e) {

        }

        private void toolStripSessionStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }
    }
}
