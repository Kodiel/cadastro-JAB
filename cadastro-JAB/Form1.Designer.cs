namespace cadastro_JAB
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtCpf = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            label5 = new Label();
            txtTelefone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            boxM = new CheckBox();
            boxF = new CheckBox();
            confirma_cad = new Button();
            limpa_cad = new Button();
            pickerNascimento = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(531, 52);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Usuário";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 127);
            label2.Name = "label2";
            label2.Size = new Size(201, 44);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.BackColor = SystemColors.Control;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(248, 135);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(854, 28);
            txtNome.TabIndex = 2;
            txtNome.TextAlign = HorizontalAlignment.Center;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = SystemColors.Control;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 185);
            label3.Name = "label3";
            label3.Size = new Size(201, 44);
            label3.TabIndex = 3;
            label3.Text = "CPF";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.BackColor = SystemColors.Control;
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCpf.Location = new Point(248, 192);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(854, 28);
            txtCpf.TabIndex = 4;
            txtCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = SystemColors.Control;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 243);
            label4.Name = "label4";
            label4.Size = new Size(201, 44);
            label4.TabIndex = 5;
            label4.Text = "Logradouro";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEndereco.BackColor = SystemColors.Control;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(248, 249);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(854, 28);
            txtEndereco.TabIndex = 6;
            txtEndereco.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = SystemColors.Control;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 299);
            label5.Name = "label5";
            label5.Size = new Size(201, 44);
            label5.TabIndex = 7;
            label5.Text = "Telefone";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.BackColor = SystemColors.Control;
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(251, 306);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(310, 28);
            txtTelefone.TabIndex = 8;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            txtTelefone.TextChanged += telefone_TextChanged;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(575, 299);
            label6.Name = "label6";
            label6.Size = new Size(201, 44);
            label6.TabIndex = 9;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(792, 306);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 28);
            txtEmail.TabIndex = 10;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = SystemColors.Control;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 356);
            label7.Name = "label7";
            label7.Size = new Size(201, 44);
            label7.TabIndex = 11;
            label7.Text = "Data de nascimento";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(575, 356);
            label8.Name = "label8";
            label8.Size = new Size(201, 44);
            label8.TabIndex = 13;
            label8.Text = "Sexo";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boxM
            // 
            boxM.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxM.Location = new Point(792, 365);
            boxM.Name = "boxM";
            boxM.Size = new Size(135, 30);
            boxM.TabIndex = 14;
            boxM.Text = "Masculino";
            boxM.UseVisualStyleBackColor = true;
            boxM.CheckedChanged += boxM_CheckedChanged;
            // 
            // boxF
            // 
            boxF.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxF.Location = new Point(967, 364);
            boxF.Name = "boxF";
            boxF.Size = new Size(135, 30);
            boxF.TabIndex = 15;
            boxF.Text = "Feminino";
            boxF.UseVisualStyleBackColor = true;
            boxF.CheckedChanged += boxF_CheckedChanged;
            // 
            // confirma_cad
            // 
            confirma_cad.BackColor = Color.DarkOrange;
            confirma_cad.FlatStyle = FlatStyle.Popup;
            confirma_cad.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirma_cad.ForeColor = SystemColors.Window;
            confirma_cad.Location = new Point(27, 467);
            confirma_cad.Name = "confirma_cad";
            confirma_cad.Size = new Size(201, 59);
            confirma_cad.TabIndex = 16;
            confirma_cad.Text = "Confirmar";
            confirma_cad.UseVisualStyleBackColor = false;
            confirma_cad.Click += confirma_cad_Click;
            // 
            // limpa_cad
            // 
            limpa_cad.BackColor = SystemColors.Control;
            limpa_cad.FlatStyle = FlatStyle.Popup;
            limpa_cad.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            limpa_cad.ForeColor = SystemColors.MenuText;
            limpa_cad.Location = new Point(248, 467);
            limpa_cad.Name = "limpa_cad";
            limpa_cad.Size = new Size(201, 59);
            limpa_cad.TabIndex = 17;
            limpa_cad.Text = "Limpar";
            limpa_cad.UseVisualStyleBackColor = false;
            limpa_cad.Click += limpa_cad_Click;
            // 
            // pickerNascimento
            // 
            pickerNascimento.CalendarFont = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pickerNascimento.CalendarMonthBackground = SystemColors.Control;
            pickerNascimento.Checked = false;
            pickerNascimento.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pickerNascimento.Format = DateTimePickerFormat.Short;
            pickerNascimento.Location = new Point(251, 367);
            pickerNascimento.MaxDate = new DateTime(2006, 12, 31, 0, 0, 0, 0);
            pickerNascimento.MinDate = new DateTime(1935, 12, 31, 0, 0, 0, 0);
            pickerNascimento.Name = "pickerNascimento";
            pickerNascimento.RightToLeft = RightToLeft.Yes;
            pickerNascimento.Size = new Size(307, 29);
            pickerNascimento.TabIndex = 19;
            pickerNascimento.Value = new DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1125, 552);
            Controls.Add(pickerNascimento);
            Controls.Add(limpa_cad);
            Controls.Add(confirma_cad);
            Controls.Add(boxF);
            Controls.Add(boxM);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(txtEndereco);
            Controls.Add(label4);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCpf;
        private Label label4;
        private TextBox txtEndereco;
        private Label label5;
        private TextBox txtTelefone;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private Label label8;
        private CheckBox boxM;
        private CheckBox boxF;
        private Button confirma_cad;
        private Button limpa_cad;
        private DateTimePicker pickerNascimento;
        public TextBox txtNome;
    }
}
