using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hremp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public List<Models.Employee> employeeList;

        public void OnGet()
        {
            var ctx = new Models.hremployeedbContext();
            employeeList = ctx.Employee.ToList();

        }
        public void OnPostDelete(int id)
        {
            var ctx = new Models.hremployeedbContext();
            ctx.Entry(ctx.Employee.Where(x => x.EmployeeNumber == id).FirstOrDefault()).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            ctx.SaveChanges();
            employeeList = ctx.Employee.ToList();
        }

    }
}
