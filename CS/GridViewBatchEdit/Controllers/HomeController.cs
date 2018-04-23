using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using Models;

namespace GridViewBatchEdit.Controllers {
    public class HomeController: Controller {
        public ActionResult Index() {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial() {
            return PartialView("_GridViewPartial", GridViewData.GridData);
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult DeleteRowPartial(int ID) {
            if (ID >= 0) {
                try {
                    GridViewData.DeleteItem(ID);
                }
                catch (Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartial", GridViewData.GridData);
        }

    }
}