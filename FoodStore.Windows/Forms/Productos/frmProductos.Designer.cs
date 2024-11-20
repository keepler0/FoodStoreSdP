namespace FoodStore.Windows.Forms.Productos
{
	partial class frmProductos
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
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
			panel3 = new Panel();
			dgvDatos = new DataGridView();
			colpais = new DataGridViewTextBoxColumn();
			colProvincia = new DataGridViewTextBoxColumn();
			colCuit = new DataGridViewTextBoxColumn();
			colRol = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			col = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			panel2 = new Panel();
			tbxMarca = new TextBox();
			btnBuscarMarca = new Button();
			btnQuitarOrden = new Button();
			btnQuitarSubCategoria = new Button();
			label5 = new Label();
			btnQuitarCategoria = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			cbxOrdenar = new ComboBox();
			cbxSubCategorias = new ComboBox();
			cbxCategorias = new ComboBox();
			panel1 = new Panel();
			btnSalir = new Button();
			btnDatos = new Button();
			btnActualiza = new Button();
			btnEditar = new Button();
			btnBorrar = new Button();
			btnNuevo = new Button();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.Controls.Add(dgvDatos);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(122, 82);
			panel3.Name = "panel3";
			panel3.Size = new Size(1627, 519);
			panel3.TabIndex = 14;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle6.SelectionForeColor = Color.Black;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			dgvDatos.BackgroundColor = Color.FromArgb(250, 255, 145);
			dgvDatos.BorderStyle = BorderStyle.None;
			dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.Desktop;
			dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colpais, colProvincia, colCuit, colRol, Column1, col, Column2, Column3 });
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			dgvDatos.DefaultCellStyle = dataGridViewCellStyle8;
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.GridColor = SystemColors.InactiveBorder;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			dgvDatos.RowHeadersWidth = 62;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle10;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(1627, 519);
			dgvDatos.TabIndex = 0;
			// 
			// colpais
			// 
			colpais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colpais.HeaderText = "Marca";
			colpais.MinimumWidth = 8;
			colpais.Name = "colpais";
			colpais.ReadOnly = true;
			// 
			// colProvincia
			// 
			colProvincia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colProvincia.HeaderText = "Descripcion";
			colProvincia.MinimumWidth = 8;
			colProvincia.Name = "colProvincia";
			colProvincia.ReadOnly = true;
			// 
			// colCuit
			// 
			colCuit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colCuit.HeaderText = "Categoria";
			colCuit.MinimumWidth = 8;
			colCuit.Name = "colCuit";
			colCuit.ReadOnly = true;
			// 
			// colRol
			// 
			colRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colRol.HeaderText = "Sub-Categoria";
			colRol.MinimumWidth = 8;
			colRol.Name = "colRol";
			colRol.ReadOnly = true;
			// 
			// Column1
			// 
			Column1.HeaderText = "Stock";
			Column1.MinimumWidth = 8;
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Width = 150;
			// 
			// col
			// 
			col.HeaderText = "Precio unitario";
			col.MinimumWidth = 8;
			col.Name = "col";
			col.ReadOnly = true;
			col.Width = 150;
			// 
			// Column2
			// 
			Column2.HeaderText = "Precio final";
			Column2.MinimumWidth = 8;
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Width = 150;
			// 
			// Column3
			// 
			Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Column3.HeaderText = "Fecha vencimiento";
			Column3.MinimumWidth = 8;
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(224, 230, 4);
			panel2.Controls.Add(tbxMarca);
			panel2.Controls.Add(btnBuscarMarca);
			panel2.Controls.Add(btnQuitarOrden);
			panel2.Controls.Add(btnQuitarSubCategoria);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(btnQuitarCategoria);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(cbxOrdenar);
			panel2.Controls.Add(cbxSubCategorias);
			panel2.Controls.Add(cbxCategorias);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(122, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1627, 82);
			panel2.TabIndex = 13;
			// 
			// tbxMarca
			// 
			tbxMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tbxMarca.Location = new Point(687, 42);
			tbxMarca.Name = "tbxMarca";
			tbxMarca.Size = new Size(202, 31);
			tbxMarca.TabIndex = 3;
			// 
			// btnBuscarMarca
			// 
			btnBuscarMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnBuscarMarca.BackgroundImage = (Image)resources.GetObject("btnBuscarMarca.BackgroundImage");
			btnBuscarMarca.BackgroundImageLayout = ImageLayout.Zoom;
			btnBuscarMarca.Location = new Point(895, 42);
			btnBuscarMarca.Name = "btnBuscarMarca";
			btnBuscarMarca.Size = new Size(33, 33);
			btnBuscarMarca.TabIndex = 2;
			btnBuscarMarca.UseVisualStyleBackColor = true;
			btnBuscarMarca.Click += btnBuscarMarca_Click;
			// 
			// btnQuitarOrden
			// 
			btnQuitarOrden.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarOrden.BackgroundImage = (Image)resources.GetObject("btnQuitarOrden.BackgroundImage");
			btnQuitarOrden.BackgroundImageLayout = ImageLayout.Zoom;
			btnQuitarOrden.Enabled = false;
			btnQuitarOrden.Location = new Point(1124, 43);
			btnQuitarOrden.Name = "btnQuitarOrden";
			btnQuitarOrden.Size = new Size(33, 33);
			btnQuitarOrden.TabIndex = 2;
			btnQuitarOrden.UseVisualStyleBackColor = true;
			btnQuitarOrden.Click += btnQuitarOrden_Click;
			// 
			// btnQuitarSubCategoria
			// 
			btnQuitarSubCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarSubCategoria.Enabled = false;
			btnQuitarSubCategoria.Location = new Point(1582, 43);
			btnQuitarSubCategoria.Name = "btnQuitarSubCategoria";
			btnQuitarSubCategoria.Size = new Size(33, 33);
			btnQuitarSubCategoria.TabIndex = 2;
			btnQuitarSubCategoria.UseVisualStyleBackColor = true;
			btnQuitarSubCategoria.Click += btnQuitarSubCategoria_Click;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.Location = new Point(687, 11);
			label5.Name = "label5";
			label5.Size = new Size(149, 25);
			label5.TabIndex = 1;
			label5.Text = "Buscar por Marca";
			// 
			// btnQuitarCategoria
			// 
			btnQuitarCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarCategoria.Enabled = false;
			btnQuitarCategoria.Location = new Point(1353, 43);
			btnQuitarCategoria.Name = "btnQuitarCategoria";
			btnQuitarCategoria.Size = new Size(33, 33);
			btnQuitarCategoria.TabIndex = 2;
			btnQuitarCategoria.UseVisualStyleBackColor = true;
			btnQuitarCategoria.Click += btnQuitarCategoria_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(934, 12);
			label3.Name = "label3";
			label3.Size = new Size(110, 25);
			label3.TabIndex = 1;
			label3.Text = "Ordenar por";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(1392, 12);
			label2.Name = "label2";
			label2.Size = new Size(203, 25);
			label2.TabIndex = 1;
			label2.Text = "Filtrar por sub-categoria";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(1163, 12);
			label1.Name = "label1";
			label1.Size = new Size(167, 25);
			label1.TabIndex = 1;
			label1.Text = "Filtrar por categoria";
			// 
			// cbxOrdenar
			// 
			cbxOrdenar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxOrdenar.FormattingEnabled = true;
			cbxOrdenar.Location = new Point(934, 43);
			cbxOrdenar.Name = "cbxOrdenar";
			cbxOrdenar.Size = new Size(184, 33);
			cbxOrdenar.TabIndex = 0;
			cbxOrdenar.SelectedIndexChanged += cbxOrdenar_SelectedIndexChanged;
			// 
			// cbxSubCategorias
			// 
			cbxSubCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxSubCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxSubCategorias.FormattingEnabled = true;
			cbxSubCategorias.Location = new Point(1392, 43);
			cbxSubCategorias.Name = "cbxSubCategorias";
			cbxSubCategorias.Size = new Size(184, 33);
			cbxSubCategorias.TabIndex = 0;
			cbxSubCategorias.SelectedIndexChanged += cbxSubCategorias_SelectedIndexChanged;
			// 
			// cbxCategorias
			// 
			cbxCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCategorias.FormattingEnabled = true;
			cbxCategorias.Location = new Point(1163, 43);
			cbxCategorias.Name = "cbxCategorias";
			cbxCategorias.Size = new Size(184, 33);
			cbxCategorias.TabIndex = 0;
			cbxCategorias.SelectedIndexChanged += cbxCategorias_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(224, 230, 4);
			panel1.Controls.Add(btnSalir);
			panel1.Controls.Add(btnDatos);
			panel1.Controls.Add(btnActualiza);
			panel1.Controls.Add(btnEditar);
			panel1.Controls.Add(btnBorrar);
			panel1.Controls.Add(btnNuevo);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(122, 601);
			panel1.TabIndex = 12;
			// 
			// btnSalir
			// 
			btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSalir.Location = new Point(-10, 523);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(126, 54);
			btnSalir.TabIndex = 0;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
			// 
			// btnDatos
			// 
			btnDatos.BackgroundImage = (Image)resources.GetObject("btnDatos.BackgroundImage");
			btnDatos.BackgroundImageLayout = ImageLayout.Zoom;
			btnDatos.Location = new Point(-10, 358);
			btnDatos.Name = "btnDatos";
			btnDatos.Size = new Size(126, 63);
			btnDatos.TabIndex = 0;
			btnDatos.Text = "Ver datos";
			btnDatos.TextAlign = ContentAlignment.MiddleRight;
			btnDatos.UseVisualStyleBackColor = true;
			btnDatos.Click += btnDatos_Click;
			// 
			// btnActualiza
			// 
			btnActualiza.BackgroundImage = (Image)resources.GetObject("btnActualiza.BackgroundImage");
			btnActualiza.BackgroundImageLayout = ImageLayout.Zoom;
			btnActualiza.Location = new Point(-10, 289);
			btnActualiza.Name = "btnActualiza";
			btnActualiza.Size = new Size(126, 63);
			btnActualiza.TabIndex = 0;
			btnActualiza.Text = "Actualizar";
			btnActualiza.TextAlign = ContentAlignment.MiddleRight;
			btnActualiza.UseVisualStyleBackColor = true;
			btnActualiza.Click += btnActualiza_Click;
			// 
			// btnEditar
			// 
			btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
			btnEditar.BackgroundImageLayout = ImageLayout.Zoom;
			btnEditar.Location = new Point(-10, 220);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(126, 63);
			btnEditar.TabIndex = 0;
			btnEditar.Text = "Editar";
			btnEditar.TextAlign = ContentAlignment.MiddleRight;
			btnEditar.UseVisualStyleBackColor = true;
			btnEditar.Click += btnEditar_Click;
			// 
			// btnBorrar
			// 
			btnBorrar.BackgroundImage = (Image)resources.GetObject("btnBorrar.BackgroundImage");
			btnBorrar.BackgroundImageLayout = ImageLayout.Zoom;
			btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
			btnBorrar.Location = new Point(-10, 151);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(126, 63);
			btnBorrar.TabIndex = 0;
			btnBorrar.Text = "Borrar";
			btnBorrar.TextAlign = ContentAlignment.MiddleRight;
			btnBorrar.TextImageRelation = TextImageRelation.TextAboveImage;
			btnBorrar.UseVisualStyleBackColor = true;
			btnBorrar.Click += btnBorrar_Click;
			// 
			// btnNuevo
			// 
			btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
			btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
			btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
			btnNuevo.Location = new Point(-10, 82);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(126, 63);
			btnNuevo.TabIndex = 0;
			btnNuevo.Text = "Nuevo";
			btnNuevo.TextAlign = ContentAlignment.MiddleRight;
			btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnNuevo.UseVisualStyleBackColor = true;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// frmProductos
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1749, 601);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MinimumSize = new Size(1335, 561);
			Name = "frmProductos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmProductos";
			Load += frmProductos_Load;
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
		private DataGridView dgvDatos;
		private Panel panel2;
		private TextBox tbxMarca;
		private Button btnBuscarMarca;
		private Button btnQuitarOrden;
		private Button btnQuitarSubCategoria;
		private Label label5;
		private Button btnQuitarCategoria;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox cbxOrdenar;
		private ComboBox cbxSubCategorias;
		private ComboBox cbxCategorias;
		private Panel panel1;
		private Button btnSalir;
		private Button btnDatos;
		private Button btnActualiza;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnNuevo;
		private DataGridViewTextBoxColumn colpais;
		private DataGridViewTextBoxColumn colProvincia;
		private DataGridViewTextBoxColumn colCuit;
		private DataGridViewTextBoxColumn colRol;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn col;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
	}
}