using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabBigSchool_TruongNguyenMinhTin_1911061886.Models;
using LabBigSchool_TruongNguyenMinhTin_1911061886.ViewModels;
namespace LabBigSchool_TruongNguyenMinhTin_1911061886.Controllers
{
    
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}