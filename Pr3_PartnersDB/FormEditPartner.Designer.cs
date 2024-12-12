namespace Pr3_PartnersDB {
	partial class FormEditPartner {
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
			panelRight = new Panel();
			dataGridViewPartnerTypes = new DataGridView();
			panelTop = new Panel();
			buttonSave = new Button();
			panelFill = new Panel();
			dataGridViewPartner = new DataGridView();
			buttonDelete = new Button();
			panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewPartnerTypes).BeginInit();
			panelTop.SuspendLayout();
			panelFill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewPartner).BeginInit();
			SuspendLayout();
			// 
			// panelRight
			// 
			panelRight.Controls.Add(buttonDelete);
			panelRight.Controls.Add(dataGridViewPartnerTypes);
			panelRight.Dock = DockStyle.Right;
			panelRight.Location = new Point(529, 0);
			panelRight.Name = "panelRight";
			panelRight.Padding = new Padding(6);
			panelRight.Size = new Size(228, 250);
			panelRight.TabIndex = 0;
			// 
			// dataGridViewPartnerTypes
			// 
			dataGridViewPartnerTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPartnerTypes.Dock = DockStyle.Fill;
			dataGridViewPartnerTypes.Location = new Point(6, 6);
			dataGridViewPartnerTypes.Name = "dataGridViewPartnerTypes";
			dataGridViewPartnerTypes.Size = new Size(216, 238);
			dataGridViewPartnerTypes.TabIndex = 0;
			// 
			// panelTop
			// 
			panelTop.Controls.Add(buttonSave);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(6);
			panelTop.Size = new Size(529, 54);
			panelTop.TabIndex = 1;
			// 
			// buttonSave
			// 
			buttonSave.Dock = DockStyle.Fill;
			buttonSave.Location = new Point(6, 6);
			buttonSave.Name = "buttonSave";
			buttonSave.Padding = new Padding(6);
			buttonSave.Size = new Size(517, 42);
			buttonSave.TabIndex = 0;
			buttonSave.Text = "Сохранить";
			buttonSave.UseVisualStyleBackColor = true;
			buttonSave.Click += buttonSave_Click;
			// 
			// panelFill
			// 
			panelFill.Controls.Add(dataGridViewPartner);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 54);
			panelFill.Name = "panelFill";
			panelFill.Padding = new Padding(6);
			panelFill.Size = new Size(529, 196);
			panelFill.TabIndex = 2;
			// 
			// dataGridViewPartner
			// 
			dataGridViewPartner.AllowUserToAddRows = false;
			dataGridViewPartner.AllowUserToDeleteRows = false;
			dataGridViewPartner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPartner.Dock = DockStyle.Fill;
			dataGridViewPartner.Location = new Point(6, 6);
			dataGridViewPartner.Name = "dataGridViewPartner";
			dataGridViewPartner.Size = new Size(517, 184);
			dataGridViewPartner.TabIndex = 0;
			// 
			// buttonDelete
			// 
			buttonDelete.Dock = DockStyle.Bottom;
			buttonDelete.Location = new Point(6, 205);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(216, 39);
			buttonDelete.TabIndex = 1;
			buttonDelete.Text = "Удалить";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// FormEditPartner
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(757, 250);
			Controls.Add(panelFill);
			Controls.Add(panelTop);
			Controls.Add(panelRight);
			Name = "FormEditPartner";
			Text = "Изменение данных о партнёре";
			panelRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewPartnerTypes).EndInit();
			panelTop.ResumeLayout(false);
			panelFill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewPartner).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelRight;
		private DataGridView dataGridViewPartnerTypes;
		private Panel panelTop;
		private Button buttonSave;
		private Panel panelFill;
		private DataGridView dataGridViewPartner;
		private Button buttonDelete;
	}
}