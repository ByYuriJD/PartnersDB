using System;
using System.Collections.Generic;

namespace PartnersDB.Models;

public partial class Partner { 
    public Partner() { }
    public Partner(Partner partner) {
        this.Id = partner.Id;
        this.PartnersProducts = partner.PartnersProducts;
        this.NameOfPartner = partner.NameOfPartner;
        this.Inn = partner.Inn;
        this.FullNameOfCeo = partner.FullNameOfCeo;
        this.LegalAdress = partner.LegalAdress;
        this.PhoneNumber = partner.PhoneNumber;
        this.Email = partner.Email;
        this.IdPartnerTypeNavigation = partner.IdPartnerTypeNavigation;
        this.Rating = partner.Rating;
        this.IdPartnerType = partner.IdPartnerType;
    }

    public short Id { get; set; }

    public short IdPartnerType { get; set; }

    public short Rating { get; set; }

    public string NameOfPartner { get; set; } = null!;

    public string LegalAdress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string FullNameOfCeo { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual PartnerType IdPartnerTypeNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
