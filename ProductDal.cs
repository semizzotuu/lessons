using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (EtradeContext context = new EtradeContext())//using ETradeContext bellekte çok yer kaplıyor bu tip nesneler interfaceini kullanarak method bittiği zaman
                                                               //dapnet bellek yöneticisi çöpe atıyor using kullanmazsak blok bittiği anda nesneyi bellekten atmaz ve çok yer kaplar.
            {

                return context.Products.ToList();

            }

        }
        public void Add(Product product)
        {
            using (EtradeContext context = new EtradeContext())//using ETradeContext bellekte çok yer kaplıyor bu tip nesneler interfaceini kullanarak method bittiği zaman
                                                               //dapnet bellek yöneticisi çöpe atıyor using kullanmazsak blok bittiği anda nesneyi bellekten atmaz ve çok yer kaplar.
            {

                //context.Products.Add(product);
                var entity = context.Entry(product);//context üzerinden abone ol
                entity.State = EntityState.Added;
                context.SaveChanges();

            }
        }
        public void Update(Product product)
        {
            using (EtradeContext context = new EtradeContext())//using ETradeContext bellekte çok yer kaplıyor bu tip nesneler interfaceini kullanarak method bittiği zaman
                                                               //dapnet bellek yöneticisi çöpe atıyor using kullanmazsak blok bittiği anda nesneyi bellekten atmaz ve çok yer kaplar.
            {

                var entity = context.Entry(product);//context üzerinden abone ol
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void Delete(Product product)
        {
            using (EtradeContext context = new EtradeContext())//using ETradeContext bellekte çok yer kaplıyor bu tip nesneler interfaceini kullanarak method bittiği zaman
                                                               //dapnet bellek yöneticisi çöpe atıyor using kullanmazsak blok bittiği anda nesneyi bellekten atmaz ve çok yer kaplar.
            {

                var entity = context.Entry(product);//context üzerinden abone ol
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
        public List<Product> GeyByName(string key)
        {
            using (EtradeContext context = new EtradeContext())//using ETradeContext bellekte çok yer kaplıyor bu tip nesneler interfaceini kullanarak method bittiği zaman
                                                               //dapnet bellek yöneticisi çöpe atıyor using kullanmazsak blok bittiği anda nesneyi bellekten atmaz ve çok yer kaplar.
            {

                return context.Products.Where(x=>x.Name.Contains(key)).ToList();//context.Products buradaki Products = sql de ki tablonun ismi
                //burada veri tabanına sorgu yapıyoruz.
            }

        }
        public List<Product> GetByUnitPrice(decimal price)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Where(x => x.UnitPrice >= price).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Where(x => x.UnitPrice >= min && x.UnitPrice<=max).ToList();
            }
        }
        public Product GetById(int id1)
        {
            using (EtradeContext context = new EtradeContext())
            {
                
                  return context.Products.SingleOrDefault(p => p.Id == id1);//bu id ye uygun olan ilk id yi getir.Eğer o id de bir veri yoksa null döndür.
                
            }
        }
    }
}
