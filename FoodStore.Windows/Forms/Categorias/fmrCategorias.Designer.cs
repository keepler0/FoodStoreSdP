namespace FoodStore.Windows.Forms.Categorias
{
	partial class fmrCategorias
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
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			panel3 = new Panel();
			dgvDatos = new DataGridView();
			panel2 = new Panel();
			panel1 = new Panel();
			btnSalir = new Button();
			btnEditar = new Button();
			btnBorrar = new Button();
			btnNuevo = new Button();
			colpais = new DataGridViewTextBoxColumn();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel3
			// 
			panel3.Controls.Add(dgvDatos);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(122, 51);
			panel3.Name = "panel3";
			panel3.Size = new Size(731, 545);
			panel3.TabIndex = 5;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle11.SelectionForeColor = Color.Black;
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			dgvDatos.BackgroundColor = Color.FromArgb(250, 255, 145);
			dgvDatos.BorderStyle = BorderStyle.None;
			dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle12.SelectionForeColor = SystemColors.Desktop;
			dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colpais });
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle13.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
			dgvDatos.DefaultCellStyle = dataGridViewCellStyle13;
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.GridColor = SystemColors.InactiveBorder;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = Color.FromArgb(254, 255, 230);
			dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle14.SelectionForeColor = SystemColors.Desktop;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
			dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			dgvDatos.RowHeadersWidth = 62;
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle15;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(731, 545);
			dgvDatos.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(224, 230, 4);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(122, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(731, 51);
			panel2.TabIndex = 4;
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
			panel1.Size = new Size(122, 596);
			panel1.TabIndex = 3;
			// 
			// btnSalir
			// 
			btnSalir.Location = new Point(-10, 258);
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
			btnEditar.Location = new Point(-10, 189);
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
			btnBorrar.Location = new Point(-10, 120);
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
			btnNuevo.Location = new Point(-10, 51);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(126, 63);
			btnNuevo.TabIndex = 0;
			btnNuevo.Text = "Nuevo";
			btnNuevo.TextAlign = ContentAlignment.MiddleRight;
			btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnNuevo.UseVisualStyleBackColor = true;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// colpais
			// 
			colpais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colpais.HeaderText = "Categoria";
			colpais.MinimumWidth = 8;
			colpais.Name = "colpais";
			colpais.ReadOnly = true;
			// 
			// fmrCategorias
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(853, 596);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			MinimumSize = new Size(875, 392);
			Name = "fmrCategorias";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "fmrCategorias";
			FormClosing += fmrCategorias_FormClosing;
			Load += fmrCategorias_Load;
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel3;
		private DataGridView dgvDatos;
		private Panel panel2;
		private Panel panel1;
		private Button btnSalir;
		private Button btnEditar;
		private Button btnBorrar;
		private Button btnNuevo;
		private DataGridViewTextBoxColumn colpais;
	}
}