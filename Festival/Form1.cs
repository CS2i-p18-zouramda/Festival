using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Festival.Models;

namespace Festival
{
    public partial class Form1 : Form
    {
        private List<Band> bands;

        public Form1()
        {
            InitializeComponent();
            InitializeBands();
            DisplaySmallCards();
        }

        private void InitializeBands()
        {
            bands = new List<Band>
            {
                new Band
                {
                    Name = "Nova Twins",
                    Country = "Royaume-Uni",
                    Genre = "Hip Hop",
                    Date = new DateTime(2023, 7, 17, 17, 30, 0),
                    Stage = "Kerouac",
                    Description = "Un duo de Londoniennes badass comme on les aime ! Amy Love et Georgia South, reines de l’urban punk, sont dotées d’un indéniable panache et d’une volonté d’embras(s)er dans un geste plein de fureur 30 ans de contestation sonore made in England : agressivité politique du punk, verve provocatrice du grime, hédonisme expérimental de la bass music. Sur scène, le duo offre des performances dopées aux riffs et aux lignes de basses de plus en plus lourdes avec une énergie contagieuse ! Le public est secoué !",
                    Photo = Properties.Resources.nova_twins
                },
                new Band
                {
                    Name = "Skip The Use",
                    Country = "France",
                    Genre = "Rock",
                    Date = new DateTime(2023, 7, 17, 18, 45, 0),
                    Stage = "Glenmor",
                    Description = "Skip The Use, le fameux groupe de rock lillois, effectue son grand retour après 2 ans d'absence avec un nouvel album et une nouvelle tournée, Human Disorder. L'album, intense, paradoxal, aux émotions qui s’entrechoquent, s'écoute comme une traversée des ténèbres pour accéder à la lumière, celle qui fait de nous des Hommes. Human Disorder nous montre encore une fois toute l’efficacité et la puissance de Skip the Use, un groupe taillé pour la scène, son terrain de prédilection.",
                    Photo = Properties.Resources.skip_the_use
                },
                new Band
                {
                    Name = "Silmarils",
                    Country = "France",
                    Genre = "Rock / Hip Hop",
                    Date = new DateTime(2023, 7, 17, 20, 0, 0),
                    Stage = "Kerouac",
                    Description = "Fer de lance de la scène rock / hip hop de 1995 à 2010 avec des titres et des clips qui résonnent encore aujourd’hui (Cours vite, Va y avoir du Sport, Tant que parle l’Economie, Guérilla…), Silmarils est de retour en studio avec son nouvel album, RunFast, disponible en avril, et sur scène ! Et qui plus est, dans sa formation originelle, emmenée par son leader David Salsedo. Ce lundi sera survitaminé ou ne sera pas !",
                    Photo = Properties.Resources.silmarils
                },
                new Band
                {
                    Name = "Red Hot Chili Peppers",
                    Country = "USA",
                    Genre = "Funk Rock",
                    Date = new DateTime(2023, 7, 17, 20, 30, 0),
                    Stage = "Glenmor",
                    Description = "Anthony Kiedis, Flea et Chad Smith retrouvent John Frusciante, a.k.a le meilleur guitariste du monde, pour jouer leurs immenses tubes (Californication, Snow, Can’t stop, Under the Bridge, Give it away…) et présenter leur dernier album, Return of the Dream Canteen. Généreux, libres et surprenants, les Californiens forgés pour la scène ont encore l’énergie dévastatrice de gamins survoltés. Rendez-vous à Kerampuilh pour un concert qui s’annonce déjà historique !",
                    Photo = Properties.Resources.red_hot_chili_peppers
                },
                new Band
                {
                    Name = "The Inspector Cluzo",
                    Country = "France",
                    Genre = "Rock'n Roll",
                    Date = new DateTime(2023, 7, 17, 0, 20, 0),
                    Stage = "Kerouac",
                    Description = "15 ans de carrière, plus de 67 pays visités, 1200 concerts en totale auto-production et déjà le 9e album Horizon ! Enregistré en trois semaines à Nashville et produit à nouveau par Vance Powell (Raconters, Stapleton, Jack White), ce nouvel opus s'inspire d'événements et d'expériences survenus dans la vie du duo, qui continue de militer contre la voracité de l'industrie agro-alimentaire et décrit le combat permanent des agriculteurs contre un système absurde qui appelle parfois à la désobéissance civile, le tout avec une énergie sans faille !",
                    Photo = Properties.Resources.the_inspector_cluzo
                }
            };
        }

        private void DisplaySmallCards()
        {
            panelGroups.Controls.Clear();
            int y = 10;

            foreach (var band in bands)
            {
                SmallCard smallCard = new SmallCard(band);
                smallCard.Location = new Point(10, y);
                panelGroups.Controls.Add(smallCard);
                y += smallCard.Height + 10;
            }
        }

        private void DisplayLargeCards()
        {
            panelGroups.Controls.Clear();
            int y = 10;

            foreach (var band in bands)
            {
                LargeCard largeCard = new LargeCard(band);
                largeCard.Location = new Point(10, y);
                panelGroups.Controls.Add(largeCard);
                y += largeCard.Height + 10;
            }
        }

        private void affichagePetitesCartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplaySmallCards();
            affichagePetitesCartesToolStripMenuItem.Checked = true;
            affichageLargesCartesToolStripMenuItem.Checked = false;
        }

        private void affichageLargesCartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayLargeCards();
            affichagePetitesCartesToolStripMenuItem.Checked = false;
            affichageLargesCartesToolStripMenuItem.Checked = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
