namespace Projeto_Operadoras
{
    partial class Frm_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grp_Regiao = new System.Windows.Forms.GroupBox();
            this.Txt_DDD = new System.Windows.Forms.TextBox();
            this.Pic_Bandeira = new System.Windows.Forms.PictureBox();
            this.Lbl_DDD = new System.Windows.Forms.Label();
            this.Rad_SP = new System.Windows.Forms.RadioButton();
            this.Txt_Regiao = new System.Windows.Forms.TextBox();
            this.Lbl_Regiao = new System.Windows.Forms.Label();
            this.Rad_RJ = new System.Windows.Forms.RadioButton();
            this.Rad_MG = new System.Windows.Forms.RadioButton();
            this.Rad_ES = new System.Windows.Forms.RadioButton();
            this.Pic_Desing = new System.Windows.Forms.PictureBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Grp_Regiao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bandeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Desing)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grp_Regiao);
            this.groupBox1.Controls.Add(this.Pic_Desing);
            this.groupBox1.Controls.Add(this.Txt_nome);
            this.groupBox1.Controls.Add(this.Lbl_Nome);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(52, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 593);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Recarga";
            // 
            // Grp_Regiao
            // 
            this.Grp_Regiao.Controls.Add(this.Txt_DDD);
            this.Grp_Regiao.Controls.Add(this.Pic_Bandeira);
            this.Grp_Regiao.Controls.Add(this.Lbl_DDD);
            this.Grp_Regiao.Controls.Add(this.Rad_SP);
            this.Grp_Regiao.Controls.Add(this.Txt_Regiao);
            this.Grp_Regiao.Controls.Add(this.Lbl_Regiao);
            this.Grp_Regiao.Controls.Add(this.Rad_RJ);
            this.Grp_Regiao.Controls.Add(this.Rad_MG);
            this.Grp_Regiao.Controls.Add(this.Rad_ES);
            this.Grp_Regiao.ForeColor = System.Drawing.Color.White;
            this.Grp_Regiao.Location = new System.Drawing.Point(540, 110);
            this.Grp_Regiao.Name = "Grp_Regiao";
            this.Grp_Regiao.Size = new System.Drawing.Size(665, 409);
            this.Grp_Regiao.TabIndex = 1;
            this.Grp_Regiao.TabStop = false;
            this.Grp_Regiao.Text = "Região Sudeste";
            // 
            // Txt_DDD
            // 
            this.Txt_DDD.Enabled = false;
            this.Txt_DDD.Location = new System.Drawing.Point(562, 362);
            this.Txt_DDD.Name = "Txt_DDD";
            this.Txt_DDD.Size = new System.Drawing.Size(89, 29);
            this.Txt_DDD.TabIndex = 7;
            this.Txt_DDD.TabStop = false;
            this.Txt_DDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pic_Bandeira
            // 
            this.Pic_Bandeira.Image = global::Projeto_Operadoras.Properties.Resources.Região_Sudeste;
            this.Pic_Bandeira.Location = new System.Drawing.Point(35, 56);
            this.Pic_Bandeira.Name = "Pic_Bandeira";
            this.Pic_Bandeira.Size = new System.Drawing.Size(275, 195);
            this.Pic_Bandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Bandeira.TabIndex = 4;
            this.Pic_Bandeira.TabStop = false;
            // 
            // Lbl_DDD
            // 
            this.Lbl_DDD.AutoSize = true;
            this.Lbl_DDD.Location = new System.Drawing.Point(513, 365);
            this.Lbl_DDD.Name = "Lbl_DDD";
            this.Lbl_DDD.Size = new System.Drawing.Size(43, 23);
            this.Lbl_DDD.TabIndex = 6;
            this.Lbl_DDD.Text = "DDD";
            // 
            // Rad_SP
            // 
            this.Rad_SP.AutoSize = true;
            this.Rad_SP.Location = new System.Drawing.Point(343, 224);
            this.Rad_SP.Name = "Rad_SP";
            this.Rad_SP.Size = new System.Drawing.Size(104, 27);
            this.Rad_SP.TabIndex = 3;
            this.Rad_SP.Text = "São Paulo";
            this.Rad_SP.UseVisualStyleBackColor = true;
            this.Rad_SP.CheckedChanged += new System.EventHandler(this.Rad_SP_CheckedChanged);
            // 
            // Txt_Regiao
            // 
            this.Txt_Regiao.Enabled = false;
            this.Txt_Regiao.Location = new System.Drawing.Point(174, 362);
            this.Txt_Regiao.Name = "Txt_Regiao";
            this.Txt_Regiao.Size = new System.Drawing.Size(313, 29);
            this.Txt_Regiao.TabIndex = 5;
            this.Txt_Regiao.TabStop = false;
            this.Txt_Regiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Regiao
            // 
            this.Lbl_Regiao.AutoSize = true;
            this.Lbl_Regiao.Location = new System.Drawing.Point(8, 365);
            this.Lbl_Regiao.Name = "Lbl_Regiao";
            this.Lbl_Regiao.Size = new System.Drawing.Size(160, 23);
            this.Lbl_Regiao.TabIndex = 4;
            this.Lbl_Regiao.Text = "Região Selecionada";
            // 
            // Rad_RJ
            // 
            this.Rad_RJ.AutoSize = true;
            this.Rad_RJ.Location = new System.Drawing.Point(343, 170);
            this.Rad_RJ.Name = "Rad_RJ";
            this.Rad_RJ.Size = new System.Drawing.Size(137, 27);
            this.Rad_RJ.TabIndex = 2;
            this.Rad_RJ.Text = "Rio de Janeiro";
            this.Rad_RJ.UseVisualStyleBackColor = true;
            this.Rad_RJ.CheckedChanged += new System.EventHandler(this.Rad_RJ_CheckedChanged);
            // 
            // Rad_MG
            // 
            this.Rad_MG.AutoSize = true;
            this.Rad_MG.Location = new System.Drawing.Point(343, 109);
            this.Rad_MG.Name = "Rad_MG";
            this.Rad_MG.Size = new System.Drawing.Size(126, 27);
            this.Rad_MG.TabIndex = 1;
            this.Rad_MG.Text = "Minas Gerais";
            this.Rad_MG.UseVisualStyleBackColor = true;
            this.Rad_MG.CheckedChanged += new System.EventHandler(this.Rad_MG_CheckedChanged);
            // 
            // Rad_ES
            // 
            this.Rad_ES.AutoSize = true;
            this.Rad_ES.Location = new System.Drawing.Point(343, 56);
            this.Rad_ES.Name = "Rad_ES";
            this.Rad_ES.Size = new System.Drawing.Size(134, 27);
            this.Rad_ES.TabIndex = 0;
            this.Rad_ES.TabStop = true;
            this.Rad_ES.Text = "Espírito Santo";
            this.Rad_ES.UseVisualStyleBackColor = true;
            this.Rad_ES.CheckedChanged += new System.EventHandler(this.Rad_ES_CheckedChanged);
            // 
            // Pic_Desing
            // 
            this.Pic_Desing.Image = global::Projeto_Operadoras.Properties.Resources.recarga1;
            this.Pic_Desing.Location = new System.Drawing.Point(53, 185);
            this.Pic_Desing.Name = "Pic_Desing";
            this.Pic_Desing.Size = new System.Drawing.Size(432, 334);
            this.Pic_Desing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Desing.TabIndex = 2;
            this.Pic_Desing.TabStop = false;
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(53, 110);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(432, 29);
            this.Txt_nome.TabIndex = 0;
            this.Txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(49, 72);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(54, 23);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Confirmar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Confirmar.Location = new System.Drawing.Point(1142, 666);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(132, 35);
            this.Btn_Confirmar.TabIndex = 1;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1334, 764);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Cadastro_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grp_Regiao.ResumeLayout(false);
            this.Grp_Regiao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bandeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Desing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Grp_Regiao;
        private System.Windows.Forms.PictureBox Pic_Desing;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Lbl_Regiao;
        private System.Windows.Forms.PictureBox Pic_Bandeira;
        private System.Windows.Forms.RadioButton Rad_SP;
        private System.Windows.Forms.RadioButton Rad_RJ;
        private System.Windows.Forms.RadioButton Rad_MG;
        private System.Windows.Forms.RadioButton Rad_ES;
        private System.Windows.Forms.TextBox Txt_Regiao;
        private System.Windows.Forms.TextBox Txt_DDD;
        private System.Windows.Forms.Label Lbl_DDD;
        private System.Windows.Forms.Button Btn_Confirmar;
    }
}

