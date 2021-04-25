using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplicationELton.Data;
using WebApplicationELton.Models;
using WebApplicationELton.Repository;

namespace WebApplicationELton.UnityOfWork
{
    public class UnityOfWorkApp : DbContext
    {
        ContextApp context = new ContextApp();
        Repository<Product> productRepository;
        public Repository<Product> ProductRepository
        {

            get
            {
                if (productRepository == null)
                {
                    productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }

        }
        public void Comit()
        {
            context.SaveChanges();
        }
    }

}