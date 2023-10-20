using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_CORE.ViewComponents.Default
{
    public class _TestiMonial: ViewComponent
    {
        TestiMonialManager testiMonialManager = new TestiMonialManager(new EfTestiMonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testiMonialManager.TGetList();
            return View(values);
        }

    }
}
