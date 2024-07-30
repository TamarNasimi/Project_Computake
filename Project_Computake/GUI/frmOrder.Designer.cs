
namespace ProjectComputers.GUI
{
    partial class frmOrder
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
            this.btnOrderOk = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxfiltering = new System.Windows.Forms.GroupBox();
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
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.rbprojectorSell = new System.Windows.Forms.RadioButton();
            this.rbComputerSell = new System.Windows.Forms.RadioButton();
            this.rbprojectorRent = new System.Windows.Forms.RadioButton();
            this.rbComputerRent = new System.Windows.Forms.RadioButton();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.lblOrderFinish = new System.Windows.Forms.Label();
            this.btnClearFiltering = new System.Windows.Forms.Button();
            this.groupBoxfiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderOk
            // 
            this.btnOrderOk.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderOk.Location = new System.Drawing.Point(483, 32);
            this.btnOrderOk.Name = "btnOrderOk";
            this.btnOrderOk.Size = new System.Drawing.Size(141, 31);
            this.btnOrderOk.TabIndex = 0;
            this.btnOrderOk.Text = "להזמנה לחץ כאן";
            this.btnOrderOk.UseVisualStyleBackColor = true;
            this.btnOrderOk.Click += new System.EventHandler(this.btnOrderOk_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1257, 792);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.groupBoxfiltering.Controls.Add(this.label4);
            this.groupBoxfiltering.Controls.Add(this.label3);
            this.groupBoxfiltering.Controls.Add(this.ColorGold);
            this.groupBoxfiltering.Controls.Add(this.ColorWhite);
            this.groupBoxfiltering.Controls.Add(this.ColorSilver);
            this.groupBoxfiltering.Controls.Add(this.ColorBlack);
            this.groupBoxfiltering.Controls.Add(this.color);
            this.groupBoxfiltering.Controls.Add(this.rbSell);
            this.groupBoxfiltering.Controls.Add(this.rbprojectorSell);
            this.groupBoxfiltering.Controls.Add(this.rbComputerSell);
            this.groupBoxfiltering.Controls.Add(this.rbprojectorRent);
            this.groupBoxfiltering.Controls.Add(this.rbComputerRent);
            this.groupBoxfiltering.Controls.Add(this.rbRent);
            this.groupBoxfiltering.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxfiltering.Location = new System.Drawing.Point(1308, 95);
            this.groupBoxfiltering.Name = "groupBoxfiltering";
            this.groupBoxfiltering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxfiltering.Size = new System.Drawing.Size(138, 643);
            this.groupBoxfiltering.TabIndex = 7;
            this.groupBoxfiltering.TabStop = false;
            this.groupBoxfiltering.Text = "סינון";
            // 
            // AcerCompany
            // 
            this.AcerCompany.AutoSize = true;
            this.AcerCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcerCompany.Location = new System.Drawing.Point(50, 536);
            this.AcerCompany.Name = "AcerCompany";
            this.AcerCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AcerCompany.Size = new System.Drawing.Size(53, 20);
            this.AcerCompany.TabIndex = 17;
            this.AcerCompany.Text = "Acer";
            this.AcerCompany.UseVisualStyleBackColor = true;
            this.AcerCompany.Visible = false;
            this.AcerCompany.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // AppleCompany
            // 
            this.AppleCompany.AutoSize = true;
            this.AppleCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppleCompany.Location = new System.Drawing.Point(42, 506);
            this.AppleCompany.Name = "AppleCompany";
            this.AppleCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AppleCompany.Size = new System.Drawing.Size(59, 20);
            this.AppleCompany.TabIndex = 16;
            this.AppleCompany.Text = "Apple";
            this.AppleCompany.UseVisualStyleBackColor = true;
            this.AppleCompany.Visible = false;
            this.AppleCompany.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // AsusCompany
            // 
            this.AsusCompany.AutoSize = true;
            this.AsusCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsusCompany.Location = new System.Drawing.Point(50, 476);
            this.AsusCompany.Name = "AsusCompany";
            this.AsusCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AsusCompany.Size = new System.Drawing.Size(54, 20);
            this.AsusCompany.TabIndex = 15;
            this.AsusCompany.Text = "Asus";
            this.AsusCompany.UseVisualStyleBackColor = true;
            this.AsusCompany.Visible = false;
            this.AsusCompany.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // DellCompany
            // 
            this.DellCompany.AutoSize = true;
            this.DellCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DellCompany.Location = new System.Drawing.Point(55, 446);
            this.DellCompany.Name = "DellCompany";
            this.DellCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DellCompany.Size = new System.Drawing.Size(48, 20);
            this.DellCompany.TabIndex = 14;
            this.DellCompany.Text = "Dell";
            this.DellCompany.UseVisualStyleBackColor = true;
            this.DellCompany.Visible = false;
            this.DellCompany.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // HPCompany
            // 
            this.HPCompany.AutoSize = true;
            this.HPCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPCompany.Location = new System.Drawing.Point(61, 416);
            this.HPCompany.Name = "HPCompany";
            this.HPCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HPCompany.Size = new System.Drawing.Size(42, 20);
            this.HPCompany.TabIndex = 13;
            this.HPCompany.Text = "HP";
            this.HPCompany.UseVisualStyleBackColor = true;
            this.HPCompany.Visible = false;
            this.HPCompany.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // LenovoCompany
            // 
            this.LenovoCompany.AutoSize = true;
            this.LenovoCompany.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LenovoCompany.Location = new System.Drawing.Point(33, 386);
            this.LenovoCompany.Name = "LenovoCompany";
            this.LenovoCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LenovoCompany.Size = new System.Drawing.Size(67, 20);
            this.LenovoCompany.TabIndex = 12;
            this.LenovoCompany.Text = "Lenovo";
            this.LenovoCompany.UseVisualStyleBackColor = true;
            this.LenovoCompany.Visible = false;
            this.LenovoCompany.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(75, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "חברות";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.ColorGold.Location = new System.Drawing.Point(62, 340);
            this.ColorGold.Name = "ColorGold";
            this.ColorGold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorGold.Size = new System.Drawing.Size(47, 22);
            this.ColorGold.TabIndex = 10;
            this.ColorGold.Text = "זהב";
            this.ColorGold.UseVisualStyleBackColor = true;
            this.ColorGold.Visible = false;
            this.ColorGold.CheckedChanged += new System.EventHandler(this.ColorGold_CheckedChanged);
            // 
            // ColorWhite
            // 
            this.ColorWhite.AutoSize = true;
            this.ColorWhite.Location = new System.Drawing.Point(65, 310);
            this.ColorWhite.Name = "ColorWhite";
            this.ColorWhite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorWhite.Size = new System.Drawing.Size(44, 22);
            this.ColorWhite.TabIndex = 9;
            this.ColorWhite.Text = "לבן";
            this.ColorWhite.UseVisualStyleBackColor = true;
            this.ColorWhite.Visible = false;
            this.ColorWhite.CheckedChanged += new System.EventHandler(this.ColorWhite_CheckedChanged);
            // 
            // ColorSilver
            // 
            this.ColorSilver.AutoSize = true;
            this.ColorSilver.Location = new System.Drawing.Point(58, 282);
            this.ColorSilver.Name = "ColorSilver";
            this.ColorSilver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorSilver.Size = new System.Drawing.Size(51, 22);
            this.ColorSilver.TabIndex = 8;
            this.ColorSilver.Text = "כסף";
            this.ColorSilver.UseVisualStyleBackColor = true;
            this.ColorSilver.Visible = false;
            this.ColorSilver.CheckedChanged += new System.EventHandler(this.ColorSilver_CheckedChanged);
            // 
            // ColorBlack
            // 
            this.ColorBlack.AutoSize = true;
            this.ColorBlack.Location = new System.Drawing.Point(53, 254);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorBlack.Size = new System.Drawing.Size(56, 22);
            this.ColorBlack.TabIndex = 7;
            this.ColorBlack.Text = "שחור";
            this.ColorBlack.UseVisualStyleBackColor = true;
            this.ColorBlack.Visible = false;
            this.ColorBlack.CheckedChanged += new System.EventHandler(this.ColorBlack_CheckedChanged_1);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.color.Location = new System.Drawing.Point(85, 224);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(31, 13);
            this.color.TabIndex = 6;
            this.color.Text = "צבע";
            this.color.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbSell
            // 
            this.rbSell.AutoSize = true;
            this.rbSell.Location = new System.Drawing.Point(59, 141);
            this.rbSell.Name = "rbSell";
            this.rbSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbSell.Size = new System.Drawing.Size(61, 22);
            this.rbSell.TabIndex = 5;
            this.rbSell.TabStop = true;
            this.rbSell.Text = "מכירה";
            this.rbSell.UseVisualStyleBackColor = true;
            this.rbSell.CheckedChanged += new System.EventHandler(this.rbSell_CheckedChanged);
            // 
            // rbprojectorSell
            // 
            this.rbprojectorSell.AutoSize = true;
            this.rbprojectorSell.Location = new System.Drawing.Point(35, 187);
            this.rbprojectorSell.Name = "rbprojectorSell";
            this.rbprojectorSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbprojectorSell.Size = new System.Drawing.Size(68, 22);
            this.rbprojectorSell.TabIndex = 4;
            this.rbprojectorSell.TabStop = true;
            this.rbprojectorSell.Text = "מקרנים";
            this.rbprojectorSell.UseVisualStyleBackColor = true;
            this.rbprojectorSell.CheckedChanged += new System.EventHandler(this.rbprojectorSell_CheckedChanged);
            // 
            // rbComputerSell
            // 
            this.rbComputerSell.AutoSize = true;
            this.rbComputerSell.Location = new System.Drawing.Point(30, 164);
            this.rbComputerSell.Name = "rbComputerSell";
            this.rbComputerSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbComputerSell.Size = new System.Drawing.Size(73, 22);
            this.rbComputerSell.TabIndex = 3;
            this.rbComputerSell.TabStop = true;
            this.rbComputerSell.Text = "מחשבים";
            this.rbComputerSell.UseVisualStyleBackColor = true;
            this.rbComputerSell.CheckedChanged += new System.EventHandler(this.rbComputerSell_CheckedChanged);
            // 
            // rbprojectorRent
            // 
            this.rbprojectorRent.AutoSize = true;
            this.rbprojectorRent.Location = new System.Drawing.Point(35, 105);
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
            this.rbComputerRent.Location = new System.Drawing.Point(30, 82);
            this.rbComputerRent.Name = "rbComputerRent";
            this.rbComputerRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbComputerRent.Size = new System.Drawing.Size(73, 22);
            this.rbComputerRent.TabIndex = 1;
            this.rbComputerRent.TabStop = true;
            this.rbComputerRent.Text = "מחשבים";
            this.rbComputerRent.UseVisualStyleBackColor = true;
            this.rbComputerRent.CheckedChanged += new System.EventHandler(this.rbComputerRent_CheckedChanged);
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.Location = new System.Drawing.Point(53, 59);
            this.rbRent.Name = "rbRent";
            this.rbRent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbRent.Size = new System.Drawing.Size(69, 22);
            this.rbRent.TabIndex = 0;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "השאלה";
            this.rbRent.UseVisualStyleBackColor = true;
            this.rbRent.CheckedChanged += new System.EventHandler(this.rbRent_CheckedChanged);
            // 
            // lblOrderFinish
            // 
            this.lblOrderFinish.AutoSize = true;
            this.lblOrderFinish.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderFinish.Location = new System.Drawing.Point(21, 34);
            this.lblOrderFinish.Name = "lblOrderFinish";
            this.lblOrderFinish.Size = new System.Drawing.Size(83, 23);
            this.lblOrderFinish.TabIndex = 8;
            this.lblOrderFinish.Text = "סיום הזמנה";
            this.lblOrderFinish.Click += new System.EventHandler(this.lblOrderFinish_Click_1);
            // 
            // btnClearFiltering
            // 
            this.btnClearFiltering.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFiltering.Location = new System.Drawing.Point(29, 587);
            this.btnClearFiltering.Name = "btnClearFiltering";
            this.btnClearFiltering.Size = new System.Drawing.Size(87, 29);
            this.btnClearFiltering.TabIndex = 18;
            this.btnClearFiltering.Text = "נקה מסננים";
            this.btnClearFiltering.UseVisualStyleBackColor = true;
            this.btnClearFiltering.Click += new System.EventHandler(this.btnClearFiltering_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 931);
            this.Controls.Add(this.lblOrderFinish);
            this.Controls.Add(this.groupBoxfiltering);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnOrderOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmOrder_Paint);
            this.groupBoxfiltering.ResumeLayout(false);
            this.groupBoxfiltering.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxfiltering;
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
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.RadioButton rbprojectorSell;
        private System.Windows.Forms.RadioButton rbComputerSell;
        private System.Windows.Forms.RadioButton rbprojectorRent;
        private System.Windows.Forms.RadioButton rbComputerRent;
        private System.Windows.Forms.RadioButton rbRent;
        private System.Windows.Forms.Label lblOrderFinish;
        private System.Windows.Forms.Button btnClearFiltering;
    }
}