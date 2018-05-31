/// ETML
/// Auteur : Christian Carbonara
/// Date   : 30.05.2018
/// Description : Page de démarrage du programme, utilisé pour la conversion
///               de nombres décimaux, binaires, otaux et hexadécimaux.

using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/// <summary>
/// Programme de conversion
/// </summary>
namespace Convertisseur_de_bases
{
    /// <summary>
    /// Form du programme de conversion et celui qui s'ouvre au lancement
    /// </summary>
    public partial class fntProgram : Form
    {
        // Permet d'utiliser les switchs suivent le format choisi
        const string BIN_TEXT = "Binaire";
        const string DEC_TEXT = "Décimale";
        const string HEX_TEXT = "Héxadécimal";
        const string OCT_TEXT = "Octal";
        const string SIGN_POS_TEXT = "Positif";
        const string SIGN_NEG_TEXT = "Négatif";

        // Valeur max en bits pour chaque format
        const int NBR_BITS_BIN_MAX = 32;
        const int NBR_BITS_DEC_MAX = 32;
        const int NBR_BITS_HEX_MAX = 0;
        const int NBR_BITS_OCT_MAX = 11;

        // Tableau pour stocker le résultat de chaque format
        int[] tabConvBin = new int[NBR_BITS_BIN_MAX];
        int[] tabConvDec = new int[NBR_BITS_DEC_MAX];
        int[] tabConvHex = new int[NBR_BITS_HEX_MAX];
        int[] tabConvOct = new int[NBR_BITS_OCT_MAX];

        // Tableau pour stocker les résultats des calculs de chaque format
        int[] tabConvCalculBin = new int[33];
        int[] tabConvCalculDec = new int[NBR_BITS_DEC_MAX];
        int[] tabConvCalculHex = new int[NBR_BITS_HEX_MAX];
        int[] tabConvCalculOct = new int[12];
        
        int valueUser;

        // Nombre de bits
        int nbrBitsInTabBin = 0;
        int nbrBitsInTabOct = 0;

        string formatSelect = "";

        // Regex pour vérifier si l'utilisateur a entré uniquement des chiffres
        Regex checkValDec = new Regex("^[0-9]+$");
        Regex checkValBin = new Regex("^[0-1]+$");

        /// <summary>
        /// Initialise l'application au lancement, n'affiche que l'interface pour effectuer des conversions
        /// non signé et sans virgule
        /// </summary>
        public fntProgram()
        {
            InitializeComponent();
            tsmiSignedNo.Checked = true;
            cobSign.Visible = false;
            lblPoint.Visible = false;
            txbValueUserAfterPoint.Visible = false;
            btnConvert.Enabled = false;
            btnShowCalculResultLeft.Enabled = false;
            btnShowCalculResultMiddle.Enabled = false;
            btnShowCalculResultRight.Enabled = false;
            txbValueUserBeforePoint.Enabled = false;
            tsmiSignedNo.BackColor = Color.PaleGreen;
            lblResultConvertLeft.Text = "";
            lblResultConvertMiddle.Text = "";
            lblResultConvertRight.Text = "";
            lblSign.Text = "";
            lblSign.Text = "";
        }

        /// <summary>
        /// Méthode qui permet à chaque changement de format d'indiquer à l'utilisateur si le nombre entré 
        /// correspond au format défini
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cobListFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatSelect = cobListFormat.Text;

            // Permet de vérifier si la valeur que l'utilisateur correspond au format choisi
            switch (formatSelect)
            {
                case DEC_TEXT:
                    if (checkValDec.IsMatch(txbValueUserBeforePoint.Text) || txbValueUserBeforePoint.Text == "")
                    {
                        txbValueUserBeforePoint.BackColor = Color.White;
                        txbValueUserBeforePoint.Enabled = true;
                    }
                    else
                    {
                        txbValueUserBeforePoint.BackColor = Color.MediumVioletRed;
                        btnConvert.Enabled = false;
                    }

                    lblResultConvertLeft.Text = BIN_TEXT;
                    lblResultConvertMiddle.Text = OCT_TEXT;
                    lblResultConvertRight.Text = HEX_TEXT;
                    break;

                case BIN_TEXT:
                    if (checkValBin.IsMatch(txbValueUserBeforePoint.Text) || txbValueUserBeforePoint.Text == "")
                    {
                        txbValueUserBeforePoint.BackColor = Color.White;
                        txbValueUserBeforePoint.Enabled = true;
                    }
                    else
                    {
                        txbValueUserBeforePoint.BackColor = Color.MediumVioletRed;
                        btnConvert.Enabled = false;
                    }

                    lblResultConvertLeft.Text = DEC_TEXT;
                    lblResultConvertMiddle.Text = OCT_TEXT;
                    lblResultConvertRight.Text = HEX_TEXT;
                    break;
            }
        }

