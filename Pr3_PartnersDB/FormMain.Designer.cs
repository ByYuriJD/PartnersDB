namespace Pr3_PartnersDB {
	partial class FormMain {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			panelBottom = new Panel();
			dataGridViewProductTypes = new DataGridView();
			panelFill = new Panel();
			dataGridViewPartnersProducts = new DataGridView();
			dataGridViewProducts = new DataGridView();
			dataGridViewPartners = new DataGridView();
			dataGridViewPartnerTypes = new DataGridView();
			panelBottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewProductTypes).BeginInit();
			panelFill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewPartners).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewPartnerTypes).BeginInit();
			SuspendLayout();
			// 
			// panelBottom
			// 
			panelBottom.Controls.Add(dataGridViewProductTypes);
			panelBottom.Controls.Add(dataGridViewPartnerTypes);
			panelBottom.Dock = DockStyle.Bottom;
			panelBottom.Location = new Point(0, 361);
			panelBottom.Name = "panelBottom";
			panelBottom.Padding = new Padding(10);
			panelBottom.Size = new Size(984, 100);
			panelBottom.TabIndex = 0;
			// 
			// dataGridViewProductTypes
			// 
			dataGridViewProductTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewProductTypes.Dock = DockStyle.Fill;
			dataGridViewProductTypes.Location = new Point(473, 10);
			dataGridViewProductTypes.Name = "dataGridViewProductTypes";
			dataGridViewProductTypes.Size = new Size(501, 80);
			dataGridViewProductTypes.TabIndex = 1;
			// 
			// panelFill
			// 
			panelFill.Controls.Add(dataGridViewPartnersProducts);
			panelFill.Controls.Add(dataGridViewProducts);
			panelFill.Controls.Add(dataGridViewPartners);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 0);
			panelFill.Name = "panelFill";
			panelFill.Padding = new Padding(10);
			panelFill.Size = new Size(984, 361);
			panelFill.TabIndex = 1;
			// 
			// dataGridViewPartnersProducts
			// 
			dataGridViewPartnersProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPartnersProducts.Dock = DockStyle.Fill;
			dataGridViewPartnersProducts.Location = new Point(341, 10);
			dataGridViewPartnersProducts.Name = "dataGridViewPartnersProducts";
			dataGridViewPartnersProducts.Size = new Size(295, 341);
			dataGridViewPartnersProducts.TabIndex = 2;
			// 
			// dataGridViewProducts
			// 
			dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewProducts.Dock = DockStyle.Right;
			dataGridViewProducts.Location = new Point(636, 10);
			dataGridViewProducts.Name = "dataGridViewProducts";
			dataGridViewProducts.Size = new Size(338, 341);
			dataGridViewProducts.TabIndex = 1;
			dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
			// 
			// dataGridViewPartners
			// 
			dataGridViewPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPartners.Dock = DockStyle.Left;
			dataGridViewPartners.Location = new Point(10, 10);
			dataGridViewPartners.Name = "dataGridViewPartners";
			dataGridViewPartners.Size = new Size(331, 341);
			dataGridViewPartners.TabIndex = 0;
			dataGridViewPartners.SelectionChanged += dataGridViewPartners_SelectionChanged;
			// 
			// dataGridViewPartnerTypes
			// 
			dataGridViewPartnerTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPartnerTypes.Dock = DockStyle.Left;
			dataGridViewPartnerTypes.Location = new Point(10, 10);
			dataGridViewPartnerTypes.Name = "dataGridViewPartnerTypes";
			dataGridViewPartnerTypes.Size = new Size(463, 80);
			dataGridViewPartnerTypes.TabIndex = 0;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(984, 461);
			Controls.Add(panelFill);
			Controls.Add(panelBottom);
			Name = "FormMain";
			Text = "Партнёры";
			panelBottom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewProductTypes).EndInit();
			panelFill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewPartners).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewPartnerTypes).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelBottom;
		private Panel panelFill;
		private DataGridView dataGridViewProductTypes;
		private DataGridView dataGridViewPartnersProducts;
		private DataGridView dataGridViewProducts;
		private DataGridView dataGridViewPartners;
		private DataGridView dataGridViewPartnerTypes;
	}
}
