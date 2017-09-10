using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientMvc5.Models
{
    public class HomePageViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string StudentNo { get; set; }
        public string ClassNo { get; set; }
    }
}