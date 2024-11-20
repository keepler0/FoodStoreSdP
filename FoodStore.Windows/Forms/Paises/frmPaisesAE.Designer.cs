namespace FoodStore.Windows.Forms.Paises
{
	partial class frmPaisesAE
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
			tbxPais = new TextBox();
			label1 = new Label();
			btnCancelar = new Button();
			btnOk = new Button();
			SuspendLayout();
			// 
			// tbxPais
			// 
			tbxPais.Location = new Point(13, 37);
			tbxPais.Name = "tbxPais";
			tbxPais.Size = new Size(268, 31);
			tbxPais.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 12);
			label1.Name = "label1";
			label1.Size = new Size(42, 25);
			label1.TabIndex = 1;
			label1.Text = "Pais";
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(210, 74);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 2;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(133, 74);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 2;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// frmPaisesAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(298, 155);
			ControlBox = false;
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label1);
			Controls.Add(tbxPais);
			Name = "frmPaisesAE";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbxPais;
		private Label label1;
		private Button btnCancelar;
		private Button btnOk;
	}
}