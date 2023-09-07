using Microsoft.AspNetCore.Mvc;
using ProjectTest.Models;
using Microsoft.AspNetCore.Http;
using CsvHelper;
using System.Globalization;

namespace ProjectTest.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index(List<Employee> employees) 
        {
            employees = employees == null ? new List<Employee>() : employees; 
            return View(employees );
        }

        [HttpPost]
        public IActionResult Index(IFormFile file, [FromServices] Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}/files/{file.FileName}";

            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush(); 
            }

            var employees = GetEmployeeList(file.FileName);
            return Index(employees);
        }

        private List<Employee> GetEmployeeList(string fileName)
        {
            List<Employee> employees = new List<Employee>();

            //Read Csv File
            var path = $"{Directory.GetCurrentDirectory()}/wwwroot/files/{fileName}";
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var employee = csv.GetRecord<Employee>();
                    employees.Add(employee);
                }
            }
            return employees;
        }
    }
}

