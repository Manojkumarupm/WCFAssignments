using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVCClient.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            EmployeeClient.EmployeeServiceClient client = new EmployeeClient.EmployeeServiceClient();
            List<EmployeeClient.Employee> Employees = client.GetEmployees().ToList();
            return View(Employees);
        }
        [HttpGet]
        public ActionResult EditEmployee(int Id)
        {
            EmployeeClient.EmployeeServiceClient client = new EmployeeClient.EmployeeServiceClient();
            EmployeeClient.Employee Employee = client.SearchEmployeeRecord(Id);
            return View(Employee);
        }
        [HttpPost]
        [ActionName("EditEmployee")]
        public ActionResult EditEmployee_Post()
        {
            if (ModelState.IsValid)
            {
                EmployeeClient.Employee e = new EmployeeClient.Employee();
                TryUpdateModel(e);
                EmployeeClient.EmployeeServiceClient client = new EmployeeClient.EmployeeServiceClient();
                client.UpdateEmployeeRecord(e);
                RedirectToAction("Index");
            }


            return View();
        }
        [HttpGet]

        public ActionResult DeleteEmployee(int Id)
        {

            EmployeeClient.EmployeeServiceClient client = new EmployeeClient.EmployeeServiceClient();
            client.DeleteEmployeeRecord(Id);
            return View("Index");

        }
        [HttpGet]

        public ActionResult DetailsEmployee(int Id)
        {
            EmployeeClient.EmployeeServiceClient client = new EmployeeClient.EmployeeServiceClient();
            EmployeeClient.Employee Employee = client.SearchEmployeeRecord(Id);
            return View(Employee);

        }
        [HttpGet]
        public ActionResult AddEmployee()
        {

            return View();

        }

        [HttpPost]
        [ActionName("AddEmployee")]
        public ActionResult AddEmployee_Post()
        {
            if (ModelState.IsValid)
            {

                EmployeeClient.Employee e = new EmployeeClient.Employee();
                UpdateModel(e);
                EmployeeClient.EmployeeServiceClient client = new EmployeeClient.EmployeeServiceClient();
                string Message = client.AddEmployeeRecord(e);
                RedirectToAction("Index");
            }
            return View();
        }


    }
}
