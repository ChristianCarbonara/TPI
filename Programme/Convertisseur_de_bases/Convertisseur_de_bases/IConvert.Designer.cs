namespace Convertisseur_de_bases
{
    partial class fntProgram
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
            this.cobListFormat = new System.Windows.Forms.ComboBox();
            this.txbValueUserBeforPoint = new System.Windows.Forms.TextBox();
            this.txbValueUserAfterPoint = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txbResultConvLeft = new System.Windows.Forms.TextBox();
            this.txbResultConvMiddle = new System.Windows.Forms.TextBox();
            this.txbResultConvRight = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tsddbChoseMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiModeAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModeSubtract = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbChoseMode,
            this.tsddbOptions,
            this.tsbHelp});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(449, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // cobListFormat
            // 
            this.cobListFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobListFormat.Items.AddRange(new object[] {
            "Décimale",
            "Binaire",
            "Octal",
            "Hexadécimal"});
            this.cobListFormat.Location = new System.Drawing.Point(158, 91);
            this.cobListFormat.Name = "cobListFormat";
            this.cobListFormat.Size = new System.Drawing.Size(121, 21);
            this.cobListFormat.TabIndex = 2;
            this.cobListFormat.SelectedIndexChanged += new System.EventHandler(this.cobListFormat_SelectedIndexChanged);
            // 
            // txbValueUserBeforPoint
            // 
            this.txbValueUserBeforPoint.Location = new System.Drawing.Point(107, 118);
            this.txbValueUserBeforPoint.Name = "txbValueUserBeforPoint";
            this.txbValueUserBeforPoint.Size = new System.Drawing.Size(100, 20);
            this.txbValueUserBeforPoint.TabIndex = 3;
            this.txbValueUserBeforPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValueUserBeforPoint.TextChanged += new System.EventHandler(this.txbValueUserBeforPoint_TextChanged);
            // 
            // txbValueUserAfterPoint
            // 
            this.txbValueUserAfterPoint.Location = new System.Drawing.Point(225, 118);
            this.txbValueUserAfterPoint.Name = "txbValueUserAfterPoint";
            this.txbValueUserAfterPoint.Size = new System.Drawing.Size(100, 20);
            this.txbValueUserAfterPoint.TabIndex = 4;
            this.txbValueUserAfterPoint.TextChanged += new System.EventHandler(this.txbValueUserAfterPoint_TextChanged);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(212, 123);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(10, 13);
            this.lblPoint.TabIndex = 5;
            this.lblPoint.Text = ".";
            // 
            // txbResultConvLeft
            // 
            this.txbResultConvLeft.Location = new System.Drawing.Point(25, 204);
            this.txbResultConvLeft.Name = "txbResultConvLeft";
            this.txbResultConvLeft.ReadOnly = true;
            this.txbResultConvLeft.Size = new System.Drawing.Size(100, 20);
            this.txbResultConvLeft.TabIndex = 6;
            this.txbResultConvLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbResultConvMiddle
            // 
            this.txbResultConvMiddle.Location = new System.Drawing.Point(168, 204);
            this.txbResultConvMiddle.Name = "txbResultConvMiddle";
            this.txbResultConvMiddle.ReadOnly = true;
            this.txbResultConvMiddle.Size = new System.Drawing.Size(100, 20);
            this.txbResultConvMiddle.TabIndex = 7;
            this.txbResultConvMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbResultConvRight
            // 
            this.txbResultConvRight.Location = new System.Drawing.Point(322, 204);
            this.txbResultConvRight.Name = "txbResultConvRight";
            this.txbResultConvRight.ReadOnly = true;
            this.txbResultConvRight.Size = new System.Drawing.Size(100, 20);
            this.txbResultConvRight.TabIndex = 8;
            this.txbResultConvRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(347, 289);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
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
            // tsddbOptions
            // 
            this.tsddbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbOptions.Name = "tsddbOptions";
            this.tsddbOptions.Size = new System.Drawing.Size(62, 22);
            this.tsddbOptions.Text = "Options";
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
            // fntProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 333);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txbResultConvRight);
            this.Controls.Add(this.txbResultConvMiddle);
            this.Controls.Add(this.txbResultConvLeft);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.txbValueUserAfterPoint);
            this.Controls.Add(this.txbValueUserBeforPoint);
            this.Controls.Add(this.cobListFormat);
            this.Controls.Add(this.tsMenu);
            this.Name = "fntProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertisseur de bases";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.TextBox txbValueUserBeforPoint;
        private System.Windows.Forms.TextBox txbValueUserAfterPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.ComboBox cobListFormat;
        private System.Windows.Forms.TextBox txbResultConvLeft;
        private System.Windows.Forms.TextBox txbResultConvMiddle;
        private System.Windows.Forms.TextBox txbResultConvRight;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ToolStripDropDownButton tsddbChoseMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiModeAddition;
        private System.Windows.Forms.ToolStripMenuItem tsmiModeSubtract;
        private System.Windows.Forms.ToolStripDropDownButton tsddbOptions;
        private System.Windows.Forms.ToolStripButton tsbHelp;
    }
}

