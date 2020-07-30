using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Entities
{
    [Table("CustomerDetails")]
    public class Customer
    {
        public Customer()
        {

        }
        [Key]
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public long customer_contact { get; set; }
        public string customer_address { get; set; }
    }
}
