﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class ItemController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Item
        public IQueryable<Item> GetItem()
        {
            return db.Items;
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}