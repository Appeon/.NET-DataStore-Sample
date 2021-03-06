using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_specialoffer", DwStyle.Grid)]
    [Table("SpecialOfferProduct", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SpecialOffer\" )  TABLE(NAME=\"Sales.SpecialOfferProduct\" ) COLUMN(NAME=\"Sales.SpecialOfferProduct.SpecialOfferID\") COLUMN(NAME=\"Sales.SpecialOfferProduct.ProductID\") COLUMN(NAME=\"Sales.SpecialOffer.Description\") COLUMN(NAME=\"Sales.SpecialOffer.DiscountPct\") COLUMN(NAME=\"Sales.SpecialOffer.Type\") COLUMN(NAME=\"Sales.SpecialOffer.Category\") COLUMN(NAME=\"Sales.SpecialOffer.MinQty\") COLUMN(NAME=\"Sales.SpecialOffer.MaxQty\")    JOIN (LEFT=\"Sales.SpecialOfferProduct.SpecialOfferID\"    OP =\"=\"RIGHT=\"Sales.SpecialOffer.SpecialOfferID\" )) ")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Specialoffer
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Specialofferproduct_Specialofferid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int Specialofferproduct_Productid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Specialoffer_Description { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("((0.00))")]
        public decimal Specialoffer_Discountpct { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Specialoffer_Type { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Specialoffer_Category { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("((0))")]
        public int Specialoffer_Minqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Specialoffer_Maxqty { get; set; }

    }

}
