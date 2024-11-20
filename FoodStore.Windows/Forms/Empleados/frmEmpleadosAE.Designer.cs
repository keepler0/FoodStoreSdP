namespace FoodStore.Windows.Forms.Empleados
{
	partial class frmEmpleadosAE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosAE));
			cbxRoles = new ComboBox();
			btnOk = new Button();
			btnCancelar = new Button();
			label2 = new Label();
			label1 = new Label();
			tbxNombre = new TextBox();
			tbxApellido = new TextBox();
			label5 = new Label();
			tbxDireccion = new TextBox();
			label6 = new Label();
			tbxTelefono = new TextBox();
			label7 = new Label();
			tbxSueldo = new TextBox();
			label8 = new Label();
			dtpFechaContrato = new DateTimePicker();
			label10 = new Label();
			tbxCuit = new TextBox();
			label11 = new Label();
			chBxActivo = new CheckBox();
			picFoto = new PictureBox();
			btnBuscarImagen = new Button();
			button1 = new Button();
			openFileDialog1 = new OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
			SuspendLayout();
			// 
			// cbxRoles
			// 
			cbxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxRoles.FormattingEnabled = true;
			cbxRoles.Location = new Point(13, 357);
			cbxRoles.Name = "cbxRoles";
			cbxRoles.Size = new Size(195, 33);
			cbxRoles.TabIndex = 24;
			cbxRoles.SelectedIndexChanged += cbxRoles_SelectedIndexChanged;
			// 
			// btnOk
			// 
			btnOk.BackColor = Color.White;
			btnOk.FlatAppearance.BorderSize = 0;
			btnOk.FlatStyle = FlatStyle.Popup;
			btnOk.Image = (Image)resources.GetObject("btnOk.Image");
			btnOk.Location = new Point(468, 476);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 21;
			btnOk.UseVisualStyleBackColor = false;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.White;
			btnCancelar.FlatAppearance.BorderSize = 0;
			btnCancelar.FlatStyle = FlatStyle.Popup;
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(545, 476);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 22;
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(78, 25);
			label2.TabIndex = 16;
			label2.Text = "Nombre";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 329);
			label1.Name = "label1";
			label1.Size = new Size(60, 25);
			label1.TabIndex = 18;
			label1.Text = "Cargo";
			// 
			// tbxNombre
			// 
			tbxNombre.Location = new Point(12, 37);
			tbxNombre.Name = "tbxNombre";
			tbxNombre.Size = new Size(268, 31);
			tbxNombre.TabIndex = 15;
			// 
			// tbxApellido
			// 
			tbxApellido.Location = new Point(13, 99);
			tbxApellido.Name = "tbxApellido";
			tbxApellido.Size = new Size(268, 31);
			tbxApellido.TabIndex = 15;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(13, 71);
			label5.Name = "label5";
			label5.Size = new Size(78, 25);
			label5.TabIndex = 16;
			label5.Text = "Apellido";
			// 
			// tbxDireccion
			// 
			tbxDireccion.Location = new Point(13, 161);
			tbxDireccion.Name = "tbxDireccion";
			tbxDireccion.Size = new Size(268, 31);
			tbxDireccion.TabIndex = 15;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(13, 133);
			label6.Name = "label6";
			label6.Size = new Size(85, 25);
			label6.TabIndex = 16;
			label6.Text = "Direccion";
			// 
			// tbxTelefono
			// 
			tbxTelefono.Location = new Point(13, 223);
			tbxTelefono.Name = "tbxTelefono";
			tbxTelefono.Size = new Size(268, 31);
			tbxTelefono.TabIndex = 15;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(13, 195);
			label7.Name = "label7";
			label7.Size = new Size(79, 25);
			label7.TabIndex = 16;
			label7.Text = "Telefono";
			// 
			// tbxSueldo
			// 
			tbxSueldo.Location = new Point(13, 288);
			tbxSueldo.Name = "tbxSueldo";
			tbxSueldo.Size = new Size(146, 31);
			tbxSueldo.TabIndex = 15;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(13, 260);
			label8.Name = "label8";
			label8.Size = new Size(67, 25);
			label8.TabIndex = 16;
			label8.Text = "Sueldo";
			// 
			// dtpFechaContrato
			// 
			dtpFechaContrato.Format = DateTimePickerFormat.Short;
			dtpFechaContrato.Location = new Point(13, 434);
			dtpFechaContrato.MaxDate = new DateTime(2500, 12, 31, 0, 0, 0, 0);
			dtpFechaContrato.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
			dtpFechaContrato.Name = "dtpFechaContrato";
			dtpFechaContrato.Size = new Size(211, 31);
			dtpFechaContrato.TabIndex = 26;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(13, 406);
			label10.Name = "label10";
			label10.Size = new Size(129, 25);
			label10.TabIndex = 18;
			label10.Text = "Fecha contrato";
			// 
			// tbxCuit
			// 
			tbxCuit.Location = new Point(165, 288);
			tbxCuit.MaxLength = 11;
			tbxCuit.Name = "tbxCuit";
			tbxCuit.Size = new Size(146, 31);
			tbxCuit.TabIndex = 15;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(165, 260);
			label11.Name = "label11";
			label11.Size = new Size(43, 25);
			label11.TabIndex = 16;
			label11.Text = "Cuit";
			// 
			// chBxActivo
			// 
			chBxActivo.AutoSize = true;
			chBxActivo.Location = new Point(230, 359);
			chBxActivo.Name = "chBxActivo";
			chBxActivo.Size = new Size(130, 29);
			chBxActivo.TabIndex = 27;
			chBxActivo.Text = "Esta activo?";
			chBxActivo.UseVisualStyleBackColor = true;
			// 
			// picFoto
			// 
			picFoto.Location = new Point(335, 12);
			picFoto.Name = "picFoto";
			picFoto.Size = new Size(281, 270);
			picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
			picFoto.TabIndex = 28;
			picFoto.TabStop = false;
			// 
			// btnBuscarImagen
			// 
			btnBuscarImagen.BackColor = Color.White;
			btnBuscarImagen.FlatAppearance.BorderSize = 0;
			btnBuscarImagen.FlatStyle = FlatStyle.Popup;
			btnBuscarImagen.Location = new Point(397, 288);
			btnBuscarImagen.Name = "btnBuscarImagen";
			btnBuscarImagen.Size = new Size(82, 31);
			btnBuscarImagen.TabIndex = 21;
			btnBuscarImagen.Text = "Buscar imagen";
			btnBuscarImagen.UseVisualStyleBackColor = false;
			btnBuscarImagen.Click += btnBuscarImagen_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.White;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Location = new Point(485, 288);
			button1.Name = "button1";
			button1.Size = new Size(82, 31);
			button1.TabIndex = 21;
			button1.Text = "Borrar";
			button1.UseVisualStyleBackColor = false;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// frmEmpleadosAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 255, 145);
			ClientSize = new Size(632, 555);
			ControlBox = false;
			Controls.Add(picFoto);
			Controls.Add(chBxActivo);
			Controls.Add(dtpFechaContrato);
			Controls.Add(cbxRoles);
			Controls.Add(button1);
			Controls.Add(btnBuscarImagen);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label11);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(tbxCuit);
			Controls.Add(tbxSueldo);
			Controls.Add(label5);
			Controls.Add(tbxTelefono);
			Controls.Add(label2);
			Controls.Add(tbxDireccion);
			Controls.Add(label10);
			Controls.Add(label1);
			Controls.Add(tbxApellido);
			Controls.Add(tbxNombre);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximumSize = new Size(654, 611);
			MinimumSize = new Size(654, 611);
			Name = "frmEmpleadosAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmEmpleadosAE";
			((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox cbxRoles;
		private Button btnOk;
		private Button btnCancelar;
		private Label label2;
		private Label label1;
		private TextBox tbxNombre;
		private TextBox tbxApellido;
		private Label label5;
		private TextBox tbxDireccion;
		private Label label6;
		private TextBox tbxTelefono;
		private Label label7;
		private TextBox tbxSueldo;
		private Label label8;
		private DateTimePicker dtpFechaContrato;
		private Label label10;
		private TextBox tbxCuit;
		private Label label11;
		private CheckBox chBxActivo;
		private PictureBox picFoto;
		private Button btnBuscarImagen;
		private Button button1;
		private OpenFileDialog openFileDialog1;
	}
}