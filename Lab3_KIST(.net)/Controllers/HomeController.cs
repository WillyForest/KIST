using Lab3_KIST_.net_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_KIST_.net_.Controllers
{
    public class HomeController : Controller
    {
        private KIST_Lab3Entities db = new KIST_Lab3Entities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult First()
        {
            return View();
        }
        
        public ActionResult FirstAnswer(string Cafedra = "TK", string Faculty = "FICT", string Speciality = "ROBOTS")
        {
            var specs = db.Specialities.Where(x => x.Speciality_name == Speciality && x.Cafedra.Cafedra_name == Cafedra && x.Cafedra.Faculty.Faculty_name == Faculty);
            var groups = db.Groups.Where(x => specs.Contains(x.Speciality)).Select(x => x.Group_ID);
            var students = db.Student_Group.Where(x => groups.Contains(x.Group_ID)).Select(x => x.Student);
            var studentIds = db.Student_Marks.Where(x => students.Select(u => u.Student_ID).Contains(x.Student_ID)).Where(x => x.SMark.Mark_name == "2").Select(x => x.Student_ID);
            //var result = db.Students.Where(x => studentIds.Contains(x.Student_ID));
            var result = db.People.Where(x => studentIds.Contains(x.PersonId));
            ViewBag.Cafedra = Cafedra;
            ViewBag.Faculty = Faculty;
            ViewBag.Speciality = Speciality;
            return View(result);
        }

        public ActionResult Second()
        {
            return View();
        }

        public ActionResult SecondAnswer()
        {
            var groupIds = db.Teach_Plan.Where(x => (x.Semester_ID == 5 || x.Semester_ID == 6) && x.Subject.Subject_name == "Вища математика").Select(x => x.Group_ID);
            var studentIds = db.Student_Group.Where(x => groupIds.Contains(x.Group_ID)).Select(x => x.Student_ID);
            var result = db.People.Where(x => studentIds.Contains(x.PersonId));
            return View(result);
        }

        public ActionResult Third()
        {
            return View();
        }

        public ActionResult ThirdAnswer(string diplomaName = "Робототехніка")
        {
            var studentIds = db.Students.Where(x => x.SDiploma.Diploma_name == diplomaName).Select(x => x.Student_ID);
            var result = db.People.Where(x => studentIds.Contains(x.PersonId));
            ViewBag.diplomaName = diplomaName;
            return View(result);
        }

        public ActionResult Fourth()
        {
            return View();
        }
        
        public ActionResult FourthAnswer()
        {
            var contractStudentIds = db.Contracts.Select(x => x.Student_ID);
            var markIds = db.SMarks.Where(x => x.Mark_name == "5").Select(x => x.Mark_ID);
            var studentIds = db.Student_Marks.Where(x => markIds.Contains(x.Mark_ID ?? -1)).Select(x => x.Student_ID);
            var result = db.People.Where(x => studentIds.Contains(x.PersonId));
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}