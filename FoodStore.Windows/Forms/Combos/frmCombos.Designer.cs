namespace FoodStore.Windows.Forms.Combos
{
	partial class frmCombos
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombos));
			panel3 = new Panel();
			dgvDatos = new DataGridView();
			colId = new DataGridViewTextBoxColumn();
			colpais = new DataGridViewTextBoxColumn();
			colProvincia = new DataGridViewTextBoxColumn();
			coltamanio = new DataGridViewTextBoxColumn();
			colcantidad = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewCheckBoxColumn();
			panel2 = new Panel();
			tbxMarca = new TextBox();
			label11 = new Label();
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
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label4 = new Label();
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
			panel3.Location = new Point(254, 132);
			panel3.Name = "panel3";
			panel3.Size = new Size(1495, 544);
			panel3.TabIndex = 17;
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
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colpais, colProvincia, coltamanio, colcantidad, Column1, Column3 });
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
			dgvDatos.Size = new Size(1495, 544);
			dgvDatos.TabIndex = 0;
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
			// colpais
			// 
			colpais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colpais.HeaderText = "Nombre";
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
			// coltamanio
			// 
			coltamanio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			coltamanio.HeaderText = "Tamaño";
			coltamanio.MinimumWidth = 8;
			coltamanio.Name = "coltamanio";
			coltamanio.ReadOnly = true;
			// 
			// colcantidad
			// 
			colcantidad.HeaderText = "Cantidad de productos";
			colcantidad.MinimumWidth = 8;
			colcantidad.Name = "colcantidad";
			colcantidad.ReadOnly = true;
			colcantidad.Width = 256;
			// 
			// Column1
			// 
			Column1.HeaderText = "Precio";
			Column1.MinimumWidth = 8;
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Width = 150;
			// 
			// Column3
			// 
			Column3.HeaderText = "Vigente";
			Column3.MinimumWidth = 8;
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			Column3.Resizable = DataGridViewTriState.True;
			Column3.SortMode = DataGridViewColumnSortMode.Automatic;
			Column3.Width = 257;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(29, 30, 44);
			panel2.Controls.Add(tbxMarca);
			panel2.Controls.Add(label11);
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
			panel2.Location = new Point(254, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1495, 132);
			panel2.TabIndex = 16;
			// 
			// tbxMarca
			// 
			tbxMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tbxMarca.Location = new Point(552, 60);
			tbxMarca.Name = "tbxMarca";
			tbxMarca.Size = new Size(202, 31);
			tbxMarca.TabIndex = 3;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.FromArgb(222, 206, 5);
			label11.Location = new Point(6, 9);
			label11.Name = "label11";
			label11.Size = new Size(304, 96);
			label11.TabIndex = 4;
			label11.Text = "Combos";
			// 
			// btnBuscarMarca
			// 
			btnBuscarMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnBuscarMarca.BackColor = Color.FromArgb(222, 206, 5);
			btnBuscarMarca.BackgroundImage = (Image)resources.GetObject("btnBuscarMarca.BackgroundImage");
			btnBuscarMarca.BackgroundImageLayout = ImageLayout.Zoom;
			btnBuscarMarca.FlatStyle = FlatStyle.Flat;
			btnBuscarMarca.Location = new Point(760, 60);
			btnBuscarMarca.Name = "btnBuscarMarca";
			btnBuscarMarca.Size = new Size(33, 33);
			btnBuscarMarca.TabIndex = 2;
			btnBuscarMarca.UseVisualStyleBackColor = false;
			// 
			// btnQuitarOrden
			// 
			btnQuitarOrden.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarOrden.BackColor = Color.FromArgb(222, 206, 5);
			btnQuitarOrden.BackgroundImage = (Image)resources.GetObject("btnQuitarOrden.BackgroundImage");
			btnQuitarOrden.BackgroundImageLayout = ImageLayout.Zoom;
			btnQuitarOrden.Enabled = false;
			btnQuitarOrden.FlatStyle = FlatStyle.Flat;
			btnQuitarOrden.Location = new Point(989, 61);
			btnQuitarOrden.Name = "btnQuitarOrden";
			btnQuitarOrden.Size = new Size(33, 33);
			btnQuitarOrden.TabIndex = 2;
			btnQuitarOrden.UseVisualStyleBackColor = false;
			// 
			// btnQuitarSubCategoria
			// 
			btnQuitarSubCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarSubCategoria.BackColor = Color.FromArgb(222, 206, 5);
			btnQuitarSubCategoria.BackgroundImage = (Image)resources.GetObject("btnQuitarSubCategoria.BackgroundImage");
			btnQuitarSubCategoria.Enabled = false;
			btnQuitarSubCategoria.FlatStyle = FlatStyle.Flat;
			btnQuitarSubCategoria.Location = new Point(1447, 61);
			btnQuitarSubCategoria.Name = "btnQuitarSubCategoria";
			btnQuitarSubCategoria.Size = new Size(33, 33);
			btnQuitarSubCategoria.TabIndex = 2;
			btnQuitarSubCategoria.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.ForeColor = SystemColors.Window;
			label5.Location = new Point(552, 29);
			label5.Name = "label5";
			label5.Size = new Size(149, 25);
			label5.TabIndex = 1;
			label5.Text = "Buscar por Marca";
			// 
			// btnQuitarCategoria
			// 
			btnQuitarCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarCategoria.BackColor = Color.FromArgb(222, 206, 5);
			btnQuitarCategoria.BackgroundImage = (Image)resources.GetObject("btnQuitarCategoria.BackgroundImage");
			btnQuitarCategoria.Enabled = false;
			btnQuitarCategoria.FlatStyle = FlatStyle.Flat;
			btnQuitarCategoria.Location = new Point(1218, 61);
			btnQuitarCategoria.Name = "btnQuitarCategoria";
			btnQuitarCategoria.Size = new Size(33, 33);
			btnQuitarCategoria.TabIndex = 2;
			btnQuitarCategoria.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.ForeColor = SystemColors.Window;
			label3.Location = new Point(799, 30);
			label3.Name = "label3";
			label3.Size = new Size(110, 25);
			label3.TabIndex = 1;
			label3.Text = "Ordenar por";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.ForeColor = SystemColors.Window;
			label2.Location = new Point(1257, 30);
			label2.Name = "label2";
			label2.Size = new Size(203, 25);
			label2.TabIndex = 1;
			label2.Text = "Filtrar por sub-categoria";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.ForeColor = SystemColors.Window;
			label1.Location = new Point(1028, 30);
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
			cbxOrdenar.Location = new Point(799, 61);
			cbxOrdenar.Name = "cbxOrdenar";
			cbxOrdenar.Size = new Size(184, 33);
			cbxOrdenar.TabIndex = 0;
			// 
			// cbxSubCategorias
			// 
			cbxSubCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxSubCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxSubCategorias.FormattingEnabled = true;
			cbxSubCategorias.Location = new Point(1257, 61);
			cbxSubCategorias.Name = "cbxSubCategorias";
			cbxSubCategorias.Size = new Size(184, 33);
			cbxSubCategorias.TabIndex = 0;
			// 
			// cbxCategorias
			// 
			cbxCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCategorias.FormattingEnabled = true;
			cbxCategorias.Location = new Point(1028, 61);
			cbxCategorias.Name = "cbxCategorias";
			cbxCategorias.Size = new Size(184, 33);
			cbxCategorias.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(29, 30, 44);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(btnSalir);
			panel1.Controls.Add(btnDatos);
			panel1.Controls.Add(btnActualiza);
			panel1.Controls.Add(btnEditar);
			panel1.Controls.Add(btnBorrar);
			panel1.Controls.Add(btnNuevo);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(254, 676);
			panel1.TabIndex = 15;
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label10.AutoSize = true;
			label10.ForeColor = Color.FromArgb(222, 206, 5);
			label10.Location = new Point(128, 605);
			label10.Name = "label10";
			label10.Size = new Size(45, 25);
			label10.TabIndex = 4;
			label10.Text = "Salir";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = Color.FromArgb(222, 206, 5);
			label9.Location = new Point(128, 431);
			label9.Name = "label9";
			label9.Size = new Size(102, 25);
			label9.TabIndex = 4;
			label9.Text = "Ver detalles";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.ForeColor = Color.FromArgb(222, 206, 5);
			label8.Location = new Point(128, 362);
			label8.Name = "label8";
			label8.Size = new Size(88, 25);
			label8.TabIndex = 4;
			label8.Text = "Actualizar";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = Color.FromArgb(222, 206, 5);
			label7.Location = new Point(128, 293);
			label7.Name = "label7";
			label7.Size = new Size(57, 25);
			label7.TabIndex = 4;
			label7.Text = "Editar";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.FromArgb(222, 206, 5);
			label6.Location = new Point(128, 224);
			label6.Name = "label6";
			label6.Size = new Size(60, 25);
			label6.TabIndex = 4;
			label6.Text = "Borrar";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(222, 206, 5);
			label4.Location = new Point(128, 155);
			label4.Name = "label4";
			label4.Size = new Size(64, 25);
			label4.TabIndex = 4;
			label4.Text = "Nuevo";
			// 
			// btnSalir
			// 
			btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSalir.BackColor = Color.FromArgb(222, 206, 5);
			btnSalir.FlatStyle = FlatStyle.Flat;
			btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
			btnSalir.Location = new Point(31, 582);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(91, 70);
			btnSalir.TabIndex = 0;
			btnSalir.TextAlign = ContentAlignment.MiddleLeft;
			btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnSalir.UseVisualStyleBackColor = false;
			// 
			// btnDatos
			// 
			btnDatos.BackColor = Color.FromArgb(222, 206, 5);
			btnDatos.BackgroundImageLayout = ImageLayout.None;
			btnDatos.FlatStyle = FlatStyle.Flat;
			btnDatos.Image = (Image)resources.GetObject("btnDatos.Image");
			btnDatos.Location = new Point(31, 408);
			btnDatos.Name = "btnDatos";
			btnDatos.Size = new Size(91, 70);
			btnDatos.TabIndex = 0;
			btnDatos.TextAlign = ContentAlignment.MiddleLeft;
			btnDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnDatos.UseVisualStyleBackColor = false;
			// 
			// btnActualiza
			// 
			btnActualiza.BackColor = Color.FromArgb(222, 206, 5);
			btnActualiza.BackgroundImageLayout = ImageLayout.None;
			btnActualiza.FlatStyle = FlatStyle.Flat;
			btnActualiza.Image = (Image)resources.GetObject("btnActualiza.Image");
			btnActualiza.Location = new Point(31, 339);
			btnActualiza.Name = "btnActualiza";
			btnActualiza.Size = new Size(91, 70);
			btnActualiza.TabIndex = 0;
			btnActualiza.TextAlign = ContentAlignment.MiddleLeft;
			btnActualiza.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnActualiza.UseVisualStyleBackColor = false;
			// 
			// btnEditar
			// 
			btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnEditar.BackColor = Color.FromArgb(222, 206, 5);
			btnEditar.BackgroundImageLayout = ImageLayout.None;
			btnEditar.FlatStyle = FlatStyle.Flat;
			btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
			btnEditar.Location = new Point(31, 270);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(91, 70);
			btnEditar.TabIndex = 0;
			btnEditar.TextAlign = ContentAlignment.MiddleLeft;
			btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnEditar.UseVisualStyleBackColor = false;
			// 
			// btnBorrar
			// 
			btnBorrar.BackColor = Color.FromArgb(222, 206, 5);
			btnBorrar.BackgroundImageLayout = ImageLayout.None;
			btnBorrar.FlatStyle = FlatStyle.Flat;
			btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
			btnBorrar.Location = new Point(31, 201);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(91, 70);
			btnBorrar.TabIndex = 0;
			btnBorrar.TextAlign = ContentAlignment.MiddleLeft;
			btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnBorrar.UseVisualStyleBackColor = false;
			// 
			// btnNuevo
			// 
			btnNuevo.BackColor = Color.FromArgb(222, 206, 5);
			btnNuevo.BackgroundImageLayout = ImageLayout.None;
			btnNuevo.FlatStyle = FlatStyle.Popup;
			btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
			btnNuevo.Location = new Point(31, 132);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(91, 70);
			btnNuevo.TabIndex = 0;
			btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
			btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnNuevo.UseVisualStyleBackColor = false;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// frmCombos
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1749, 676);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "frmCombos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmCombos";
			Load += frmCombos_Load;
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
		private DataGridView dgvDatos;
		private Panel panel2;
		private TextBox tbxMarca;
		private Label label11;
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
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label4;
		private Button btnSalir;
		private Button btnDatos;
		private Button btnActualiza;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnNuevo;
		private DataGridViewTextBoxColumn colId;
		private DataGridViewTextBoxColumn colpais;
		private DataGridViewTextBoxColumn colProvincia;
		private DataGridViewTextBoxColumn coltamanio;
		private DataGridViewTextBoxColumn colcantidad;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewCheckBoxColumn Column3;
	}
}