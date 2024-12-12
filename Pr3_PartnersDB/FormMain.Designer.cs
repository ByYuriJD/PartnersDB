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
			panelFill = new Panel();
			dataGridView1 = new DataGridView();
			dataGridView2 = new DataGridView();
			dataGridView3 = new DataGridView();
			dataGridView4 = new DataGridView();
			dataGridView5 = new DataGridView();
			panelBottom.SuspendLayout();
			panelFill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
			SuspendLayout();
			// 
			// panelBottom
			// 
			panelBottom.Controls.Add(dataGridView5);
			panelBottom.Controls.Add(dataGridView4);
			panelBottom.Dock = DockStyle.Bottom;
			panelBottom.Location = new Point(0, 350);
			panelBottom.Name = "panelBottom";
			panelBottom.Padding = new Padding(10);
			panelBottom.Size = new Size(800, 100);
			panelBottom.TabIndex = 0;
			// 
			// panelFill
			// 
			panelFill.Controls.Add(dataGridView3);
			panelFill.Controls.Add(dataGridView2);
			panelFill.Controls.Add(dataGridView1);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 0);
			panelFill.Name = "panelFill";
			panelFill.Padding = new Padding(10);
			panelFill.Size = new Size(800, 350);
			panelFill.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Left;
			dataGridView1.Location = new Point(10, 10);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(278, 330);
			dataGridView1.TabIndex = 0;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Dock = DockStyle.Right;
			dataGridView2.Location = new Point(513, 10);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(277, 330);
			dataGridView2.TabIndex = 1;
			// 
			// dataGridView3
			// 
			dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView3.Dock = DockStyle.Fill;
			dataGridView3.Location = new Point(288, 10);
			dataGridView3.Name = "dataGridView3";
			dataGridView3.Size = new Size(225, 330);
			dataGridView3.TabIndex = 2;
			// 
			// dataGridView4
			// 
			dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView4.Dock = DockStyle.Left;
			dataGridView4.Location = new Point(10, 10);
			dataGridView4.Name = "dataGridView4";
			dataGridView4.Size = new Size(400, 80);
			dataGridView4.TabIndex = 0;
			// 
			// dataGridView5
			// 
			dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView5.Dock = DockStyle.Fill;
			dataGridView5.Location = new Point(410, 10);
			dataGridView5.Name = "dataGridView5";
			dataGridView5.Size = new Size(380, 80);
			dataGridView5.TabIndex = 1;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panelFill);
			Controls.Add(panelBottom);
			Name = "FormMain";
			Text = "Партнёры";
			panelBottom.ResumeLayout(false);
			panelFill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelBottom;
		private Panel panelFill;
		private DataGridView dataGridView5;
		private DataGridView dataGridView4;
		private DataGridView dataGridView3;
		private DataGridView dataGridView2;
		private DataGridView dataGridView1;
	}
}
