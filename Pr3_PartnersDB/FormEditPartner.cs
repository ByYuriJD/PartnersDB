using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Pr3_PartnersDB.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pr3_PartnersDB {
	public partial class FormEditPartner : Form {
		public int id;
		private PartnersContext? db;


		public FormEditPartner(int id) {
			this.id = id;

			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			this.db = new PartnersContext();

			this.db.Partners.Where(x => x.Id == this.id).Load();
			this.dataGridViewPartner.DataSource = this.db.Partners.Local.ToBindingList();

			this.db.PartnerTypes.Load();
			this.dataGridViewPartnerTypes.DataSource = this.db.PartnerTypes.Local.ToBindingList();
			dataGridViewPartnerTypes.Columns["Id"].ReadOnly = true;
			dataGridViewPartnerTypes.Columns["Partners"].Visible = false;
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			this.db?.Dispose();
			this.db = null;
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			this.db!.SaveChanges();

			this.dataGridViewPartner.Refresh();
			this.dataGridViewPartnerTypes.Refresh();
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			foreach (DataGridViewRow row in dataGridViewPartnerTypes.SelectedRows) {
				dataGridViewPartnerTypes.Rows.RemoveAt(row.Index);
			}
		}
	}
}
