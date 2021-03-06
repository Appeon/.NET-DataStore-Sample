using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_person_list", DwStyle.Grid)]
    [Table("Person", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("SELECT Person.Person.businessentityid, "
                  + "Person.Person.persontype, "
                  + "Person.Person.namestyle, "
                  + "Person.Person.title, "
                  + "Person.Person.firstname, "
                  + "Person.Person.middlename, "
                  + "Person.Person.lastname, "
                  + "Person.Person.suffix, "
                  + "Person.Person.emailpromotion, "
                  + "Person.Person.modifieddate "
                  + "FROM Person.Person "
                  + "Where (Person.Person.persontype = :personType or :personType = 'ALL')")]
    #endregion
    [DwParameter("personType", typeof(string))]
    [DwSort("businessentityid A ")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Person_List
    {
        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        public int Businessentityid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        //[DwChild("Persontype", "Typedesc", typeof(D_Dddw_Persontype))]
        public string Persontype { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public bool? Namestyle { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Firstname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Middlename { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Lastname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Suffix { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Emailpromotion { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public DateTime? Modifieddate { get; set; }

    }

}
