using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarsztatApi.Entities;
using WarsztatAPI.DBContexts;
using WarsztatAPI.Entities;

namespace WarsztatAPI.Controllers
{
    [ApiController]
    [Route("api/meals")]
    public class MealController : ControllerBase
    {
        private readonly ApplicationContext context;

        public MealController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var meals = context.meal.ToList<Meal>();
            return Ok(meals);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetMeal(int id)
        {
            var part = context.meal.Where(q => q.id_meal == id).FirstOrDefault();
            return Ok(part);
        }

        [HttpPost]
        public void AddMeal(Meal part)
        {
            context.meal.Add(part);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("updateMealAmount")]
        public void UpdatePart(Meal[] mealInfo)
        {
            foreach (var meal in mealInfo)
            {
                //var mealFromDb = context.meal.Where(q => q.id_meal == meal.id_meal).FirstOrDefault();
                ////var newAmount = mealFromDb.amount - meal.amount;

                ////part.id_food = partFromDb.id_food;
                ////part.name = partFromDb.name;
                ////part.price = partFromDb.price;
                ////part.category = partFromDb.category;
                ////part.subcategory = partFromDb.subcategory;
                ////part.producer = partFromDb.producer;
                ////part.path_to_image = partFromDb.path_to_image;
                ////part.amount = newAmount;
                ////mealFromDb.amount = newAmount;

                //context.meal.Update(mealFromDb);
            }
            context.SaveChanges();
        }

        [HttpDelete]
        [Route("{id}")]
        public void RemovePart(int id)
        {
            var part = context.meal.Where(q => q.id_meal == id).FirstOrDefault();

            if (part != null)
            {
                context.meal.Remove(part);
                context.SaveChanges();
            }
        }
    }
}
