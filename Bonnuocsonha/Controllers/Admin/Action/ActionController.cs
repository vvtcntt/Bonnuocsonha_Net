using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bonnuocsonha.Models;
namespace Bonnuocsonha.Controllers.Admin.Action
{
    public class ActionController : Controller
    {
        // GET: Action
        public ActionResult Index()
        {
            return View();
        }
        private BonnuocsonhaContext db = new BonnuocsonhaContext();
        public ActionResult Command()
        {
            //var listProduct = db.tblProducts.ToList();
            //for(int i=0;i<listProduct.Count;i++)
            //{
            //    int id = listProduct[i].id;
            //    tblProduct products = db.tblProducts.Find(id);
            //    products.id = id;
            //    string tabs = products.Tabs;
            //    if(tabs!=null && tabs!="")
            //    {
            //        var arrayTabs = tabs.Split(',');
            //        for(int j=0;j<arrayTabs.Length;j++)
            //        {
            //            tblProductTag productTags = new tblProductTag();
            //            if (arrayTabs[j].Substring(0,1)==null || arrayTabs[j].Substring(0, 1) == "")
            //            {
            //                arrayTabs[j] = arrayTabs[j].Substring(1, arrayTabs.Length - 1);
            //            }
            //            productTags.idp = id;
            //            productTags.Name = products.Name;
            //            productTags.Tag = StringClass.NameToTag(arrayTabs[j]);
            //            db.tblProductTags.Add(productTags);
            //        db.SaveChanges();

            //        }

            //    }
            //products.Title = products.Name;
            //products.Tag = StringClass.NameToTag(products.Name);
            //if(products.ImageLinkThumb != null && products.ImageLinkThumb != "")
            //{
            //    var arrayImages = products.ImageLinkThumb.Split('/');
            //    for(int j=0;j<arrayImages.Length;j++)
            //    {
            //        products.ImageLinkThumb = "/Images/_thumbs/Images/" + arrayImages[arrayImages.Length- 1];
            //    }

            //}

            //}
            var listNews = db.tblNews.ToList();
            for (int i = 0; i < listNews.Count; i++)
            {
                int id = listNews[i].id;
                tblNew tblnews = db.tblNews.Find(id);
                tblnews.id = id;
                //tblnews.Title = tblnews.Name;
                tblnews.Tag = StringClass.NameToTag(tblnews.Name);
                //if (tblnews.Images != null && tblnews.Images != "")
                //{
                //    var arrayImages = tblnews.Images.Split('/');
                //    for (int j = 0; j < arrayImages.Length; j++)
                //    {
                //        tblnews.Images = "/Images/Images/" + arrayImages[arrayImages.Length - 1];
                //    }

                //}
                db.SaveChanges();
            }
            var listGroupProduct = db.tblGroupProducts.ToList();
            for (int i = 0; i < listGroupProduct.Count; i++)
            {
                int id = listGroupProduct[i].id;
                tblGroupProduct groupproducts = db.tblGroupProducts.Find(id);
                groupproducts.id = id;
                groupproducts.Title = groupproducts.Name;
                groupproducts.Tag = StringClass.NameToTag(groupproducts.Name);
                db.SaveChanges();
            }

            return View();
        }
    }
}