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
using PartnersDB.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PartnersDB {
	public partial class FormEditPartner : Form {
		public int id;
		private PartnersContext? db;
		private partnerPanel partnerPanel;
		private Partner lastPartner;


		public FormEditPartner(int id, partnerPanel partnerPanel = null) {
			this.id = id;
			this.partnerPanel = partnerPanel;
			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			this.db = new PartnersContext();

			this.db.Partners.Where(x => x.Id == this.id).Load();

			lastPartner = new Partner(db.Partners.First());

			this.dataGridViewPartner.DataSource = this.db.Partners.Local.ToBindingList();
			dataGridViewPartner.Columns["IdPartnerTypeNavigation"].Visible = false;
			dataGridViewPartner.Columns["PartnersProducts"].Visible = false;
			dataGridViewPartner.Columns["Id"].Visible = false;

			this.db.PartnerTypes.Load();
			this.dataGridViewPartnerTypes.DataSource = this.db.PartnerTypes.Local.ToBindingList();
			dataGridViewPartnerTypes.Columns["Id"].ReadOnly = true;
			dataGridViewPartnerTypes.Columns["Partners"].Visible = false;
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			this.db?.Dispose();
			this.db = null;
			if (partnerPanel != null) {
				partnerPanel.Enabled = true;
			}
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			Partner partner = db.Partners.First();
			if (db.PartnerTypes.Find(partner.IdPartnerType) == null) {
				partner.IdPartnerType = lastPartner.IdPartnerType;
				db.Partners.Update(partner);
				dataGridViewPartner.Update();
				return;
			}

			this.db!.SaveChanges();

			this.dataGridViewPartner.Refresh();
			this.dataGridViewPartnerTypes.Refresh();
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			foreach (DataGridViewRow row in dataGridViewPartnerTypes.SelectedRows) {
				if (dataGridViewPartnerTypes.Rows.Count - 1 > row.Index) {
					dataGridViewPartnerTypes.Rows.RemoveAt(row.Index);
				}
			}
		}

		private void buttonReset_Click(object sender, EventArgs e) {
			Partner partner = db.Partners.First();

			partner.NameOfPartner = lastPartner.NameOfPartner;
			partner.Email = lastPartner.Email;
			partner.PartnersProducts = lastPartner.PartnersProducts;
			partner.PhoneNumber = lastPartner.PhoneNumber;
			partner.FullNameOfCeo = lastPartner.FullNameOfCeo;
			partner.IdPartnerType = lastPartner.IdPartnerType;
			partner.Rating = lastPartner.Rating;
			partner.LegalAdress = lastPartner.LegalAdress;

			db.Partners.Update(partner);
			dataGridViewPartner.Update();
		}
	}
}
