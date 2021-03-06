using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_businessentity", DwStyle.Grid)]
    [Table("BusinessEntity", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.BusinessEntity\" ) COLUMN(NAME=\"Person.BusinessEntity.BusinessEntityID\") COLUMN(NAME=\"Person.BusinessEntity.rowguid\") COLUMN(NAME=\"Person.BusinessEntity.ModifiedDate\")) ")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Businessentity
    {
        [Identity]
        [Key]
        public int Businessentityid { get; set; }

        [SqlDefaultValue("(newid())")]
        public Guid Rowguid { get; set; }

        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

    }

}
