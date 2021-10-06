namespace FippCare
{
    partial class frmDependentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.gbDadosDependente = new System.Windows.Forms.GroupBox();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.tbGrauParentesco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSalvar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.gbDadosDependente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO DE DEPENDENTES";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(221, 39);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(119, 24);
            this.cbSexo.TabIndex = 11;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(6, 84);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(338, 22);
            this.tbNome.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de Nasc.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPF:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(6, 39);
            this.mtbCPF.Mask = "000-000-000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(96, 22);
            this.mtbCPF.TabIndex = 5;
            // 
            // gbDadosDependente
            // 
            this.gbDadosDependente.Controls.Add(this.dtpDtNasc);
            this.gbDadosDependente.Controls.Add(this.mtbCPF);
            this.gbDadosDependente.Controls.Add(this.cbSexo);
            this.gbDadosDependente.Controls.Add(this.label7);
            this.gbDadosDependente.Controls.Add(this.label3);
            this.gbDadosDependente.Controls.Add(this.tbGrauParentesco);
            this.gbDadosDependente.Controls.Add(this.tbNome);
            this.gbDadosDependente.Controls.Add(this.label5);
            this.gbDadosDependente.Controls.Add(this.label2);
            this.gbDadosDependente.Controls.Add(this.label4);
            this.gbDadosDependente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosDependente.Location = new System.Drawing.Point(12, 42);
            this.gbDadosDependente.Name = "gbDadosDependente";
            this.gbDadosDependente.Size = new System.Drawing.Size(351, 152);
            this.gbDadosDependente.TabIndex = 12;
            this.gbDadosDependente.TabStop = false;
            this.gbDadosDependente.Text = "Dados do Dependente:";
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDtNasc.Location = new System.Drawing.Point(114, 39);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(94, 22);
            this.dtpDtNasc.TabIndex = 12;
            this.dtpDtNasc.Value = new System.DateTime(2018, 9, 14, 0, 0, 0, 0);
            // 
            // tbGrauParentesco
            // 
            this.tbGrauParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGrauParentesco.Location = new System.Drawing.Point(6, 125);
            this.tbGrauParentesco.Name = "tbGrauParentesco";
            this.tbGrauParentesco.Size = new System.Drawing.Size(338, 22);
            this.tbGrauParentesco.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grau de Parentesco:";
            // 
            // bSalvar
            // 
            this.bSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.bSalvar.BackgroundImage = global::FippCare.Properties.Resources.Users_Checked_User_icon1;
            this.bSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bSalvar.Location = new System.Drawing.Point(201, 200);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(71, 35);
            this.bSalvar.TabIndex = 13;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSalvar.UseVisualStyleBackColor = false;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.bCancelar.BackgroundImage = global::FippCare.Properties.Resources.cancel_icon;
            this.bCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bCancelar.Location = new System.Drawing.Point(278, 200);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(85, 35);
            this.bCancelar.TabIndex = 13;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCancelar.UseVisualStyleBackColor = false;
            // 
            // frmDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(375, 240);
            this.Controls.Add(this.bSalvar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.gbDadosDependente);
            this.Controls.Add(this.label1);
            this.Name = "frmDependentes";
            this.Text = "frmDependentes";
            this.gbDadosDependente.ResumeLayout(false);
            this.gbDadosDependente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.GroupBox gbDadosDependente;
        private System.Windows.Forms.TextBox tbGrauParentesco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
    }
}