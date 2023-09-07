﻿using AssistedProject_32.Models;
using AssistedProject_32.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssistedProject_32.Controllers
{


    public class StudentController : Controller
    {
        private IGenericRepository<Student> repository = null;
        public StudentController()
        {
            this.repository = new GenericRepository<Student>();
        }


        // GET: Employee
        public ActionResult Index()
        {
            var student = repository.SelectAll().ToList();
            return View(student);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var student = repository.SelectByID(id);
            return View(student);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(student);
                repository.Save();

                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var student = repository.SelectByID(id);
            return View(student);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            try
            {
                repository.Update(student);
                repository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var student = repository.SelectByID(id);
            return View(student);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repository.Delete(id);
                repository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
