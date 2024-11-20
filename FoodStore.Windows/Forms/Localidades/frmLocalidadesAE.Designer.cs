namespace FoodStore.Windows.Forms.Localidades
{
	partial class frmLocalidadesAE
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
			cbxPaises = new ComboBox();
			btnAgregarPais = new Button();
			btnOk = new Button();
			btnCancelar = new Button();
			label2 = new Label();
			label1 = new Label();
			tbxLocalidad = new TextBox();
			label3 = new Label();
			cbxProvincias = new ComboBox();
			btnAgregarProvincia = new Button();
			SuspendLayout();
			// 
			// cbxPaises
			// 
			cbxPaises.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxPaises.FormattingEnabled = true;
			cbxPaises.Location = new Point(12, 42);
			cbxPaises.Name = "cbxPaises";
			cbxPaises.Size = new Size(268, 33);
			cbxPaises.TabIndex = 14;
			cbxPaises.SelectedIndexChanged += cbxPaises_SelectedIndexChanged;
			// 
			// btnAgregarPais
			// 
			btnAgregarPais.Location = new Point(286, 42);
			btnAgregarPais.Name = "btnAgregarPais";
			btnAgregarPais.Size = new Size(40, 33);
			btnAgregarPais.TabIndex = 11;
			btnAgregarPais.UseVisualStyleBackColor = true;
			btnAgregarPais.Click += btnAgregarPais_Click;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(132, 256);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 12;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(209, 256);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 13;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 142);
			label2.Name = "label2";
			label2.Size = new Size(87, 25);
			label2.TabIndex = 9;
			label2.Text = "Localidad";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 14);
			label1.Name = "label1";
			label1.Size = new Size(42, 25);
			label1.TabIndex = 10;
			label1.Text = "Pais";
			// 
			// tbxLocalidad
			// 
			tbxLocalidad.Location = new Point(12, 170);
			tbxLocalidad.Name = "tbxLocalidad";
			tbxLocalidad.Size = new Size(268, 31);
			tbxLocalidad.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 78);
			label3.Name = "label3";
			label3.Size = new Size(83, 25);
			label3.TabIndex = 10;
			label3.Text = "Provincia";
			// 
			// cbxProvincias
			// 
			cbxProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxProvincias.FormattingEnabled = true;
			cbxProvincias.Location = new Point(12, 106);
			cbxProvincias.Name = "cbxProvincias";
			cbxProvincias.Size = new Size(268, 33);
			cbxProvincias.TabIndex = 14;
			cbxProvincias.SelectedIndexChanged += cbxProvincias_SelectedIndexChanged;
			// 
			// btnAgregarProvincia
			// 
			btnAgregarProvincia.Location = new Point(287, 106);
			btnAgregarProvincia.Name = "btnAgregarProvincia";
			btnAgregarProvincia.Size = new Size(40, 33);
			btnAgregarProvincia.TabIndex = 11;
			btnAgregarProvincia.UseVisualStyleBackColor = true;
			btnAgregarProvincia.Click += btnAgregarProvincia_Click;
			// 
			// frmLocalidadesAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 255, 145);
			ClientSize = new Size(339, 335);
			ControlBox = false;
			Controls.Add(cbxProvincias);
			Controls.Add(cbxPaises);
			Controls.Add(btnAgregarProvincia);
			Controls.Add(btnAgregarPais);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbxLocalidad);
			Name = "frmLocalidadesAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmLocalidadesAE";
			Load += frmLocalidadesAE_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbxPaises;
		private Button btnAgregarPais;
		private Button btnOk;
		private Button btnCancelar;
		private Label label2;
		private Label label1;
		private TextBox tbxLocalidad;
		private Label label3;
		private ComboBox cbxProvincias;
		private Button btnAgregarProvincia;
	}
}