namespace PartnersDB {
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
			FlowPanel = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// FlowPanel
			// 
			FlowPanel.AutoScroll = true;
			FlowPanel.AutoScrollMargin = new Size(0, 50);
			FlowPanel.Dock = DockStyle.Fill;
			FlowPanel.FlowDirection = FlowDirection.TopDown;
			FlowPanel.Location = new Point(10, 10);
			FlowPanel.Margin = new Padding(3, 3, 3, 10);
			FlowPanel.Name = "FlowPanel";
			FlowPanel.Padding = new Padding(10);
			FlowPanel.Size = new Size(614, 441);
			FlowPanel.TabIndex = 0;
			FlowPanel.WrapContents = false;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(634, 461);
			Controls.Add(FlowPanel);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormMain";
			Padding = new Padding(10);
			Text = "Партнёры";
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel FlowPanel;
	}
}
