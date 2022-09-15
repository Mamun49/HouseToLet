using HouseToLet.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace HouseToLet.Controllers
{
    public class ListingController : Controller
    {
        ToLetModel db = new ToLetModel();
        // GET: Listing
        public ActionResult ListaHome()
        {
            var category = new List<SelectListItem>();
            {
                category.Add(new SelectListItem { Text = "Bachalor", Value = "Bachalor" });
                category.Add(new SelectListItem { Text = "Family", Value = "Family" });
                category.Add(new SelectListItem { Text = "Flat", Value = "Flat" });
            };

            ViewBag.list = category;
            var Beds = new List<SelectListItem>();
            {
                Beds.Add(new SelectListItem { Text = "1", Value = "1" });
                Beds.Add(new SelectListItem { Text = "2", Value = "2" });
                Beds.Add(new SelectListItem { Text = "3", Value = "3" });
                Beds.Add(new SelectListItem { Text = "4", Value = "4" });
                Beds.Add(new SelectListItem { Text = "5", Value = "5" });
                Beds.Add(new SelectListItem { Text = "6", Value = "6" });
            };
            ViewBag.Bed = Beds;
            var Baths = new List<SelectListItem>();
            {
                Baths.Add(new SelectListItem { Text = "1", Value = "1" });
                Baths.Add(new SelectListItem { Text = "2", Value = "2" });
                Baths.Add(new SelectListItem { Text = "3", Value = "3" });
                Baths.Add(new SelectListItem { Text = "4", Value = "4" });
                Baths.Add(new SelectListItem { Text = "5", Value = "5" });
                Baths.Add(new SelectListItem { Text = "6", Value = "6" });
            };
            ViewBag.Bath = Baths;
            var Garage = new List<SelectListItem>();
            {
                Garage.Add(new SelectListItem { Text = "Yes", Value = "Yes" });
                Garage.Add(new SelectListItem { Text = "No", Value = "No" });
            }
            ViewBag.Gar = Garage;


            //List <State> StateList = db.States.ToList();
            //ViewBag.StateList = new SelectList(StateList, "SId", "SName");
            ViewBag.StateList = new SelectList(GetStatesList(), "SId", "SName");

            return View();
        }
        [HttpPost]
        public ActionResult ListaHome(PageModel bg , IEnumerable<HttpPostedFileBase> ImageFile)
         {

            using (ToLetModel db = new ToLetModel())
            {
                //bg.houseinfo.DisplayImage = imgPath;
                db.HouseInfoes.Add(bg.houseinfo);
                db.SaveChanges();
            }
            //string imgPath = "";
            Image_tbl img = new Image_tbl();
            foreach (HttpPostedFileBase filename in ImageFile)
            {
                string fileName = Path.GetFileNameWithoutExtension(filename.FileName);
                string extension = Path.GetExtension(filename.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;

                img.Images = "/Images/" + fileName;

                fileName = Path.Combine(Server.MapPath("/Images/"), fileName);

                filename.SaveAs(fileName);
                //imgPath = imgPath + fileName +",";

                img.HomeId = bg.houseinfo.HomeId;
                //img.Images = fileName;
                db.Image_tbls.Add(img);
                db.SaveChanges();

            }
            
            
            ViewBag.SuccessMsg = "Blog Saved Successfully..!";
            ModelState.Clear();

            return RedirectToAction("ListaHome","Listing");
        }
        public List<State> GetStatesList()
        {
            ToLetModel db = new ToLetModel();
            List<State> states = db.States.ToList();
            return states;
        }
     
        public JsonResult GetCityList(int SId)
        {
           

            List<SelectListItem> cities = new List<SelectListItem>();
           
                var ans4 = (from n in db.Cities where n.SId == SId  select n);
                foreach (var x in ans4)
                {
                cities.Add(new SelectListItem { Text = x.CName, Value = Convert.ToString(x.CName) });
                }
            

            return Json(new SelectList(cities, "Value", "Text"));
        }
        
        public ActionResult ViewListing()
        {
            var ViewListing = db.HouseInfoes.ToList();
            return View(ViewListing);
            
        }
        [HttpGet]
        public ActionResult EditListing(int HomeId)
        {
            using (ToLetModel db = new ToLetModel())
            {
                return View(db.HouseInfoes.Where(x => x.HomeId.Equals(HomeId)).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult EditListing(int HomeId, HouseInfo bg) 
        {
            try
            {
                using (ToLetModel db = new ToLetModel())
                {
                    db.Entry(bg).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("ViewListing", "Listing");

            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteListing(int HomeId)
        {
            using (ToLetModel db = new ToLetModel())
            {
                return View(db.HouseInfoes.Where(x => x.HomeId.Equals(HomeId)).FirstOrDefault());

            }
        }
        [HttpPost]
        public ActionResult DeleteListing(int HomeId, HouseInfo bg)
        {
            try
            {
                using (ToLetModel db = new ToLetModel())
                {
                    bg = db.HouseInfoes.Where(x => x.HomeId.Equals(HomeId)).FirstOrDefault();
                    db.HouseInfoes.Remove(bg);
                    db.SaveChanges();
                }
                return RedirectToAction("ViewListing", "Listing");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult SingleListing(int HomeId)
        {
            using (ToLetModel db = new ToLetModel())
            {
               
                return View(db.HouseInfoes.Where(x => x.HomeId.Equals(HomeId)).FirstOrDefault());
            }
        }

        public ActionResult property_grid()
        {
            ToLetModel db = new ToLetModel();
            var grid = (from n in db.HouseInfoes orderby n.HomeId descending select n).ToList();


            return View(grid);

        }

    }
}

