using CalendarSystem.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calendar.Controllers
{
    public class CalendarController : Controller
    {
        #region Fields
        private IAppointmentService _AppointmentService = null;
        private IMonthService _MonthService = null;
        #endregion
        #region Constructors
       
        public CalendarController(IAppointmentService appointmentService,IMonthService monthService)
        {
            _AppointmentService = appointmentService;
            _MonthService = monthService;
           
          
        }
        #endregion
        // GET: Calendar
        public ActionResult Index()
        {
          
            return View();
        }
        public ActionResult GetMonth()
        {
            var Months = _MonthService.GetMonths();
            return View(Months);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }

    }
}