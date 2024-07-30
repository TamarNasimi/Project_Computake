
namespace ProjectComputers.GUI
{
    partial class frmAllProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAllProduct = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.עדכןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchNamePro = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBoxfiltering = new System.Windows.Forms.GroupBox();
            this.btnClearFiltering = new System.Windows.Forms.Button();
            this.AcerCompany = new System.Windows.Forms.CheckBox();
            this.AppleCompany = new System.Windows.Forms.CheckBox();
            this.AsusCompany = new System.Windows.Forms.CheckBox();
            this.DellCompany = new System.Windows.Forms.CheckBox();
            this.HPCompany = new System.Windows.Forms.CheckBox();
            this.LenovoCompany = new System.Windows.Forms.CheckBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorGold = new System.Windows.Forms.CheckBox();
            this.ColorWhite = new System.Windows.Forms.CheckBox();
            this.ColorSilver = new System.Windows.Forms.CheckBox();
            this.ColorBlack = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.rbprojectorSell = new System.Windows.Forms.RadioButton();
            this.rbComputerSell = new System.Windows.Forms.RadioButton();
            this.rbprojectorRent = new System.Windows.Forms.RadioButton();
            this.rbComputerRent = new System.Windows.Forms.RadioButton();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxfiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllProduct
            // 
            this.dgvAllProduct.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProduct.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllProduct.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAllProduct.Location = new System.Drawing.Point(278, 96);
            this.dgvAllProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllProduct.Name = "dgvAllProduct";
            this.dgvAllProduct.Size = new System.Drawing.Size(827, 593);
            this.dgvAllProduct.TabIndex = 0;
            this.dgvAllProduct.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllProduct_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.עדכןToolStripMenuItem,
            this.מחקToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // עדכןToolStripMenuItem
            // 
            this.עדכןToolStripMenuItem.Name = "עדכןToolStripMenuItem";
            this.עדכןToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.עדכןToolStripMenuItem.Text = "עדכן";
            this.עדכןToolStripMenuItem.Click += new System.EventHandler(this.עדכןToolStripMenuItem_Click);
            // 
            // מחקToolStripMenuItem
            // 
            this.מחקToolStripMenuItem.Name = "מחקToolStripMenuItem";
            this.מחקToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.מחקToolStripMenuItem.Text = "מחק";
            this.מחקToolStripMenuItem.Click += new System.EventHandler(this.מחקToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchNamePro);
            this.groupBox1.Location = new System.Drawing.Point(25, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(229, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "חיפוש";
            // 
            // btnDelSearch
            // 
            this.btnDelSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelSearch.Location = new System.Drawing.Point(59, 82);
            this.btnDelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelSearch.Name = "btnDelSearch";
            this.btnDelSearch.Size = new System.Drawing.Size(82, 31);
            this.btnDelSearch.TabIndex = 2;
            this.btnDelSearch.Text = "נקה";
            this.btnDelSearch.UseVisualStyleBackColor = false;
            this.btnDelSearch.Click += new System.EventHandler(this.btnDelSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = ":הקש שם מוצר";
            // 
            // txtSearchNamePro
            // 
            this.txtSearchNamePro.Location = new System.Drawing.Point(20, 31);
            this.txtSearchNamePro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchNamePro.Name = "txtSearchNamePro";
            this.txtSearchNamePro.Size = new System.Drawing.Size(116, 22);
            this.txtSearchNamePro.TabIndex = 0;
            this.txtSearchNamePro.TextChanged += new System.EventHandler(this.txtSearchNamePro_TextChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddProduct.Location = new System.Drawing.Point(85, 161);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(93, 31);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "הוסף פריט";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnView.Location = new System.Drawing.Point(612, 59);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(96, 32);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "הצג מוצרים";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBoxfiltering
            // 
            this.groupBoxfiltering.Controls.Add(this.btnClearFiltering);
            this.groupBoxfiltering.Controls.Add(this.AcerCompany);
            this.groupBoxfiltering.Controls.Add(this.AppleCompany);
            this.groupBoxfiltering.Controls.Add(this.AsusCompany);
            this.groupBoxfiltering.Controls.Add(this.DellCompany);
            this.groupBoxfiltering.Controls.Add(this.HPCompany);
            this.groupBoxfiltering.Controls.Add(this.LenovoCompany);
            this.groupBoxfiltering.Controls.Add(this.lblCompany);
            this.groupBoxfiltering.Controls.Add(this.label3);
            this.groupBoxfiltering.Controls.Add(this.ColorGold);
            this.groupBoxfiltering.Controls.Add(this.ColorWhite);
            this.groupBoxfiltering.Controls.Add(this.ColorSilver);
            this.groupBoxfiltering.Controls.Add(this.ColorBlack);
            this.groupBoxfiltering.Controls.Add(this.label2);
            this.groupBoxfiltering.Controls.Add(this.rbSell);
            this.groupBoxfiltering.Controls.Add(this.rbprojectorSell);
            this.groupBoxfiltering.Controls.Add(this.rbComputerSell);
            this.groupBoxfiltering.Controls.Add(this.rbprojectorRent);
            this.groupBoxfiltering.Controls.Add(this.rbComputerRent);
            this.groupBoxfiltering.Controls.Add(this.rbRent);
            this.groupBoxfiltering.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxfiltering.Location = new System.Drawing.Point(1125, 59);
            this.groupBoxfiltering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxfiltering.Name = "groupBoxfiltering";
            this.groupBoxfiltering.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxfiltering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxfiltering.Size = new System.Drawing.Size(146, 626);
            this.groupBoxfiltering.TabIndex = 6;
            this.groupBoxfiltering.TabStop = false;
            this.groupBoxfiltering.Text = "סינון";
            // 
            // btnClearFiltering
            // 
            this.btnClearFiltering.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClearFiltering.Location = new System.Drawing.Point(37, 582);
            this.btnClearFiltering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFiltering.Name = "btnClearFiltering";
            this.btnClearFiltering.Size = new System.Drawing.Size(87, 28);
            this.btnClearFiltering.TabIndex = 18;
            this.btnClearFiltering.Text = "נקה מסננים";
            this.btnClearFiltering.UseVisualStyleBackColor = false;
            this.btnClearFiltering.Click += new System.EventHandler(this.btnClearFiltering_Click);
            // 
            // AcerCompany
            // 
            this.AcerCompany.AutoSize = true;
            this.AcerCompany.Location = new System.Drawing.Point(60, 545);
            this.AcerCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcerCompany.Name = "AcerCompany";
            this.AcerCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AcerCompany.Size = new System.Drawing.Size(54, 21);
            this.AcerCompany.TabIndex = 17;
            this.AcerCompany.Text = "Acer";
            this.AcerCompany.UseVisualStyleBackColor = true;
            this.AcerCompany.CheckedChanged += new System.EventHandler(this.AcerCompany_CheckedChanged);
            // 
            // AppleCompany
            // 
            this.AppleCompany.AutoSize = true;
            this.AppleCompany.Location = new System.Drawing.Point(54, 517);
            this.AppleCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppleCompany.Name = "AppleCompany";
            this.AppleCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AppleCompany.Size = new System.Drawing.Size(60, 21);
            this.AppleCompany.TabIndex = 16;
            this.AppleCompany.Text = "Apple";
            this.AppleCompany.UseVisualStyleBackColor = true;
            this.AppleCompany.CheckedChanged += new System.EventHandler(this.AppleCompany_CheckedChanged);
            // 
            // AsusCompany
            // 
            this.AsusCompany.AutoSize = true;
            this.AsusCompany.Location = new System.Drawing.Point(60, 491);
            this.AsusCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AsusCompany.Name = "AsusCompany";
            this.AsusCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AsusCompany.Size = new System.Drawing.Size(55, 21);
            this.AsusCompany.TabIndex = 15;
            this.AsusCompany.Text = "Asus";
            this.AsusCompany.UseVisualStyleBackColor = true;
            this.AsusCompany.CheckedChanged += new System.EventHandler(this.AsusCompany_CheckedChanged);
            // 
            // DellCompany
            // 
            this.DellCompany.AutoSize = true;
            this.DellCompany.Location = new System.Drawing.Point(66, 462);
            this.DellCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DellCompany.Name = "DellCompany";
            this.DellCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DellCompany.Size = new System.Drawing.Size(49, 21);
            this.DellCompany.TabIndex = 14;
            this.DellCompany.Text = "Dell";
            this.DellCompany.UseVisualStyleBackColor = true;
            this.DellCompany.CheckedChanged += new System.EventHandler(this.DellCompany_CheckedChanged);
            // 
            // HPCompany
            // 
            this.HPCompany.AutoSize = true;
            this.HPCompany.Location = new System.Drawing.Point(71, 439);
            this.HPCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HPCompany.Name = "HPCompany";
            this.HPCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HPCompany.Size = new System.Drawing.Size(43, 21);
            this.HPCompany.TabIndex = 13;
            this.HPCompany.Text = "HP";
            this.HPCompany.UseVisualStyleBackColor = true;
            this.HPCompany.CheckedChanged += new System.EventHandler(this.HPCompany_CheckedChanged);
            // 
            // LenovoCompany
            // 
            this.LenovoCompany.AutoSize = true;
            this.LenovoCompany.Location = new System.Drawing.Point(45, 410);
            this.LenovoCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LenovoCompany.Name = "LenovoCompany";
            this.LenovoCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LenovoCompany.Size = new System.Drawing.Size(69, 21);
            this.LenovoCompany.TabIndex = 12;
            this.LenovoCompany.Text = "Lenovo";
            this.LenovoCompany.UseVisualStyleBackColor = true;
            this.LenovoCompany.CheckedChanged += new System.EventHandler(this.LenovoCompany_CheckedChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCompany.Location = new System.Drawing.Point(84, 387);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(44, 13);
            this.lblCompany.TabIndex = 7;
            this.lblCompany.Text = "חברות";
            this.lblCompany.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(72, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "קטגוריה";
            // 
            // ColorGold
            // 
            this.ColorGold.AutoSize = true;
            this.ColorGold.Location = new System.Drawing.Point(64, 354);
            this.ColorGold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorGold.Name = "ColorGold";
            this.ColorGold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorGold.Size = new System.Drawing.Size(46, 21);
            this.ColorGold.TabIndex = 10;
            this.ColorGold.Text = "זהב";
            this.ColorGold.UseVisualStyleBackColor = true;
            this.ColorGold.CheckedChanged += new System.EventHandler(this.ColorGold_CheckedChanged);
            // 
            // ColorWhite
            // 
            this.ColorWhite.AutoSize = true;
            this.ColorWhite.Location = new System.Drawing.Point(66, 325);
            this.ColorWhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorWhite.Name = "ColorWhite";
            this.ColorWhite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorWhite.Size = new System.Drawing.Size(44, 21);
            this.ColorWhite.TabIndex = 9;
            this.ColorWhite.Text = "לבן";
            this.ColorWhite.UseVisualStyleBackColor = true;
            this.ColorWhite.CheckedChanged += new System.EventHandler(this.ColorWhite_CheckedChanged);
            // 
            // ColorSilver
            // 
            this.ColorSilver.AutoSize = true;
            this.ColorSilver.Location = new System.Drawing.Point(62, 296);
            this.ColorSilver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorSilver.Name = "ColorSilver";
            this.ColorSilver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorSilver.Size = new System.Drawing.Size(49, 21);
            this.ColorSilver.TabIndex = 8;
            this.ColorSilver.Text = "כסף";
            this.ColorSilver.UseVisualStyleBackColor = true;
            this.ColorSilver.CheckedChanged += new System.EventHandler(this.ColorSilver_CheckedChanged);
            // 
            // ColorBlack
            // 
            this.ColorBlack.AutoSize = true;
            this.ColorBlack.Location = new System.Drawing.Point(57, 267);
            this.ColorBlack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorBlack.Size = new System.Drawing.Size(54, 21);
            this.ColorBlack.TabIndex = 7;
            this.ColorBlack.Text = "שחור";
            this.ColorBlack.UseVisualStyleBackColor = true;
            this.ColorBlack.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(99, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "צבע";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbSell
            // 
            this.rbSell.AutoSize = true;
            this.rbSell.Location = new System.Drawing.Point(69, 160);
            this.rbSell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSell.Name = "rbSell";
            this.rbSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbSell.Size = new System.Drawing.Size(59, 21);
            this.rbSell.TabIndex = 5;
            this.rbSell.TabStop = true;
            this.rbSell.Text = "מכירה";
            this.rbSell.UseVisualStyleBackColor = true;
            this.rbSell.CheckedChanged += new System.EventHandler(this.rbSell_CheckedChanged);
            // 
            // rbprojectorSell
            // 
            this.rbprojectorSell.AutoSize = true;
            this.rbprojectorSell.Location = new System.Drawing.Point(41, 216);
            this.rbprojectorSell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbprojectorSell.Name = "rbprojectorSell";
            this.rbprojectorSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbprojectorSell.Size = new System.Drawing.Size(65, 21);
            this.rbprojectorSell.TabIndex = 4;
            this.rbprojectorSell.TabStop = true;
            this.rbprojectorSell.Text = "מקרנים";
            this.rbprojectorSell.UseVisualStyleBackColor = true;
            this.rbprojectorSell.CheckedChanged += new System.EventHandler(this.rbprojectorSell_CheckedChanged);
            // 
            // rbComputerSell
            // 
            this.rbComputerSell.AutoSize = true;
            this.rbComputerSell.Location = new System.Drawing.Point(35, 188);
            this.rbComputerSell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbComputerSell.Name = "rbComputerSell";
            this.rbComputerSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbComputerSell.Size = new System.Drawing.Size(69, 21);
            this.rbComputerSell.TabIndex = 3;
            this.rbComputerSell.TabStop = true;
            this.rbComputerSell.Text = "מחשבים";
            this.rbComputerSell.UseVisualStyleBackColor = true;
            this.rbComputerSell.CheckedChanged += new System.EventHandler(this.rbComputerSell_CheckedChanged);
            // 
            // rbprojectorRent
            // 
            this.rbprojectorRent.AutoSize = true;
            this.rbprojectorRent.Location = new System.Drawing.Point(41, 129);
            this.rbprojectorRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbprojectorRent.Name = "rbprojectorRent";
            this.rbprojectorRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbprojectorRent.Size = new System.Drawing.Size(65, 21);
            this.rbprojectorRent.TabIndex = 2;
            this.rbprojectorRent.TabStop = true;
            this.rbprojectorRent.Text = "מקרנים";
            this.rbprojectorRent.UseVisualStyleBackColor = true;
            this.rbprojectorRent.CheckedChanged += new System.EventHandler(this.rbprojectorRent_CheckedChanged);
            // 
            // rbComputerRent
            // 
            this.rbComputerRent.AutoSize = true;
            this.rbComputerRent.Location = new System.Drawing.Point(37, 102);
            this.rbComputerRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbComputerRent.Name = "rbComputerRent";
            this.rbComputerRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbComputerRent.Size = new System.Drawing.Size(69, 21);
            this.rbComputerRent.TabIndex = 1;
            this.rbComputerRent.TabStop = true;
            this.rbComputerRent.Text = "מחשבים";
            this.rbComputerRent.UseVisualStyleBackColor = true;
            this.rbComputerRent.CheckedChanged += new System.EventHandler(this.rbComputerRent_CheckedChanged);
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.Location = new System.Drawing.Point(62, 73);
            this.rbRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRent.Name = "rbRent";
            this.rbRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbRent.Size = new System.Drawing.Size(66, 21);
            this.rbRent.TabIndex = 0;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "השאלה";
            this.rbRent.UseVisualStyleBackColor = true;
            this.rbRent.CheckedChanged += new System.EventHandler(this.rbRent_CheckedChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Underline);
            this.linkLabel2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.Location = new System.Drawing.Point(21, 23);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(145, 23);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "חזרה לתפריט הראשי";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmAllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1280, 698);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.groupBoxfiltering);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvAllProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAllProduct";
            this.Text = "הצג מוצרים";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxfiltering.ResumeLayout(false);
            this.groupBoxfiltering.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchNamePro;
        private System.Windows.Forms.Button btnDelSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBoxfiltering;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.RadioButton rbprojectorSell;
        private System.Windows.Forms.RadioButton rbComputerSell;
        private System.Windows.Forms.RadioButton rbprojectorRent;
        private System.Windows.Forms.RadioButton rbComputerRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ColorGold;
        private System.Windows.Forms.CheckBox ColorWhite;
        private System.Windows.Forms.CheckBox ColorSilver;
        private System.Windows.Forms.CheckBox ColorBlack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AcerCompany;
        private System.Windows.Forms.CheckBox AppleCompany;
        private System.Windows.Forms.CheckBox AsusCompany;
        private System.Windows.Forms.CheckBox DellCompany;
        private System.Windows.Forms.CheckBox HPCompany;
        private System.Windows.Forms.CheckBox LenovoCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnClearFiltering;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem עדכןToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbRent;
    }
}