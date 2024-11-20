namespace FoodStore.Windows.Forms.Clientes
{
	partial class frmClientes
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
			panel3 = new Panel();
			dgvDatos = new DataGridView();
			colNombreCompleto = new DataGridViewTextBoxColumn();
			colDireccionCompleta = new DataGridViewTextBoxColumn();
			colLocalidad = new DataGridViewTextBoxColumn();
			panel2 = new Panel();
			tbxDireccion = new TextBox();
			tbxNombre = new TextBox();
			btnQuitarOrden = new Button();
			btnBucarDireccion = new Button();
			btnBuscarNombre = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			cbxOrdenar = new ComboBox();
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
			panel3.Size = new Size(1346, 423);
			panel3.TabIndex = 14;
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
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNombreCompleto, colDireccionCompleta, colLocalidad });
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
			dgvDatos.Location = new Point(0, 0);
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
			dgvDatos.Size = new Size(1346, 423);
			dgvDatos.TabIndex = 0;
			// 
			// colNombreCompleto
			// 
			colNombreCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colNombreCompleto.HeaderText = "Nombre completo";
			colNombreCompleto.MinimumWidth = 8;
			colNombreCompleto.Name = "colNombreCompleto";
			colNombreCompleto.ReadOnly = true;
			// 
			// colDireccionCompleta
			// 
			colDireccionCompleta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colDireccionCompleta.HeaderText = "Direccion";
			colDireccionCompleta.MinimumWidth = 8;
			colDireccionCompleta.Name = "colDireccionCompleta";
			colDireccionCompleta.ReadOnly = true;
			// 
			// colLocalidad
			// 
			colLocalidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colLocalidad.HeaderText = "Telefono";
			colLocalidad.MinimumWidth = 8;
			colLocalidad.Name = "colLocalidad";
			colLocalidad.ReadOnly = true;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(224, 230, 4);
			panel2.Controls.Add(tbxDireccion);
			panel2.Controls.Add(tbxNombre);
			panel2.Controls.Add(btnQuitarOrden);
			panel2.Controls.Add(btnBucarDireccion);
			panel2.Controls.Add(btnBuscarNombre);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(cbxOrdenar);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(122, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1346, 82);
			panel2.TabIndex = 13;
			// 
			// tbxDireccion
			// 
			tbxDireccion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tbxDireccion.Location = new Point(882, 44);
			tbxDireccion.Name = "tbxDireccion";
			tbxDireccion.Size = new Size(184, 31);
			tbxDireccion.TabIndex = 3;
			// 
			// tbxNombre
			// 
			tbxNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tbxNombre.Location = new Point(653, 42);
			tbxNombre.Name = "tbxNombre";
			tbxNombre.Size = new Size(184, 31);
			tbxNombre.TabIndex = 3;
			// 
			// btnQuitarOrden
			// 
			btnQuitarOrden.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarOrden.Enabled = false;
			btnQuitarOrden.Location = new Point(1301, 43);
			btnQuitarOrden.Name = "btnQuitarOrden";
			btnQuitarOrden.Size = new Size(33, 33);
			btnQuitarOrden.TabIndex = 2;
			btnQuitarOrden.UseVisualStyleBackColor = true;
			btnQuitarOrden.Click += btnQuitarOrden_Click;
			// 
			// btnBucarDireccion
			// 
			btnBucarDireccion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnBucarDireccion.Location = new Point(1072, 43);
			btnBucarDireccion.Name = "btnBucarDireccion";
			btnBucarDireccion.Size = new Size(33, 33);
			btnBucarDireccion.TabIndex = 2;
			btnBucarDireccion.UseVisualStyleBackColor = true;
			btnBucarDireccion.Click += btnBucarApellido_Click;
			// 
			// btnBuscarNombre
			// 
			btnBuscarNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnBuscarNombre.Location = new Point(843, 42);
			btnBuscarNombre.Name = "btnBuscarNombre";
			btnBuscarNombre.Size = new Size(33, 33);
			btnBuscarNombre.TabIndex = 2;
			btnBuscarNombre.UseVisualStyleBackColor = true;
			btnBuscarNombre.Click += btnBuscarNombre_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(1111, 12);
			label3.Name = "label3";
			label3.Size = new Size(110, 25);
			label3.TabIndex = 1;
			label3.Text = "Ordenar por";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(882, 12);
			label2.Name = "label2";
			label2.Size = new Size(174, 25);
			label2.TabIndex = 1;
			label2.Text = "Buscar por Direccion";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(653, 11);
			label1.Name = "label1";
			label1.Size = new Size(164, 25);
			label1.TabIndex = 1;
			label1.Text = "Buscar por nombre";
			// 
			// cbxOrdenar
			// 
			cbxOrdenar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxOrdenar.FormattingEnabled = true;
			cbxOrdenar.Location = new Point(1111, 43);
			cbxOrdenar.Name = "cbxOrdenar";
			cbxOrdenar.Size = new Size(184, 33);
			cbxOrdenar.TabIndex = 0;
			cbxOrdenar.SelectedIndexChanged += cbxOrdenar_SelectedIndexChanged;
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
			panel1.Size = new Size(122, 505);
			panel1.TabIndex = 12;
			// 
			// btnSalir
			// 
			btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSalir.Location = new Point(-10, 427);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(126, 54);
			btnSalir.TabIndex = 0;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
			// 
			// btnDatos
			// 
			btnDatos.Location = new Point(-10, 358);
			btnDatos.Name = "btnDatos";
			btnDatos.Size = new Size(126, 63);
			btnDatos.TabIndex = 0;
			btnDatos.Text = "Ver datos";
			btnDatos.UseVisualStyleBackColor = true;
			btnDatos.Click += btnDatos_Click;
			// 
			// btnActualiza
			// 
			btnActualiza.Location = new Point(-10, 289);
			btnActualiza.Name = "btnActualiza";
			btnActualiza.Size = new Size(126, 63);
			btnActualiza.TabIndex = 0;
			btnActualiza.Text = "Actualizar";
			btnActualiza.UseVisualStyleBackColor = true;
			btnActualiza.Click += btnActualiza_Click;
			// 
			// btnEditar
			// 
			btnEditar.Location = new Point(-10, 220);
			btnEditar.Name = "btnEditar";
			btnEditar.Size = new Size(126, 63);
			btnEditar.TabIndex = 0;
			btnEditar.Text = "Editar";
			btnEditar.UseVisualStyleBackColor = true;
			btnEditar.Click += btnEditar_Click;
			// 
			// btnBorrar
			// 
			btnBorrar.Location = new Point(-10, 151);
			btnBorrar.Name = "btnBorrar";
			btnBorrar.Size = new Size(126, 63);
			btnBorrar.TabIndex = 0;
			btnBorrar.Text = "Borrar";
			btnBorrar.UseVisualStyleBackColor = true;
			btnBorrar.Click += btnBorrar_Click;
			// 
			// btnNuevo
			// 
			btnNuevo.Location = new Point(-10, 82);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(126, 63);
			btnNuevo.TabIndex = 0;
			btnNuevo.Text = "Nuevo";
			btnNuevo.UseVisualStyleBackColor = true;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// frmClientes
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1468, 505);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MinimumSize = new Size(1490, 561);
			Name = "frmClientes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmClientes";
			FormClosing += frmClientes_FormClosing;
			Load += frmClientes_Load;
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
		private Button btnQuitarOrden;
		private Button btnBucarDireccion;
		private Button btnBuscarNombre;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox cbxOrdenar;
		private Panel panel1;
		private Button btnSalir;
		private Button btnDatos;
		private Button btnActualiza;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnNuevo;
		private TextBox tbxDireccion;
		private TextBox tbxNombre;
		private DataGridViewTextBoxColumn colNombreCompleto;
		private DataGridViewTextBoxColumn colDireccionCompleta;
		private DataGridViewTextBoxColumn colLocalidad;
	}
}