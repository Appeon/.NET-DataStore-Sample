using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_subcategorysalesreport_d", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("select ProductSubcategory.Name as SubcategoryName, "
                  + "sum(SalesOrderDetail.orderqty) as TotalSalesqty, "
                  + "sum(SalesOrderDetail.linetotal) as TotalSaleroom "
                  + "from Sales.SalesOrderDetail SalesOrderDetail "
                  + "inner join Sales.SalesOrderHeader SalesOrderHeader on SalesOrderDetail.SalesOrderID = SalesOrderHeader.SalesOrderID "
                  + "inner join Production.Product Product on SalesOrderDetail.ProductID = Product.ProductID "
                  + "inner join Production.ProductSubcategory ProductSubcategory on Product.ProductSubcategoryID = ProductSubcategory.ProductSubcategoryID "
                  + "where SalesOrderHeader.Status in(1,2,5) and "
                  + "(ProductSubcategory.ProductSubcategoryID = :subCategoryId) and "
                  + "(convert(varchar(6), SalesOrderHeader.OrderDate, 112) =:salesMonth ) "
                  + "group by ProductSubcategory.Name")]
    #endregion
    [DwParameter("subCategoryId", typeof(decimal?))]
    [DwParameter("salesMonth", typeof(string))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Subcategorysalesreport_D
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Subcategoryname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Totalsalesqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsaleroom { get; set; }

    }

}
