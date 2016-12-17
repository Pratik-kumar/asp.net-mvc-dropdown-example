using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dropdownListExample.Models;

namespace dropdownListExample.Controllers
{
    public class Example1Controller : Controller
    {
        //
        // GET: /Example1/
        //using hard-coded value
        public ActionResult Ex1()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text="Item1", Value="1"});
            items.Add(new SelectListItem { Text="Item2",Value="2"});
            items.Add(new SelectListItem { Text="Item3",Value="3"});
            ViewBag.ListItem = items;
            return View();
        }

        //using model binding
        public ActionResult Ex2()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Item4", Value = "4" });
            items.Add(new SelectListItem { Text = "Item5", Value = "5" });
            items.Add(new SelectListItem { Text = "Item6", Value = "6" });
            userModel model = new userModel();
            model.ListItems = items;
            model.SelectedItem = 6;
            return View(model);

        }

        public ActionResult Ex3()
        {
            //adding mock data
            List<branch> branchList = new List<branch>();
            branchList.Add(new branch { branchId = 1, branchName = "Computer Science" });
            branchList.Add(new branch { branchId = 2, branchName = "IT" });
            branchList.Add(new branch { branchId = 3, branchName = "Electonics" });
            branchList.Add(new branch { branchId = 4, branchName = "Civil" });
            studentEditViewModel sm = new studentEditViewModel();
            sm.BranchList = new SelectList(branchList, "branchId", "branchName");
            return View(sm);
        }
        //adding branch name in dropdown for studentBranch
        public ActionResult Ex4()
        {
            //adding mock data
            List<branch> branchList = new List<branch>();
            branchList.Add(new branch { branchId = 1, branchName = "Computer Science" });
            branchList.Add(new branch { branchId = 2, branchName = "IT" });
            branchList.Add(new branch { branchId = 3, branchName = "Electonics" });
            branchList.Add(new branch { branchId = 4, branchName = "Civil" });
            List<student> studList = new List<student>();
            studList.Add(new student { studentId = 070915, studentname = "Pratik Kumar", studentBranch = "Computer Science" });
            studList.Add(new student { studentId = 070915, studentname = "Ämrit Kumar", studentBranch = "Civil" });
            studentEditViewModel sm1 = new studentEditViewModel();
            sm1.student = new student { studentId = 070915, studentname = "Pratik Kumar", studentBranch = "Computer Science" };
            sm1.BranchList = new SelectList(branchList, "branchId", "branchName");
            return View(sm1);
        }
        //adding branch name in dropdown for studentBranch for creating new student
        public ActionResult Ex5()
        {
            //adding mock data
            List<branch> branchList = new List<branch>();
            branchList.Add(new branch { branchId = 1, branchName = "Computer Science" });
            branchList.Add(new branch { branchId = 2, branchName = "IT" });
            branchList.Add(new branch { branchId = 3, branchName = "Electonics" });
            branchList.Add(new branch { branchId = 4, branchName = "Civil" });
            //List<student> studList = new List<student>();
            //studList.Add(new student { studentId = 070915, studentname = "Pratik Kumar", studentBranch = "Computer Science" });
            //studList.Add(new student { studentId = 070915, studentname = "Ämrit Kumar", studentBranch = "Civil" });
            studentEditViewModel2 sm1 = new studentEditViewModel2();
            sm1.studentId = 070915;
            sm1.studentname = "Pratik Kumar";
            sm1.studentBranch = "Computer Science";
            sm1.BranchList = new SelectList(branchList, "branchId", "branchName");
            return View("Ex5-create", sm1);
        }

    }
}
