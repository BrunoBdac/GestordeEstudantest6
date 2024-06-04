namespace GestorDeEstudantesT6
{
    partial class FormInserirEstudante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirEstudante));
            this.TextBoxSobrenome = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNascimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.RadioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.TextBoxEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.ButtonEnviarFoto = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxSobrenome
            // 
            this.TextBoxSobrenome.Location = new System.Drawing.Point(128, 59);
            this.TextBoxSobrenome.Name = "TextBoxSobrenome";
            this.TextBoxSobrenome.Size = new System.Drawing.Size(163, 20);
            this.TextBoxSobrenome.TabIndex = 9;
            this.TextBoxSobrenome.UseSystemPasswordChar = true;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(128, 33);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(163, 20);
            this.TextBoxNome.TabIndex = 8;
            this.TextBoxNome.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sobrenome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nascimento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxNascimento
            // 
            this.TextBoxNascimento.Location = new System.Drawing.Point(128, 85);
            this.TextBoxNascimento.Name = "TextBoxNascimento";
            this.TextBoxNascimento.Size = new System.Drawing.Size(163, 20);
            this.TextBoxNascimento.TabIndex = 11;
            this.TextBoxNascimento.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gênero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonMasculino);
            this.groupBox1.Controls.Add(this.RadioButtonFeminino);
            this.groupBox1.Location = new System.Drawing.Point(128, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 41);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RadioButtonMasculino
            // 
            this.RadioButtonMasculino.AutoSize = true;
            this.RadioButtonMasculino.Location = new System.Drawing.Point(79, 19);
            this.RadioButtonMasculino.Name = "RadioButtonMasculino";
            this.RadioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.RadioButtonMasculino.TabIndex = 15;
            this.RadioButtonMasculino.TabStop = true;
            this.RadioButtonMasculino.Text = "Masculino";
            this.RadioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFeminino
            // 
            this.RadioButtonFeminino.AutoSize = true;
            this.RadioButtonFeminino.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonFeminino.Name = "RadioButtonFeminino";
            this.RadioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.RadioButtonFeminino.TabIndex = 14;
            this.RadioButtonFeminino.TabStop = true;
            this.RadioButtonFeminino.Text = "Feminino";
            this.RadioButtonFeminino.UseVisualStyleBackColor = true;
            this.RadioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TextBoxEndereco
            // 
            this.TextBoxEndereco.Location = new System.Drawing.Point(127, 228);
            this.TextBoxEndereco.Name = "TextBoxEndereco";
            this.TextBoxEndereco.Size = new System.Drawing.Size(163, 20);
            this.TextBoxEndereco.TabIndex = 17;
            this.TextBoxEndereco.UseSystemPasswordChar = true;
            this.TextBoxEndereco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Endereço";
            // 
            // TextBoxTelefone
            // 
            this.TextBoxTelefone.Location = new System.Drawing.Point(127, 202);
            this.TextBoxTelefone.Name = "TextBoxTelefone";
            this.TextBoxTelefone.Size = new System.Drawing.Size(163, 20);
            this.TextBoxTelefone.TabIndex = 15;
            this.TextBoxTelefone.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(94, 266);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(116, 120);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 18;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCadastrar.Location = new System.Drawing.Point(12, 449);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(135, 51);
            this.ButtonCadastrar.TabIndex = 19;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = true;
            // 
            // ButtonEnviarFoto
            // 
            this.ButtonEnviarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnviarFoto.Location = new System.Drawing.Point(84, 392);
            this.ButtonEnviarFoto.Name = "ButtonEnviarFoto";
            this.ButtonEnviarFoto.Size = new System.Drawing.Size(135, 51);
            this.ButtonEnviarFoto.TabIndex = 20;
            this.ButtonEnviarFoto.Text = "Enviar Foto";
            this.ButtonEnviarFoto.UseVisualStyleBackColor = true;
            this.ButtonEnviarFoto.Click += new System.EventHandler(this.ButtonEnviarFoto_Click_1);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancelar.Location = new System.Drawing.Point(168, 449);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(135, 51);
            this.ButtonCancelar.TabIndex = 21;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click_1);
            // 
            // FormInserirEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 491);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonEnviarFoto);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.TextBoxEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSobrenome);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormInserirEstudante";
            this.Text = "v";
            this.Load += new System.EventHandler(this.FormInserirEstudante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSobrenome;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonMasculino;
        private System.Windows.Forms.RadioButton RadioButtonFeminino;
        private System.Windows.Forms.TextBox TextBoxEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Button ButtonCadastrar;
        private System.Windows.Forms.Button ButtonEnviarFoto;
        private System.Windows.Forms.Button ButtonCancelar;
    }
}