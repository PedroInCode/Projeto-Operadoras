using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Operadoras
{
    public partial class Frm_Cadastro: Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void Rad_ES_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeira.Image = Properties.Resources.ES;
            Txt_Regiao.Text = "Espírito Santo";
            Txt_DDD.Text = "27";
        }

        private void Rad_MG_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeira.Image = Properties.Resources.MG;
            Txt_Regiao.Text = "Minas Gerais";
            Txt_DDD.Text = "31";
        }

        private void Rad_RJ_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeira.Image = Properties.Resources.RJ;
            Txt_Regiao.Text = "Rio de Janeiro";
            Txt_DDD.Text = "21";
        }

        private void Rad_SP_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeira.Image = Properties.Resources.SP;
            Txt_Regiao.Text = "São Paulo";
            Txt_DDD.Text = "11";
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            Frm_Operadoras confirmando = new Frm_Operadoras();
            confirmando.Txt_Regiao2.Text = Txt_Regiao.Text;
            confirmando.Txt_DDD2.Text = Txt_DDD.Text;
            confirmando.Lbl_Nome2.Text = Txt_nome.Text;
            confirmando.Show();
            Hide();
        }

        private void Frm_Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
