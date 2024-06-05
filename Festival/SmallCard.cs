using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Festival.Models;

namespace Festival
{
    public partial class SmallCard : UserControl
    {
        public SmallCard()
        {
            InitializeComponent();
        }

        public SmallCard(Band band)
        {
            InitializeComponent();
            DisplayBandInfo(band);
        }

        private void DisplayBandInfo(Band band)
        {
            pictureBox.Image = band.Photo;
            lblName.Text = band.Name;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
