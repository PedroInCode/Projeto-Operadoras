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
    public partial class Frm_Operadoras: Form
    {
        public Frm_Operadoras()
        {
            InitializeComponent();
        }

        private void Frm_Operadoras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Cadastro voltando = new Frm_Cadastro();
            voltando.Show();
            Hide();
        }

        private void Rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Operadora.Image = Properties.Resources.VivoAnimado;
            BackgroundImage = Properties.Resources.gravivo;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_Operadora.Text = "Vivo";
            Txt_ValorR.Text = "";
            Lbl_Status.Text = "Status da Venda";

            //Habilitando
            Pnl_Recarga.Enabled = true;
            Msk_Numero.Enabled = true;
            Lbl_Status.Enabled = true;

            //Cor dos Botoes RAD
            Rad_Vivo.ForeColor = Color.MediumOrchid;
            Rad_Claro.ForeColor = Color.White;
            Rad_Algar.ForeColor = Color.White;
            Rad_Correios.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;

            //Cor dos Valores
            Btn_V1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V1.ForeColor = Color.MediumOrchid;

            Btn_V2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V2.ForeColor = Color.MediumOrchid;

            Btn_V3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V3.ForeColor = Color.MediumOrchid;

            Btn_V4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V4.ForeColor = Color.MediumOrchid;

            Btn_V5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V5.ForeColor = Color.MediumOrchid;

            Btn_V6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V6.ForeColor = Color.MediumOrchid;

            Btn_V7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V7.ForeColor = Color.MediumOrchid;

            Btn_V8.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V8.ForeColor = Color.MediumOrchid;

            //Definindo Valores
            Btn_V1.Text = "R$12,00";
            Btn_V2.Text = "R$15,00";
            Btn_V3.Text = "R$20,00";
            Btn_V4.Text = "R$30,00";
            Btn_V5.Text = "R$35,00";
            Btn_V6.Text = "R$40,00";
            Btn_V7.Text = "R$100,00";
            Btn_V8.Text = "R$200,00";
            //Definindo Validades
            Lbl_VA1.Text = "30 dias";
            Lbl_VA2.Text = "30 dias";
            Lbl_VA3.Text = "30 dias";
            Lbl_VA4.Text = "30 dias";
            Lbl_VA5.Text = "90 dias";
            Lbl_VA6.Text = "90 dias";
            Lbl_VA7.Text = "180 dias";
            Lbl_VA8.Text = "365 dias";

        }

        private void Rad_Claro_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Operadora.Image = Properties.Resources.claro2; // Imagem da Operadora na Tela.
            BackgroundImage = Properties.Resources.graclaro;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_Operadora.Text = "Claro";
            Txt_ValorR.Text = "";
            Lbl_Status.Text = "Status da Venda";

            Pnl_Recarga.Enabled = true;
            Msk_Numero.Enabled = true;
            Lbl_Status.Enabled = true;

            Rad_Claro.ForeColor = ColorTranslator.FromHtml("#ed352a"); // Colocando cor personalizada.
            Rad_Vivo.ForeColor = Color.White;
            Rad_Correios.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;
            Rad_Algar.ForeColor = Color.White;

            //Definindo cor dos valores
            Btn_V1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V1.ForeColor = Color.Red;

            Btn_V2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V2.ForeColor = Color.Red;

            Btn_V3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V3.ForeColor = Color.Red;

            Btn_V4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V4.ForeColor = Color.Red;

            Btn_V5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V5.ForeColor = Color.Red;

            Btn_V6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V6.ForeColor = Color.Red;

            Btn_V7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V7.ForeColor = Color.Red;

            Btn_V8.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V8.ForeColor = Color.Red;


            //Definindo Valores
            Btn_V1.Text = "R$12,00";
            Btn_V2.Text = "R$15,00";
            Btn_V3.Text = "R$20,00";
            Btn_V4.Text = "R$25,00";
            Btn_V5.Text = "R$30,00";
            Btn_V6.Text = "R$35,00";
            Btn_V7.Text = "R$50,00";
            Btn_V8.Text = "R$100,00";
            //Definindo Validades
            Lbl_VA1.Text = "30 dias";
            Lbl_VA2.Text = "30 dias";
            Lbl_VA3.Text = "60 dias";
            Lbl_VA4.Text = "60 dias";
            Lbl_VA5.Text = "90 dias";
            Lbl_VA6.Text = "90 dias";
            Lbl_VA7.Text = "120 dias";
            Lbl_VA8.Text = "180 dias";
        }

        private void Rad_Tim_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Operadora.Image = Properties.Resources.TimAnimado;
            BackgroundImage = Properties.Resources.gratim;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_Operadora.Text = "Tim";
            Txt_ValorR.Text = "";
            Lbl_Status.Text = "Status da Venda";

            //Habilitando
            Pnl_Recarga.Enabled = true;
            Msk_Numero.Enabled = true;
            Lbl_Status.Enabled = true;

            //aaa
            Rad_Algar.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.DodgerBlue;
            Rad_Claro.ForeColor = Color.White;
            Rad_Correios.ForeColor = Color.White;
            Rad_Vivo.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;

            // aa
            Btn_V1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V1.ForeColor = Color.DodgerBlue;

            Btn_V2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V2.ForeColor = Color.DodgerBlue;

            Btn_V3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V3.ForeColor = Color.DodgerBlue;

            Btn_V4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V4.ForeColor = Color.DodgerBlue;

            Btn_V5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V5.ForeColor = Color.DodgerBlue;

            Btn_V6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V6.ForeColor = Color.DodgerBlue;

            Btn_V7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V7.ForeColor = Color.DodgerBlue;

            Btn_V8.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V8.ForeColor = Color.DodgerBlue;

            //Definindo Valores
            Btn_V1.Text = "R$10,00";
            Btn_V2.Text = "R$15,00";
            Btn_V3.Text = "R$20,00";
            Btn_V4.Text = "R$30,00";
            Btn_V5.Text = "R$40,00";
            Btn_V6.Text = "R$50,00";
            Btn_V7.Text = "R$60,00";
            Btn_V8.Text = "R$100,00";
            //Definindo Validades
            Lbl_VA1.Text = "30 dias";
            Lbl_VA2.Text = "30 dias";
            Lbl_VA3.Text = "30 dias";
            Lbl_VA4.Text = "90 dias";
            Lbl_VA5.Text = "90 dias";
            Lbl_VA6.Text = "180 dias";
            Lbl_VA7.Text = "180 dias";
            Lbl_VA8.Text = "180 dias";
        }

        private void Rad_Oi_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Operadora.Image = Properties.Resources.oixd;
            BackgroundImage = Properties.Resources.graoi;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_Operadora.Text = "Oi";
            Txt_ValorR.Text = "";
            Lbl_Status.Text = "Status da Venda";

            Pnl_Recarga.Enabled = true;
            Msk_Numero.Enabled = true;
            Lbl_Status.Enabled = true;

            Rad_Algar.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;
            Rad_Claro.ForeColor = Color.White;
            Rad_Correios.ForeColor = Color.White;
            Rad_Vivo.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.Orchid;

            //aa
            Btn_V1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V1.ForeColor = Color.Orchid;

            Btn_V2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V2.ForeColor = Color.Orchid;

            Btn_V3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V3.ForeColor = Color.Orchid;

            Btn_V4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V4.ForeColor = Color.Orchid;

            Btn_V5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V5.ForeColor = Color.Orchid;

            Btn_V6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V6.ForeColor = Color.Orchid;

            Btn_V7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V7.ForeColor = Color.Orchid;

            Btn_V8.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V8.ForeColor = Color.Orchid;

            //Definindo Valores
            Btn_V1.Text = "R$10,00";
            Btn_V2.Text = "R$15,00";
            Btn_V3.Text = "R$20,00";
            Btn_V4.Text = "R$25,00";
            Btn_V5.Text = "R$30,00";
            Btn_V6.Text = "R$35,00";
            Btn_V7.Text = "R$40,00";
            Btn_V8.Text = "R$50,00";
            //Definindo Validades
            Lbl_VA1.Text = "30 dias";
            Lbl_VA2.Text = "30 dias";
            Lbl_VA3.Text = "45 dias";
            Lbl_VA4.Text = "45 dias";
            Lbl_VA5.Text = "90 dias";
            Lbl_VA6.Text = "90 dias";
            Lbl_VA7.Text = "90 dias";
            Lbl_VA8.Text = "90 dias";
        }

        private void Rad_Algar_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Operadora.Image = Properties.Resources.logo_algar;
            BackgroundImage = Properties.Resources.graAlgar1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_Operadora.Text = "Algar";
            Txt_ValorR.Text = "";
            Lbl_Status.Text = "Status da Venda";

            Pnl_Recarga.Enabled = true;
            Msk_Numero.Enabled = true;
            Lbl_Status.Enabled = true;

            //aaa
            Rad_Algar.ForeColor = Color.CornflowerBlue;
            Rad_Tim.ForeColor = Color.White;
            Rad_Claro.ForeColor = Color.White;
            Rad_Correios.ForeColor = Color.White;
            Rad_Vivo.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;

            //a
            Btn_V1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V1.ForeColor = Color.CornflowerBlue;

            Btn_V2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V2.ForeColor = Color.CornflowerBlue;

            Btn_V3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V3.ForeColor = Color.CornflowerBlue;

            Btn_V4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V4.ForeColor = Color.CornflowerBlue;

            Btn_V5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V5.ForeColor = Color.CornflowerBlue;

            Btn_V6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V6.ForeColor = Color.CornflowerBlue;

            Btn_V7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V7.ForeColor = Color.CornflowerBlue;

            Btn_V8.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V8.ForeColor = Color.CornflowerBlue;

            //Definindo Valores
            Btn_V1.Text = "R$11,00";
            Btn_V2.Text = "R$18,00";
            Btn_V3.Text = "R$25,00";
            Btn_V4.Text = "R$30,00";
            Btn_V5.Text = "R$37,00";
            Btn_V6.Text = "R$44,00";
            Btn_V7.Text = "R$55,00";
            Btn_V8.Text = "R$70,00";
            //Definindo Validades
            Lbl_VA1.Text = "20 dias";
            Lbl_VA2.Text = "20 dias";
            Lbl_VA3.Text = "45 dias";
            Lbl_VA4.Text = "45 dias";
            Lbl_VA5.Text = "90 dias";
            Lbl_VA6.Text = "90 dias";
            Lbl_VA7.Text = "180 dias";
            Lbl_VA8.Text = "365 dias";
        }

        private void Rad_Correios_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Operadora.Image = Properties.Resources.correios;
            BackgroundImage = Properties.Resources.gracorr;
            BackgroundImageLayout = ImageLayout.Stretch;
            Rad_Correios.ForeColor = Color.Black;
            Txt_Operadora.Text = "Correios";
            Txt_ValorR.Text = "";
            Lbl_Status.Text = "Status da Venda";

            Pnl_Recarga.Enabled = true;
            Msk_Numero.Enabled = true;
            Lbl_Status.Enabled = true;

            //aaa
            Rad_Algar.ForeColor = Color.White;
            Rad_Tim.ForeColor = Color.White;
            Rad_Claro.ForeColor = Color.White;
            Rad_Correios.ForeColor = Color.Black;
            Rad_Vivo.ForeColor = Color.White;
            Rad_Oi.ForeColor = Color.White;

            //aaa
            Btn_V1.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V1.ForeColor = Color.Black;

            Btn_V2.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V2.ForeColor = Color.Black;

            Btn_V3.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V3.ForeColor = Color.Black;

            Btn_V4.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V4.ForeColor = Color.Black;

            Btn_V5.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V5.ForeColor = Color.Black;

            Btn_V6.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V6.ForeColor = Color.Black;

            Btn_V7.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V7.ForeColor = Color.Black;

            Btn_V8.FlatAppearance.MouseOverBackColor = Color.White;
            Btn_V8.ForeColor = Color.Black;

            //Definindo Valores
            Btn_V1.Text = "R$5,00";
            Btn_V2.Text = "R$10,00";
            Btn_V3.Text = "R$15,00";
            Btn_V4.Text = "R$20,00";
            Btn_V5.Text = "R$25,00";
            Btn_V6.Text = "R$30,00";
            Btn_V7.Text = "R$35,00";
            Btn_V8.Text = "R$40,00";
            //Definindo Validades
            Lbl_VA1.Text = "30 dias";
            Lbl_VA2.Text = "30 dias";
            Lbl_VA3.Text = "30 dias";
            Lbl_VA4.Text = "90 dias";
            Lbl_VA5.Text = "90 dias";
            Lbl_VA6.Text = "180 dias";
            Lbl_VA7.Text = "180 dias";
            Lbl_VA8.Text = "180 dias";
        }

        private void Btn_V1_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V1.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Btn_V2_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V2.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Btn_V3_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V3.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Btn_V4_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V4.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Btn_V5_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V5.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Btn_V6_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V6.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Btn_V7_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V7.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Btn_V8_Click(object sender, EventArgs e)
        {
            Txt_ValorR.Text = Btn_V8.Text;
            //STATUS
            Lbl_Status.Text = "RECARGA FEITA COM SUCESSO!!!";
        }

        private void Grp_Dados_Enter(object sender, EventArgs e)
        {

        }
    }
}
