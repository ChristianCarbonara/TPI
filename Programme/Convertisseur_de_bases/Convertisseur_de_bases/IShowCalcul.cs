/// ETML
/// Auteur : Christian Carbonara
/// Date   : 30.05.2018
/// Description : Page de Permettant d'afficher les calculs de conversions
///               dans le but de démontrer à l'utilisateur comment effectuer les opérations

using System;
using System.Windows.Forms;

/// <summary>
/// Page d'affichage des calculs
/// </summary>
namespace Convertisseur_de_bases
{
    /// <summary>
    /// Form qui s'ouvre pour afficher les calculs nécessaire pour obtenir le résultat
    /// </summary>
    public partial class IShowCalcul : Form
    {
        // Permet d'utiliser les switchs suivent le format choisi
        const string BIN_TEXT = "Binaire";
        const string DEC_TEXT = "Décimale";
        const string HEX_TEXT = "Héxadécimal";
        const string OCT_TEXT = "Octal";

        // Table contenant les calculs
        int[] tabCalcul = new int[33];
        int[] tabConvert = new int[33];

        // Nombre de fois où un calcul a été fait et est montré
        int nbrConvCalculShow = 0;

        // Text démontrant le calcul
        string textFormatRest = "";

        /// <summary>
        /// Initialise la page avec les composants
        /// </summary>
        public IShowCalcul()
        {
            InitializeComponent();

            // Rend invisible tous les calculs afin de n'afficher que ceux qui sont nécessaire
            lblFirstResult.Visible = false;
            lblSecondResult.Visible = false;
            lblThirdResult.Visible = false;
            lblFourthResult.Visible = false;
            lblFifthResult.Visible = false;
            lblSixthResult.Visible = false;
            lblSeventhResult.Visible = false;
            lblEighthResult.Visible = false;
            lblNinthResult.Visible = false;
            lblTenthResult.Visible = false;
            lblEleventhResult.Visible = false;
            lblTwelfthResult.Visible = false;
            lblThirteenthResult.Visible = false;
            lblFourteenthResult.Visible = false;
            lblFifteenthResult.Visible = false;
            lblSixteenthResult.Visible = false;
            lblSeventeenthResult.Visible = false;
            lblEighteenthResult.Visible = false;
            lblNineteenthResult.Visible = false;
            lblTwentiethResult.Visible = false;
            lblTwentyFirstResult.Visible = false;
            lblTwentySecondResult.Visible = false;
            lblTwentyThirdResult.Visible = false;
            lblTwentyFourthResult.Visible = false;
            lblTwentyFifthResult.Visible = false;
            lblTwentySixthResult.Visible = false;
            lblTwentySeventhResult.Visible = false;
            lblTwentyEighthResult.Visible = false;
            lblTwentyNinthResult.Visible = false;
            lblThirtiethResult.Visible = false;
            lblThirtiethFirstResult.Visible = false;
            lblThirtiethSecondResult.Visible = false;
        }

        /// <summary>
        /// Permet de récupérer les résultats du calcul dans des tables, défini quel résultat il faut affiché
        /// </summary>
        /// <param name="nbrResult">Nombre à diviser pour le calcul</param>
        /// <param name="nbrTabConvert">Reste après la division utilisé pour convertir</param>
        /// <param name="formatResult">Permet de savoir dans quel est le format de conversion</param>
        public void GetTable(int nbrResult,int nbrTabConvert, string formatResult)
        {
            switch (formatResult)
            {
                case BIN_TEXT:
                    tabCalcul[nbrConvCalculShow] = nbrResult;
                    tabConvert[nbrConvCalculShow] = nbrTabConvert;
                    textFormatRest = "  %  2        |    Reste ";
                    nbrConvCalculShow++;
                    break;

                case OCT_TEXT:
                    tabCalcul[nbrConvCalculShow] = nbrResult;
                    tabConvert[nbrConvCalculShow] = nbrTabConvert;
                    textFormatRest = "  %  8        |    Reste ";
                    nbrConvCalculShow++;
                    break;
            }
        }

        /// <summary>
        /// Permet d'afficher tout le calcul en entier avec chaque résultat
        /// </summary>
        public void ShowAllCalcul()
        {
            for (int nbrResultCalculShow = 0; nbrResultCalculShow < nbrConvCalculShow; nbrResultCalculShow++)
            {
                switch (nbrResultCalculShow)
                {
                    case 0:
                        lblFirstResult.Text = tabCalcul[nbrResultCalculShow] + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblFirstResult.Visible = true;
                        break;

                    case 1:
                        lblSecondResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblSecondResult.Visible = true;
                        break;

                    case 2:
                        lblThirdResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblThirdResult.Visible = true;
                        break;

                    case 3:
                        lblFourthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblFourthResult.Visible = true;
                        break;

                    case 4:
                        lblFifthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblFifthResult.Visible = true;
                        break;

                    case 5:
                        lblSixthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblSixthResult.Visible = true;
                        break;

                    case 6:
                        lblSeventhResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblSeventhResult.Visible = true;
                        break;

                    case 7:
                        lblEighthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblEighthResult.Visible = true;
                        break;

                    case 8:
                        lblNinthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblNinthResult.Visible = true;
                        break;

                    case 9:
                        lblTenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTenthResult.Visible = true;
                        break;

                    case 10:
                        lblEleventhResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblEleventhResult.Visible = true;
                        break;

                    case 11:
                        lblTwelfthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwelfthResult.Visible = true;
                        break;

                    case 12:
                        lblThirteenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblThirteenthResult.Visible = true;
                        break;

                    case 13:
                        lblFourteenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblFourteenthResult.Visible = true;
                        break;

                    case 14:
                        lblFifteenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblFifteenthResult.Visible = true;
                        break;

                    case 15:
                        lblSixteenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblSixteenthResult.Visible = true;
                        break;

                    case 16:
                        lblSeventeenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblSeventeenthResult.Visible = true;
                        break;

                    case 17:
                        lblEighteenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblEighteenthResult.Visible = true;
                        break;

                    case 18:
                        lblNineteenthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblNineteenthResult.Visible = true;
                        break;

                    case 19:
                        lblTwentiethResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentiethResult.Visible = true;
                        break;

                    case 20:
                        lblTwentyFirstResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentyFirstResult.Visible = true;
                        break;

                    case 21:
                        lblTwentySecondResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentySecondResult.Visible = true;
                        break;

                    case 22:
                        lblTwentyThirdResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentyThirdResult.Visible = true;
                        break;

                    case 23:
                        lblTwentyFourthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentyFourthResult.Visible = true;
                        break;

                    case 24:
                        lblTwentyFifthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentyFifthResult.Visible = true;
                        break;

                    case 25:
                        lblTwentySixthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentySixthResult.Visible = true;
                        break;

                    case 26:
                        lblTwentySeventhResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentySeventhResult.Visible = true;
                        break;

                    case 27:
                        lblTwentyEighthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentyEighthResult.Visible = true;
                        break;

                    case 28:
                        lblTwentyNinthResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblTwentyNinthResult.Visible = true;
                        break;

                    case 29:
                        lblThirtiethResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblThirtiethResult.Visible = true;
                        break;

                    case 30:
                        lblThirtiethFirstResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblThirtiethFirstResult.Visible = true;
                        break;

                    case 31:
                        lblThirtiethSecondResult.Text = Convert.ToString(tabCalcul[nbrResultCalculShow]) + textFormatRest + tabConvert[nbrResultCalculShow];
                        lblThirtiethSecondResult.Visible = true;
                        break;
                }
            }
        }
    }
}
