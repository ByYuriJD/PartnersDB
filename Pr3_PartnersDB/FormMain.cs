using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Pr3_PartnersDB.Models;

namespace Pr3_PartnersDB {
	public partial class FormMain : Form {
		private PartnersContext? db;
		public FormMain() {
			InitializeComponent();

		}
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			this.db = new PartnersContext();

			// Загрузка из БД
			this.db.Partners.Load();
			this.db.Products.Load();
			this.db.PartnerTypes.Load();
			this.db.ProductTypes.Load();
			this.dataGridViewPartners.DataSource = this.db.Partners.Local.ToBindingList();
			this.dataGridViewProducts.DataSource = this.db.Products.Local.ToBindingList();
			this.dataGridViewPartnerTypes.DataSource = this.db.PartnerTypes.Local.ToBindingList();
			this.dataGridViewProductTypes.DataSource = this.db.ProductTypes.Local.ToBindingList();
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			this.db?.Dispose();
			this.db = null;
		}

		private void dataGridViewPartners_SelectionChanged(object sender, EventArgs e) {
			if (this.db != null) {
				var partner = (Partner)this.dataGridViewPartners.CurrentRow.DataBoundItem;

				if (partner != null) {
					this.db.Entry(partner).Collection(e => e.PartnersProducts).Load();
					this.dataGridViewPartnersProducts.DataSource = partner.PartnersProducts;
				}
			}
		}
		private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e) {
			if (this.db != null) {
				var product = (Product)this.dataGridViewProducts.CurrentRow.DataBoundItem;

				if (product != null) {
					this.db.Entry(product).Collection(e => e.PartnersProducts).Load();
					this.dataGridViewPartnersProducts.DataSource = product.PartnersProducts;
				}
			}
		}
	}
}
