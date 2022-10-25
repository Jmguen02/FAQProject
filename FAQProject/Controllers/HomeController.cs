using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FAQProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQProject.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context { get; set; }

        public HomeController(FAQContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(FAQListViewModel model, string topic, string category)
        {
            model.Topics = context.Topics.ToList();
            model.Categories = context.Categories.ToList();

            IQueryable<FAQ> query = context.FAQs;
            if (model.ActiveCat != "all")
                query = query.Where(
                    f => f.Category.CategoryId.ToLower() == model.ActiveCat.ToLower());
            if (model.ActiveTopic != "all")
                query = query.Where(
                    f => f.Topic.TopicId.ToLower() == model.ActiveTopic.ToLower());
            model.FAQs = query.ToList();

            return View(model);
        }
    }
}
