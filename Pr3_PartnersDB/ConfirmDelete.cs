using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartnersDB {
	public partial class ConfirmDelete : Form {
		partnerPanel partnerPanel;
		public ConfirmDelete(partnerPanel partnerPanel) {
			this.partnerPanel = partnerPanel;
			InitializeComponent();
		}
		private void ConfirmDelete_Load(object sender, EventArgs e) {}
		private void buttonNo_Click(object sender, EventArgs e) {
			Close();
		}
		private void buttonYes_Click(object sender, EventArgs e) {
			if (partnerPanel != null) {
				partnerPanel.deleteEntry();
			}
			Close();
		}
		protected override void OnClosing(CancelEventArgs e) {
			if (partnerPanel != null) {
				partnerPanel.Enabled = true;
			}
		}
	}
}
