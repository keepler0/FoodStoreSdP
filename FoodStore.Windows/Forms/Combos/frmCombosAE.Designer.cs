namespace FoodStore.Windows.Forms.Combos
{
	partial class frmCombosAE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombosAE));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			button1 = new Button();
			btnOk = new Button();
			btnCancelar = new Button();
			dtpInicio = new DateTimePicker();
			cbxTamanio = new ComboBox();
			label9 = new Label();
			label12 = new Label();
			label6 = new Label();
			label7 = new Label();
			tbxPrecio = new TextBox();
			label2 = new Label();
			label1 = new Label();
			tbxDescripcion = new TextBox();
			tbxNombre = new TextBox();
			picImagen = new PictureBox();
			label3 = new Label();
			dtpFin = new DateTimePicker();
			panel1 = new Panel();
			dgvDatos = new DataGridView();
			colId = new DataGridViewTextBoxColumn();
			colCodigo = new DataGridViewTextBoxColumn();
			colpais = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			panel2 = new Panel();
			label4 = new Label();
			label5 = new Label();
			label8 = new Label();
			btnEditar = new Button();
			btnBorrar = new Button();
			btnAgregar = new Button();
			((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(222, 206, 5);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(427, 412);
			button1.Name = "button1";
			button1.Size = new Size(432, 33);
			button1.TabIndex = 33;
			button1.Text = "Buscar";
			button1.TextAlign = ContentAlignment.TopCenter;
			button1.UseVisualStyleBackColor = false;
			// 
			// btnOk
			// 
			btnOk.BackColor = Color.FromArgb(29, 30, 44);
			btnOk.FlatStyle = FlatStyle.Popup;
			btnOk.Image = (Image)resources.GetObject("btnOk.Image");
			btnOk.Location = new Point(711, 847);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 32;
			btnOk.UseVisualStyleBackColor = false;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.FromArgb(29, 30, 44);
			btnCancelar.FlatStyle = FlatStyle.Popup;
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(788, 847);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 34;
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// dtpInicio
			// 
			dtpInicio.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpInicio.Format = DateTimePickerFormat.Short;
			dtpInicio.Location = new Point(12, 340);
			dtpInicio.Name = "dtpInicio";
			dtpInicio.Size = new Size(149, 31);
			dtpInicio.TabIndex = 29;
			// 
			// cbxTamanio
			// 
			cbxTamanio.BackColor = Color.FromArgb(222, 206, 5);
			cbxTamanio.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxTamanio.FormattingEnabled = true;
			cbxTamanio.Location = new Point(12, 262);
			cbxTamanio.Name = "cbxTamanio";
			cbxTamanio.Size = new Size(315, 33);
			cbxTamanio.TabIndex = 27;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = Color.White;
			label9.Location = new Point(12, 312);
			label9.Name = "label9";
			label9.Size = new Size(128, 25);
			label9.TabIndex = 24;
			label9.Text = "Fecha de inicio";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label12.ForeColor = Color.White;
			label12.Location = new Point(12, 406);
			label12.Name = "label12";
			label12.Size = new Size(32, 38);
			label12.TabIndex = 23;
			label12.Text = "$";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.White;
			label6.Location = new Point(12, 374);
			label6.Name = "label6";
			label6.Size = new Size(60, 25);
			label6.TabIndex = 22;
			label6.Text = "Precio";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = Color.White;
			label7.Location = new Point(12, 234);
			label7.Name = "label7";
			label7.Size = new Size(74, 25);
			label7.TabIndex = 21;
			label7.Text = "Tamaño";
			// 
			// tbxPrecio
			// 
			tbxPrecio.BackColor = Color.FromArgb(222, 206, 5);
			tbxPrecio.BorderStyle = BorderStyle.None;
			tbxPrecio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tbxPrecio.Location = new Point(50, 406);
			tbxPrecio.Name = "tbxPrecio";
			tbxPrecio.Size = new Size(277, 38);
			tbxPrecio.TabIndex = 14;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(12, 73);
			label2.Name = "label2";
			label2.Size = new Size(104, 25);
			label2.TabIndex = 17;
			label2.Text = "Descripcion";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.White;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(169, 25);
			label1.TabIndex = 16;
			label1.Text = "Nombre del combo";
			// 
			// tbxDescripcion
			// 
			tbxDescripcion.BackColor = Color.FromArgb(222, 206, 5);
			tbxDescripcion.BorderStyle = BorderStyle.None;
			tbxDescripcion.Location = new Point(12, 101);
			tbxDescripcion.Multiline = true;
			tbxDescripcion.Name = "tbxDescripcion";
			tbxDescripcion.Size = new Size(396, 130);
			tbxDescripcion.TabIndex = 10;
			// 
			// tbxNombre
			// 
			tbxNombre.BackColor = Color.FromArgb(222, 206, 5);
			tbxNombre.BorderStyle = BorderStyle.None;
			tbxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tbxNombre.Location = new Point(12, 37);
			tbxNombre.Name = "tbxNombre";
			tbxNombre.Size = new Size(396, 32);
			tbxNombre.TabIndex = 15;
			// 
			// picImagen
			// 
			picImagen.Location = new Point(427, 9);
			picImagen.Name = "picImagen";
			picImagen.Size = new Size(432, 390);
			picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
			picImagen.TabIndex = 9;
			picImagen.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.White;
			label3.Location = new Point(178, 312);
			label3.Name = "label3";
			label3.Size = new Size(107, 25);
			label3.TabIndex = 24;
			label3.Text = "Fecha de fin";
			// 
			// dtpFin
			// 
			dtpFin.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dtpFin.Format = DateTimePickerFormat.Short;
			dtpFin.Location = new Point(178, 340);
			dtpFin.Name = "dtpFin";
			dtpFin.Size = new Size(149, 31);
			dtpFin.TabIndex = 29;
			// 
			// panel1
			// 
			panel1.Controls.Add(dgvDatos);
			panel1.Location = new Point(174, 478);
			panel1.Name = "panel1";
			panel1.Size = new Size(685, 363);
			panel1.TabIndex = 35;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(218, 253, 254);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(218, 253, 254);
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.BackgroundColor = Color.FromArgb(218, 253, 254);
			dgvDatos.BorderStyle = BorderStyle.None;
			dgvDatos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(218, 253, 254);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(218, 253, 254);
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
			dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colCodigo, colpais, colCantidad });
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(218, 253, 254);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(218, 253, 254);
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.GridColor = SystemColors.InactiveBorder;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dgvDatos.RowHeadersWidth = 62;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(685, 363);
			dgvDatos.TabIndex = 1;
			// 
			// colId
			// 
			colId.HeaderText = "id";
			colId.MinimumWidth = 8;
			colId.Name = "colId";
			colId.ReadOnly = true;
			colId.Visible = false;
			colId.Width = 150;
			// 
			// colCodigo
			// 
			colCodigo.HeaderText = "Codigo de producto";
			colCodigo.MinimumWidth = 8;
			colCodigo.Name = "colCodigo";
			colCodigo.ReadOnly = true;
			colCodigo.Width = 150;
			// 
			// colpais
			// 
			colpais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colpais.HeaderText = "Producto";
			colpais.MinimumWidth = 8;
			colpais.Name = "colpais";
			colpais.ReadOnly = true;
			// 
			// colCantidad
			// 
			colCantidad.HeaderText = "Cantidad";
			colCantidad.MinimumWidth = 8;
			colCantidad.Name = "colCantidad";
			colCantidad.ReadOnly = true;
			colCantidad.Width = 150;
			// 
			// panel2
			// 
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(label8);
			panel2.Controls.Add(btnEditar);
			panel2.Controls.Add(btnBorrar);
			panel2.Controls.Add(btnAgregar);
			panel2.Location = new Point(12, 478);
			panel2.Name = "panel2";
			panel2.Size = new Size(156, 360);
			panel2.TabIndex = 0;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(222, 206, 5);
			label4.Location = new Point(80, 230);
			label4.Name = "label4";
			label4.Size = new Size(57, 25);
			label4.TabIndex = 8;
			label4.Text = "Editar";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.FromArgb(222, 206, 5);
			label5.Location = new Point(80, 161);
			label5.Name = "label5";
			label5.Size = new Size(60, 25);
			label5.TabIndex = 9;
			label5.Text = "Borrar";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.ForeColor = Color.FromArgb(222, 206, 5);
			label8.Location = new Point(80, 92);
			label8.Name = "label8";
			label8.Size = new Size(76, 25);
			label8.TabIndex = 10;
			label8.Text = "Agregar";
			label8.Click += btnNuevo_Click;
			// 
			// btnEditar
			// 
			btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnEditar.BackColor = Color.FromArgb(222, 206, 5);
			btnEditar.BackgroundImageLayout = ImageLayout.None;
			btnEditar.FlatStyle = FlatStyle.Flat;
			btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
			btnEditar.Location = new Point(9, 207);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(65, 70);
			btnEditar.TabIndex = 5;
			btnEditar.TextAlign = ContentAlignment.MiddleLeft;
			btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnEditar.UseVisualStyleBackColor = false;
			btnEditar.Click += btnEditar_Click;
			// 
			// btnBorrar
			// 
			btnBorrar.BackColor = Color.FromArgb(222, 206, 5);
			btnBorrar.BackgroundImageLayout = ImageLayout.None;
			btnBorrar.FlatStyle = FlatStyle.Flat;
			btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
			btnBorrar.Location = new Point(9, 138);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(65, 70);
			btnBorrar.TabIndex = 6;
			btnBorrar.TextAlign = ContentAlignment.MiddleLeft;
			btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnBorrar.UseVisualStyleBackColor = false;
			btnBorrar.Click += btnBorrar_Click;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.FromArgb(222, 206, 5);
			btnAgregar.BackgroundImageLayout = ImageLayout.None;
			btnAgregar.FlatStyle = FlatStyle.Popup;
			btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
			btnAgregar.Location = new Point(9, 69);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(65, 70);
			btnAgregar.TabIndex = 7;
			btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
			btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnNuevo_Click;
			// 
			// frmCombosAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(29, 30, 44);
			ClientSize = new Size(883, 928);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(button1);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(dtpFin);
			Controls.Add(dtpInicio);
			Controls.Add(cbxTamanio);
			Controls.Add(label3);
			Controls.Add(label9);
			Controls.Add(label12);
			Controls.Add(label6);
			Controls.Add(label7);
			Controls.Add(tbxPrecio);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbxDescripcion);
			Controls.Add(tbxNombre);
			Controls.Add(picImagen);
			Name = "frmCombosAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmCombosAE";
			((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button btnOk;
		private Button btnCancelar;
		private DateTimePicker dtpInicio;
		private ComboBox cbxTamanio;
		private Label label9;
		private Label label12;
		private Label label6;
		private Label label7;
		private TextBox tbxPrecio;
		private Label label2;
		private Label label1;
		private TextBox tbxDescripcion;
		private TextBox tbxNombre;
		private PictureBox picImagen;
		private Label label3;
		private DateTimePicker dtpFin;
		private Panel panel1;
		private DataGridView dgvDatos;
		private Panel panel2;
		private DataGridViewTextBoxColumn colId;
		private DataGridViewTextBoxColumn colCodigo;
		private DataGridViewTextBoxColumn colpais;
		private DataGridViewTextBoxColumn colCantidad;
		private Label label4;
		private Label label5;
		private Label label8;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnAgregar;
	}
}