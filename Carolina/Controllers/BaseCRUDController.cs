using Carolina.Data;
using Carolina.Models;
using Carolina.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carolina.Controllers
{
	public class BaseCRUDController<TModel> : BaseController where TModel : class, IBaseModel
	{
		protected ApplicationDbContext DbContext { get; set; }

		protected DbSet<TModel> Models { get; set; }

		public BaseCRUDController(ApplicationDbContext dbContext)
		{
			DbContext = dbContext;
			Models = dbContext.Set<TModel>();
		}

		[HttpGet]
		public ActionResult Index()
		{
			var result = Models.ToList();
			return View(result);
		}

		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(BaseCreateViewModel<TModel> viewModel)
		{
			TModel model = viewModel.Model;
			model.Id = Guid.NewGuid();
			Models.Add(model);
			DbContext.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Update(Guid id)
		{
			TModel model = Models.FirstOrDefault(m => m.Id.Equals(id));
			if (model == null)
			{
				return NotFound($"Model with id = {id} not found");
			}
			BaseUpdaeViewModel<TModel> result = new BaseUpdaeViewModel<TModel>(model);
			return View(result);
		}

		[HttpPost]
		public ActionResult Update(BaseUpdaeViewModel<TModel> viewModel)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			DbContext.Entry<TModel>(viewModel.Model).State = EntityState.Modified;
			DbContext.SaveChanges();
			return View(viewModel);
		}

		[HttpGet]
		public ActionResult Delete(Guid id)
		{
			TModel model = Models.FirstOrDefault(m => m.Id.Equals(id));
			if (model is null)
			{
				return NotFound($"Model with id = {id} not found");
			}

			Models.Remove(model);
			DbContext.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Detail(Guid id)
		{
			TModel model = Models.FirstOrDefault(m => m.Id.Equals(id));
			if (model is null)
			{
				return NotFound($"Model with id = {id} not found");
			}
			return View(model);
		}
	}
}
