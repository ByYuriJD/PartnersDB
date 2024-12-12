using System;
using System.Collections.Generic;

namespace Pr3_PartnersDB.Models;

public partial class Product
{
    public short Id { get; set; }

    public short IdProductType { get; set; }

    public decimal PriceMin { get; set; }

    public string NameOfProduct { get; set; } = null!;

    public string Article { get; set; } = null!;

    public virtual ProductType IdProductTypeNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
