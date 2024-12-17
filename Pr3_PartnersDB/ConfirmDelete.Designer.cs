namespace PartnersDB {
	partial class ConfirmDelete {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			label1 = new Label();
			panel1 = new Panel();
			buttonYes = new Button();
			buttonNo = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(277, 42);
			label1.TabIndex = 0;
			label1.Text = "Удалить данного партнёра?";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			panel1.Controls.Add(buttonNo);
			panel1.Controls.Add(buttonYes);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 42);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(20);
			panel1.Size = new Size(277, 82);
			panel1.TabIndex = 1;
			// 
			// buttonYes
			// 
			buttonYes.Dock = DockStyle.Left;
			buttonYes.Location = new Point(20, 20);
			buttonYes.Name = "buttonYes";
			buttonYes.Size = new Size(75, 42);
			buttonYes.TabIndex = 0;
			buttonYes.Text = "Да";
			buttonYes.UseVisualStyleBackColor = true;
			buttonYes.Click += this.buttonYes_Click;
			// 
			// buttonNo
			// 
			buttonNo.Dock = DockStyle.Right;
			buttonNo.Location = new Point(101, 20);
			buttonNo.Name = "buttonNo";
			buttonNo.Size = new Size(156, 42);
			buttonNo.TabIndex = 1;
			buttonNo.Text = "Нет";
			buttonNo.UseVisualStyleBackColor = true;
			buttonNo.Click += this.buttonNo_Click;
			// 
			// ConfirmDelete
			// 
			AcceptButton = buttonYes;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonNo;
			ClientSize = new Size(277, 124);
			Controls.Add(panel1);
			Controls.Add(label1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ConfirmDelete";
			ShowIcon = false;
			ShowInTaskbar = false;
			TopMost = true;
			Load += this.ConfirmDelete_Load;
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private Button buttonNo;
		private Button buttonYes;
	}
}