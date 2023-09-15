using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;
using EFLayer.Class;
using FluentValidation.Results;
using BusinessLayer.Managment;
using BusinessLayer.ValidationRoles;
using DataAccessLayer.EntittyFramework;
using Microsoft.CodeAnalysis.Scripting;
using DataAccessLayer.Repostory;

namespace IKBlok.Controllers
{
    public class RegisterController : Controller
    {
		DataUserRepostory db = new DataUserRepostory();
		
		UserManagment um = new UserManagment(new EfUserRepo());

		// GET: Register

		public async Task<IActionResult> Index(User user)
		{
			return View();
		}

		// GET: Register/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Register/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(User user)
		{
			RegisterValidation us = new RegisterValidation();
			ValidationResult result = us.Validate(user);
            if (result.IsValid)
			{
				db.add(user);

				ViewBag.KayitBasarili = true;

				return View();
			}
			else
			{
				foreach (var item in result.Errors)
				{

					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

				}
				return View(user);
			}
		}
	}
}