        /// <summary>
        /// Bouton pour effectuer la conversion du nombre entrer suivent le format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string resultToShowBin = "";
            string resultToShowOct = "";
            string resultToShowDec = "";
            int nbrBitsBlockShow = 0;
            int nbrBitsBlockShowMax = 4;
            txbResultConvLeft.Text = "";
            txbResultConvMiddle.Text = "";
            
            // Permet de convertir suivent le format que l'utilisateur choisit
            switch (formatSelect)
            {
                case DEC_TEXT:

                    btnShowCalculResultLeft.Enabled = true;
                    btnShowCalculResultMiddle.Enabled = true;

                    // Stock le résultat sur une variable en récupérant dans chaque case du tableau les valeurs
                    for (int countNbrInverse = ConvertDecToBin(); countNbrInverse >= 0; countNbrInverse--)
                    {
                        // Permet d'espacer les chiffres une fois qu'un certain nombre de chiffres ont été affichés
                        if (nbrBitsBlockShow < nbrBitsBlockShowMax)
                        {
                            resultToShowBin = resultToShowBin + Convert.ToString(tabConvBin[countNbrInverse]);
                            nbrBitsBlockShow++;
                        }
                        else
                        {
                            resultToShowBin = resultToShowBin + " " + Convert.ToString(tabConvBin[countNbrInverse]);
                            nbrBitsBlockShow = 1;
                        }
                    }

                    nbrBitsBlockShow = 0;

                    txbResultConvLeft.Text = resultToShowBin;

                    // Stock le résultat sur une variable en récupérant dans chaque case du tableau les valeurs
                    for (int countNbrInverse = ConvertDecToOct(); countNbrInverse >= 0; countNbrInverse--)
                    {
                        // Permet d'espacer les chiffres une fois qu'un certain nombre de chiffres ont été affichés
                        if (nbrBitsBlockShow < nbrBitsBlockShowMax)
                        {
                            resultToShowOct = resultToShowOct + Convert.ToString(tabConvOct[countNbrInverse]);
                            nbrBitsBlockShow++;
                        }
                        else
                        {
                            resultToShowOct = resultToShowOct + " ";
                            nbrBitsBlockShow = 0;
                        }
                    }
                    txbResultConvMiddle.Text = resultToShowOct;
                    break;

                case BIN_TEXT:

                    btnShowCalculResultLeft.Enabled = true;
                    btnShowCalculResultMiddle.Enabled = true;

                    // Stock le résultat sur une variable en récupérant dans chaque case du tableau les valeurs
                    for (int countNbrInverse = ConvertBinToDec(); countNbrInverse >= 0; countNbrInverse--)
                    {
                        if (resultToShowDec != "")
                        {
                            resultToShowDec = Convert.ToString(Convert.ToInt32(resultToShowDec) + (tabConvDec[countNbrInverse]));
                        }
                        else
                        {
                            resultToShowDec = "0";
                        }
                    }

                    nbrBitsBlockShow = 0;

                    txbResultConvLeft.Text = resultToShowDec;
                    int limiteOct = 0;
                    // Stock le résultat sur une variable en récupérant dans chaque case du tableau les valeurs
                    for (int countNbrInverse = ConvertBinToOct() - 1; countNbrInverse >= 0; countNbrInverse--)
                    {

                        if (resultToShowOct != "")
                        {
                            if (limiteOct < 3)
                            {
                                resultToShowOct = Convert.ToString(Convert.ToInt32(resultToShowOct) + (tabConvOct[countNbrInverse]));
                                limiteOct++;
                            }
                            else
                            {
                                txbResultConvMiddle.Text = resultToShowOct + txbResultConvMiddle.Text;
                                resultToShowOct = "0";
                                resultToShowOct = Convert.ToString(Convert.ToInt32(resultToShowOct) + (tabConvOct[countNbrInverse]));
                                limiteOct = 1;
                            }
                        }
                        else
                        {
                            resultToShowOct = "0";
                            if (limiteOct < 3)
                            {
                                resultToShowOct = Convert.ToString(Convert.ToInt32(resultToShowOct) + (tabConvOct[countNbrInverse ]));
                                limiteOct++;
                            }
                            else
                            {
                                txbResultConvMiddle.Text = resultToShowOct + txbResultConvMiddle.Text;
                                resultToShowOct = "0";
                                resultToShowOct = Convert.ToString(Convert.ToInt32(resultToShowOct) + (tabConvOct[countNbrInverse]));
                                limiteOct = 1;
                            }
                        }

                    }
                    txbResultConvMiddle.Text = resultToShowOct +txbResultConvMiddle.Text;
                    break;
            }
        }

        /// <summary>
        /// Vérifie le nombre entré par l'utilisateur correspond au format choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbValueUserBeforePoint_TextChanged(object sender, EventArgs e)
        {
            string valueUserToCheck = "";

            if(lblSign.Text == "+" || lblSign.Text == "-")
            {
                valueUserToCheck = lblSign.Text + txbValueUserBeforePoint.Text;
            }
            else
            {
                valueUserToCheck = txbValueUserBeforePoint.Text;
            }

            switch (formatSelect)
            {
                case DEC_TEXT:
                    if (checkValDec.IsMatch(txbValueUserBeforePoint.Text) && int.TryParse(valueUserToCheck, out valueUser))
                    {
                        txbValueUserBeforePoint.BackColor = Color.White;
                        btnConvert.Enabled = true;
                    }
                    else
                    {
                        txbValueUserBeforePoint.BackColor = Color.MediumVioletRed;
                        btnConvert.Enabled = false;
                    }
                    break;

                case BIN_TEXT:
                    if (checkValBin.IsMatch(txbValueUserBeforePoint.Text) && int.TryParse(valueUserToCheck, out valueUser))
                    {
                        txbValueUserBeforePoint.BackColor = Color.White;
                        btnConvert.Enabled = true;
                    }
                    else
                    {
                        txbValueUserBeforePoint.BackColor = Color.MediumVioletRed;
                        btnConvert.Enabled = false;
                    }
                    break;
            }
        }

        /// <summary>
        /// Permet de définir que le nombre entré n'est pas signé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSignedNo_Click(object sender, EventArgs e)
        {
            tsmiSignedYes.BackColor = Color.White;
            tsmiSignedNo.BackColor = Color.PaleGreen;
            tsmiSignedYes.Checked = false;
            tsmiSignedNo.Checked = true;
            lblSign.Text = "";
            cobSign.Visible = false;
        }

        /// <summary>
        /// Permet de définir que le nombre entré est signé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSignedYes_Click(object sender, EventArgs e)
        {
            tsmiSignedYes.BackColor = Color.PaleGreen;
            tsmiSignedNo.BackColor = Color.White;
            tsmiSignedYes.Checked = true;
            tsmiSignedNo.Checked = false;
            lblSign.Text = "";
            cobSign.Visible = true;
        }

        /// <summary>
        /// Permet de définir si le nombre signé est positif ou négatif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cobSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobSign.Text)
            {
                case SIGN_POS_TEXT:
                    lblSign.Text = "+";
                    break;

                case SIGN_NEG_TEXT:
                    lblSign.Text = "-";
                    break;
            }
        }
        
        /// <summary>
        /// Fonction permettant de convertir de décimal à binaire le nombre entré par l'utilisateur
        /// </summary>
        /// <returns>Nombre de caractère à afficher</returns>
        private int ConvertDecToBin()
        {
            nbrBitsInTabBin = 0;
            tabConvCalculBin[0] = valueUser;

            // Permet de convertir le nombre en binaire et le stocker dans un tableau
            for (int countNbr = 0; countNbr < NBR_BITS_BIN_MAX; countNbr++)
            {
                tabConvBin[countNbr] = tabConvCalculBin[countNbr] % 2;

                if (tabConvBin[countNbr] == 1)
                {
                    tabConvCalculBin[countNbr + 1] = (tabConvCalculBin[countNbr] - 1) / 2;
                }
                else
                {
                    tabConvCalculBin[countNbr + 1] = tabConvCalculBin[countNbr] / 2;
                }

                if (tabConvCalculBin[countNbr + 1] == 0)
                {
                    break;
                }

                nbrBitsInTabBin += 1;
            }
            return nbrBitsInTabBin;
        }

        /// <summary>
        /// Fonction permettant de convertir de binaire à décimal le nombre entré par l'utilisateur
        /// </summary>
        /// <returns>Nombre de caractère à afficher</returns>
        private int ConvertBinToDec()
        {
            int nbrBitsInTabDec = 0;
            string valueUserToConvert = Convert.ToString(valueUser);

            int lengthValueUser = valueUserToConvert.Length;

            for (int posTable = lengthValueUser; posTable > 0; posTable--)
            {
                tabConvCalculDec[posTable -1] = Convert.ToInt32(valueUserToConvert.Substring(lengthValueUser - posTable, 1));
                tabConvDec[posTable - 1] = tabConvCalculDec[posTable - 1] * Convert.ToInt32(Math.Pow(Convert.ToDouble(2), Convert.ToDouble(posTable - 1)));
                nbrBitsInTabDec++;
            }
            
            return nbrBitsInTabDec;
        }

        /// <summary>
        /// Fonction permettant de convertir de décimal à octal le nombre entré par l'utilisateur
        /// </summary>
        /// <returns>Nombre de caractère à afficher</returns>
        private int ConvertDecToOct()
        {
            nbrBitsInTabOct = 0;
            tabConvCalculOct[0] = valueUser;

            // Permet de convertir le nombre en octal et le stocker dans un tableau
            for (int countNbr = 0; countNbr < NBR_BITS_OCT_MAX; countNbr++)
            {
                tabConvOct[countNbr] = tabConvCalculOct[countNbr] % 8;

                if (tabConvOct[countNbr] != 0)
                {
                    tabConvCalculOct[countNbr + 1] = (tabConvCalculOct[countNbr] - (tabConvCalculOct[countNbr] % 8)) / 8;
                }
                else
                {
                    tabConvCalculOct[countNbr + 1] = tabConvCalculOct[countNbr] / 8;
                }

                if (tabConvCalculOct[countNbr + 1] == 0)
                {
                    break;
                }

                nbrBitsInTabOct += 1;
            }
            return nbrBitsInTabOct;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int ConvertBinToOct()
        {
            int nbrBitsInTabOct = 0;
            int limitConvertOct = 0;
            string valueUserToConvert = Convert.ToString(valueUser);

            int lengthValueUser = valueUserToConvert.Length;

            for (int posTable = lengthValueUser-1; posTable >= 0; posTable--)
            {
                if (limitConvertOct < 3)
                {
                    tabConvCalculOct[posTable] = Convert.ToInt32(valueUserToConvert.Substring(posTable, 1));
                    tabConvOct[posTable] = tabConvCalculOct[posTable ] * Convert.ToInt32(Math.Pow(Convert.ToDouble(2), Convert.ToDouble(limitConvertOct)));
                    limitConvertOct++;
                }
                else
                {
                    limitConvertOct = 0;
                    tabConvCalculOct[posTable] = Convert.ToInt32(valueUserToConvert.Substring(posTable, 1));
                    tabConvOct[posTable] = tabConvCalculOct[posTable] * Convert.ToInt32(Math.Pow(Convert.ToDouble(2), Convert.ToDouble(limitConvertOct)));
                    limitConvertOct++;
                }
                nbrBitsInTabOct++;
            }

            return nbrBitsInTabOct;
        }

        /// <summary>
        /// Bouton pour afficher en entier le calcul nécessaire pour obtenir le résultat de gauche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCalculResultLeft_Click(object sender, EventArgs e)
        {
            IShowCalcul fntCalcul = new IShowCalcul();

            for(int nbrConvCalculBinShow = 0; nbrConvCalculBinShow <= nbrBitsInTabBin; nbrConvCalculBinShow++)
            {
                fntCalcul.GetTable(tabConvCalculBin[nbrConvCalculBinShow], tabConvBin[nbrConvCalculBinShow], lblResultConvertLeft.Text);
            }
            fntCalcul.ShowAllCalcul();
            fntCalcul.Show();
        }

        /// <summary>
        /// Bouton pour afficher en entier le calcul nécessaire pour obtenir le résultat du milieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCalculResultMiddle_Click(object sender, EventArgs e)
        {
            IShowCalcul fntCalcul = new IShowCalcul();

            for (int nbrConvCalculOctShow = 0; nbrConvCalculOctShow <= nbrBitsInTabOct; nbrConvCalculOctShow++)
            {
                fntCalcul.GetTable(tabConvCalculOct[nbrConvCalculOctShow], tabConvOct[nbrConvCalculOctShow], lblResultConvertMiddle.Text);
            }
            fntCalcul.ShowAllCalcul();
            fntCalcul.Show();
        }
    }
}
