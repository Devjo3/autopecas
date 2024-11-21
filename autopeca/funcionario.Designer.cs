namespace autopeca
{
    partial class funcionario
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.sair = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.deletar = new System.Windows.Forms.Button();
            this.busca = new System.Windows.Forms.Button();
            this.inserir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.senha_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(614, 24);
            this.comboBox1.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "CARGO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "EMAIL:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(148, 162);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(615, 22);
            this.email.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "ID:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(149, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(615, 22);
            this.id.TabIndex = 42;
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(655, 408);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(108, 36);
            this.sair.TabIndex = 41;
            this.sair.Text = "SAIR";
            this.sair.UseVisualStyleBackColor = true;
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(260, 408);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(108, 36);
            this.alterar.TabIndex = 40;
            this.alterar.Text = "ATUALIZAR";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.alterar_Click_1);
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(374, 408);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(108, 36);
            this.deletar.TabIndex = 39;
            this.deletar.Text = "DELETAR";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click_1);
            // 
            // busca
            // 
            this.busca.Location = new System.Drawing.Point(149, 408);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(108, 36);
            this.busca.TabIndex = 38;
            this.busca.Text = "PROCURAR";
            this.busca.UseVisualStyleBackColor = true;
            this.busca.Click += new System.EventHandler(this.busca_Click_1);
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(38, 408);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(108, 36);
            this.inserir.TabIndex = 37;
            this.inserir.Text = "INSERIR";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 137);
            this.dataGridView1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "ENDEREÇO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "TELEFONE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "NOME:";
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(148, 134);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(615, 22);
            this.endereco.TabIndex = 31;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(148, 105);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(615, 22);
            this.telefone.TabIndex = 30;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(148, 77);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(615, 22);
            this.cpf.TabIndex = 29;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(148, 49);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(615, 22);
            this.nome.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "SENHA:";
            // 
            // senha_txt
            // 
            this.senha_txt.Location = new System.Drawing.Point(149, 231);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(615, 22);
            this.senha_txt.TabIndex = 49;
            // 
            // funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senha_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.nome);
            this.Name = "funcionario";
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button busca;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox senha_txt;
    }
}