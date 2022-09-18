using DataBaseNet.Data.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseNet.Data
{
    public static class DataBaseSeeder
    {
        public static void Seed() 
        {
            using (MyDataContext dataContext = new MyDataContext())
            {
                SeedUsers(dataContext);
                SeedProdacts(dataContext);
                SeedBaskets(dataContext);
                SeedOrderStatus(dataContext);
                SeedOrder(dataContext);
                SeedOrderItems(dataContext);
                SeedProductImages(dataContext);

            }
        }
        private static void SeedUsers(MyDataContext dataContext)
        {
            if (! dataContext.Users.Any() )
            {
                var user = new User()
                {
                    FirstName = "Кабачок",
                    LastName = "Петро",
                    Email = "ivan@gmail.com",
                    Phone = "380974565667"
                };
                dataContext.Users.Add(user);
                dataContext.SaveChanges();
            }
        }

        private static void SeedProdacts(MyDataContext dataContext)
        {
            if (!dataContext.Products.Any())
            {
                var product = new Product()
                {
                    Name = "SSD 256 Gb",
                    Price = 120.45m,
                    DescriptionPrice = "Звичайна швидкість"
                
                };
                dataContext.Products.Add(product);
                dataContext.SaveChanges();

                var product2 = new Product()
                {
                    Name = "DDR 4 16 Gb",
                    Price = 2400.50m,
                    DescriptionPrice = "Хороша швидкість"

                };
                dataContext.Products.Add(product2);
                dataContext.SaveChanges();
            }
        }

        private static void SeedBaskets(MyDataContext dataContext)
        {
            if (!dataContext.Baskets.Any())
            {
                var basket = new Basket()
                {
                    UserId = 1,
                    ProductId = 1,
                    Count = 1
                };
                dataContext.Baskets.Add(basket);
                dataContext.SaveChanges();

                var basket2 = new Basket()
                {
                    UserId = 1,
                    ProductId = 2,
                    Count = 2
                };
                dataContext.Baskets.Add(basket2);
                dataContext.SaveChanges();
            }
        }

        private static void SeedOrderStatus(MyDataContext dataContext)
        {
            if (!dataContext.OrderStatuses.Any())
            {

                string[] statuses = {
                    "Новий заказ",
                    "Оброблено автоматично",
                    "Виконано",
                    "Прибув у відділення",
                    "Скасовано"
                };
                foreach (var item in statuses)
                {
                    OrderStatus status = new OrderStatus
                    {
                        Name = item
                    };
                dataContext.OrderStatuses.Add(status);
                dataContext.SaveChanges();
                } 
            }
        }

        private static void SeedOrder(MyDataContext dataContext)
        {
            if (!dataContext.Orders.Any())
            {
                var order = new Order
                {
                    StutusId = 1,
                    DateCreated = DateTime.Now,
                    UserID = 1
                };

                dataContext.Orders.Add(order);
                dataContext.SaveChanges();
            }
        }

        private static void SeedOrderItems(MyDataContext dataContext)
        {
            if (!dataContext.OrderItems.Any())
            {
                var orderItem = new OrderItem
                {
                    OrderId = 1,
                    Count = 2,
                    ProductId = 1,
                    PriceBuy = 1150.45m
                };
                dataContext.OrderItems.Add(orderItem);
                dataContext.SaveChanges();

                var orderItem2 = new OrderItem
                {
                    OrderId = 1,
                    Count = 1,
                    ProductId = 2,
                    PriceBuy = 2245.89m
                };
                dataContext.OrderItems.Add(orderItem2);
                dataContext.SaveChanges();
            }
        }

        private static void SeedProductImages(MyDataContext dataContext)
        {
            if (!dataContext.ProductImages.Any())
            {
                var image = new ProductImage
                {
                    Name = "1.jpg",
                    ProductId = 1,
                    Priority = 1
                };
                dataContext.ProductImages.Add(image);
                dataContext.SaveChanges();
                var image2 = new ProductImage
                {
                    Name = "2.jpg",
                    ProductId = 1,
                    Priority = 2
                };
                dataContext.ProductImages.Add(image2);
                dataContext.SaveChanges();
            }
        }
        }

    }



