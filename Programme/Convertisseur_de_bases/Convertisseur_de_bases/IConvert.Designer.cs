namespace Convertisseur_de_bases
{
    partial class frmProgram
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsddbChoseMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiModeAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModeSubtract = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsmiSigned = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSignedYes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSignedNo = new System.Windows.Forms.ToolStripMenuItem();
            this.cobListFormat = new System.Windows.Forms.ComboBox();
            this.txbValueUserBeforePoint = new System.Windows.Forms.TextBox();
            this.txbValueUserAfterPoint = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txbResultConvLeft = new System.Windows.Forms.TextBox();
            this.txbResultConvMiddle = new System.Windows.Forms.TextBox();
            this.txbResultConvRight = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResultConvertLeft = new System.Windows.Forms.Label();
            this.lblResultConvertMiddle = new System.Windows.Forms.Label();
            this.lblResultConvertRight = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();
            this.cobSign = new System.Windows.Forms.ComboBox();
            this.btnShowCalculResultLeft = new System.Windows.Forms.Button();
            this.btnShowCalculResultMiddle = new System.Windows.Forms.Button();
            this.btnShowCalculResultRight = new System.Windows.Forms.Button();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbChoseMode,
            this.tsbHelp,
            this.tsmiSigned});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(504, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsddbChoseMode
            // 
            this.tsddbChoseMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbChoseMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModeAddition,
            this.tsmiModeSubtract});
            this.tsddbChoseMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbChoseMode.Name = "tsddbChoseMode";
            this.tsddbChoseMode.Size = new System.Drawing.Size(51, 22);
            this.tsddbChoseMode.Text = "Mode";
            // 
            // tsmiModeAddition
            // 
            this.tsmiModeAddition.Name = "tsmiModeAddition";
            this.tsmiModeAddition.Size = new System.Drawing.Size(152, 22);
            this.tsmiModeAddition.Text = "Additionner";
            // 
            // tsmiModeSubtract
            // 
            this.tsmiModeSubtract.Name = "tsmiModeSubtract";
            this.tsmiModeSubtract.Size = new System.Drawing.Size(152, 22);
            this.tsmiModeSubtract.Text = "Soustraire";
            // 
            // tsbHelp
            // 
            this.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbHelp.Text = "?";
            // 
            // tsmiSigned
            // 
            this.tsmiSigned.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSignedYes,
            this.tsmiSignedNo});
            this.tsmiSigned.Name = "tsmiSigned";
            this.tsmiSigned.Size = new System.Drawing.Size(48, 25);
            this.tsmiSigned.Text = "Signé";
            // 
            // tsmiSignedYes
            // 
            this.tsmiSignedYes.Name = "tsmiSignedYes";
            this.tsmiSignedYes.Size = new System.Drawing.Size(97, 22);
            this.tsmiSignedYes.Text = "Oui";
            // 
            // tsmiSignedNo
            // 
            this.tsmiSignedNo.BackColor = System.Drawing.SystemColors.Window;
            this.tsmiSignedNo.Name = "tsmiSignedNo";
            this.tsmiSignedNo.Size = new System.Drawing.Size(97, 22);
            this.tsmiSignedNo.Text = "Non";
            // 
            // cobListFormat
            // 
            this.cobListFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobListFormat.Items.AddRange(new object[] {
            "Décimale",
            "Binaire",
            "Octal",
            "Hexadécimal"});
            this.cobListFormat.Location = new System.Drawing.Point(40, 44);
            this.cobListFormat.Name = "cobListFormat";
            this.cobListFormat.Size = new System.Drawing.Size(121, 21);
            this.cobListFormat.TabIndex = 2;
            this.cobListFormat.SelectedIndexChanged += new System.EventHandler(this.cobListFormat_SelectedIndexChanged);
            // 
            // txbValueUserBeforePoint
            // 
            this.txbValueUserBeforePoint.Location = new System.Drawing.Point(40, 71);
            this.txbValueUserBeforePoint.Name = "txbValueUserBeforePoint";
            this.txbValueUserBeforePoint.Size = new System.Drawing.Size(239, 20);
            this.txbValueUserBeforePoint.TabIndex = 3;
            this.txbValueUserBeforePoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValueUserBeforePoint.TextChanged += new System.EventHandler(this.txbValueUserBeforePoint_TextChanged);
            // 
            // txbValueUserAfterPoint
            // 
            this.txbValueUserAfterPoint.Location = new System.Drawing.Point(301, 71);
            this.txbValueUserAfterPoint.Name = "txbValueUserAfterPoint";
            this.txbValueUserAfterPoint.Size = new System.Drawing.Size(191, 20);
            this.txbValueUserAfterPoint.TabIndex = 4;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(285, 74);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(10, 13);
            this.lblPoint.TabIndex = 5;
            this.lblPoint.Text = ".";
            // 
            // txbResultConvLeft
            // 
            this.txbResultConvLeft.Location = new System.Drawing.Point(25, 138);
            this.txbResultConvLeft.Name = "txbResultConvLeft";
            this.txbResultConvLeft.ReadOnly = true;
            this.txbResultConvLeft.Size = new System.Drawing.Size(467, 20);
            this.txbResultConvLeft.TabIndex = 6;
            this.txbResultConvLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbResultConvMiddle
            // 
            this.txbResultConvMiddle.Location = new System.Drawing.Point(25, 224);
            this.txbResultConvMiddle.Name = "txbResultConvMiddle";
            this.txbResultConvMiddle.ReadOnly = true;
            this.txbResultConvMiddle.Size = new System.Drawing.Size(467, 20);
            this.txbResultConvMiddle.TabIndex = 7;
            this.txbResultConvMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbResultConvRight
            // 
            this.txbResultConvRight.Location = new System.Drawing.Point(25, 316);
            this.txbResultConvRight.Name = "txbResultConvRight";
            this.txbResultConvRight.ReadOnly = true;
            this.txbResultConvRight.Size = new System.Drawing.Size(467, 20);
            this.txbResultConvRight.TabIndex = 8;
            this.txbResultConvRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(417, 424);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResultConvertLeft
            // 
            this.lblResultConvertLeft.AutoSize = true;
            this.lblResultConvertLeft.Location = new System.Drawing.Point(22, 122);
            this.lblResultConvertLeft.Name = "lblResultConvertLeft";
            this.lblResultConvertLeft.Size = new System.Drawing.Size(85, 13);
            this.lblResultConvertLeft.TabIndex = 10;
            this.lblResultConvertLeft.Text = "Résultat gauche";
            // 
            // lblResultConvertMiddle
            // 
            this.lblResultConvertMiddle.AutoSize = true;
            this.lblResultConvertMiddle.Location = new System.Drawing.Point(22, 208);
            this.lblResultConvertMiddle.Name = "lblResultConvertMiddle";
            this.lblResultConvertMiddle.Size = new System.Drawing.Size(75, 13);
            this.lblResultConvertMiddle.TabIndex = 11;
            this.lblResultConvertMiddle.Text = "Résultat milieu";
            // 
            // lblResultConvertRight
            // 
            this.lblResultConvertRight.AutoSize = true;
            this.lblResultConvertRight.Location = new System.Drawing.Point(22, 300);
            this.lblResultConvertRight.Name = "lblResultConvertRight";
            this.lblResultConvertRight.Size = new System.Drawing.Size(75, 13);
            this.lblResultConvertRight.TabIndex = 12;
            this.lblResultConvertRight.Text = "Résultat droite";
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(22, 74);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(13, 13);
            this.lblSign.TabIndex = 13;
            this.lblSign.Text = "+";
            // 
            // cobSign
            // 
            this.cobSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSign.Items.AddRange(new object[] {
            "Positif",
            "Négatif"});
            this.cobSign.Location = new System.Drawing.Point(170, 44);
            this.cobSign.Name = "cobSign";
            this.cobSign.Size = new System.Drawing.Size(65, 21);
            this.cobSign.TabIndex = 14;
            this.cobSign.SelectedIndexChanged += new System.EventHandler(this.cobSign_SelectedIndexChanged);
            // 
            // btnShowCalculResultLeft
            // 
            this.btnShowCalculResultLeft.Location = new System.Drawing.Point(392, 164);
            this.btnShowCalculResultLeft.Name = "btnShowCalculResultLeft";
            this.btnShowCalculResultLeft.Size = new System.Drawing.Size(100, 23);
            this.btnShowCalculResultLeft.TabIndex = 15;
            this.btnShowCalculResultLeft.Text = "Montrer le calcul";
            this.btnShowCalculResultLeft.UseVisualStyleBackColor = true;
            this.btnShowCalculResultLeft.Click += new System.EventHandler(this.btnShowCalculResultLeft_Click);
            // 
            // btnShowCalculResultMiddle
            // 
            this.btnShowCalculResultMiddle.Location = new System.Drawing.Point(392, 250);
            this.btnShowCalculResultMiddle.Name = "btnShowCalculResultMiddle";
            this.btnShowCalculResultMiddle.Size = new System.Drawing.Size(100, 23);
            this.btnShowCalculResultMiddle.TabIndex = 16;
            this.btnShowCalculResultMiddle.Text = "Montrer le calcul";
            this.btnShowCalculResultMiddle.UseVisualStyleBackColor = true;
            this.btnShowCalculResultMiddle.Click += new System.EventHandler(this.btnShowCalculResultMiddle_Click);
            // 
            // btnShowCalculResultRight
            // 
            this.btnShowCalculResultRight.Location = new System.Drawing.Point(392, 342);
            this.btnShowCalculResultRight.Name = "btnShowCalculResultRight";
            this.btnShowCalculResultRight.Size = new System.Drawing.Size(100, 23);
            this.btnShowCalculResultRight.TabIndex = 17;
            this.btnShowCalculResultRight.Text = "Montrer le calcul";
            this.btnShowCalculResultRight.UseVisualStyleBackColor = true;
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 459);
            this.Controls.Add(this.btnShowCalculResultRight);
            this.Controls.Add(this.btnShowCalculResultMiddle);
            this.Controls.Add(this.btnShowCalculResultLeft);
            this.Controls.Add(this.cobSign);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.lblResultConvertRight);
            this.Controls.Add(this.lblResultConvertMiddle);
            this.Controls.Add(this.lblResultConvertLeft);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txbResultConvRight);
            this.Controls.Add(this.txbResultConvMiddle);
            this.Controls.Add(this.txbResultConvLeft);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.txbValueUserAfterPoint);
            this.Controls.Add(this.txbValueUserBeforePoint);
            this.Controls.Add(this.cobListFormat);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertisseur de bases";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.TextBox txbValueUserBeforePoint;
        private System.Windows.Forms.TextBox txbValueUserAfterPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txbResultConvLeft;
        private System.Windows.Forms.TextBox txbResultConvMiddle;
        private System.Windows.Forms.TextBox txbResultConvRight;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ToolStripDropDownButton tsddbChoseMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiModeAddition;
        private System.Windows.Forms.ToolStripMenuItem tsmiModeSubtract;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.Label lblResultConvertLeft;
        private System.Windows.Forms.Label lblResultConvertMiddle;
        protected internal System.Windows.Forms.ComboBox cobListFormat;
        private System.Windows.Forms.Label lblResultConvertRight;
        private System.Windows.Forms.Label lblSign;
        protected internal System.Windows.Forms.ComboBox cobSign;
        private System.Windows.Forms.Button btnShowCalculResultLeft;
        private System.Windows.Forms.Button btnShowCalculResultMiddle;
        private System.Windows.Forms.Button btnShowCalculResultRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiSigned;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignedYes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignedNo;
    }
}

