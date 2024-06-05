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
    public partial class LargeCard : UserControl
    {
        public LargeCard()
        {
            InitializeComponent();
        }

        public LargeCard(Band band)
        {
            InitializeComponent();
            DisplayBandInfo(band);
        }

        private void DisplayBandInfo(Band band)
        {
            pictureBox.Image = band.Photo;
            lblName.Text = band.Name;
            lblCountry.Text = $"Pays: {band.Country}";
            lblGenre.Text = $"Genre: {band.Genre}";
            lblDate.Text = $"Date: {band.Date.ToString("dd/MM/yyyy HH:mm")}";
            lblStage.Text = $"Scène: {band.Stage}";
            lblDescription.Text = band.Description;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
