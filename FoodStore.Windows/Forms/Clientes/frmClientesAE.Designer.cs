namespace FoodStore.Windows.Forms.Clientes
{
	partial class frmClientesAE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesAE));
			groupBox1 = new GroupBox();
			label1 = new Label();
			label8 = new Label();
			label6 = new Label();
			tbxnumero = new TextBox();
			tbxCalle2 = new TextBox();
			tbxCalle1 = new TextBox();
			btnOk = new Button();
			btnCancelar = new Button();
			label11 = new Label();
			label7 = new Label();
			tbxDni = new TextBox();
			label5 = new Label();
			tbxTelefono = new TextBox();
			label2 = new Label();
			tbxApellido = new TextBox();
			tbxNombre = new TextBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(tbxnumero);
			groupBox1.Controls.Add(tbxCalle2);
			groupBox1.Controls.Add(tbxCalle1);
			groupBox1.Location = new Point(311, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(306, 242);
			groupBox1.TabIndex = 46;
			groupBox1.TabStop = false;
			groupBox1.Text = "Direccion";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 155);
			label1.Name = "label1";
			label1.Size = new Size(77, 25);
			label1.TabIndex = 39;
			label1.Text = "Numero";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(17, 93);
			label8.Name = "label8";
			label8.Size = new Size(64, 25);
			label8.TabIndex = 39;
			label8.Text = "Calle 2";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(17, 31);
			label6.Name = "label6";
			label6.Size = new Size(64, 25);
			label6.TabIndex = 37;
			label6.Text = "Calle 1";
			// 
			// tbxnumero
			// 
			tbxnumero.Location = new Point(17, 183);
			tbxnumero.MaxLength = 4;
			tbxnumero.Name = "tbxnumero";
			tbxnumero.Size = new Size(131, 31);
			tbxnumero.TabIndex = 31;
			// 
			// tbxCalle2
			// 
			tbxCalle2.Location = new Point(17, 121);
			tbxCalle2.MaxLength = 200;
			tbxCalle2.Name = "tbxCalle2";
			tbxCalle2.Size = new Size(268, 31);
			tbxCalle2.TabIndex = 31;
			// 
			// tbxCalle1
			// 
			tbxCalle1.Location = new Point(17, 59);
			tbxCalle1.MaxLength = 200;
			tbxCalle1.Name = "tbxCalle1";
			tbxCalle1.Size = new Size(268, 31);
			tbxCalle1.TabIndex = 29;
			// 
			// btnOk
			// 
			btnOk.BackColor = Color.White;
			btnOk.FlatAppearance.BorderSize = 0;
			btnOk.FlatStyle = FlatStyle.Popup;
			btnOk.Image = (Image)resources.GetObject("btnOk.Image");
			btnOk.Location = new Point(469, 260);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 43;
			btnOk.UseVisualStyleBackColor = false;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.White;
			btnCancelar.FlatAppearance.BorderSize = 0;
			btnCancelar.FlatStyle = FlatStyle.Popup;
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(546, 260);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 44;
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(11, 195);
			label11.Name = "label11";
			label11.Size = new Size(43, 25);
			label11.TabIndex = 38;
			label11.Text = "DNI";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(11, 133);
			label7.Name = "label7";
			label7.Size = new Size(79, 25);
			label7.TabIndex = 36;
			label7.Text = "Telefono";
			// 
			// tbxDni
			// 
			tbxDni.Location = new Point(11, 223);
			tbxDni.MaxLength = 8;
			tbxDni.Name = "tbxDni";
			tbxDni.Size = new Size(171, 31);
			tbxDni.TabIndex = 32;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 71);
			label5.Name = "label5";
			label5.Size = new Size(78, 25);
			label5.TabIndex = 35;
			label5.Text = "Apellido";
			// 
			// tbxTelefono
			// 
			tbxTelefono.Location = new Point(11, 161);
			tbxTelefono.MaxLength = 11;
			tbxTelefono.Name = "tbxTelefono";
			tbxTelefono.Size = new Size(268, 31);
			tbxTelefono.TabIndex = 30;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(78, 25);
			label2.TabIndex = 34;
			label2.Text = "Nombre";
			// 
			// tbxApellido
			// 
			tbxApellido.Location = new Point(12, 99);
			tbxApellido.MaxLength = 50;
			tbxApellido.Name = "tbxApellido";
			tbxApellido.Size = new Size(268, 31);
			tbxApellido.TabIndex = 33;
			// 
			// tbxNombre
			// 
			tbxNombre.Location = new Point(12, 37);
			tbxNombre.MaxLength = 50;
			tbxNombre.Name = "tbxNombre";
			tbxNombre.Size = new Size(268, 31);
			tbxNombre.TabIndex = 28;
			// 
			// frmClientesAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 255, 145);
			ClientSize = new Size(638, 346);
			ControlBox = false;
			Controls.Add(groupBox1);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label11);
			Controls.Add(label7);
			Controls.Add(tbxDni);
			Controls.Add(label5);
			Controls.Add(tbxTelefono);
			Controls.Add(label2);
			Controls.Add(tbxApellido);
			Controls.Add(tbxNombre);
			Name = "frmClientesAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmClientesAE";
			Load += frmClientesAE_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private Label label8;
		private Label label6;
		private TextBox tbxnumero;
		private TextBox tbxCalle2;
		private TextBox tbxCalle1;
		private Button btnOk;
		private Button btnCancelar;
		private Label label11;
		private Label label7;
		private TextBox tbxDni;
		private Label label5;
		private TextBox tbxTelefono;
		private Label label2;
		private TextBox tbxApellido;
		private TextBox tbxNombre;
	}
}