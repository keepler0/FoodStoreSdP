namespace FoodStore.Windows.Forms.Empresas
{
	partial class frmEmpresas
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
			colRs = new DataGridViewTextBoxColumn();
			cold = new DataGridViewTextBoxColumn();
			cuit = new DataGridViewTextBoxColumn();
			coltel = new DataGridViewTextBoxColumn();
			colEmail = new DataGridViewTextBoxColumn();
			panel2 = new Panel();
			tbxFiltroTexto = new TextBox();
			btnQuitarOrden = new Button();
			btnFiltrar = new Button();
			label3 = new Label();
			label2 = new Label();
			cbxOrdenar = new ComboBox();
			panel1 = new Panel();
			btnSalir = new Button();
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
			panel3.Size = new Size(895, 559);
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
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colRs, cold, cuit, coltel, colEmail });
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
			dgvDatos.Size = new Size(895, 559);
			dgvDatos.TabIndex = 0;
			// 
			// colRs
			// 
			colRs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colRs.HeaderText = "Razon social";
			colRs.MinimumWidth = 8;
			colRs.Name = "colRs";
			colRs.ReadOnly = true;
			// 
			// cold
			// 
			cold.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			cold.HeaderText = "Direccion";
			cold.MinimumWidth = 8;
			cold.Name = "cold";
			cold.ReadOnly = true;
			// 
			// cuit
			// 
			cuit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			cuit.HeaderText = "Cuit";
			cuit.MinimumWidth = 8;
			cuit.Name = "cuit";
			cuit.ReadOnly = true;
			// 
			// coltel
			// 
			coltel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			coltel.HeaderText = "Telefono";
			coltel.MinimumWidth = 8;
			coltel.Name = "coltel";
			coltel.ReadOnly = true;
			// 
			// colEmail
			// 
			colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colEmail.HeaderText = "Email";
			colEmail.MinimumWidth = 8;
			colEmail.Name = "colEmail";
			colEmail.ReadOnly = true;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(224, 230, 4);
			panel2.Controls.Add(tbxFiltroTexto);
			panel2.Controls.Add(btnQuitarOrden);
			panel2.Controls.Add(btnFiltrar);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(cbxOrdenar);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(122, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(895, 82);
			panel2.TabIndex = 10;
			// 
			// tbxFiltroTexto
			// 
			tbxFiltroTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			tbxFiltroTexto.Location = new Point(633, 43);
			tbxFiltroTexto.Name = "tbxFiltroTexto";
			tbxFiltroTexto.Size = new Size(211, 31);
			tbxFiltroTexto.TabIndex = 3;
			// 
			// btnQuitarOrden
			// 
			btnQuitarOrden.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnQuitarOrden.Enabled = false;
			btnQuitarOrden.Location = new Point(594, 42);
			btnQuitarOrden.Name = "btnQuitarOrden";
			btnQuitarOrden.Size = new Size(33, 33);
			btnQuitarOrden.TabIndex = 2;
			btnQuitarOrden.UseVisualStyleBackColor = true;
			btnQuitarOrden.Click += btnQuitarOrden_Click;
			// 
			// btnFiltrar
			// 
			btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnFiltrar.Location = new Point(850, 42);
			btnFiltrar.Name = "btnFiltrar";
			btnFiltrar.Size = new Size(33, 33);
			btnFiltrar.TabIndex = 2;
			btnFiltrar.UseVisualStyleBackColor = true;
			btnFiltrar.Click += btnFiltrar_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(404, 11);
			label3.Name = "label3";
			label3.Size = new Size(110, 25);
			label3.TabIndex = 1;
			label3.Text = "Ordenar por";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(633, 11);
			label2.Name = "label2";
			label2.Size = new Size(187, 25);
			label2.TabIndex = 1;
			label2.Text = "Filtrar por razon social";
			// 
			// cbxOrdenar
			// 
			cbxOrdenar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			cbxOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxOrdenar.FormattingEnabled = true;
			cbxOrdenar.Location = new Point(404, 42);
			cbxOrdenar.Name = "cbxOrdenar";
			cbxOrdenar.Size = new Size(184, 33);
			cbxOrdenar.TabIndex = 0;
			cbxOrdenar.SelectedIndexChanged += cbxOrdenar_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(224, 230, 4);
			panel1.Controls.Add(btnSalir);
			panel1.Controls.Add(btnActualiza);
			panel1.Controls.Add(btnEditar);
			panel1.Controls.Add(btnBorrar);
			panel1.Controls.Add(btnNuevo);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(122, 641);
			panel1.TabIndex = 9;
			// 
			// btnSalir
			// 
			btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSalir.Location = new Point(-10, 566);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(126, 63);
			btnSalir.TabIndex = 0;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
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
			// frmEmpresas
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1017, 641);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MinimumSize = new Size(1039, 697);
			Name = "frmEmpresas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmEmpresas";
			FormClosing += frmEmpresas_FormClosing;
			Load += frmEmpresas_Load;
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
		private Button btnFiltrar;
		private Label label3;
		private Label label2;
		private ComboBox cbxOrdenar;
		private Panel panel1;
		private Button btnSalir;
		private Button btnActualiza;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnNuevo;
		private TextBox tbxFiltroTexto;
		private DataGridViewTextBoxColumn colRs;
		private DataGridViewTextBoxColumn cold;
		private DataGridViewTextBoxColumn cuit;
		private DataGridViewTextBoxColumn coltel;
		private DataGridViewTextBoxColumn colEmail;
	}
}