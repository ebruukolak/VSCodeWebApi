using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Suppliers
    {
         [Key]
         public int supplier_id{get;set;}
        public string company_name{get;set;}
        public string city{get;set;}
        public string region{get;set;}
        public string country{get;set;}
    }
}