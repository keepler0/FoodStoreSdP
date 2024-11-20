namespace FoodStore.Windows.Forms.SubCategorias
{
	partial class frmSubcategorias
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
			panel2 = new Panel();
			btnQuitarOrden = new Button();
			label1 = new Label();
			cbxOrdenar = new ComboBox();
			btnQuitarFiltro = new Button();
			label2 = new Label();
			cbxCombosCategorias = new ComboBox();
			panel1 = new Panel();
			btnSalir = new Button();
			btnEditar = new Button();
			btnBorrar = new Button();
			btnNuevo = new Button();
			dgvDatos = new DataGridView();
			colpais = new DataGridViewTextBoxColumn();
			colSubCategoria = new DataGridViewTextBoxColumn();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(224, 230, 4);
			panel2.Controls.Add(btnQuitarOrden);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(cbxOrdenar);
			panel2.Controls.Add(btnQuitarFiltro);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(cbxCombosCategorias);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(122, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(772, 70);
			panel2.TabIndex = 7;
			// 
			// btnQuitarOrden
			// 
			btnQuitarOrden.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarOrden.Enabled = false;
			btnQuitarOrden.Location = new Point(500, 30);
			btnQuitarOrden.Name = "btnQuitarOrden";
			btnQuitarOrden.Size = new Size(33, 33);
			btnQuitarOrden.TabIndex = 8;
			btnQuitarOrden.UseVisualStyleBackColor = true;
			btnQuitarOrden.Click += btnQuitarOrden_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(310, 3);
			label1.Name = "label1";
			label1.Size = new Size(110, 25);
			label1.TabIndex = 7;
			label1.Text = "Ordenar por";
			// 
			// cbxOrdenar
			// 
			cbxOrdenar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxOrdenar.FormattingEnabled = true;
			cbxOrdenar.Location = new Point(310, 31);
			cbxOrdenar.Name = "cbxOrdenar";
			cbxOrdenar.Size = new Size(184, 33);
			cbxOrdenar.TabIndex = 6;
			cbxOrdenar.SelectedIndexChanged += cbxOrdenar_SelectedIndexChanged;
			// 
			// btnQuitarFiltro
			// 
			btnQuitarFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarFiltro.Enabled = false;
			btnQuitarFiltro.Location = new Point(727, 30);
			btnQuitarFiltro.Name = "btnQuitarFiltro";
			btnQuitarFiltro.Size = new Size(33, 33);
			btnQuitarFiltro.TabIndex = 5;
			btnQuitarFiltro.UseVisualStyleBackColor = true;
			btnQuitarFiltro.Click += btnQuitarFiltro_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(537, 2);
			label2.Name = "label2";
			label2.Size = new Size(89, 25);
			label2.TabIndex = 4;
			label2.Text = "Filtrar por";
			// 
			// cbxCombosCategorias
			// 
			cbxCombosCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxCombosCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCombosCategorias.FormattingEnabled = true;
			cbxCombosCategorias.Location = new Point(537, 30);
			cbxCombosCategorias.Name = "cbxCombosCategorias";
			cbxCombosCategorias.Size = new Size(184, 33);
			cbxCombosCategorias.TabIndex = 3;
			cbxCombosCategorias.SelectedIndexChanged += cbxCombosCategorias_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(224, 230, 4);
			panel1.Controls.Add(btnSalir);
			panel1.Controls.Add(btnEditar);
			panel1.Controls.Add(btnBorrar);
			panel1.Controls.Add(btnNuevo);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(122, 537);
			panel1.TabIndex = 6;
			// 
			// btnSalir
			// 
			btnSalir.Location = new Point(-10, 460);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(126, 65);
			btnSalir.TabIndex = 0;
			btnSalir.Text = "Salir";
			btnSalir.TextAlign = ContentAlignment.MiddleRight;
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
			// 
			// btnEditar
			// 
			btnEditar.Location = new Point(-10, 208);
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
			btnBorrar.Location = new Point(-10, 139);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(126, 63);
			btnBorrar.TabIndex = 0;
			btnBorrar.Text = "Borrar";
			btnBorrar.TextAlign = ContentAlignment.MiddleRight;
			btnBorrar.UseVisualStyleBackColor = true;
			btnBorrar.Click += btnBorrar_Click;
			// 
			// btnNuevo
			// 
			btnNuevo.BackgroundImageLayout = ImageLayout.None;
			btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
			btnNuevo.Location = new Point(-10, 70);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(126, 63);
			btnNuevo.TabIndex = 0;
			btnNuevo.Text = "Nuevo";
			btnNuevo.TextAlign = ContentAlignment.MiddleRight;
			btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnNuevo.UseVisualStyleBackColor = true;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.BackgroundColor = Color.FromArgb(250, 255, 145);
			dgvDatos.BorderStyle = BorderStyle.None;
			dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
			dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colpais, colSubCategoria });
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.GridColor = SystemColors.InactiveBorder;
			dgvDatos.Location = new Point(122, 70);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
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
			dgvDatos.Size = new Size(772, 467);
			dgvDatos.TabIndex = 0;
			// 
			// colpais
			// 
			colpais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colpais.HeaderText = "Categoria";
			colpais.MinimumWidth = 8;
			colpais.Name = "colpais";
			colpais.ReadOnly = true;
			// 
			// colSubCategoria
			// 
			colSubCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colSubCategoria.HeaderText = "Sub-Categoria";
			colSubCategoria.MinimumWidth = 8;
			colSubCategoria.Name = "colSubCategoria";
			colSubCategoria.ReadOnly = true;
			// 
			// frmSubcategorias
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(894, 537);
			Controls.Add(dgvDatos);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MinimumSize = new Size(875, 392);
			Name = "frmSubcategorias";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmSubcategorias";
			FormClosing += frmSubcategorias_FormClosing;
			Load += frmSubcategorias_Load;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Panel panel1;
		private Button btnSalir;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnNuevo;
		private DataGridView dgvDatos;
		private DataGridViewTextBoxColumn colpais;
		private DataGridViewTextBoxColumn colSubCategoria;
		private Button btnQuitarFiltro;
		private Label label2;
		private ComboBox cbxCombosCategorias;
		private Button btnQuitarOrden;
		private Label label1;
		private ComboBox cbxOrdenar;
	}
}