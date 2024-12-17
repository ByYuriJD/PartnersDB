using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using PartnersDB.Models;

namespace PartnersDB {
	public partial class FormMain : Form {
		private PartnersContext? db;
		public FormMain() {
			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			this.db = new PartnersContext();
			this.db.Partners.Load();
			this.db.PartnerTypes.Load();
			this.db.PartnersProducts.Load();

			UpdatePanel(new Point(Top));

		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			this.db?.Dispose();
			this.db = null;
		}
		public void DeleteEntity(int id) {
			db.Partners.Where(e=>e.Id==id).ExecuteDeleteAsync();
			db.SaveChanges();
		}
		protected void UpdatePanel(Point position) {
			FlowPanel.Controls.Clear();

			Button buttonNew = new Button();
			buttonNew.Text = "Добавить партнёра";
			buttonNew.Click += ButtonNew_Click;
			buttonNew.Dock = DockStyle.Bottom;
			buttonNew.Height = 40;
			FlowPanel.Controls.Add(buttonNew);

			Dictionary<int, String> partnerTypes = new Dictionary<int, string>();
			foreach (PartnerType partnerType in this.db.PartnerTypes) {
				partnerTypes.Add(partnerType.Id, partnerType.TypeOfPartner);
			}


			foreach (Partner partner in this.db.Partners) {
				partnerPanel partnerPanel = new partnerPanel(partner,partnerTypes, this);
				FlowPanel.Controls.Add(partnerPanel);
			}


			FlowPanel.Height = FlowPanel.Height + 30;
			FlowPanel.AutoScrollPosition = position;
		}

		private void ButtonNew_Click(object sender, EventArgs e) {
			if (db != null) {
				db.Partners.Add(new Partner {
					NameOfPartner = "Новый партнёр",
					LegalAdress = "Адрес",
					Inn = "ИНН",
					FullNameOfCeo = "ФИО директора",
					PhoneNumber = "Телефон",
					Email = "Почта",
					IdPartnerType = 0,
					IdPartnerTypeNavigation = db.PartnerTypes.First(),
					Rating = 0,
				});
				db.SaveChanges();

				UpdatePanel(FlowPanel.AutoScrollPosition);
			}
		}
	}
}
