using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnTapKiemTra2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnTapKiemTra2.Controllers
{
    public class SinhVienController : Controller
    {
        List<Sinhvien> sinhViens = new List<Sinhvien>();
        SQL_SinhVienContext _context = new SQL_SinhVienContext();
        public IActionResult Index()
        {
            sinhViens = _context.Sinhviens.ToList();
            return View(sinhViens);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinhvien);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sinhvien);
        }
        [HttpGet]
        public IActionResult Edit(String id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Sinhvien sinhvien = _context.Sinhviens.Find(id);
            return View(sinhvien);
        }
        [HttpPost]
        public IActionResult Edit(Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                _context.Sinhviens.Update(sinhvien);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sinhvien);
        }

        public IActionResult Delete(string id)
        {
            var phongBan = _context.Sinhviens.Find(id);
            if (phongBan != null)
            {
                _context.Sinhviens.Remove(phongBan);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}
