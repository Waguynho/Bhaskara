using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class frm_Bhaskara : Form
    {
        private double a, b, c;
        private Bhaskara bhask;

        public frm_Bhaskara()
        {
            InitializeComponent();
        }

        #region"Metodos Ws"

        private void calculaBhaskara()
        {
            try
            {
                ConverteImputs();

                bhask = new Bhaskara(a, b, c);

                tb_X1.Text = bhask.getX1().ToString();

                tb_X2.Text = bhask.getX2().ToString();

                SetaDeltaLabel();

            }
            catch (Ex_AZero aZero)
            {
                MessageBox.Show(aZero.Mensagem, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Ex_Delta_Negativo deltaNegativo)
            {
                MessageBox.Show(deltaNegativo.Mensagem, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lb_Delta.Text = "Delta Negativo!";
                limpaXLinhas();
            }           
            catch (Exception)
            {
                MessageBox.Show("Algum valor não foi digitado corretamente! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpaXLinhas();
            }
        }

        private void ConverteImputs()
        {
            a = Convert.ToDouble(tb_A.Text);
            b = Convert.ToDouble(tb_B.Text);
            c = Convert.ToDouble(tb_C.Text);
        }

        private void SetaDeltaLabel()
        {
            this.lb_Delta.Text = "Delta: " + bhask.getDelta().ToString();

            if (bhask.getDelta() == 0)
            {
                MessageBox.Show("As Raízes são igualis.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lb_Delta.Text = "Delta é igual a Zero.";
            }
        }

        private void limpaXLinhas()
        {
            tb_X1.Text = "";
            tb_X2.Text = "";
        }

       
        #endregion


        #region"Eventos"

        private void frm_Bhaskara_Load(object sender, EventArgs e)
        {

        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {
            calculaBhaskara();
        }

        private void frm_Bhaskara_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult resultado = MessageBox.Show("Tem certeza que quer fechar a Janela? ", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            
            limpaXLinhas();

            tb_A.Text = "";
            tb_B.Text = "";
            tb_C.Text = "";

            tb_A.BackColor = System.Drawing.Color.White;
            tb_B.BackColor = System.Drawing.Color.White;
            tb_C.BackColor = System.Drawing.Color.White;

            lb_Delta.Text = "Digita apenas nos quadros acima.";
        }


        //---------------Entrando nos textBoxs
        private void tb_A_TextChanged_1(object sender, EventArgs e)
        {
            tb_A.BackColor = System.Drawing.Color.Khaki;
        }

        private void tb_B_TextChanged(object sender, EventArgs e)
        {
            tb_B.BackColor = System.Drawing.Color.Khaki;
        }

        private void tb_C_TextChanged(object sender, EventArgs e)
        {
            tb_C.BackColor = Color.Khaki;
        }

        //---------------Saindo nos textBoxs
        private void tb_A_Leave(object sender, EventArgs e)
        {
            tb_A.BackColor = System.Drawing.Color.White;
        }

        private void tb_B_Leave(object sender, EventArgs e)
        {
            tb_B.BackColor = System.Drawing.Color.White;
        }

        private void tb_C_Leave(object sender, EventArgs e)
        {
            tb_C.BackColor = System.Drawing.Color.White;
        }

        //----------------Efeito nos botoes

        private void bt_Calcular_MouseHover(object sender, EventArgs e)
        {
            bt_Calcular.ForeColor = Color.Green;
        }

        private void bt_Calcular_MouseLeave(object sender, EventArgs e)
        {
            bt_Calcular.ForeColor = Color.Black;
        }

        private void bt_Limpar_MouseHover(object sender, EventArgs e)
        {
            bt_Limpar.ForeColor = Color.Red;
        }

        private void bt_Limpar_MouseLeave(object sender, EventArgs e)
        {
            bt_Limpar.ForeColor = Color.Black;
        }


        #endregion


      

    }
}
