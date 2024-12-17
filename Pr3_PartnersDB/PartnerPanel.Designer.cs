namespace PartnersDB {
	partial class partnerPanel {
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			panel1 = new Panel();
			labelRating = new Label();
			labelPhone = new Label();
			labelCeo = new Label();
			labelNameType = new Label();
			panel2 = new Panel();
			buttonDelete = new Button();
			buttonEdit = new Button();
			labelCut = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(labelRating);
			panel1.Controls.Add(labelPhone);
			panel1.Controls.Add(labelCeo);
			panel1.Controls.Add(labelNameType);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(10, 10);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(10);
			panel1.Size = new Size(338, 120);
			panel1.TabIndex = 0;
			// 
			// labelRating
			// 
			labelRating.Dock = DockStyle.Top;
			labelRating.Location = new Point(10, 87);
			labelRating.Name = "labelRating";
			labelRating.Size = new Size(318, 23);
			labelRating.TabIndex = 3;
			labelRating.Text = "Рейтинг: 10";
			labelRating.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelPhone
			// 
			labelPhone.Dock = DockStyle.Top;
			labelPhone.Location = new Point(10, 64);
			labelPhone.Name = "labelPhone";
			labelPhone.Size = new Size(318, 23);
			labelPhone.TabIndex = 2;
			labelPhone.Text = "+7 999 999 99 99";
			labelPhone.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelCeo
			// 
			labelCeo.Dock = DockStyle.Top;
			labelCeo.Location = new Point(10, 41);
			labelCeo.Name = "labelCeo";
			labelCeo.Size = new Size(318, 23);
			labelCeo.TabIndex = 1;
			labelCeo.Text = "Директор";
			labelCeo.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelNameType
			// 
			labelNameType.Dock = DockStyle.Top;
			labelNameType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			labelNameType.Location = new Point(10, 10);
			labelNameType.Name = "labelNameType";
			labelNameType.Size = new Size(318, 31);
			labelNameType.TabIndex = 0;
			labelNameType.Text = "Тип | Наименование партнёра";
			labelNameType.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			panel2.Controls.Add(buttonDelete);
			panel2.Controls.Add(buttonEdit);
			panel2.Controls.Add(labelCut);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(369, 10);
			panel2.Name = "panel2";
			panel2.Padding = new Padding(10);
			panel2.Size = new Size(171, 120);
			panel2.TabIndex = 1;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.Salmon;
			buttonDelete.Dock = DockStyle.Bottom;
			buttonDelete.Font = new Font("Segoe UI", 12F);
			buttonDelete.ForeColor = SystemColors.Control;
			buttonDelete.Location = new Point(10, 39);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(151, 29);
			buttonDelete.TabIndex = 2;
			buttonDelete.Text = "Удалить";
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonEdit
			// 
			buttonEdit.Dock = DockStyle.Bottom;
			buttonEdit.Font = new Font("Segoe UI", 12F);
			buttonEdit.ForeColor = SystemColors.ControlText;
			buttonEdit.Location = new Point(10, 68);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(151, 42);
			buttonEdit.TabIndex = 1;
			buttonEdit.Text = "Изменить";
			buttonEdit.UseVisualStyleBackColor = true;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// labelCut
			// 
			labelCut.Dock = DockStyle.Top;
			labelCut.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
			labelCut.Location = new Point(10, 10);
			labelCut.Name = "labelCut";
			labelCut.Size = new Size(151, 31);
			labelCut.TabIndex = 0;
			labelCut.Text = "10%";
			labelCut.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// partnerPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "partnerPanel";
			Padding = new Padding(10);
			Size = new Size(550, 140);
			Load += UserControl1_Load;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label labelNameType;
		private Panel panel2;
		private Label labelRating;
		private Label labelPhone;
		private Label labelCeo;
		private Label labelCut;
		private Button buttonDelete;
		private Button buttonEdit;
	}
}
