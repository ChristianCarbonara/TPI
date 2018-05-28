﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertisseur_de_bases
{
    public partial class IShowCalcul : Form
    {
        // Permet d'utiliser les switchs suivent le format choisi
        const string BIN_TEXT = "Binaire";
        const string DEC_TEXT = "Décimale";
        const string HEX_TEXT = "Héxadécimal";
        const string OCT_TEXT = "Octal";

        int[] tabCalcul = new int[33];
        int[] tabConvert = new int[33];
        int nbrConvCalculBinShow = 0;

        string textFormatRest = "";

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

        public void getTable(int nbrResult,int nbrTabConvert, string formatResult)
        {

            switch (formatResult)
            {
                case BIN_TEXT:
                    tabCalcul[nbrConvCalculBinShow] = nbrResult;
                    tabConvert[nbrConvCalculBinShow] = nbrTabConvert;
                    textFormatRest = "  %  2        |    Reste ";
                    nbrConvCalculBinShow++;
                    break;

                case OCT_TEXT:
                    tabCalcul[nbrConvCalculBinShow] = nbrResult;
                    tabConvert[nbrConvCalculBinShow] = nbrTabConvert;
                    textFormatRest = "  %  8        |    Reste ";
                    nbrConvCalculBinShow++;
                    break;
            }
        }

        
        public void showAllCalcul()
        {
            for (int nbrResultCalculShow = 0; nbrResultCalculShow < nbrConvCalculBinShow; nbrResultCalculShow++)
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