using AdformAcademyTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdformAcademyTask.Controllers
{
    public class CarsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetCars()
        {
            //Dummy data
            List<car> carList = new List<car>();

            carList.Add(new car()
            {
                id = 1,
                imgUrl = "http://buyersguide.caranddriver.com/media/assets/submodel/7528.jpg",
                model = "Aston Martin",
                year = 2012,
                ration = 2.2
            });

            carList.Add(new car()
            {
                id = 2,
                imgUrl = "http://buyersguide.caranddriver.com/media/assets/submodel/5824.jpg",
                model = "Audi R8",
                year = 2015,
                ration = 5.8
            });

            carList.Add(new car()
            {
                id = 3,
                imgUrl = "http://pictures.topspeed.com/IMG/crop/201203/koenigsegg-agera-r-3_800x0w.jpg",
                model = "Koenigsegg",
                year = 2011,
                ration = 3.8
            });

            carList.Add(new car()
            {
                id = 4,
                imgUrl = "http://o.aolcdn.com/dims-global/dims3/GLOB/legacy_thumbnail/430x242/quality/85/http://o.aolcdn.com/commerce/autodata/images/USC50FOC051B021001.jpg",
                model = "Ford Mustang",
                year = 2008,
                ration = 8.0
            });

            carList.Add(new car()
            {
                id = 5,
                imgUrl = "http://car-pictures.cars.com/images/?IMG=USB70BGC011A0101.png&WIDTH=624&HEIGHT=300&AUTOTRIM=1",
                model = "Bugatti Veyron",
                year = 2007,
                ration = 4.5
            });

            carList.Add(new car()
            {
                id = 6,
                imgUrl = "http://blog.caranddriver.com/wp-content/uploads/2015/11/Ferrari-488GTB1.jpg",
                model = "Ferrari",
                year = 2008,
                ration = 3.3
            });

            carList.Add(new car()
            {
                id = 7,
                imgUrl = "http://cdn.lamborghini.com/content/models/gallardo_lp570-4_spyder_performante_edizione_tecnica_2012/gal_lp570-4_spyder_perf_ov_1_1920x1080.jpg",
                model = "Lamborghini Gallardo",
                year = 2006,
                ration = 10.1
            });



            return Json(new { carList }, JsonRequestBehavior.AllowGet);
        }
    }
}