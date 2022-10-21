using HR_Management_System.Data;
using HR_Management_System.Models;
using HR_Management_System.ModelsV2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Controllers
{
    public class SalaryController : Controller
    {
        private readonly HRMSV2_DB_Context _db;

        private readonly AccountManageModel _accountManage;
        public SalaryController(HRMSV2_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;

        }
        // GET: SalaryController
        public async Task<ActionResult> Index()
        {
            SalaryViewModel viewModel = new SalaryViewModel();
            viewModel.DeptLst = await _db.Departments.ToListAsync();
            viewModel.UserLst = await _db.Users.Where(e => e.UserType == 1 && e.SalaryId!=null).ToListAsync();
            viewModel.SalaryLst = await _db.Salaries.ToListAsync();
            foreach (var item in viewModel.UserLst)
            {
                var temp =  viewModel.SalaryLst.Where(e => e.Id == item.SalaryId).FirstOrDefault();
                viewModel.UserLst.Single(e=>e.Id==item.Id).Salary = temp;
            }
            return View(viewModel);
        }

        // GET: SalaryController/Details/5
        public ActionResult GetDeatilSalary(int id)
        {
            return View();
        }

        public async Task<ActionResult> GetDeatilSalary()
        {
            return View();
        }
        // GET: SalaryController/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: SalaryController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SalaryController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: SalaryController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SalaryController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: SalaryController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
//Scaffold-DbContext "Server=DESKTOP-O3AGVTM;Database=CoreEhrmsDB;user id =sa;password=1234567890;Trusted_Connection=True;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir ModelsV2 -Context HRMSV2_DB_Context -Force