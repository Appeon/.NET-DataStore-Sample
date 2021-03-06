using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_subreport_filter", DwStyle.Default)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Subreport_Filter
    {
        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Productcategoryid", "Name", typeof(D_Dddw_Category))]
        public decimal? Categoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Productsubcategoryid", "Name", typeof(D_Dddw_Subcategory))]
        public decimal? Subcategoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Year { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Annual { get; set; }

    }

}
