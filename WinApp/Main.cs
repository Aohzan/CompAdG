using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Main : Form
    {
        public const string titleApp = "CompAdG";
        public string mnemoLeft = "";
        public string mnemoRight = "";

        public Main()
        {
            InitializeComponent();
            listViewCompare.Scrollable = true;
            listViewCompare.View = View.Details;
            listViewCompare.Columns.Add("Nom", 170);
            listViewCompare.Columns.Add("Présent", 50);
            listViewCompare.FullRowSelect = true;
            listViewCompare.Sorting = SortOrder.Ascending;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            try
            {
                mnemoLeft = textBoxLeft.Text;
                listBoxLeft.Items.Clear();
                listBoxLeft.Items.AddRange(Actions.GetGroups(textBoxLeft.Text).ToArray());
                labelLeft.Text = Actions.GetName(textBoxLeft.Text);
            }
            catch(Exception ex)
            {
                labelLeft.Text = ex.Message;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            try
            {
                mnemoRight = textBoxRight.Text;
                listBoxRight.Items.Clear();
                listBoxRight.Items.AddRange(Actions.GetGroups(textBoxRight.Text).ToArray());
                labelRight.Text = Actions.GetName(textBoxRight.Text);
            }
            catch (Exception ex)
            {
                labelLeft.Text = ex.Message;
            }
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            try
            {
                buttonLeft_Click(sender, e);
                buttonRight_Click(sender, e);
                var listeLeft = Actions.GetGroups(textBoxLeft.Text);
                var listeRight = Actions.GetGroups(textBoxRight.Text);

                listViewCompare.Items.Clear();
                int gpCommun = 0;
                int gpLeft = 0;
                int gpRight = 0;
                foreach (var item in listeLeft.Union(listeRight))
                {
                    var lvItem = new ListViewItem();
                    lvItem.Text = item;

                    if(listeLeft.Contains(item) && listeRight.Contains(item))
                    {
                        lvItem.BackColor = Color.LightGreen;
                        lvItem.SubItems.Add("<=>");
                        gpCommun++;
                    }
                    else if (listeLeft.Contains(item) && !listeRight.Contains(item))
                    {
                        lvItem.BackColor = Color.LightYellow;
                        lvItem.SubItems.Add("<=");
                        gpLeft++;
                    }
                    else if (!listeLeft.Contains(item) && listeRight.Contains(item))
                    {
                        lvItem.BackColor = Color.Orange;
                        lvItem.SubItems.Add("=>");
                        gpRight++;
                    }
                    listViewCompare.Items.Add(lvItem);
                }

                listViewCompare.Sort();

                labelStats.Text = gpCommun + " groupes en commun, " + gpLeft + " à gauche seulement et " + gpRight + " à droite seulement.";
                labelHelpCompare.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titleApp);
            }
        }
        
        private void listViewCompare_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewCompare.SelectedItems.Count > 0)
            {
                string nomGroupe = listViewCompare.SelectedItems[0].Text;
                string nomuser = "";
                if (listViewCompare.SelectedItems[0].SubItems[1].Text == "<=>")
                {
                    MessageBox.Show("Le groupe est déjà des deux côtés.", titleApp);
                }
                else
                {
                    if (listViewCompare.SelectedItems[0].SubItems[1].Text == "<=")
                    {
                        nomuser = mnemoRight;
                    }
                    else if (listViewCompare.SelectedItems[0].SubItems[1].Text == "=>")
                    {
                        nomuser = mnemoLeft;
                    }
                    var choix = MessageBox.Show("Voulez-vous ajouter le groupe \n" + nomGroupe + "\nà l'utilisateur \n" + nomuser + " ?", titleApp, MessageBoxButtons.YesNo);
                    if (choix == DialogResult.Yes)
                    {
                        try
                        {
                            Actions.AddUserToGroup(nomuser, nomGroupe);
                            MessageBox.Show("Ajout effectué", titleApp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur : " + ex.Message, titleApp);
                        }
                    }
                }        
            }
        }

        private void buttonApropos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Créé par Matthieu BOURGAIN\nVersion 1.0\n19/05/2016", titleApp);
        }
    }
}