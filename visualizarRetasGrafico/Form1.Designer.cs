namespace visualizarRetasGrafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inclinacaoBox = new System.Windows.Forms.TextBox();
            inclinacaoLabel = new System.Windows.Forms.Label();
            azulBtn = new System.Windows.Forms.RadioButton();
            interceptoLabel = new System.Windows.Forms.Label();
            interceptoBox = new System.Windows.Forms.TextBox();
            intervaloLabel = new System.Windows.Forms.Label();
            intervalosBox = new System.Windows.Forms.TextBox();
            verdeBtn = new System.Windows.Forms.RadioButton();
            cinzaBtn = new System.Windows.Forms.RadioButton();
            laranjaBtn = new System.Windows.Forms.RadioButton();
            rosaBtn = new System.Windows.Forms.RadioButton();
            pretoBtn = new System.Windows.Forms.RadioButton();
            roxoBtn = new System.Windows.Forms.RadioButton();
            marromBtn = new System.Windows.Forms.RadioButton();
            amareloBtn = new System.Windows.Forms.RadioButton();
            coresLabel = new System.Windows.Forms.Label();
            listaRetas = new System.Windows.Forms.ListBox();
            listaLabel = new System.Windows.Forms.Label();
            controleLabel = new System.Windows.Forms.Label();
            criarRetaBtn = new System.Windows.Forms.Button();
            deletarRetaBtn = new System.Windows.Forms.Button();
            salvarImagemBtn = new System.Windows.Forms.Button();
            yPositivoLabel = new System.Windows.Forms.Label();
            YNegativoLabel = new System.Windows.Forms.Label();
            xPositivoLabel = new System.Windows.Forms.Label();
            xNegativoLabel = new System.Windows.Forms.Label();
            resetarPlanoBtn = new System.Windows.Forms.Button();
            messageLabel = new System.Windows.Forms.Label();
            deletarBox = new System.Windows.Forms.TextBox();
            deleteLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // inclinacaoBox
            // 
            inclinacaoBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            inclinacaoBox.Location = new System.Drawing.Point(330, 96);
            inclinacaoBox.Name = "inclinacaoBox";
            inclinacaoBox.Size = new System.Drawing.Size(75, 23);
            inclinacaoBox.TabIndex = 0;
            // 
            // inclinacaoLabel
            // 
            inclinacaoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            inclinacaoLabel.AutoSize = true;
            inclinacaoLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            inclinacaoLabel.Location = new System.Drawing.Point(12, 83);
            inclinacaoLabel.Name = "inclinacaoLabel";
            inclinacaoLabel.Size = new System.Drawing.Size(289, 45);
            inclinacaoLabel.TabIndex = 1;
            inclinacaoLabel.Text = "Defina o valor da inclinação(m):";
            // 
            // azulBtn
            // 
            azulBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            azulBtn.AutoSize = true;
            azulBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            azulBtn.ForeColor = System.Drawing.Color.Blue;
            azulBtn.Location = new System.Drawing.Point(458, 94);
            azulBtn.Name = "azulBtn";
            azulBtn.Size = new System.Drawing.Size(60, 22);
            azulBtn.TabIndex = 3;
            azulBtn.TabStop = true;
            azulBtn.Text = "Azul";
            azulBtn.UseVisualStyleBackColor = true;
            // 
            // interceptoLabel
            // 
            interceptoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            interceptoLabel.AutoSize = true;
            interceptoLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            interceptoLabel.Location = new System.Drawing.Point(12, 125);
            interceptoLabel.Name = "interceptoLabel";
            interceptoLabel.Size = new System.Drawing.Size(282, 45);
            interceptoLabel.TabIndex = 5;
            interceptoLabel.Text = "Defina o valor do intercepto(b):";
            // 
            // interceptoBox
            // 
            interceptoBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            interceptoBox.Location = new System.Drawing.Point(330, 139);
            interceptoBox.Name = "interceptoBox";
            interceptoBox.Size = new System.Drawing.Size(75, 23);
            interceptoBox.TabIndex = 4;
            // 
            // intervaloLabel
            // 
            intervaloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            intervaloLabel.AutoSize = true;
            intervaloLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            intervaloLabel.Location = new System.Drawing.Point(12, 178);
            intervaloLabel.Name = "intervaloLabel";
            intervaloLabel.Size = new System.Drawing.Size(312, 45);
            intervaloLabel.TabIndex = 7;
            intervaloLabel.Text = "Defina os valores dos intervalos(x):";
            // 
            // intervalosBox
            // 
            intervalosBox.Location = new System.Drawing.Point(330, 184);
            intervalosBox.Multiline = true;
            intervalosBox.Name = "intervalosBox";
            intervalosBox.Size = new System.Drawing.Size(75, 37);
            intervalosBox.TabIndex = 6;
            // 
            // verdeBtn
            // 
            verdeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            verdeBtn.AutoSize = true;
            verdeBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            verdeBtn.ForeColor = System.Drawing.Color.Green;
            verdeBtn.Location = new System.Drawing.Point(458, 184);
            verdeBtn.Name = "verdeBtn";
            verdeBtn.Size = new System.Drawing.Size(71, 22);
            verdeBtn.TabIndex = 8;
            verdeBtn.TabStop = true;
            verdeBtn.Text = "Verde";
            verdeBtn.UseVisualStyleBackColor = true;
            // 
            // cinzaBtn
            // 
            cinzaBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cinzaBtn.AutoSize = true;
            cinzaBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            cinzaBtn.ForeColor = System.Drawing.Color.Gray;
            cinzaBtn.Location = new System.Drawing.Point(458, 140);
            cinzaBtn.Name = "cinzaBtn";
            cinzaBtn.Size = new System.Drawing.Size(69, 22);
            cinzaBtn.TabIndex = 9;
            cinzaBtn.TabStop = true;
            cinzaBtn.Text = "Cinza";
            cinzaBtn.UseVisualStyleBackColor = true;
            // 
            // laranjaBtn
            // 
            laranjaBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            laranjaBtn.AutoSize = true;
            laranjaBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            laranjaBtn.ForeColor = System.Drawing.Color.Orange;
            laranjaBtn.Location = new System.Drawing.Point(615, 140);
            laranjaBtn.Name = "laranjaBtn";
            laranjaBtn.Size = new System.Drawing.Size(89, 22);
            laranjaBtn.TabIndex = 12;
            laranjaBtn.TabStop = true;
            laranjaBtn.Text = "Laranja";
            laranjaBtn.UseVisualStyleBackColor = true;
            // 
            // rosaBtn
            // 
            rosaBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            rosaBtn.AutoSize = true;
            rosaBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            rosaBtn.ForeColor = System.Drawing.Color.FromArgb(255, 192, 255);
            rosaBtn.Location = new System.Drawing.Point(615, 184);
            rosaBtn.Name = "rosaBtn";
            rosaBtn.Size = new System.Drawing.Size(65, 22);
            rosaBtn.TabIndex = 11;
            rosaBtn.TabStop = true;
            rosaBtn.Text = "Rosa";
            rosaBtn.UseVisualStyleBackColor = true;
            // 
            // pretoBtn
            // 
            pretoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pretoBtn.AutoSize = true;
            pretoBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            pretoBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            pretoBtn.Location = new System.Drawing.Point(615, 94);
            pretoBtn.Name = "pretoBtn";
            pretoBtn.Size = new System.Drawing.Size(69, 22);
            pretoBtn.TabIndex = 10;
            pretoBtn.TabStop = true;
            pretoBtn.Text = "Preto";
            pretoBtn.UseVisualStyleBackColor = true;
            // 
            // roxoBtn
            // 
            roxoBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            roxoBtn.AutoSize = true;
            roxoBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            roxoBtn.ForeColor = System.Drawing.Color.DarkViolet;
            roxoBtn.Location = new System.Drawing.Point(740, 137);
            roxoBtn.Name = "roxoBtn";
            roxoBtn.Size = new System.Drawing.Size(67, 22);
            roxoBtn.TabIndex = 15;
            roxoBtn.TabStop = true;
            roxoBtn.Text = "Roxo";
            roxoBtn.UseVisualStyleBackColor = true;
            // 
            // marromBtn
            // 
            marromBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            marromBtn.AutoSize = true;
            marromBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            marromBtn.ForeColor = System.Drawing.Color.Sienna;
            marromBtn.Location = new System.Drawing.Point(740, 181);
            marromBtn.Name = "marromBtn";
            marromBtn.Size = new System.Drawing.Size(93, 22);
            marromBtn.TabIndex = 14;
            marromBtn.TabStop = true;
            marromBtn.Text = "Marrom";
            marromBtn.UseVisualStyleBackColor = true;
            // 
            // amareloBtn
            // 
            amareloBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            amareloBtn.AutoSize = true;
            amareloBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            amareloBtn.ForeColor = System.Drawing.Color.Yellow;
            amareloBtn.Location = new System.Drawing.Point(740, 95);
            amareloBtn.Name = "amareloBtn";
            amareloBtn.Size = new System.Drawing.Size(93, 22);
            amareloBtn.TabIndex = 13;
            amareloBtn.TabStop = true;
            amareloBtn.Text = "Amarelo";
            amareloBtn.UseVisualStyleBackColor = true;
            // 
            // coresLabel
            // 
            coresLabel.AutoSize = true;
            coresLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            coresLabel.Location = new System.Drawing.Point(458, 46);
            coresLabel.Name = "coresLabel";
            coresLabel.Size = new System.Drawing.Size(342, 45);
            coresLabel.TabIndex = 16;
            coresLabel.Text = "Escolha uma opção de cor para a reta: ";
            // 
            // listaRetas
            // 
            listaRetas.FormattingEnabled = true;
            listaRetas.ItemHeight = 15;
            listaRetas.Location = new System.Drawing.Point(961, 94);
            listaRetas.Name = "listaRetas";
            listaRetas.Size = new System.Drawing.Size(381, 184);
            listaRetas.TabIndex = 17;
            // 
            // listaLabel
            // 
            listaLabel.AutoSize = true;
            listaLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            listaLabel.Location = new System.Drawing.Point(1039, 46);
            listaLabel.Name = "listaLabel";
            listaLabel.Size = new System.Drawing.Size(151, 45);
            listaLabel.TabIndex = 18;
            listaLabel.Text = "Retas inseridas:";
            // 
            // controleLabel
            // 
            controleLabel.AutoSize = true;
            controleLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            controleLabel.Location = new System.Drawing.Point(1039, 366);
            controleLabel.Name = "controleLabel";
            controleLabel.Size = new System.Drawing.Size(186, 45);
            controleLabel.TabIndex = 19;
            controleLabel.Text = "Opções de Controle:";
            // 
            // criarRetaBtn
            // 
            criarRetaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            criarRetaBtn.FlatAppearance.BorderSize = 2;
            criarRetaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            criarRetaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            criarRetaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            criarRetaBtn.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            criarRetaBtn.Location = new System.Drawing.Point(990, 459);
            criarRetaBtn.Name = "criarRetaBtn";
            criarRetaBtn.Size = new System.Drawing.Size(129, 31);
            criarRetaBtn.TabIndex = 20;
            criarRetaBtn.Text = "Criar Reta";
            criarRetaBtn.UseVisualStyleBackColor = true;
            criarRetaBtn.Click += criarRetaBtn_Click;
            // 
            // deletarRetaBtn
            // 
            deletarRetaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            deletarRetaBtn.FlatAppearance.BorderSize = 2;
            deletarRetaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            deletarRetaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            deletarRetaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deletarRetaBtn.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deletarRetaBtn.Location = new System.Drawing.Point(1125, 459);
            deletarRetaBtn.Name = "deletarRetaBtn";
            deletarRetaBtn.Size = new System.Drawing.Size(129, 31);
            deletarRetaBtn.TabIndex = 21;
            deletarRetaBtn.Text = "Deletar Reta";
            deletarRetaBtn.UseVisualStyleBackColor = true;
            deletarRetaBtn.Click += deletarRetaBtn_Click;
            // 
            // salvarImagemBtn
            // 
            salvarImagemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            salvarImagemBtn.FlatAppearance.BorderSize = 2;
            salvarImagemBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            salvarImagemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            salvarImagemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            salvarImagemBtn.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            salvarImagemBtn.Location = new System.Drawing.Point(990, 620);
            salvarImagemBtn.Name = "salvarImagemBtn";
            salvarImagemBtn.Size = new System.Drawing.Size(352, 31);
            salvarImagemBtn.TabIndex = 23;
            salvarImagemBtn.Text = "Gerar Arquivo com o conjunto Imagem das Retas";
            salvarImagemBtn.UseVisualStyleBackColor = true;
            salvarImagemBtn.Click += salvarImagemBtn_Click;
            // 
            // yPositivoLabel
            // 
            yPositivoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            yPositivoLabel.AutoSize = true;
            yPositivoLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            yPositivoLabel.Location = new System.Drawing.Point(458, 290);
            yPositivoLabel.Name = "yPositivoLabel";
            yPositivoLabel.Size = new System.Drawing.Size(110, 18);
            yPositivoLabel.TabIndex = 24;
            yPositivoLabel.Text = "Y Máx(230).";
            // 
            // YNegativoLabel
            // 
            YNegativoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            YNegativoLabel.AutoSize = true;
            YNegativoLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            YNegativoLabel.Location = new System.Drawing.Point(458, 680);
            YNegativoLabel.Name = "YNegativoLabel";
            YNegativoLabel.Size = new System.Drawing.Size(113, 18);
            YNegativoLabel.TabIndex = 25;
            YNegativoLabel.Text = "Y Min(-120).";
            // 
            // xPositivoLabel
            // 
            xPositivoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            xPositivoLabel.AutoSize = true;
            xPositivoLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            xPositivoLabel.Location = new System.Drawing.Point(776, 548);
            xPositivoLabel.Name = "xPositivoLabel";
            xPositivoLabel.Size = new System.Drawing.Size(109, 18);
            xPositivoLabel.TabIndex = 26;
            xPositivoLabel.Text = "X Máx(315).";
            // 
            // xNegativoLabel
            // 
            xNegativoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            xNegativoLabel.AutoSize = true;
            xNegativoLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            xNegativoLabel.Location = new System.Drawing.Point(12, 548);
            xNegativoLabel.Name = "xNegativoLabel";
            xNegativoLabel.Size = new System.Drawing.Size(113, 18);
            xNegativoLabel.TabIndex = 27;
            xNegativoLabel.Text = "X Min(-315).";
            // 
            // resetarPlanoBtn
            // 
            resetarPlanoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            resetarPlanoBtn.FlatAppearance.BorderSize = 2;
            resetarPlanoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            resetarPlanoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            resetarPlanoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resetarPlanoBtn.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            resetarPlanoBtn.Location = new System.Drawing.Point(990, 548);
            resetarPlanoBtn.Name = "resetarPlanoBtn";
            resetarPlanoBtn.Size = new System.Drawing.Size(352, 31);
            resetarPlanoBtn.TabIndex = 28;
            resetarPlanoBtn.Text = "Limpar o Plano Cartesiano";
            resetarPlanoBtn.UseVisualStyleBackColor = true;
            resetarPlanoBtn.Click += resetarPlanoBtn_Click;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            messageLabel.Location = new System.Drawing.Point(12, 710);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(0, 25);
            messageLabel.TabIndex = 29;
            // 
            // deletarBox
            // 
            deletarBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            deletarBox.Location = new System.Drawing.Point(1260, 465);
            deletarBox.Name = "deletarBox";
            deletarBox.Size = new System.Drawing.Size(75, 23);
            deletarBox.TabIndex = 30;
            // 
            // deleteLabel
            // 
            deleteLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            deleteLabel.AutoSize = true;
            deleteLabel.Font = new System.Drawing.Font("Georgia", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteLabel.Location = new System.Drawing.Point(1260, 453);
            deleteLabel.Name = "deleteLabel";
            deleteLabel.Size = new System.Drawing.Size(75, 9);
            deleteLabel.TabIndex = 31;
            deleteLabel.Text = "Número da Reta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(1354, 661);
            Controls.Add(deleteLabel);
            Controls.Add(deletarBox);
            Controls.Add(messageLabel);
            Controls.Add(resetarPlanoBtn);
            Controls.Add(xNegativoLabel);
            Controls.Add(xPositivoLabel);
            Controls.Add(YNegativoLabel);
            Controls.Add(yPositivoLabel);
            Controls.Add(salvarImagemBtn);
            Controls.Add(deletarRetaBtn);
            Controls.Add(criarRetaBtn);
            Controls.Add(controleLabel);
            Controls.Add(listaLabel);
            Controls.Add(listaRetas);
            Controls.Add(coresLabel);
            Controls.Add(roxoBtn);
            Controls.Add(marromBtn);
            Controls.Add(amareloBtn);
            Controls.Add(laranjaBtn);
            Controls.Add(rosaBtn);
            Controls.Add(pretoBtn);
            Controls.Add(cinzaBtn);
            Controls.Add(verdeBtn);
            Controls.Add(intervaloLabel);
            Controls.Add(intervalosBox);
            Controls.Add(interceptoLabel);
            Controls.Add(interceptoBox);
            Controls.Add(azulBtn);
            Controls.Add(inclinacaoLabel);
            Controls.Add(inclinacaoBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Vizualizar Retas em um Grafico";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox inclinacaoBox;
        private System.Windows.Forms.Label inclinacaoLabel;
        private System.Windows.Forms.RadioButton azulBtn;
        private System.Windows.Forms.Label interceptoLabel;
        private System.Windows.Forms.TextBox interceptoBox;
        private System.Windows.Forms.Label intervaloLabel;
        private System.Windows.Forms.TextBox intervalosBox;
        private System.Windows.Forms.RadioButton verdeBtn;
        private System.Windows.Forms.RadioButton cinzaBtn;
        private System.Windows.Forms.RadioButton laranjaBtn;
        private System.Windows.Forms.RadioButton rosaBtn;
        private System.Windows.Forms.RadioButton pretoBtn;
        private System.Windows.Forms.RadioButton roxoBtn;
        private System.Windows.Forms.RadioButton marromBtn;
        private System.Windows.Forms.RadioButton amareloBtn;
        private System.Windows.Forms.Label coresLabel;
        private System.Windows.Forms.ListBox listaRetas;
        private System.Windows.Forms.Label listaLabel;
        private System.Windows.Forms.Label controleLabel;
        private System.Windows.Forms.Button criarRetaBtn;
        private System.Windows.Forms.Button deletarRetaBtn;
        private System.Windows.Forms.Button salvarImagemBtn;
        private System.Windows.Forms.Label yPositivoLabel;
        private System.Windows.Forms.Label YNegativoLabel;
        private System.Windows.Forms.Label xPositivoLabel;
        private System.Windows.Forms.Label xNegativoLabel;
        private System.Windows.Forms.Button resetarPlanoBtn;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox deletarBox;
        private System.Windows.Forms.Label deleteLabel;
    }
}
