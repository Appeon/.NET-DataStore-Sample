using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_order_detail_free", DwStyle.Default)]
    [Table("SalesOrderDetail", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SalesOrderDetail\" ) COLUMN(NAME=\"Sales.SalesOrderDetail.salesorderid\") COLUMN(NAME=\"Sales.SalesOrderDetail.salesorderdetailid\") COLUMN(NAME=\"Sales.SalesOrderDetail.carriertrackingnumber\") COLUMN(NAME=\"Sales.SalesOrderDetail.orderqty\") COLUMN(NAME=\"Sales.SalesOrderDetail.productid\") COLUMN(NAME=\"Sales.SalesOrderDetail.specialofferid\") COLUMN(NAME=\"Sales.SalesOrderDetail.unitprice\") COLUMN(NAME=\"Sales.SalesOrderDetail.unitpricediscount\") COLUMN(NAME=\"Sales.SalesOrderDetail.linetotal\") COLUMN(NAME=\"Sales.SalesOrderDetail.modifieddate\")WHERE(    EXP1 =\"Sales.SalesOrderDetail.SalesOrderID\"   OP =\"=\"    EXP2 =\":al_order_id\" ) ) ORDER(NAME=\"Sales.SalesOrderDetail.salesorderdetailid\" ASC=yes ) ARG(NAME = \"al_order_id\" TYPE = number) ")]
    #endregion
    [DwParameter("al_order_id", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Order_Detail_Free
    {
        [Key]
        public int Salesorderid { get; set; }

        [Identity]
        [Key]
        public int Salesorderdetailid { get; set; }

        [ConcurrencyCheck]
        public string Carriertrackingnumber { get; set; }

        [ConcurrencyCheck]
        [DefaultValue("0")]
        public int Orderqty { get; set; }

        [ConcurrencyCheck]
        [DwChild("Product_Productid", "Product_Name", typeof(D_Dddw_Order_Production))]
        public int Productid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Specialofferproduct_Specialofferid", "Specialoffer_Description", typeof(D_Dddw_Specialoffer))]
        public int Specialofferid { get; set; }

        [ConcurrencyCheck]
        [DefaultValue("0")]
        public decimal Unitprice { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("0")]
        public decimal Unitpricediscount { get; set; }

        [Identity]
        [PropertySave(SaveStrategy.ReadAfterSave)]
        public decimal Linetotal { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

        [DwCompute("String(getrow()) +\"/\" + RowCount()")]
        public object Compute_1 { get; set; }

    }

}
