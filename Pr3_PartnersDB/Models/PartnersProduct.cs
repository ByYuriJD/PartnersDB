using System;
using System.Collections.Generic;

namespace Pr3_PartnersDB.Models;

public partial class PartnersProduct
{
    public short Id { get; set; }

    public short IdOfPartner { get; set; }

    public short IdOfProduct { get; set; }

    public int Amount { get; set; }

    public DateTime SaleDate { get; set; }

    public virtual Partner IdOfPartnerNavigation { get; set; } = null!;

    public virtual Product IdOfProductNavigation { get; set; } = null!;
}
