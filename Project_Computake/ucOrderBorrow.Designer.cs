
namespace ProjectComputers
{
    partial class ucOrderBorrow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPriceCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPriceCount
            // 
            this.lblPriceCount.AutoSize = true;
            this.lblPriceCount.Font = new System.Drawing.Font("Gisha", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCount.Location = new System.Drawing.Point(142, 74);
            this.lblPriceCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPriceCount.Name = "lblPriceCount";
            this.lblPriceCount.Size = new System.Drawing.Size(18, 19);
            this.lblPriceCount.TabIndex = 23;
            this.lblPriceCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "הקש מספר ימים:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOk.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(36, 69);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 31);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLess
            // 
            this.btnLess.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLess.Location = new System.Drawing.Point(21, 21);
            this.btnLess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(24, 27);
            this.btnLess.TabIndex = 29;
            this.btnLess.Text = "-";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(71, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 27);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumP
            // 
            this.lblNumP.AutoSize = true;
            this.lblNumP.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumP.Location = new System.Drawing.Point(51, 22);
            this.lblNumP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumP.Name = "lblNumP";
            this.lblNumP.Size = new System.Drawing.Size(20, 24);
            this.lblNumP.TabIndex = 27;
            this.lblNumP.Text = "0";
            // 
            // ucOrderBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumP);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPriceCount);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucOrderBorrow";
            this.Size = new System.Drawing.Size(229, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPriceCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumP;
    }
}
