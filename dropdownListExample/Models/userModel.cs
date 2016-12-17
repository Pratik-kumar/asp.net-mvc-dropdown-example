using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dropdownListExample.Models
{
    public class userModel
    {
        public List<SelectListItem> ListItems { get; set; }
        public int SelectedItem { get; set; }
    }
}