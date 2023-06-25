using InventorySystem.helpers;
using InventorySystem.Models;
using InventorySystem.services;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService _companyService)
        {
            companyService = _companyService;
        }

        public IActionResult Index(int CurrentPage = 1)
        {
            PaginatedList<CompanyDTO> companies= companyService.GetAll(CurrentPage);

            return View("CompanyList", companies);
        }

        public IActionResult PatientList(int CurrentPage = 1)
        {
            PaginatedList<CompanyDTO> companies = companyService.GetAll(CurrentPage);

            return View("CompanyList", companies);
        }
        public IActionResult NewCompany()
        {
            ViewData["IsEdit"] = false;
            return View("CompanyAdd");
        }

        public IActionResult Save(CompanyDTO company)
        {
            companyService.Create(company);
            ViewData["IsEdit"] = true;
            return View("CompanyAdd");
        }

        public IActionResult Update(CompanyDTO company)
        {
            companyService.Update(company);
            ViewData["IsEdit"] = true;
            return View("CompanyAdd");
        }

        public IActionResult Edit(int Id)
        {
            CompanyDTO Company = companyService.Get(Id);
            ViewData["IsEdit"] = true;
            return View("CompanyAdd",Company);
        }

        public IActionResult Delete(int Id)
        {
            companyService.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
