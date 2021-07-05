using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Universal_Chat_Plugin.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Payment_type { get; set; }
        public string Payment_status { get; set; }
        public int Card_no { get; set; }
        public int CVC { get; set; }
        public DateTime Payment_date { get; set; }
        public int Total_amount { get; set; }
        public int Paid_amount { get; set; }
        public int Due_amount { get; set; }


    }
}