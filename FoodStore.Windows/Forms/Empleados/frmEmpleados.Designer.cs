namespace FoodStore.Windows.Forms.Empleados
{
	partial class frmEmpleados
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
			colpais = new DataGridViewTextBoxColumn();
			colProvincia = new DataGridViewTextBoxColumn();
			colCuit = new DataGridViewTextBoxColumn();
			colRol = new DataGridViewTextBoxColumn();
			colActivo = new DataGridViewCheckBoxColumn();
			panel2 = new Panel();
			tbxNombre = new TextBox();
			btnBuscarNombre = new Button();
			tbxApellido = new TextBox();
			btnBuscarApellido = new Button();
			btnQuitarOrden = new Button();
			btnQuitarEstado = new Button();
			label5 = new Label();
			btnQuitarCargo = new Button();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			cbxOrdenar = new ComboBox();
			cbxEstadoEmpleado = new ComboBox();
			cbxCargos = new ComboBox();
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
			panel3.Size = new Size(1627, 423);
			panel3.TabIndex = 11;
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
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colpais, colProvincia, colCuit, colRol, colActivo });
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
			dgvDatos.Size = new Size(1627, 423);
			dgvDatos.TabIndex = 0;
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
			colProvincia.HeaderText = "Apellido";
			colProvincia.MinimumWidth = 8;
			colProvincia.Name = "colProvincia";
			colProvincia.ReadOnly = true;
			// 
			// colCuit
			// 
			colCuit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colCuit.HeaderText = "Cuit";
			colCuit.MinimumWidth = 8;
			colCuit.Name = "colCuit";
			colCuit.ReadOnly = true;
			// 
			// colRol
			// 
			colRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colRol.HeaderText = "Cargo";
			colRol.MinimumWidth = 8;
			colRol.Name = "colRol";
			colRol.ReadOnly = true;
			// 
			// colActivo
			// 
			colActivo.HeaderText = "Esta activo?";
			colActivo.MinimumWidth = 8;
			colActivo.Name = "colActivo";
			colActivo.ReadOnly = true;
			colActivo.Width = 150;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(224, 230, 4);
			panel2.Controls.Add(tbxNombre);
			panel2.Controls.Add(btnBuscarNombre);
			panel2.Controls.Add(tbxApellido);
			panel2.Controls.Add(btnBuscarApellido);
			panel2.Controls.Add(btnQuitarOrden);
			panel2.Controls.Add(btnQuitarEstado);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(btnQuitarCargo);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(cbxOrdenar);
			panel2.Controls.Add(cbxEstadoEmpleado);
			panel2.Controls.Add(cbxCargos);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(122, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1627, 82);
			panel2.TabIndex = 10;
			// 
			// tbxNombre
			// 
			tbxNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tbxNombre.Location = new Point(440, 43);
			tbxNombre.Name = "tbxNombre";
			tbxNombre.Size = new Size(202, 31);
			tbxNombre.TabIndex = 3;
			// 
			// btnBuscarNombre
			// 
			btnBuscarNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnBuscarNombre.Location = new Point(648, 43);
			btnBuscarNombre.Name = "btnBuscarNombre";
			btnBuscarNombre.Size = new Size(33, 33);
			btnBuscarNombre.TabIndex = 2;
			btnBuscarNombre.UseVisualStyleBackColor = true;
			btnBuscarNombre.Click += btnBuscarNombre_Click;
			// 
			// tbxApellido
			// 
			tbxApellido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tbxApellido.Location = new Point(687, 43);
			tbxApellido.Name = "tbxApellido";
			tbxApellido.Size = new Size(202, 31);
			tbxApellido.TabIndex = 3;
			// 
			// btnBuscarApellido
			// 
			btnBuscarApellido.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnBuscarApellido.Location = new Point(895, 43);
			btnBuscarApellido.Name = "btnBuscarApellido";
			btnBuscarApellido.Size = new Size(33, 33);
			btnBuscarApellido.TabIndex = 2;
			btnBuscarApellido.UseVisualStyleBackColor = true;
			btnBuscarApellido.Click += btnBuscarApellido_Click;
			// 
			// btnQuitarOrden
			// 
			btnQuitarOrden.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarOrden.Enabled = false;
			btnQuitarOrden.Location = new Point(1124, 43);
			btnQuitarOrden.Name = "btnQuitarOrden";
			btnQuitarOrden.Size = new Size(33, 33);
			btnQuitarOrden.TabIndex = 2;
			btnQuitarOrden.UseVisualStyleBackColor = true;
			btnQuitarOrden.Click += btnQuitarOrden_Click;
			// 
			// btnQuitarEstado
			// 
			btnQuitarEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarEstado.Enabled = false;
			btnQuitarEstado.Location = new Point(1582, 43);
			btnQuitarEstado.Name = "btnQuitarEstado";
			btnQuitarEstado.Size = new Size(33, 33);
			btnQuitarEstado.TabIndex = 2;
			btnQuitarEstado.UseVisualStyleBackColor = true;
			btnQuitarEstado.Click += btnQuitarEstado_Click;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label5.AutoSize = true;
			label5.Location = new Point(440, 12);
			label5.Name = "label5";
			label5.Size = new Size(167, 25);
			label5.TabIndex = 1;
			label5.Text = "Buscar por Nombre";
			// 
			// btnQuitarCargo
			// 
			btnQuitarCargo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarCargo.Enabled = false;
			btnQuitarCargo.Location = new Point(1353, 43);
			btnQuitarCargo.Name = "btnQuitarCargo";
			btnQuitarCargo.Size = new Size(33, 33);
			btnQuitarCargo.TabIndex = 2;
			btnQuitarCargo.UseVisualStyleBackColor = true;
			btnQuitarCargo.Click += btnQuitarCargo_Click;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label4.AutoSize = true;
			label4.Location = new Point(687, 12);
			label4.Name = "label4";
			label4.Size = new Size(167, 25);
			label4.TabIndex = 1;
			label4.Text = "Buscar por Apellido";
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
			label2.Size = new Size(148, 25);
			label2.TabIndex = 1;
			label2.Text = "Filtrar por estado";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(1163, 12);
			label1.Name = "label1";
			label1.Size = new Size(139, 25);
			label1.TabIndex = 1;
			label1.Text = "Filtrar por cargo";
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
			// cbxEstadoEmpleado
			// 
			cbxEstadoEmpleado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxEstadoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxEstadoEmpleado.FormattingEnabled = true;
			cbxEstadoEmpleado.Location = new Point(1392, 43);
			cbxEstadoEmpleado.Name = "cbxEstadoEmpleado";
			cbxEstadoEmpleado.Size = new Size(184, 33);
			cbxEstadoEmpleado.TabIndex = 0;
			cbxEstadoEmpleado.SelectedIndexChanged += cbxEstadoEmpleado_SelectedIndexChanged;
			// 
			// cbxCargos
			// 
			cbxCargos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxCargos.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCargos.FormattingEnabled = true;
			cbxCargos.Location = new Point(1163, 43);
			cbxCargos.Name = "cbxCargos";
			cbxCargos.Size = new Size(184, 33);
			cbxCargos.TabIndex = 0;
			cbxCargos.SelectedIndexChanged += cbxCargos_SelectedIndexChanged;
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
			panel1.TabIndex = 9;
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
			// 
			// btnDatos
			// 
			btnDatos.Location = new Point(-10, 358);
			btnDatos.Name = "btnDatos";
			btnDatos.Size = new Size(126, 63);
			btnDatos.TabIndex = 0;
			btnDatos.Text = "Ver datos";
			btnDatos.UseVisualStyleBackColor = true;
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
			// frmEmpleados
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1749, 505);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MinimumSize = new Size(1335, 561);
			Name = "frmEmpleados";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmEmpleados";
			Load += frmEmpleados_Load;
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
		private Button btnQuitarEstado;
		private Button btnQuitarCargo;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox cbxOrdenar;
		private ComboBox cbxEstadoEmpleado;
		private ComboBox cbxCargos;
		private Panel panel1;
		private Button btnSalir;
		private Button btnActualiza;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnNuevo;
		private Button btnDatos;
		private TextBox tbxApellido;
		private Button btnBuscarApellido;
		private Label label4;
		private TextBox tbxNombre;
		private Button btnBuscarNombre;
		private Label label5;
		private DataGridViewTextBoxColumn colpais;
		private DataGridViewTextBoxColumn colProvincia;
		private DataGridViewTextBoxColumn colCuit;
		private DataGridViewTextBoxColumn colRol;
		private DataGridViewCheckBoxColumn colActivo;
	}
}