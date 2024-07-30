
namespace ProjectComputers.GUI
{
    partial class frmOrderBorrow
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxfiltering = new System.Windows.Forms.GroupBox();
            this.btnClearFiltering = new System.Windows.Forms.Button();
            this.AcerCompany = new System.Windows.Forms.CheckBox();
            this.AppleCompany = new System.Windows.Forms.CheckBox();
            this.AsusCompany = new System.Windows.Forms.CheckBox();
            this.DellCompany = new System.Windows.Forms.CheckBox();
            this.HPCompany = new System.Windows.Forms.CheckBox();
            this.LenovoCompany = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorGold = new System.Windows.Forms.CheckBox();
            this.ColorWhite = new System.Windows.Forms.CheckBox();
            this.ColorSilver = new System.Windows.Forms.CheckBox();
            this.ColorBlack = new System.Windows.Forms.CheckBox();
            this.color = new System.Windows.Forms.Label();
            this.rbprojectorRent = new System.Windows.Forms.RadioButton();
            this.rbComputerRent = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxfiltering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Underline);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(-23, -22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 23);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "סיום הזמנה";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1244, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 25);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "לחיפוש הקש שם מוצר";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxfiltering
            // 
            this.groupBoxfiltering.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxfiltering.Controls.Add(this.btnClearFiltering);
            this.groupBoxfiltering.Controls.Add(this.AcerCompany);
            this.groupBoxfiltering.Controls.Add(this.AppleCompany);
            this.groupBoxfiltering.Controls.Add(this.AsusCompany);
            this.groupBoxfiltering.Controls.Add(this.DellCompany);
            this.groupBoxfiltering.Controls.Add(this.HPCompany);
            this.groupBoxfiltering.Controls.Add(this.LenovoCompany);
            this.groupBoxfiltering.Controls.Add(this.label4);
            this.groupBoxfiltering.Controls.Add(this.label3);
            this.groupBoxfiltering.Controls.Add(this.ColorGold);
            this.groupBoxfiltering.Controls.Add(this.ColorWhite);
            this.groupBoxfiltering.Controls.Add(this.ColorSilver);
            this.groupBoxfiltering.Controls.Add(this.ColorBlack);
            this.groupBoxfiltering.Controls.Add(this.color);
            this.groupBoxfiltering.Controls.Add(this.rbprojectorRent);
            this.groupBoxfiltering.Controls.Add(this.rbComputerRent);
            this.groupBoxfiltering.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxfiltering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxfiltering.Location = new System.Drawing.Point(1305, 88);
            this.groupBoxfiltering.Name = "groupBoxfiltering";
            this.groupBoxfiltering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxfiltering.Size = new System.Drawing.Size(127, 565);
            this.groupBoxfiltering.TabIndex = 15;
            this.groupBoxfiltering.TabStop = false;
            // 
            // btnClearFiltering
            // 
            this.btnClearFiltering.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClearFiltering.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFiltering.Location = new System.Drawing.Point(25, 488);
            this.btnClearFiltering.Name = "btnClearFiltering";
            this.btnClearFiltering.Size = new System.Drawing.Size(87, 29);
            this.btnClearFiltering.TabIndex = 18;
            this.btnClearFiltering.Text = "נקה מסננים";
            this.btnClearFiltering.UseVisualStyleBackColor = false;
            this.btnClearFiltering.Click += new System.EventHandler(this.btnClearFiltering_Click);
            // 
            // AcerCompany
            // 
            this.AcerCompany.AutoSize = true;
            this.AcerCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcerCompany.Location = new System.Drawing.Point(51, 433);
            this.AcerCompany.Name = "AcerCompany";
            this.AcerCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AcerCompany.Size = new System.Drawing.Size(53, 20);
            this.AcerCompany.TabIndex = 17;
            this.AcerCompany.Text = "Acer";
            this.AcerCompany.UseVisualStyleBackColor = true;
            this.AcerCompany.CheckedChanged += new System.EventHandler(this.AcerCompany_CheckedChanged);
            // 
            // AppleCompany
            // 
            this.AppleCompany.AutoSize = true;
            this.AppleCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppleCompany.Location = new System.Drawing.Point(45, 407);
            this.AppleCompany.Name = "AppleCompany";
            this.AppleCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AppleCompany.Size = new System.Drawing.Size(59, 20);
            this.AppleCompany.TabIndex = 16;
            this.AppleCompany.Text = "Apple";
            this.AppleCompany.UseVisualStyleBackColor = true;
            this.AppleCompany.CheckedChanged += new System.EventHandler(this.AppleCompany_CheckedChanged);
            // 
            // AsusCompany
            // 
            this.AsusCompany.AutoSize = true;
            this.AsusCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsusCompany.Location = new System.Drawing.Point(50, 378);
            this.AsusCompany.Name = "AsusCompany";
            this.AsusCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AsusCompany.Size = new System.Drawing.Size(54, 20);
            this.AsusCompany.TabIndex = 15;
            this.AsusCompany.Text = "Asus";
            this.AsusCompany.UseVisualStyleBackColor = true;
            this.AsusCompany.CheckedChanged += new System.EventHandler(this.AsusCompany_CheckedChanged);
            // 
            // DellCompany
            // 
            this.DellCompany.AutoSize = true;
            this.DellCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DellCompany.Location = new System.Drawing.Point(56, 352);
            this.DellCompany.Name = "DellCompany";
            this.DellCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DellCompany.Size = new System.Drawing.Size(48, 20);
            this.DellCompany.TabIndex = 14;
            this.DellCompany.Text = "Dell";
            this.DellCompany.UseVisualStyleBackColor = true;
            this.DellCompany.CheckedChanged += new System.EventHandler(this.DellCompany_CheckedChanged);
            // 
            // HPCompany
            // 
            this.HPCompany.AutoSize = true;
            this.HPCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPCompany.Location = new System.Drawing.Point(62, 326);
            this.HPCompany.Name = "HPCompany";
            this.HPCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HPCompany.Size = new System.Drawing.Size(42, 20);
            this.HPCompany.TabIndex = 13;
            this.HPCompany.Text = "HP";
            this.HPCompany.UseVisualStyleBackColor = true;
            this.HPCompany.CheckedChanged += new System.EventHandler(this.HPCompany_CheckedChanged);
            // 
            // LenovoCompany
            // 
            this.LenovoCompany.AutoSize = true;
            this.LenovoCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LenovoCompany.Location = new System.Drawing.Point(37, 300);
            this.LenovoCompany.Name = "LenovoCompany";
            this.LenovoCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LenovoCompany.Size = new System.Drawing.Size(67, 20);
            this.LenovoCompany.TabIndex = 12;
            this.LenovoCompany.Text = "Lenovo";
            this.LenovoCompany.UseVisualStyleBackColor = true;
            this.LenovoCompany.CheckedChanged += new System.EventHandler(this.LenovoCompany_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(75, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "חברות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(62, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "קטגוריה";
            // 
            // ColorGold
            // 
            this.ColorGold.AutoSize = true;
            this.ColorGold.Location = new System.Drawing.Point(62, 237);
            this.ColorGold.Name = "ColorGold";
            this.ColorGold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorGold.Size = new System.Drawing.Size(47, 22);
            this.ColorGold.TabIndex = 10;
            this.ColorGold.Text = "זהב";
            this.ColorGold.UseVisualStyleBackColor = true;
            this.ColorGold.CheckedChanged += new System.EventHandler(this.ColorGold_CheckedChanged);
            // 
            // ColorWhite
            // 
            this.ColorWhite.AutoSize = true;
            this.ColorWhite.Location = new System.Drawing.Point(65, 207);
            this.ColorWhite.Name = "ColorWhite";
            this.ColorWhite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorWhite.Size = new System.Drawing.Size(44, 22);
            this.ColorWhite.TabIndex = 9;
            this.ColorWhite.Text = "לבן";
            this.ColorWhite.UseVisualStyleBackColor = true;
            this.ColorWhite.CheckedChanged += new System.EventHandler(this.ColorWhite_CheckedChanged);
            // 
            // ColorSilver
            // 
            this.ColorSilver.AutoSize = true;
            this.ColorSilver.Location = new System.Drawing.Point(58, 179);
            this.ColorSilver.Name = "ColorSilver";
            this.ColorSilver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorSilver.Size = new System.Drawing.Size(51, 22);
            this.ColorSilver.TabIndex = 8;
            this.ColorSilver.Text = "כסף";
            this.ColorSilver.UseVisualStyleBackColor = true;
            this.ColorSilver.CheckedChanged += new System.EventHandler(this.ColorSilver_CheckedChanged);
            // 
            // ColorBlack
            // 
            this.ColorBlack.AutoSize = true;
            this.ColorBlack.Location = new System.Drawing.Point(53, 151);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorBlack.Size = new System.Drawing.Size(56, 22);
            this.ColorBlack.TabIndex = 7;
            this.ColorBlack.Text = "שחור";
            this.ColorBlack.UseVisualStyleBackColor = true;
            this.ColorBlack.CheckedChanged += new System.EventHandler(this.ColorBlack_CheckedChanged);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.color.Location = new System.Drawing.Point(85, 121);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(31, 13);
            this.color.TabIndex = 6;
            this.color.Text = "צבע";
            // 
            // rbprojectorRent
            // 
            this.rbprojectorRent.AutoSize = true;
            this.rbprojectorRent.Location = new System.Drawing.Point(35, 84);
            this.rbprojectorRent.Name = "rbprojectorRent";
            this.rbprojectorRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbprojectorRent.Size = new System.Drawing.Size(68, 22);
            this.rbprojectorRent.TabIndex = 2;
            this.rbprojectorRent.TabStop = true;
            this.rbprojectorRent.Text = "מקרנים";
            this.rbprojectorRent.UseVisualStyleBackColor = true;
            this.rbprojectorRent.CheckedChanged += new System.EventHandler(this.rbprojectorRent_CheckedChanged);
            // 
            // rbComputerRent
            // 
            this.rbComputerRent.AutoSize = true;
            this.rbComputerRent.Location = new System.Drawing.Point(30, 61);
            this.rbComputerRent.Name = "rbComputerRent";
            this.rbComputerRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbComputerRent.Size = new System.Drawing.Size(73, 22);
            this.rbComputerRent.TabIndex = 1;
            this.rbComputerRent.TabStop = true;
            this.rbComputerRent.Text = "מחשבים";
            this.rbComputerRent.UseVisualStyleBackColor = true;
            this.rbComputerRent.CheckedChanged += new System.EventHandler(this.rbComputerRent_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(965, 632);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = ":הזמנה מספר";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1016, 100);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(270, 630);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjectComputers.Properties.Resources.search1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1384, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Underline);
            this.linkLabel2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.Location = new System.Drawing.Point(204, 29);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(145, 23);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "חזרה לתפריט הראשי";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.White;
            this.linkLabel3.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Underline);
            this.linkLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel3.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel3.Location = new System.Drawing.Point(204, 55);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(83, 23);
            this.linkLabel3.TabIndex = 23;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "סיום הזמנה";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "שים לב! השאלת מוצרים מחייבת השארת פיקדון";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProjectComputers.Properties.Resources._100;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 110);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // frmOrderBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1448, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBoxfiltering);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmOrderBorrow";
            this.Text = "השאלה חדשה";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderBorrow_FormClosing);
            this.groupBoxfiltering.ResumeLayout(false);
            this.groupBoxfiltering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxfiltering;
        private System.Windows.Forms.Button btnClearFiltering;
        private System.Windows.Forms.CheckBox AcerCompany;
        private System.Windows.Forms.CheckBox AppleCompany;
        private System.Windows.Forms.CheckBox AsusCompany;
        private System.Windows.Forms.CheckBox DellCompany;
        private System.Windows.Forms.CheckBox HPCompany;
        private System.Windows.Forms.CheckBox LenovoCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ColorGold;
        private System.Windows.Forms.CheckBox ColorWhite;
        private System.Windows.Forms.CheckBox ColorSilver;
        private System.Windows.Forms.CheckBox ColorBlack;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.RadioButton rbprojectorRent;
        private System.Windows.Forms.RadioButton rbComputerRent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}