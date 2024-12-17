using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PartnersDB.Models;

namespace PartnersDB {
	public partial class partnerPanel : UserControl {
		private Partner partner;
		private String[] partnerTypes;
		private int totalSales;
		private FormMain formMain;
		public partnerPanel(Partner partner, String[] partnerTypes,FormMain formMain) {
			this.partner = partner;
			this.partnerTypes = partnerTypes;
			this.totalSales = totalSales;
			this.formMain = formMain;

			InitializeComponent();
		}

		private void UserControl1_Load(object sender, EventArgs e) {
			labelCeo.Text = partner.FullNameOfCeo;
			labelNameType.Text = partnerTypes[partner.IdPartnerType] + " | " + partner.NameOfPartner;
			labelPhone.Text = partner.PhoneNumber;
			labelRating.Text = "Рейтинг: " + partner.Rating;

			foreach (PartnersProduct partnersProduct in partner.PartnersProducts) {
				totalSales += partnersProduct.Amount;
			}


			if (totalSales < 10000) {
				labelCut.Text = "0%";
			} else if (totalSales < 50000) {
				labelCut.Text = "5%";
			} else if (totalSales < 300000) {
				labelCut.Text = "10%";
			} else {
				labelCut.Text = "15%";
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			this.Enabled = false;
			FormEditPartner formEditPartner = new FormEditPartner(partner.Id,this);
			formEditPartner.Show();
		}
		private void buttonDelete_Click(object sender, EventArgs e) {
			ConfirmDelete confirmDelete = new ConfirmDelete(this);
			confirmDelete.Show();
			this.Enabled = false;
		}
		public void deleteEntry() {
			formMain.DeleteEntity(partner.Id);
			Dispose();
		}
	}
}
