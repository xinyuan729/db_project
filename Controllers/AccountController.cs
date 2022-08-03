﻿using Microsoft.AspNetCore.Mvc;
using TJ_Games.Models;
using Newtonsoft.Json;

namespace TJ_Games.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult LogIn()
		{
			return View();
		}

		public IActionResult Register()
		{
			return View();
		}
		public IActionResult Modify()
		{
			return View();
		}

		// 前后端交互
		[HttpPost]
		public IActionResult login([FromBody] Object a)   //登录
		{
			return Json(a.ToString());
		}

		[HttpPost]
		public IActionResult register([FromBody] Object a)   //注册
		{
			return Json(a.ToString());
		}

		[HttpPost]
		public IActionResult modify([FromBody] Object a)   //修改
		{
			return Json(a.ToString());
		}
	}
}
