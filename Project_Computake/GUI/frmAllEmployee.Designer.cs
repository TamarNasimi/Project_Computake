
namespace ProjectComputers.GUI
{
    partial class frmAllEmployee
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
            this.dgvAllEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelate = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddEm = new System.Windows.Forms.Button();
            this.btnVeiw = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.עדכןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllEmployee
            // 
            this.dgvAllEmployee.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvAllEmployee.ColumnHeadersHeight = 25;
            this.dgvAllEmployee.Location = new System.Drawing.Point(14, 126);
            this.dgvAllEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllEmployee.Name = "dgvAllEmployee";
            this.dgvAllEmployee.Size = new System.Drawing.Size(630, 386);
            this.dgvAllEmployee.TabIndex = 0;
            this.dgvAllEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllEmployee_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDelate);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(671, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(214, 279);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "חיפוש";
            this.groupBox1.Visible = false;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(23, 100);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(126, 22);
            this.txtCity.TabIndex = 8;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "עיר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "טלפון";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "שם";
            // 
            // btnDelate
            // 
            this.btnDelate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelate.Location = new System.Drawing.Point(63, 220);
            this.btnDelate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(87, 28);
            this.btnDelate.TabIndex = 2;
            this.btnDelate.Text = "נקה";
            this.btnDelate.UseVisualStyleBackColor = false;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(23, 156);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(126, 22);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Location = new System.Drawing.Point(734, 126);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 27);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddEm
            // 
            this.btnAddEm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddEm.Location = new System.Drawing.Point(723, 62);
            this.btnAddEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEm.Name = "btnAddEm";
            this.btnAddEm.Size = new System.Drawing.Size(110, 28);
            this.btnAddEm.TabIndex = 15;
            this.btnAddEm.Text = "הוסף עובד";
            this.btnAddEm.UseVisualStyleBackColor = false;
            this.btnAddEm.Click += new System.EventHandler(this.btnAddEm_Click);
            // 
            // btnVeiw
            // 
            this.btnVeiw.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVeiw.Location = new System.Drawing.Point(266, 77);
            this.btnVeiw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVeiw.Name = "btnVeiw";
            this.btnVeiw.Size = new System.Drawing.Size(114, 32);
            this.btnVeiw.TabIndex = 16;
            this.btnVeiw.Text = "הצג עובדים";
            this.btnVeiw.UseVisualStyleBackColor = false;
            this.btnVeiw.Click += new System.EventHandler(this.btnVeiw_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Underline);
            this.linkLabel2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.Location = new System.Drawing.Point(14, 11);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(145, 23);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "חזרה לתפריט הראשי";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            // frmAllEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 541);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnVeiw);
            this.Controls.Add(this.btnAddEm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAllEmployee);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAllEmployee";
            this.Text = "הצג עובדים";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddEm;
        private System.Windows.Forms.Button btnVeiw;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem עדכןToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
    }
}