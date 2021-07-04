using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservation.Properties;
using Microsoft.VisualBasic;

namespace HotelReservation.userControls
{
    public partial class ucChambre : UserControl
    {
        private bool isReserved;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChambre));

        public Model.Chambre chambre{get; set;}
        public DateTime date { get; set; }
        public ucChambre(Model.Chambre chambre,DateTime searchdate)
        {
            this.date = searchdate;
            this.chambre = chambre;
            InitializeComponent();

            int userReservee = Model.dbReservation.isReserved(chambre.id,date);
            lblNum.Text = "N°" + chambre.numero;
            this.isReserved = userReservee != -1;


            BackColor = ColorTranslator.FromHtml(isReserved ? "#f8cecc" : "#d5e8d4");

            if (this.isReserved)
            {
                this.button1.Text = "Liberer";
            }
                
            Model.TypeChambres types = new Model.TypeChambres();
            foreach(Model.Type t in Model.TypeChambres.list)
            {
                if(t.id.Equals(chambre.type_id))
                {
                    lblType.Text = "Chambre " + t.classe;
                    break;
                }
            }
        }
        private void réserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void libérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.isReserved)
            {
                this.Liberer();
            }
            else
            {
                this.Reserver();
            }
        }

        private void Reserver()
        {
            ReservationForm resform = new ReservationForm(this);
            resform.Show();
        }

        private void Liberer()
        {
            if ((MessageBox.Show("Voulez vous libérer la chambre ?", "Attention!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                Model.dbReservation.libererChambre(this.chambre);
                ucHotel p = (ucHotel)this.Parent.Parent;
                p.reload();
            }
        }
    }
}
