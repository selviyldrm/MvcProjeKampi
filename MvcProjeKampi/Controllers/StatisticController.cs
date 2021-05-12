using DataAccess.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        Context context = new Context(); 
        // GET: Statistic
        public ActionResult Index()
        {
            //Toplam Kategori Sayısı
            var result = context.Categories.Count().ToString();
            ViewBag.categoryCount = result;

            //"Yazılım" kategorisine ait başlık sayısı
            var result1 = context.Headings.Count(c =>c.CategoryID == 9).ToString();
            ViewBag.HeadingCount = result1;

            //Yazar adında "a" harfi geçen yazar sayısı
            var result2 = context.Writers.Count(t => t.WriterName.Contains("a"));
            ViewBag.WriterCount = result2;

            //En fazla başlığa sahip kategori adı
            var result3 = context.Categories.Where(c => c.CategoryID == (context.Headings.GroupBy(h => h.CategoryID)
            .OrderByDescending(h => h.Count()).Select(h => h.Key).FirstOrDefault())).
            Select(h => h.CategoryName).FirstOrDefault();
            ViewBag.EnFazlaBaşlikSayisi = result3;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
            var result4 = context.Categories.Count(c => c.CategoryStatus == true) - context.Categories.Count(c => c.CategoryStatus == false);
            ViewBag.tffarki = result4;
            return View();
        }
    }
}