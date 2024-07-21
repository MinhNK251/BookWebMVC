﻿using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Utility;

namespace BookWeb.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = SD.Role_Admin)]
	public class UserController : Controller
	{
		private readonly ApplicationDbContext _context;
		public UserController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		#region API CALLS

		[HttpGet]
		public IActionResult GetAll()
		{
			List<ApplicationUser> objUserList = _context.ApplicationUsers.Include(u => u.Company).ToList();
			var userRoles = _context.UserRoles.ToList();
			var roles = _context.Roles.ToList();
			foreach (var user in objUserList)
			{
				var roleId = userRoles.FirstOrDefault(u => u.UserId == user.Id).RoleId;
				user.Role = roles.FirstOrDefault(u => u.Id == roleId).Name;
				if (user.Company == null)
				{
					user.Company = new Company()
					{
						Name = ""
					};
				}
			}
			return Json(new { data = objUserList });
		}

		[HttpPost]
		public IActionResult LockUnlock([FromBody] string id)
		{
			var objFromDb = _context.ApplicationUsers.FirstOrDefault(u => u.Id == id);
			if (objFromDb == null)
			{
				return Json(new { success = false, message = "Error while Locking/Unlocking" });
			}

			if (objFromDb.LockoutEnd != null && objFromDb.LockoutEnd > DateTime.Now)
			{
				objFromDb.LockoutEnd = DateTime.Now;
			}
			else
			{
				objFromDb.LockoutEnd = DateTime.Now.AddYears(1000);
			}
			_context.SaveChanges();
			return Json(new { success = true, message = "Operation Successful" });
		}

		#endregion
	}
}