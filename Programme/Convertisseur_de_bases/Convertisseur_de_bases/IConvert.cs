/// ETML
/// Auteur : Christian Carbonara
/// Date   : 17.05.2018
/// Description : Page de démarrage du programme, utilisé pour la conversion
///               de nombres décimaux, binaires, otaux et hexadécimaux.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace Convertisseur_de_bases
{
    /// <summary>
    /// 
    /// </summary>
    public partial class fntProgram : Form
    {
        // Permet d'utiliser les switchs suivent le format choisi
        const string BIN_TEXT = "Binaire";
        const string DEC_TEXT = "Décimale";
        const string HEX_TEXT = "Héxadécimal";
        const string OCT_TEXT = "Octal";

        // Valeur max en bits pour chaque format
        const int NBR_BITS_BIN_MAX = 31;
        const int NBR_BITS_DEC_MAX = 0;
        const int NBR_BITS_HEX_MAX = 0;
        const int NBR_BITS_OCT_MAX = 11;

        // Tableau pour stocker le résultat de chaque format
        int[] tabConvBin = new int[NBR_BITS_BIN_MAX];
        int[] tabConvDec = new int[NBR_BITS_DEC_MAX];
        int[] tabConvHex = new int[NBR_BITS_HEX_MAX];
        int[] tabConvOct = new int[NBR_BITS_OCT_MAX];

        int valueUserEnter;
        int nbrBitsUser;

        // Regex pour vérifier si l'utilisateur a entré uniquement des chiffres
        Regex checkValDec = new Regex("^[0-9]+$");

        /// <summary>
        /// 
        /// </summary>
        public fntProgram()
        {
            InitializeComponent();
            lblResultConvertLeft.Text = "";
            lblResultConvertMiddle.Text = "";
        }

        /// <summary>
        /// Méthode qui permet à chaque changement de format d'indiquer à l'utilisateur si le nombre entrer 
        /// correspond au format accépté ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cobListFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Permet de vérifier si la valeur que l'utilisateur correspond au format choisi
            switch(cobListFormat.Text)
            {
                case DEC_TEXT:
                    if (checkValDec.IsMatch(txbValueUserBeforePoint.Text) || txbValueUserBeforePoint.Text == "")
                    {
                        txbValueUserBeforePoint.BackColor = Color.White;
                    }
                    else
                    {
                        txbValueUserBeforePoint.BackColor = Color.MediumVioletRed;
                    }

                    lblResultConvertLeft.Text = BIN_TEXT;
                    lblResultConvertMiddle.Text = OCT_TEXT;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbValueUserAfterPoint_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton pour effectuer la conversion du nombre entrer suivent le format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string resultToShowBin = "";
            string resultToShowOCt = "";
            int nbrBitsInTabBin = 0;
            int nbrBitsInTabOct = 0;
            int nbrBitsBlockShow = 0;
            int nbrBitsBlockShowMax = 4;

            // Permet de convertir suivent le format que l'utilisateur choisit
            switch (cobListFormat.Text)
            {
                case DEC_TEXT:
                    if (checkValDec.IsMatch(txbValueUserBeforePoint.Text))
                    {
                        valueUserEnter = Convert.ToInt32(txbValueUserBeforePoint.Text);
                        nbrBitsUser = txbValueUserBeforePoint.Text.Length;

                        // Permet de convertir le nombre en binaire et le stocker dans un tableau
                        for (int countNbr = 0; countNbr < NBR_BITS_BIN_MAX; countNbr++)
                        {
                            tabConvBin[countNbr] = valueUserEnter % 2;

                            if (tabConvBin[countNbr] == 1)
                            {
                                valueUserEnter = (valueUserEnter - 1) / 2;
                            }
                            else
                            {
                                valueUserEnter = valueUserEnter / 2;
                            }

                            if (valueUserEnter == 0)
                            {
                                break;
                            }

                            nbrBitsInTabBin += 1;
                        }

                        valueUserEnter = Convert.ToInt32(txbValueUserBeforePoint.Text);
                        // Permet de convertir le nombre en octal et le stocker dans un tableau
                        for (int countNbr = 0; countNbr < NBR_BITS_OCT_MAX; countNbr++)
                        {
                            tabConvOct[countNbr] = valueUserEnter % 8;

                            if (tabConvOct[countNbr] != 0)
                            {
                                valueUserEnter = (valueUserEnter - (valueUserEnter % 8)) / 8;
                            }
                            else
                            {
                                valueUserEnter = valueUserEnter / 8;
                            }

                            if (valueUserEnter == 0)
                            {
                                break;
                            }

                            nbrBitsInTabOct += 1;
                        }
                        break;
                    }
                    else
                    {
                        break;
                    }
            }
            
            // Stock le résultat sur une variable en récupérant dans chaque case du tableau les valeurs
            for (int countNbrInverse = nbrBitsInTabBin; countNbrInverse >= 0; countNbrInverse--)
            {
                // Permet d'espacer les chiffres une fois qu'un certain nombre de chiffres ont été affichés
                if (nbrBitsBlockShow < nbrBitsBlockShowMax)
                {
                    resultToShowBin = resultToShowBin + Convert.ToString(tabConvBin[countNbrInverse]);
                    nbrBitsBlockShow++;
                }
                else
                {
                    resultToShowBin = resultToShowBin + " ";
                    nbrBitsBlockShow = 0;
                }
            }

            txbResultConvLeft.Text = resultToShowBin;

            nbrBitsBlockShow = 0;
            nbrBitsBlockShowMax = 4;

            // Stock le résultat sur une variable en récupérant dans chaque case du tableau les valeurs
            for (int countNbrInverse = nbrBitsInTabOct; countNbrInverse >= 0; countNbrInverse--)
            {
                // Permet d'espacer les chiffres une fois qu'un certain nombre de chiffres ont été affichés
                if (nbrBitsBlockShow < nbrBitsBlockShowMax)
                {
                    resultToShowOCt = resultToShowOCt + Convert.ToString(tabConvOct[countNbrInverse]);
                    nbrBitsBlockShow++;
                }
                else
                {
                    resultToShowOCt = resultToShowOCt + " ";
                    nbrBitsBlockShow = 0;
                }
            }
            txbResultConvMiddle.Text = resultToShowOCt;

        }

        /// <summary>
        /// Suivent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbValueUserBeforePoint_TextChanged(object sender, EventArgs e)
        {
            switch (cobListFormat.Text)
            {
                case DEC_TEXT:
                    if (checkValDec.IsMatch(txbValueUserBeforePoint.Text))
                    {
                        txbValueUserBeforePoint.BackColor = Color.White;
                    }
                    else
                    {
                        txbValueUserBeforePoint.BackColor = Color.MediumVioletRed;
                    }
                    break;  
            }
        }
    }
}
