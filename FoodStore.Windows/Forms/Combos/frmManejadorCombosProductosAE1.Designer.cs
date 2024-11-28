namespace FoodStore.Windows.Forms.Combos
{
	partial class frmManejadorCombosProductosAE1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejadorCombosProductosAE1));
			panel1 = new Panel();
			dgvDatos = new DataGridView();
			colId = new DataGridViewTextBoxColumn();
			colpais = new DataGridViewTextBoxColumn();
			colPrecioUnitario = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			colTotal = new DataGridViewTextBoxColumn();
			btnOk = new Button();
			btnCancelar = new Button();
			flowLayoutPanel1 = new FlowLayoutPanel();
			fileSystemWatcher1 = new FileSystemWatcher();
			panel2 = new Panel();
			button1 = new Button();
			button2 = new Button();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			panel1.Controls.Add(dgvDatos);
			panel1.Controls.Add(btnOk);
			panel1.Controls.Add(btnCancelar);
			panel1.Location = new Point(1008, 44);
			panel1.Name = "panel1";
			panel1.Size = new Size(668, 468);
			panel1.TabIndex = 0;
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
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colpais, colPrecioUnitario, colCantidad, colTotal });
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
			dgvDatos.Size = new Size(668, 468);
			dgvDatos.TabIndex = 35;
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
			colpais.HeaderText = "Producto";
			colpais.MinimumWidth = 8;
			colpais.Name = "colpais";
			colpais.ReadOnly = true;
			// 
			// colPrecioUnitario
			// 
			colPrecioUnitario.HeaderText = "Precio unitario";
			colPrecioUnitario.MinimumWidth = 8;
			colPrecioUnitario.Name = "colPrecioUnitario";
			colPrecioUnitario.ReadOnly = true;
			colPrecioUnitario.Width = 150;
			// 
			// colCantidad
			// 
			colCantidad.HeaderText = "Cantidad";
			colCantidad.MinimumWidth = 8;
			colCantidad.Name = "colCantidad";
			colCantidad.ReadOnly = true;
			colCantidad.Width = 150;
			// 
			// colTotal
			// 
			colTotal.HeaderText = "Total";
			colTotal.MinimumWidth = 8;
			colTotal.Name = "colTotal";
			colTotal.ReadOnly = true;
			colTotal.Width = 153;
			// 
			// btnOk
			// 
			btnOk.BackColor = Color.FromArgb(29, 30, 44);
			btnOk.FlatStyle = FlatStyle.Popup;
			btnOk.Image = (Image)resources.GetObject("btnOk.Image");
			btnOk.Location = new Point(606, 766);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 36;
			btnOk.UseVisualStyleBackColor = false;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.FromArgb(29, 30, 44);
			btnCancelar.FlatStyle = FlatStyle.Popup;
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(683, 766);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 37;
			btnCancelar.UseVisualStyleBackColor = false;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(46, 44);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(903, 625);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// panel2
			// 
			panel2.Controls.Add(button1);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(1008, 529);
			panel2.Name = "panel2";
			panel2.Size = new Size(668, 140);
			panel2.TabIndex = 2;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(29, 30, 44);
			button1.FlatStyle = FlatStyle.Popup;
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.Location = new Point(500, 35);
			button1.Name = "button1";
			button1.Size = new Size(71, 67);
			button1.TabIndex = 35;
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(29, 30, 44);
			button2.FlatStyle = FlatStyle.Popup;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.Location = new Point(577, 35);
			button2.Name = "button2";
			button2.Size = new Size(71, 67);
			button2.TabIndex = 36;
			button2.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.FromArgb(222, 206, 5);
			label5.Location = new Point(101, 77);
			label5.Name = "label5";
			label5.Size = new Size(22, 25);
			label5.TabIndex = 0;
			label5.Text = "0";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(222, 206, 5);
			label4.Location = new Point(83, 77);
			label4.Name = "label4";
			label4.Size = new Size(22, 25);
			label4.TabIndex = 0;
			label4.Text = "$";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(222, 206, 5);
			label3.Location = new Point(12, 77);
			label3.Name = "label3";
			label3.Size = new Size(49, 25);
			label3.TabIndex = 0;
			label3.Text = "Total";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(222, 206, 5);
			label2.Location = new Point(101, 37);
			label2.Name = "label2";
			label2.Size = new Size(22, 25);
			label2.TabIndex = 0;
			label2.Text = "0";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(222, 206, 5);
			label1.Location = new Point(12, 37);
			label1.Name = "label1";
			label1.Size = new Size(83, 25);
			label1.TabIndex = 0;
			label1.Text = "Cantidad";
			// 
			// frmManejadorCombosProductosAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(29, 30, 44);
			ClientSize = new Size(1723, 703);
			Controls.Add(panel2);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(panel1);
			Name = "frmManejadorCombosProductosAE";
			Text = "frmManejadorCombosProductos";
			Load += frmManejadorCombosProductosAE_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private FlowLayoutPanel flowLayoutPanel1;
		private FileSystemWatcher fileSystemWatcher1;
		private Button btnOk;
		private Button btnCancelar;
		private DataGridView dgvDatos;
		private DataGridViewTextBoxColumn colId;
		private DataGridViewTextBoxColumn colpais;
		private DataGridViewTextBoxColumn colPrecioUnitario;
		private DataGridViewTextBoxColumn colCantidad;
		private DataGridViewTextBoxColumn colTotal;
		private Panel panel2;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button button1;
		private Button button2;
	}
}