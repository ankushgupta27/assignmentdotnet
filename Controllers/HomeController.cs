using System.Diagnostics;
using assignmentdotnet.Models;
using Microsoft.AspNetCore.Mvc;
using assignmentdotnet.Models;
using assignmentdotnet.Entities;

namespace myapp.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index => View();
    public IActionResult Registration()
    {
        return View();
    }
    public IActionResult index()
    {
    //      var model = new List<UserModel>();
    // model.Add(new UserModel { Name = "Ankush",Age = 21,Salary = 180,Designation = ".Net"});
    // model.Add(new UserModel{ Name = "Rahul",Age = 21,Salary = 3613,Designation = ".Net"});
    // model.Add(new UserModel{ Name = "janak", Age = 22,Salary = 232,Designation = "React"});
    // return View(model);
       using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeDetails.ToList();
             return View(employeeList);
        }
    }
           public IActionResult Employee()
    {
        using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeDetails.ToList();
            // var emplist=context.Forms.Where(x=>x.EmpId==3).FirstOrDefault();
        }
        return View();
    }
        public IActionResult AddEmployee(UserModel employeeModel)
    {
        using (var context=new EmployeeDBContext())
        {
            // EmployeeModel employee=new EmployeeModel();
            // employee.FirstName=employeeModel.FirstName;
            // employee.Name=employeeModel.Name;
            // employee.Email=employeeModel.Email;
            // employee.Password=employeeModel.Password;
            // employee.ConfirmPassword=employee.ConfirmPassword;
            // employee.Contact=employeeModel.Contact;
            // context.Forms.Add(employee);
            // context.SaveChanges();
        }
        return RedirectToAction(actionName: "Index", controllerName: "Home");
        // return View();
    }

public class CachedController : Controller
{
    public IActionResult Index()
    {
        return Content("This content was generated at " + DateTime.Now);
    }
}
    public IActionResult Privacy()
    {
        return View();
    }
    
    [HttpPost]
     public IActionResult Login()
    {
        return RedirectToAction("Index","Home");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}