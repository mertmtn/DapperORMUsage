using Dapper;
using DapperNorthWind.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace DapperNorthWind
{
    public class DapperMethods
    {
        public static List<Urunler> ProductCategory()
        {
            var connection = DbConnect.Connection;

            var query = "SELECT * FROM dbo.Categories INNER JOIN  dbo.Products ON dbo.Categories.CategoryID = dbo.Products.CategoryID";

            var list = connection.Query<Urunler, Kategori, Urunler>(query, (urun, kat) =>
                 {
                     urun.Kategori = kat;
                     return urun;
                 }, splitOn: "CategoryID").ToList();

            return list;
        }

        public static List<Siparis> OrderOrderDetails()
        {
            var connection = DbConnect.Connection;

            var query = "SELECT * FROM dbo.Products INNER JOIN  dbo.[Order Details] ON dbo.Products.ProductID = dbo.[Order Details].ProductID";

            var list = connection.Query<Siparis, SiparisDetay, Siparis>(query, (siparis, siparisDetay) =>
            {
                siparis.OrderDetails = siparisDetay;
                return siparis;
            }, splitOn: "ProductID").ToList();

            return list;
        }

        public static List<dynamic> AnonymusList()
        {
            var connection = DbConnect.Connection;

            var urunListesi = connection.Query("SELECT * FROM Products").ToList();

            return urunListesi;
        }


        public static ArrayList SelectMultipleQueries()
        {
            var connection = DbConnect.Connection;

            var sql = "Select * From Products; Select * From Categories";

            SqlMapper.GridReader multiQuery = connection.QueryMultiple(sql);
            var productList = multiQuery.Read<Urunler>().ToList();
            var categoryList = multiQuery.Read<Kategori>().ToList();

            return new ArrayList() { productList, categoryList };
        }

        public static List<Urunler> GetAllProducts()
        {
            var connection = DbConnect.Connection;

            List<Urunler> urunListesi = connection.Query<Urunler>("SELECT * FROM Products").ToList();

            return urunListesi;
        }

        public static List<Urunler> SPGetAllProducts()
        {
            var connection = DbConnect.Connection;

            var query = "GetAllProducts";

            List<Urunler> urunListesi = connection.Query<Urunler>(query, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return urunListesi;
        }

        public static Urunler GetProductById(int id)
        {
            var connection = DbConnect.Connection;

            var query = "Select * From Products Where ProductId=@ProductId";

            return connection.QueryFirstOrDefault<Urunler>(query, new { ProductId = id });
            //return connection.QueryFirst<Urunler>(query, new { ProductId = id });
            //return connection.QuerySingle<Urunler>(query, new { ProductId = id });
            //return connection.QuerySingleOrDefault<Urunler>(query, new { ProductId = id });
        }

        public static Urunler SPGetProductById(int id)
        {
            var connection = DbConnect.Connection;

            var query = "GetProductById";

            return connection.QueryFirstOrDefault<Urunler>(query, new { id = id }, commandType: System.Data.CommandType.StoredProcedure);
        }

        public static int AddOneCategory(Kategori kategori)
        {
            var connection = DbConnect.Connection;

            var query = "INSERT INTO [dbo].[Categories]([CategoryName],[Description]) VALUES (@CategoryName, @Description)";

            return connection.Execute(query, new { CategoryName = kategori.CategoryName, Description = kategori.Description });
        }

        public static int UpdateCategory(Kategori kategori, int id)
        {
            var connection = DbConnect.Connection;

            var query = "UPDATE [dbo].[Categories] SET[CategoryName] =@CategoryName  ,[Description] = @Description WHERE CategoryId=@CategoryId";

            return connection.Execute(query, new { CategoryName = kategori.CategoryName, Description = kategori.Description, CategoryId = id });
        }

        public static int DeleteCategory(int id)
        {
            var connection = DbConnect.Connection;

            var query = "DELETE FROM [dbo].[Categories] WHERE CategoryId=@CategoryId";

            return connection.Execute(query, new { CategoryId = id });
        }

        public static int DeleteCategory(List<int> idList)
        {
            var connection = DbConnect.Connection;

            var query = "DELETE FROM [dbo].[Categories] WHERE CategoryId IN @CategoryId";

            return connection.Execute(query, new { CategoryId = idList });
        }

        public static int SPAddOneCategory(Kategori kategori)
        {
            var connection = DbConnect.Connection;

            var query = "AddCategory";

            return connection.Execute(query, new { CategoryName = kategori.CategoryName, Description = kategori.Description }, commandType: System.Data.CommandType.StoredProcedure);
        }

        public static int AddManyCategories(List<Urunler> urunListesi)
        {
            var connection = DbConnect.Connection;

            var query = "INSERT INTO [dbo].[Products]([ProductName],[UnitPrice],[UnitsInStock],CategoryID) VALUES (@ProductName,@UnitPrice,@UnitsInStock,@CategoryID)";

            foreach (Urunler urun in urunListesi)
            {
                connection.Execute(query, new { ProductName = urun.ProductName, UnitPrice = urun.UnitPrice, UnitsInStock = urun.UnitsInStock, CategoryID = urun.CategoryId });
            }
            return urunListesi.Count;
        }
    }
}
