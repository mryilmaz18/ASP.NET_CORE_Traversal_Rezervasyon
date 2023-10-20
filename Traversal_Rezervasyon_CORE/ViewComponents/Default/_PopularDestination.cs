using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_CORE.ViewComponents.Default
{
    public class _PopularDestination: ViewComponent
    {
        DestinationManager destinaitonManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinaitonManager.TGetList();
            return View(values);
        }

    }
}
