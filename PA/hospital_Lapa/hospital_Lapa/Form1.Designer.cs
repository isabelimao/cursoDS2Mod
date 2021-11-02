
namespace hospital_Lapa
{
    partial class frmHospital
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
            this.gbxDadosPaciente = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxPlanoSaude = new System.Windows.Forms.GroupBox();
            this.rbtnPrivado = new System.Windows.Forms.RadioButton();
            this.rbtnPartcular = new System.Windows.Forms.RadioButton();
            this.rbtnSus = new System.Windows.Forms.RadioButton();
            this.gbxServicos = new System.Windows.Forms.GroupBox();
            this.cbxExamesLaboratoriais = new System.Windows.Forms.CheckBox();
            this.cbxInternacao = new System.Windows.Forms.CheckBox();
            this.cbxConsulta = new System.Windows.Forms.CheckBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblInternacao = new System.Windows.Forms.Label();
            this.lblExames = new System.Windows.Forms.Label();
            this.gbxOperacoes = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbrirCalculadora = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbxFormaPgto = new System.Windows.Forms.GroupBox();
            this.lblTotalPlanoConvenio = new System.Windows.Forms.Label();
            this.lblCobrarGovernoPlano = new System.Windows.Forms.Label();
            this.lblTotalApagar = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTotalServ = new System.Windows.Forms.Label();
            this.lblVtotalServicos = new System.Windows.Forms.Label();
            this.gbxPrazoVista = new System.Windows.Forms.GroupBox();
            this.rbtnAprazo = new System.Windows.Forms.RadioButton();
            this.rbtnAvista = new System.Windows.Forms.RadioButton();
            this.lblTotalFormaPG = new System.Windows.Forms.Label();
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxDadosPaciente.SuspendLayout();
            this.gbxPlanoSaude.SuspendLayout();
            this.gbxServicos.SuspendLayout();
            this.gbxOperacoes.SuspendLayout();
            this.gbxFormaPgto.SuspendLayout();
            this.gbxPrazoVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDadosPaciente
            // 
            this.gbxDadosPaciente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxDadosPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxDadosPaciente.Controls.Add(this.txtTelefone);
            this.gbxDadosPaciente.Controls.Add(this.txtNomePaciente);
            this.gbxDadosPaciente.Controls.Add(this.lblPaciente);
            this.gbxDadosPaciente.Controls.Add(this.label3);
            this.gbxDadosPaciente.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxDadosPaciente.Location = new System.Drawing.Point(57, 82);
            this.gbxDadosPaciente.Name = "gbxDadosPaciente";
            this.gbxDadosPaciente.Size = new System.Drawing.Size(728, 100);
            this.gbxDadosPaciente.TabIndex = 0;
            this.gbxDadosPaciente.TabStop = false;
            this.gbxDadosPaciente.Text = "Dados do Paciente";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTelefone.Location = new System.Drawing.Point(105, 68);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(560, 20);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.Visible = false;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNomePaciente.Location = new System.Drawing.Point(105, 27);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(560, 20);
            this.txtNomePaciente.TabIndex = 8;
            this.txtNomePaciente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            this.txtNomePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomePaciente_KeyPress);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(31, 30);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 6;
            this.lblPaciente.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // gbxPlanoSaude
            // 
            this.gbxPlanoSaude.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxPlanoSaude.Controls.Add(this.rbtnPrivado);
            this.gbxPlanoSaude.Controls.Add(this.rbtnPartcular);
            this.gbxPlanoSaude.Controls.Add(this.rbtnSus);
            this.gbxPlanoSaude.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxPlanoSaude.Location = new System.Drawing.Point(57, 194);
            this.gbxPlanoSaude.Name = "gbxPlanoSaude";
            this.gbxPlanoSaude.Size = new System.Drawing.Size(356, 100);
            this.gbxPlanoSaude.TabIndex = 1;
            this.gbxPlanoSaude.TabStop = false;
            this.gbxPlanoSaude.Text = "Plano de Saúde";
            this.gbxPlanoSaude.Visible = false;
            // 
            // rbtnPrivado
            // 
            this.rbtnPrivado.AutoSize = true;
            this.rbtnPrivado.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbtnPrivado.Location = new System.Drawing.Point(245, 52);
            this.rbtnPrivado.Name = "rbtnPrivado";
            this.rbtnPrivado.Size = new System.Drawing.Size(61, 17);
            this.rbtnPrivado.TabIndex = 2;
            this.rbtnPrivado.TabStop = true;
            this.rbtnPrivado.Text = "Privado";
            this.rbtnPrivado.UseVisualStyleBackColor = true;
            this.rbtnPrivado.CheckedChanged += new System.EventHandler(this.rbtnPrivado_CheckedChanged);
            // 
            // rbtnPartcular
            // 
            this.rbtnPartcular.AutoSize = true;
            this.rbtnPartcular.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbtnPartcular.Location = new System.Drawing.Point(126, 52);
            this.rbtnPartcular.Name = "rbtnPartcular";
            this.rbtnPartcular.Size = new System.Drawing.Size(69, 17);
            this.rbtnPartcular.TabIndex = 1;
            this.rbtnPartcular.TabStop = true;
            this.rbtnPartcular.Text = "Particular";
            this.rbtnPartcular.UseVisualStyleBackColor = true;
            this.rbtnPartcular.CheckedChanged += new System.EventHandler(this.rbtnPartcular_CheckedChanged);
            // 
            // rbtnSus
            // 
            this.rbtnSus.AutoSize = true;
            this.rbtnSus.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbtnSus.Location = new System.Drawing.Point(34, 54);
            this.rbtnSus.Name = "rbtnSus";
            this.rbtnSus.Size = new System.Drawing.Size(47, 17);
            this.rbtnSus.TabIndex = 0;
            this.rbtnSus.TabStop = true;
            this.rbtnSus.Text = "SUS";
            this.rbtnSus.UseVisualStyleBackColor = true;
            this.rbtnSus.CheckedChanged += new System.EventHandler(this.rbtnSus_CheckedChanged);
            // 
            // gbxServicos
            // 
            this.gbxServicos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxServicos.Controls.Add(this.cbxExamesLaboratoriais);
            this.gbxServicos.Controls.Add(this.cbxInternacao);
            this.gbxServicos.Controls.Add(this.cbxConsulta);
            this.gbxServicos.Controls.Add(this.lblConsulta);
            this.gbxServicos.Controls.Add(this.lblInternacao);
            this.gbxServicos.Controls.Add(this.lblExames);
            this.gbxServicos.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxServicos.Location = new System.Drawing.Point(57, 300);
            this.gbxServicos.Name = "gbxServicos";
            this.gbxServicos.Size = new System.Drawing.Size(356, 137);
            this.gbxServicos.TabIndex = 1;
            this.gbxServicos.TabStop = false;
            this.gbxServicos.Text = "Serviços";
            this.gbxServicos.Visible = false;
            // 
            // cbxExamesLaboratoriais
            // 
            this.cbxExamesLaboratoriais.AutoSize = true;
            this.cbxExamesLaboratoriais.Location = new System.Drawing.Point(34, 101);
            this.cbxExamesLaboratoriais.Name = "cbxExamesLaboratoriais";
            this.cbxExamesLaboratoriais.Size = new System.Drawing.Size(126, 17);
            this.cbxExamesLaboratoriais.TabIndex = 20;
            this.cbxExamesLaboratoriais.Text = "Exames Laboratoriais";
            this.cbxExamesLaboratoriais.UseVisualStyleBackColor = true;
            this.cbxExamesLaboratoriais.CheckedChanged += new System.EventHandler(this.cbxExamesLaboratoriais_CheckedChanged);
            // 
            // cbxInternacao
            // 
            this.cbxInternacao.AutoSize = true;
            this.cbxInternacao.Location = new System.Drawing.Point(34, 65);
            this.cbxInternacao.Name = "cbxInternacao";
            this.cbxInternacao.Size = new System.Drawing.Size(77, 17);
            this.cbxInternacao.TabIndex = 19;
            this.cbxInternacao.Text = "Internação";
            this.cbxInternacao.UseVisualStyleBackColor = true;
            this.cbxInternacao.CheckedChanged += new System.EventHandler(this.cbxInternacao_CheckedChanged);
            // 
            // cbxConsulta
            // 
            this.cbxConsulta.AutoSize = true;
            this.cbxConsulta.Location = new System.Drawing.Point(34, 30);
            this.cbxConsulta.Name = "cbxConsulta";
            this.cbxConsulta.Size = new System.Drawing.Size(67, 17);
            this.cbxConsulta.TabIndex = 18;
            this.cbxConsulta.Text = "Consulta";
            this.cbxConsulta.UseVisualStyleBackColor = true;
            this.cbxConsulta.CheckedChanged += new System.EventHandler(this.cbxConsulta_CheckedChanged);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(244, 31);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(58, 13);
            this.lblConsulta.TabIndex = 15;
            this.lblConsulta.Text = "lblConsulta";
            this.lblConsulta.Visible = false;
            // 
            // lblInternacao
            // 
            this.lblInternacao.AutoSize = true;
            this.lblInternacao.Location = new System.Drawing.Point(244, 66);
            this.lblInternacao.Name = "lblInternacao";
            this.lblInternacao.Size = new System.Drawing.Size(68, 13);
            this.lblInternacao.TabIndex = 16;
            this.lblInternacao.Text = "lblInternacao";
            this.lblInternacao.Visible = false;
            // 
            // lblExames
            // 
            this.lblExames.AutoSize = true;
            this.lblExames.Location = new System.Drawing.Point(244, 102);
            this.lblExames.Name = "lblExames";
            this.lblExames.Size = new System.Drawing.Size(54, 13);
            this.lblExames.TabIndex = 17;
            this.lblExames.Text = "lblExames";
            this.lblExames.Visible = false;
            // 
            // gbxOperacoes
            // 
            this.gbxOperacoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxOperacoes.Controls.Add(this.btnClose);
            this.gbxOperacoes.Controls.Add(this.btnAbrirCalculadora);
            this.gbxOperacoes.Controls.Add(this.btnCalcular);
            this.gbxOperacoes.Controls.Add(this.btnLimpar);
            this.gbxOperacoes.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxOperacoes.Location = new System.Drawing.Point(57, 452);
            this.gbxOperacoes.Name = "gbxOperacoes";
            this.gbxOperacoes.Size = new System.Drawing.Size(728, 51);
            this.gbxOperacoes.TabIndex = 1;
            this.gbxOperacoes.TabStop = false;
            this.gbxOperacoes.Text = "Operações";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(537, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Encerrar - Alt + e";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbrirCalculadora
            // 
            this.btnAbrirCalculadora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbrirCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCalculadora.Location = new System.Drawing.Point(394, 19);
            this.btnAbrirCalculadora.Name = "btnAbrirCalculadora";
            this.btnAbrirCalculadora.Size = new System.Drawing.Size(128, 26);
            this.btnAbrirCalculadora.TabIndex = 2;
            this.btnAbrirCalculadora.Text = "Calculadora Alt + c";
            this.btnAbrirCalculadora.UseVisualStyleBackColor = false;
            this.btnAbrirCalculadora.Click += new System.EventHandler(this.btnAbrirCalculadora_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(184, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 26);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular - Alt + a";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(50, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 26);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar - Alt + L";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbxFormaPgto
            // 
            this.gbxFormaPgto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxFormaPgto.Controls.Add(this.lblTotalPlanoConvenio);
            this.gbxFormaPgto.Controls.Add(this.lblCobrarGovernoPlano);
            this.gbxFormaPgto.Controls.Add(this.lblTotalApagar);
            this.gbxFormaPgto.Controls.Add(this.lblTotalPagar);
            this.gbxFormaPgto.Controls.Add(this.lblTotalServ);
            this.gbxFormaPgto.Controls.Add(this.lblVtotalServicos);
            this.gbxFormaPgto.Controls.Add(this.gbxPrazoVista);
            this.gbxFormaPgto.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxFormaPgto.Location = new System.Drawing.Point(429, 194);
            this.gbxFormaPgto.Name = "gbxFormaPgto";
            this.gbxFormaPgto.Size = new System.Drawing.Size(356, 243);
            this.gbxFormaPgto.TabIndex = 2;
            this.gbxFormaPgto.TabStop = false;
            this.gbxFormaPgto.Text = "Formas de Pagamento";
            this.gbxFormaPgto.Visible = false;
            // 
            // lblTotalPlanoConvenio
            // 
            this.lblTotalPlanoConvenio.AutoSize = true;
            this.lblTotalPlanoConvenio.Location = new System.Drawing.Point(20, 218);
            this.lblTotalPlanoConvenio.Name = "lblTotalPlanoConvenio";
            this.lblTotalPlanoConvenio.Size = new System.Drawing.Size(113, 13);
            this.lblTotalPlanoConvenio.TabIndex = 14;
            this.lblTotalPlanoConvenio.Text = "lblTotalPlanoConvenio";
            this.lblTotalPlanoConvenio.Visible = false;
            // 
            // lblCobrarGovernoPlano
            // 
            this.lblCobrarGovernoPlano.AutoSize = true;
            this.lblCobrarGovernoPlano.Location = new System.Drawing.Point(20, 193);
            this.lblCobrarGovernoPlano.Name = "lblCobrarGovernoPlano";
            this.lblCobrarGovernoPlano.Size = new System.Drawing.Size(178, 13);
            this.lblCobrarGovernoPlano.TabIndex = 13;
            this.lblCobrarGovernoPlano.Text = "Cobrar do Governo/Plano de Saúde";
            this.lblCobrarGovernoPlano.Visible = false;
            // 
            // lblTotalApagar
            // 
            this.lblTotalApagar.AutoSize = true;
            this.lblTotalApagar.Location = new System.Drawing.Point(20, 168);
            this.lblTotalApagar.Name = "lblTotalApagar";
            this.lblTotalApagar.Size = new System.Drawing.Size(70, 13);
            this.lblTotalApagar.TabIndex = 11;
            this.lblTotalApagar.Text = "Total a pagar";
            this.lblTotalApagar.Visible = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(222, 168);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(69, 13);
            this.lblTotalPagar.TabIndex = 12;
            this.lblTotalPagar.Text = "lblTotalPagar";
            this.lblTotalPagar.Visible = false;
            // 
            // lblTotalServ
            // 
            this.lblTotalServ.AutoSize = true;
            this.lblTotalServ.Location = new System.Drawing.Point(222, 54);
            this.lblTotalServ.Name = "lblTotalServ";
            this.lblTotalServ.Size = new System.Drawing.Size(63, 13);
            this.lblTotalServ.TabIndex = 9;
            this.lblTotalServ.Text = "lblTotalServ";
            this.lblTotalServ.Visible = false;
            // 
            // lblVtotalServicos
            // 
            this.lblVtotalServicos.AutoSize = true;
            this.lblVtotalServicos.Location = new System.Drawing.Point(20, 54);
            this.lblVtotalServicos.Name = "lblVtotalServicos";
            this.lblVtotalServicos.Size = new System.Drawing.Size(90, 13);
            this.lblVtotalServicos.TabIndex = 8;
            this.lblVtotalServicos.Text = "Total de Serviços";
            this.lblVtotalServicos.Visible = false;
            // 
            // gbxPrazoVista
            // 
            this.gbxPrazoVista.Controls.Add(this.rbtnAprazo);
            this.gbxPrazoVista.Controls.Add(this.rbtnAvista);
            this.gbxPrazoVista.Controls.Add(this.lblTotalFormaPG);
            this.gbxPrazoVista.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbxPrazoVista.Location = new System.Drawing.Point(6, 95);
            this.gbxPrazoVista.Name = "gbxPrazoVista";
            this.gbxPrazoVista.Size = new System.Drawing.Size(344, 55);
            this.gbxPrazoVista.TabIndex = 3;
            this.gbxPrazoVista.TabStop = false;
            this.gbxPrazoVista.Text = "Forma de Pagamento";
            this.gbxPrazoVista.Visible = false;
            // 
            // rbtnAprazo
            // 
            this.rbtnAprazo.AutoSize = true;
            this.rbtnAprazo.Location = new System.Drawing.Point(84, 32);
            this.rbtnAprazo.Name = "rbtnAprazo";
            this.rbtnAprazo.Size = new System.Drawing.Size(60, 17);
            this.rbtnAprazo.TabIndex = 4;
            this.rbtnAprazo.TabStop = true;
            this.rbtnAprazo.Text = "à prazo";
            this.rbtnAprazo.UseVisualStyleBackColor = true;
            // 
            // rbtnAvista
            // 
            this.rbtnAvista.AutoSize = true;
            this.rbtnAvista.Location = new System.Drawing.Point(17, 32);
            this.rbtnAvista.Name = "rbtnAvista";
            this.rbtnAvista.Size = new System.Drawing.Size(56, 17);
            this.rbtnAvista.TabIndex = 3;
            this.rbtnAvista.TabStop = true;
            this.rbtnAvista.Text = "à vista";
            this.rbtnAvista.UseVisualStyleBackColor = true;
            // 
            // lblTotalFormaPG
            // 
            this.lblTotalFormaPG.AutoSize = true;
            this.lblTotalFormaPG.Location = new System.Drawing.Point(216, 32);
            this.lblTotalFormaPG.Name = "lblTotalFormaPG";
            this.lblTotalFormaPG.Size = new System.Drawing.Size(85, 13);
            this.lblTotalFormaPG.TabIndex = 10;
            this.lblTotalFormaPG.Text = "lblTotalFormaPG";
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.AutoSize = true;
            this.lblCabecalho.Font = new System.Drawing.Font("Myanmar Text", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho.Location = new System.Drawing.Point(262, 21);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(336, 66);
            this.lblCabecalho.TabIndex = 3;
            this.lblCabecalho.Text = "SPOCK HOSPITAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hospital_Lapa.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(57, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hospital_Lapa.Properties.Resources._25807ef71bcdaca65a4b0ec871ab6d6c;
            this.pictureBox2.Location = new System.Drawing.Point(700, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // frmHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 515);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxFormaPgto);
            this.Controls.Add(this.gbxPlanoSaude);
            this.Controls.Add(this.gbxServicos);
            this.Controls.Add(this.gbxOperacoes);
            this.Controls.Add(this.gbxDadosPaciente);
            this.Controls.Add(this.lblCabecalho);
            this.Name = "frmHospital";
            this.Text = "Spock Hospital";
            this.Load += new System.EventHandler(this.frmHospital_Load);
            this.gbxDadosPaciente.ResumeLayout(false);
            this.gbxDadosPaciente.PerformLayout();
            this.gbxPlanoSaude.ResumeLayout(false);
            this.gbxPlanoSaude.PerformLayout();
            this.gbxServicos.ResumeLayout(false);
            this.gbxServicos.PerformLayout();
            this.gbxOperacoes.ResumeLayout(false);
            this.gbxFormaPgto.ResumeLayout(false);
            this.gbxFormaPgto.PerformLayout();
            this.gbxPrazoVista.ResumeLayout(false);
            this.gbxPrazoVista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxPlanoSaude;
        private System.Windows.Forms.GroupBox gbxServicos;
        private System.Windows.Forms.GroupBox gbxOperacoes;
        private System.Windows.Forms.GroupBox gbxFormaPgto;
        private System.Windows.Forms.Label lblTotalApagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTotalServ;
        private System.Windows.Forms.Label lblVtotalServicos;
        private System.Windows.Forms.GroupBox gbxPrazoVista;
        private System.Windows.Forms.Label lblTotalFormaPG;
        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.RadioButton rbtnPrivado;
        private System.Windows.Forms.RadioButton rbtnPartcular;
        private System.Windows.Forms.RadioButton rbtnSus;
        private System.Windows.Forms.CheckBox cbxExamesLaboratoriais;
        private System.Windows.Forms.CheckBox cbxInternacao;
        private System.Windows.Forms.CheckBox cbxConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label lblInternacao;
        private System.Windows.Forms.Label lblExames;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbrirCalculadora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTotalPlanoConvenio;
        private System.Windows.Forms.Label lblCobrarGovernoPlano;
        private System.Windows.Forms.RadioButton rbtnAprazo;
        private System.Windows.Forms.RadioButton rbtnAvista;
    }
}

