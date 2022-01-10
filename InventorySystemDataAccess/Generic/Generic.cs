using InventorySystemDataAccess.Context;
using InventorySystemDataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystemDataAccess.Generic
{
   public class Generic<T> : IGeneric<T> where T : class
    {
        InventoryContext context;
        public Generic()
        {
            context = new InventoryContext();
        }

        public void Delete(int ID)
        {
            T Obj= context.Set<T>().Find(ID);
            context.Set<T>().Remove(Obj);
            context.SaveChanges();
        }

        public void Insert(T obj)
        {  
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public List<T> Load()
        {
            List<T> obj = context.Set<T>().ToList();
            return obj;
        }

        public T Edit(int ID)
        {
            T Obj = context.Set<T>().Find(ID);
            return Obj;
        }
        public void Update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges(); 
        }


    }
}
