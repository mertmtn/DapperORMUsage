using DapperNorthWind.Models;
using System;
using System.Collections.Generic;

namespace DapperNorthWind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region GetAllProducts
                foreach (var urun in DapperMethods.GetAllProducts())
                {
                    Console.WriteLine("Ürün Adı:{0} Ürün Fiyatı:{1} Ürün Stok Miktarı:{2}",
                        urun.ProductName, urun.UnitPrice, urun.UnitsInStock);
                }
                #endregion

                #region AnonymousList
                //foreach (var urun in DapperMethods.AnonymusList())
                //{
                //    Console.WriteLine("Ürün Adı:{0} Ürün Fiyatı:{1} Ürün Stok Miktarı:{2}",
                //        urun.ProductName, urun.UnitPrice, urun.UnitsInStock);
                //}
                #endregion
                 
                #region GetProductById
                //Random rnd = new Random();
                //int id = rnd.Next(1, DapperMethods.GetAllProducts().Count);

                //Urunler p = DapperMethods.GetProductById(id);

                //Console.WriteLine("ürün adı:{0} ürün fiyatı:{1} ürün stok miktarı:{2}",
                //     p.ProductName, p.UnitPrice, p.UnitsInStock);
                #endregion

                #region AddOneCategory

                //Kategori kategori = new Kategori { CategoryName = "Spor", Description = "Spor Malzemeleri" };

                //if (DapperMethods.AddOneCategory(kategori)>0)
                //{
                //    Console.WriteLine("1 adet kategori eklendi");
                //}
                #endregion

                #region UpdateCategory
                //Kategori kategori = new Kategori { CategoryName = "Futbol", Description = "Futbol" };

                //if (DapperMethods.UpdateCategory(kategori,9) > 0)
                //{
                //    Console.WriteLine("Belirtilen kategori güncellendi");
                //}
                #endregion

                #region DeleteCategory
                //if (DapperMethods.DeleteCategory(9) > 0)
                //{
                //    Console.WriteLine("Belirtilen kategori silindi");
                //}
                #endregion

                #region DeleteMultipleCategory
                //List<int> idList = new List<int>();
                //int[] arrayCategoryId = { 10, 11 };
                //idList.AddRange(arrayCategoryId);                

                //if (DapperMethods.DeleteCategory(idList) > 0)
                //{
                //    Console.WriteLine("Belirtilen kategoriler silindi");
                //}
                #endregion

                #region SPGetAllProducts
                //foreach (var urun in DapperMethods.SPGetAllProducts())
                //{
                //    Console.WriteLine("Ürün Adı:{0} Ürün Fiyatı:{1} Ürün Stok Miktarı:{2}",
                //        urun.ProductName, urun.UnitPrice, urun.UnitsInStock);
                //}
                #endregion

                #region SPGetProductById
                //Random rnd = new Random();
                //int id = rnd.Next(1, DapperMethods.GetAllProducts().Count);

                //Urunler p = DapperMethods.SPGetProductById(id);

                //Console.WriteLine("Ürün Adı:{0} Ürün Fiyatı:{1} Ürün Stok Miktarı:{2}",
                //     p.ProductName, p.UnitPrice, p.UnitsInStock);
                #endregion

                #region SPAddOneCategory
                //Kategori kategori = new Kategori { CategoryName = "Kamp", Description = "Kamp Malzemeleri" };

                //if (DapperMethods.SPAddOneCategory(kategori) > 0)
                //{
                //    Console.WriteLine("1 adet kategori eklendi");
                //}
                #endregion

                #region AddManyCategories
                //var newProducts = new List<Urunler>();
                //newProducts.Add(new Urunler { CategoryId = 13, ProductName = "2 Kişilik Çadır", UnitPrice = 89, UnitsInStock = 24 });
                //newProducts.Add(new Urunler { CategoryId = 13, ProductName = "Uyku Tulumu", UnitPrice = 45, UnitsInStock = 78 });
                //var count=DapperMethods.AddManyCategories(newProducts);
                //if (count>0)
                //{
                //    Console.WriteLine("{0} ürün başarıyla eklendi.", count.ToString());
                //}
                #endregion

                #region SelectMultipleCategory

                //var arr = DapperMethods.SelectMultipleQueries();
                //var product = arr[0] as List<Urunler>;

                //Console.WriteLine("ÜRÜNLER");
                //foreach (var item in product)
                //{
                //    Console.WriteLine(item.ProductName);
                //}
                //Console.WriteLine("-----------------");
                //Console.WriteLine("KATEGORİLER");
                //var category = arr[1] as List<Kategori>;
                //foreach (var item in category)
                //{
                //    Console.WriteLine(item.CategoryName);
                //}
                #endregion

                #region ProductCategory
                //var urunler = DapperMethods.ProductCategory(); 

                //foreach (var item in urunler)
                //{
                //    Console.WriteLine(item.ProductName+" "+item.CategoryName);
                //}
                #endregion

                #region OrderOrderDetails
                //var siparis = DapperMethods.OrderOrderDetails();

                //foreach (var item in siparis)
                //{
                //    Console.WriteLine(item.OrderID + " " + item.ProductName + " " + item.OrderDetails.Quantity);
                //}
                #endregion


            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
