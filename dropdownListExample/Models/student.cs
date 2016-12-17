using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dropdownListExample.Models
{
    //Example 4
    public class student
    {
        public int studentId { get; set; }
        public string studentname { get; set; }
        public string studentBranch { get; set; }
    }
    //Example3 and 4
    #region ex3&4
    public class branch
    {
        public int branchId { get; set; }
        public string branchName { get; set; }
    }

    public class studentEditViewModel
    {
        //public int studentId { get; set; }
        //public string studentname { get; set; }
        //public string studentBranch { get; set; }
        public student student { get; set; }
        public SelectList BranchList { get; set; }
    }
    #endregion ex3&4
    public class studentEditViewModel2
    {
        public int studentId { get; set; }
        public string studentname { get; set; }
        public string studentBranch { get; set; }
        //public student student { get; set; }
        public SelectList BranchList { get; set; }
    }
}