using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POLM_API_Service.Models
{
    public class ETCTableModels
    {
        public Nullable<double> newEACREV { get; set; }
        public Nullable<double> currentEACRev { get; set; }
        public Nullable<double> DeltaEACRev { get; set; }
        public Nullable<double> newEACCost { get; set; }
        public Nullable<double> currentEACCost { get; set; }
        public Nullable<double> DeltaEACCost { get; set; }
        public Nullable<double> newEACGP { get; set; }
        public Nullable<double> currentEACGP { get; set; }
        public Nullable<double> DeltaEACGP { get; set; }
        public Nullable<double> newEACGPP { get; set; }
        public Nullable<double> currentEACGPP { get; set; }
        public Nullable<double> DeltaEACGPP { get; set; }
        public Nullable<double> newRevAdj { get; set; }
    }
}