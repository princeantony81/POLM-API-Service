using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POLM_API_Service.Models
{
    public class ETCInfoModels
    {
        public string ETC_Project_Name { get; set; }
        public string Project_Name___ID { get; set; }
        public string Reporting_Project_ID { get; set; }
        public string Category { get; set; }
        public string Cost_Type { get; set; }
        public string Type { get; set; }
        public string USD_Amount { get; set; }
        public string Date { get; set; }
        public Nullable<System.DateTime> ETCDate { get; set; }
        public string ParentProjectID { get; set; }
        public int ETCInfoId { get; set; }
    }
}