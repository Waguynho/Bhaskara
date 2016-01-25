namespace Bhaskara
{
    partial class frm_Bhaskara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Bhaskara));
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Delta = new System.Windows.Forms.Label();
            this.tb_X1 = new System.Windows.Forms.TextBox();
            this.tb_X2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_A
            // 
            this.tb_A.BackColor = System.Drawing.SystemColors.Window;
            this.tb_A.Location = new System.Drawing.Point(18, 17);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(43, 20);
            this.tb_A.TabIndex = 0;
            this.tb_A.TextChanged += new System.EventHandler(this.tb_A_TextChanged_1);
            this.tb_A.Leave += new System.EventHandler(this.tb_A_Leave);
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(112, 17);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(43, 20);
            this.tb_B.TabIndex = 1;
            this.tb_B.TextChanged += new System.EventHandler(this.tb_B_TextChanged);
            this.tb_B.Leave += new System.EventHandler(this.tb_B_Leave);
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(209, 17);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(43, 20);
            this.tb_C.TabIndex = 2;
            this.tb_C.TextChanged += new System.EventHandler(this.tb_C_TextChanged);
            this.tb_C.Leave += new System.EventHandler(this.tb_C_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a²";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(158, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(254, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "c";
            // 
            // lb_Delta
            // 
            this.lb_Delta.AutoSize = true;
            this.lb_Delta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Delta.Location = new System.Drawing.Point(17, 56);
            this.lb_Delta.Name = "lb_Delta";
            this.lb_Delta.Size = new System.Drawing.Size(164, 13);
            this.lb_Delta.TabIndex = 7;
            this.lb_Delta.Text = "Digita apenas nos quadros acima";
            // 
            // tb_X1
            // 
            this.tb_X1.Location = new System.Drawing.Point(41, 80);
            this.tb_X1.Name = "tb_X1";
            this.tb_X1.ReadOnly = true;
            this.tb_X1.Size = new System.Drawing.Size(139, 20);
            this.tb_X1.TabIndex = 8;
            // 
            // tb_X2
            // 
            this.tb_X2.Location = new System.Drawing.Point(41, 121);
            this.tb_X2.Name = "tb_X2";
            this.tb_X2.ReadOnly = true;
            this.tb_X2.Size = new System.Drawing.Size(139, 20);
            this.tb_X2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(18, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X2";
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Image = global::Bhaskara.Properties.Resources.icone_delete_2;
            this.bt_Limpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_Limpar.Location = new System.Drawing.Point(208, 118);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(80, 24);
            this.bt_Limpar.TabIndex = 12;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            this.bt_Limpar.MouseLeave += new System.EventHandler(this.bt_Limpar_MouseLeave);
            this.bt_Limpar.MouseHover += new System.EventHandler(this.bt_Limpar_MouseHover);
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.Image = global::Bhaskara.Properties.Resources.Icone_OK_2;
            this.bt_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Calcular.Location = new System.Drawing.Point(208, 80);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(80, 32);
            this.bt_Calcular.TabIndex = 6;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Calcular.UseVisualStyleBackColor = true;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            this.bt_Calcular.MouseLeave += new System.EventHandler(this.bt_Calcular_MouseLeave);
            this.bt_Calcular.MouseHover += new System.EventHandler(this.bt_Calcular_MouseHover);
            // 
            // frm_Bhaskara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(307, 154);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_X2);
            this.Controls.Add(this.tb_X1);
            this.Controls.Add(this.lb_Delta);
            this.Controls.Add(this.bt_Calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_A);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Bhaskara";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bhaskara-Ws";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Bhaskara_FormClosing);
            this.Load += new System.EventHandler(this.frm_Bhaskara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Calcular;
        private System.Windows.Forms.Label lb_Delta;
        private System.Windows.Forms.TextBox tb_X1;
        private System.Windows.Forms.TextBox tb_X2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Limpar;
    }
}

