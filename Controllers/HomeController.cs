using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionProject.Controllers 
{
    public class HomeController : Controller
    {
        public ActionResult Index() //this returns the homepage
        {
            return View();
        }

        public ActionResult About() //this returns the about page
        {

            return View();
        }

        public ActionResult Contact() //this returns the contact page
        {
          
            return View();
        }

        public ActionResult Missions() //this returns the page where the user can select the mission
        {
            return View();
        }

        public ActionResult MissionDisplay(String mission) //this method contains the viewbags for each individual mission
        {
            if ( mission == "brasilia" )  //load the view bag with all objects for this mission
            {
                ViewBag.MName = "Brazil Brasília Mission";
                ViewBag.PName = "Mark C. Lundgren";
                ViewBag.MAddress = "SHIN CA 05, LOTE B1 Salas 304/307, Brasilia, 71503-505 DF, CEP – DF, Brazil";
                ViewBag.Language = "Portuguese";
                ViewBag.Climate = "Hot and humid";
                ViewBag.Religion = "Catholicism";
                ViewBag.Symbol = Url.Content("~/IMGs/brasilia.jpg");
                ViewBag.Flag = Url.Content("~/IMGs/brasilFlag.png");
                        
            }

            else if (mission == "SLC") //load the view bag with all objects for this mission
            {
                ViewBag.MName = "Utah Salt Lake City Mission";
                ViewBag.PName = "G. Scott Spendlove";
                ViewBag.MAddress = "1535 S Edison St, Salt Lake City UT 84115-1625, USA";
                ViewBag.Language = "English, Spanish, etc.";
                ViewBag.Climate = "Hot, dry summers/cold winters";
                ViewBag.Religion = "Mormonism";
                ViewBag.Symbol = Url.Content("~/IMGs/SLC.jpg");
                ViewBag.Flag = Url.Content("~/IMGs/SLCFlag.png");

            }

            else if (mission == "madrid") //load the view bag with all objects for this mission
            {
                ViewBag.MName = "Spain Madrid Mission";
                ViewBag.PName = "Kevin B. Pack";
                ViewBag.MAddress = "Calle Fuerteventura 4, 2, Office 8B, 28703 San Sebastian de los Reyes, Madrid, Spain";
                ViewBag.Language = "Spanish";
                ViewBag.Climate = "Hot, dry summers/cold winters";
                ViewBag.Religion = "Catholicism";
                ViewBag.Symbol = Url.Content("~/IMGs/madrid.png");
                ViewBag.Flag = Url.Content("~/IMGs/madridFlag.png");

            }


            return View();


        }
    }

}