namespace FoodStore.Windows.Forms.Empresas
{
	partial class frmEmpresasAE
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
			btnOk = new Button();
			btnCancelar = new Button();
			label2 = new Label();
			tbxCuit = new TextBox();
			tbxCalle1 = new TextBox();
			label1 = new Label();
			tbxRazonSocial = new TextBox();
			label3 = new Label();
			tbxEmail = new TextBox();
			tbxTelefono = new TextBox();
			label4 = new Label();
			label5 = new Label();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			button2 = new Button();
			button1 = new Button();
			btnAgregarLocalidades = new Button();
			label10 = new Label();
			cbxPaises = new ComboBox();
			label9 = new Label();
			cbxProvincias = new ComboBox();
			label8 = new Label();
			cbxLocalidades = new ComboBox();
			label7 = new Label();
			tbxNumero = new TextBox();
			label6 = new Label();
			tbxCalle2 = new TextBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// btnOk
			// 
			btnOk.Location = new Point(564, 419);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 21;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(641, 419);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 22;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(314, 13);
			label2.Name = "label2";
			label2.Size = new Size(43, 25);
			label2.TabIndex = 16;
			label2.Text = "Cuit";
			// 
			// tbxCuit
			// 
			tbxCuit.Location = new Point(314, 41);
			tbxCuit.MaxLength = 12;
			tbxCuit.Name = "tbxCuit";
			tbxCuit.Size = new Size(268, 31);
			tbxCuit.TabIndex = 12;
			tbxCuit.TextChanged += tbxCuit_TextChanged;
			// 
			// tbxCalle1
			// 
			tbxCalle1.Location = new Point(29, 55);
			tbxCalle1.Name = "tbxCalle1";
			tbxCalle1.Size = new Size(192, 31);
			tbxCalle1.TabIndex = 15;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 27);
			label1.Name = "label1";
			label1.Size = new Size(64, 25);
			label1.TabIndex = 16;
			label1.Text = "Calle 1";
			// 
			// tbxRazonSocial
			// 
			tbxRazonSocial.Location = new Point(12, 41);
			tbxRazonSocial.Name = "tbxRazonSocial";
			tbxRazonSocial.Size = new Size(268, 31);
			tbxRazonSocial.TabIndex = 15;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 13);
			label3.Name = "label3";
			label3.Size = new Size(110, 25);
			label3.TabIndex = 16;
			label3.Text = "Razon social";
			// 
			// tbxEmail
			// 
			tbxEmail.Location = new Point(28, 117);
			tbxEmail.MaxLength = 200;
			tbxEmail.Name = "tbxEmail";
			tbxEmail.Size = new Size(268, 31);
			tbxEmail.TabIndex = 15;
			// 
			// tbxTelefono
			// 
			tbxTelefono.Location = new Point(28, 55);
			tbxTelefono.MaxLength = 11;
			tbxTelefono.Name = "tbxTelefono";
			tbxTelefono.Size = new Size(268, 31);
			tbxTelefono.TabIndex = 15;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(28, 89);
			label4.Name = "label4";
			label4.Size = new Size(54, 25);
			label4.TabIndex = 16;
			label4.Text = "Email";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 27);
			label5.Name = "label5";
			label5.Size = new Size(79, 25);
			label5.TabIndex = 16;
			label5.Text = "Telefono";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(tbxEmail);
			groupBox1.Controls.Add(tbxTelefono);
			groupBox1.Controls.Add(label4);
			groupBox1.FlatStyle = FlatStyle.System;
			groupBox1.Location = new Point(390, 103);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(322, 189);
			groupBox1.TabIndex = 23;
			groupBox1.TabStop = false;
			groupBox1.Text = "Contacto";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button2);
			groupBox2.Controls.Add(button1);
			groupBox2.Controls.Add(btnAgregarLocalidades);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(cbxPaises);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(cbxProvincias);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(cbxLocalidades);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(tbxNumero);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(tbxCalle2);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(tbxCalle1);
			groupBox2.Location = new Point(8, 103);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(358, 383);
			groupBox2.TabIndex = 24;
			groupBox2.TabStop = false;
			groupBox2.Text = "Direccion";
			// 
			// button2
			// 
			button2.Location = new Point(227, 179);
			button2.Name = "button2";
			button2.Size = new Size(33, 33);
			button2.TabIndex = 25;
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(227, 243);
			button1.Name = "button1";
			button1.Size = new Size(33, 33);
			button1.TabIndex = 25;
			button1.UseVisualStyleBackColor = true;
			// 
			// btnAgregarLocalidades
			// 
			btnAgregarLocalidades.Location = new Point(227, 307);
			btnAgregarLocalidades.Name = "btnAgregarLocalidades";
			btnAgregarLocalidades.Size = new Size(33, 33);
			btnAgregarLocalidades.TabIndex = 25;
			btnAgregarLocalidades.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(29, 151);
			label10.Name = "label10";
			label10.Size = new Size(42, 25);
			label10.TabIndex = 18;
			label10.Text = "Pais";
			// 
			// cbxPaises
			// 
			cbxPaises.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxPaises.FormattingEnabled = true;
			cbxPaises.Location = new Point(29, 179);
			cbxPaises.Name = "cbxPaises";
			cbxPaises.Size = new Size(192, 33);
			cbxPaises.TabIndex = 17;
			cbxPaises.SelectedIndexChanged += cbxPaises_SelectedIndexChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(29, 215);
			label9.Name = "label9";
			label9.Size = new Size(83, 25);
			label9.TabIndex = 18;
			label9.Text = "Provincia";
			// 
			// cbxProvincias
			// 
			cbxProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxProvincias.FormattingEnabled = true;
			cbxProvincias.Location = new Point(29, 243);
			cbxProvincias.Name = "cbxProvincias";
			cbxProvincias.Size = new Size(192, 33);
			cbxProvincias.TabIndex = 17;
			cbxProvincias.SelectedIndexChanged += cbxProvincias_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(29, 279);
			label8.Name = "label8";
			label8.Size = new Size(87, 25);
			label8.TabIndex = 18;
			label8.Text = "Localidad";
			// 
			// cbxLocalidades
			// 
			cbxLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxLocalidades.FormattingEnabled = true;
			cbxLocalidades.Location = new Point(29, 307);
			cbxLocalidades.Name = "cbxLocalidades";
			cbxLocalidades.Size = new Size(192, 33);
			cbxLocalidades.TabIndex = 17;
			cbxLocalidades.SelectedIndexChanged += cbxLocalidades_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(239, 27);
			label7.Name = "label7";
			label7.Size = new Size(77, 25);
			label7.TabIndex = 16;
			label7.Text = "Numero";
			// 
			// tbxNumero
			// 
			tbxNumero.Location = new Point(239, 55);
			tbxNumero.MaxLength = 4;
			tbxNumero.Name = "tbxNumero";
			tbxNumero.Size = new Size(98, 31);
			tbxNumero.TabIndex = 15;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(29, 89);
			label6.Name = "label6";
			label6.Size = new Size(64, 25);
			label6.TabIndex = 16;
			label6.Text = "Calle 2";
			// 
			// tbxCalle2
			// 
			tbxCalle2.Location = new Point(29, 117);
			tbxCalle2.Name = "tbxCalle2";
			tbxCalle2.Size = new Size(192, 31);
			tbxCalle2.TabIndex = 15;
			// 
			// frmEmpresasAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 255, 145);
			ClientSize = new Size(729, 501);
			ControlBox = false;
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(tbxRazonSocial);
			Controls.Add(tbxCuit);
			Name = "frmEmpresasAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmEmpresasAE";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOk;
		private Button btnCancelar;
		private Label label2;
		private TextBox tbxCuit;
		private TextBox tbxCalle1;
		private Label label1;
		private TextBox tbxRazonSocial;
		private Label label3;
		private TextBox tbxEmail;
		private TextBox tbxTelefono;
		private Label label4;
		private Label label5;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label8;
		private ComboBox cbxLocalidades;
		private Label label7;
		private TextBox tbxNumero;
		private Label label6;
		private TextBox tbxCalle2;
		private Button btnAgregarLocalidades;
		private Button button2;
		private Button button1;
		private Label label10;
		private ComboBox cbxPaises;
		private Label label9;
		private ComboBox cbxProvincias;
	}
}