namespace FoodStore.Windows.Forms.Provincias
{
	partial class frmProvinciasAE
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
			label1 = new Label();
			tbxProvincia = new TextBox();
			label2 = new Label();
			cbxPaises = new ComboBox();
			btnAgregarPais = new Button();
			SuspendLayout();
			// 
			// btnOk
			// 
			btnOk.Location = new Point(132, 137);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 5;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(209, 137);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 6;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 8);
			label1.Name = "label1";
			label1.Size = new Size(42, 25);
			label1.TabIndex = 4;
			label1.Text = "Pais";
			// 
			// tbxProvincia
			// 
			tbxProvincia.Location = new Point(12, 100);
			tbxProvincia.Name = "tbxProvincia";
			tbxProvincia.Size = new Size(268, 31);
			tbxProvincia.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 72);
			label2.Name = "label2";
			label2.Size = new Size(83, 25);
			label2.TabIndex = 4;
			label2.Text = "Provincia";
			// 
			// cbxPaises
			// 
			cbxPaises.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxPaises.FormattingEnabled = true;
			cbxPaises.Location = new Point(12, 36);
			cbxPaises.Name = "cbxPaises";
			cbxPaises.Size = new Size(268, 33);
			cbxPaises.TabIndex = 7;
			cbxPaises.SelectedIndexChanged += cbxPaises_SelectedIndexChanged;
			// 
			// btnAgregarPais
			// 
			btnAgregarPais.Location = new Point(286, 36);
			btnAgregarPais.Name = "btnAgregarPais";
			btnAgregarPais.Size = new Size(40, 33);
			btnAgregarPais.TabIndex = 5;
			btnAgregarPais.UseVisualStyleBackColor = true;
			btnAgregarPais.Click += btnAgregarPais_Click;
			// 
			// frmProvinciasAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 255, 145);
			ClientSize = new Size(335, 221);
			ControlBox = false;
			Controls.Add(cbxPaises);
			Controls.Add(btnAgregarPais);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbxProvincia);
			MaximumSize = new Size(357, 277);
			MinimumSize = new Size(357, 277);
			Name = "frmProvinciasAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmProvinciasAE";
			Load += frmProvinciasAE_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOk;
		private Button btnCancelar;
		private Label label1;
		private TextBox tbxProvincia;
		private Label label2;
		private ComboBox cbxPaises;
		private Button btnAgregarPais;
	}
}