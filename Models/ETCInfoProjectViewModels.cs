using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POLM_API_Service.Models
{
    public class ETCInfoProjectViewModels
    {
        public List<DateTime> ETCDateList { get; set; }
        public ETCTableModels ETCTable { get; set; }
        public List<ETCInfoModels> ETCInfoList { get; set; }

    }
}