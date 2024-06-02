using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TourExplorer {
    public partial class Form1 : TripsCatalogForm {
        public Form1(Session session) : base(session){
            InitializeComponent();
        }

        protected new void TripsCatalogForm_Load(object sender, EventArgs e) {
            ShowAllTrips();
        }
    }
}
