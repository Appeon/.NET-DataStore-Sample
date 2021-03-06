using DWNet.Data;
using SnapObjects.Data;
using System.Collections.Generic;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_categorysalesreport_m", DwStyle.Composite)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Categorysalesreport_M
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string A { get; set; }

        [DwReport(typeof(D_Categorysalesreport_Pie_Saleroom))]
        public IList<D_Categorysalesreport_Pie_Saleroom> Dw_Catereport_Pie { get; set; }

        [DwReport(typeof(D_Categorysalesreport))]
        public IList<D_Categorysalesreport> Dw_Reportlist { get; set; }

        [DwReport(typeof(D_Categorysalesreport_D))]
        public IList<D_Categorysalesreport_D> Dw_Catereport { get; set; }

        [DwReport(typeof(D_Categorysalesreport_Graph_Saleroom))]
        public IList<D_Categorysalesreport_Graph_Saleroom> Dw_Compare { get; set; }

        [DwReport(typeof(D_Categorysalesreport_Graph_Saleqty))]
        public IList<D_Categorysalesreport_Graph_Saleqty> Dw_Qty { get; set; }

    }

}
