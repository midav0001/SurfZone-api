using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using SurfZone.DataAccess;
using System.Data.Entity;
using SurfZone.DataAccess.Models;
using NLog;

namespace SurfZone.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Initialize();
        }


        public static void Initialize()
        {
            using (SurfZoneContext context = new SurfZoneContext())
            {
                var surfboards = new Category { Name = "Surfboards" };
                var surfClothing = new Category { Name = "Surf clothing" };
                var accessories = new Category { Name = "Accessories" };
                var services = new Category { Name = "Services" };

                context.Categories.Add(surfboards);
                context.Categories.Add(surfClothing);
                context.Categories.Add(accessories);
                context.Categories.Add(services);

                context.SaveChanges();

                var heritage = new Product
                {
                    Name = "8'8 Heritage",
                    Category = surfboards,
                    Price = 310,
                    Description = "8'8 Soft Top Surfboard - The 8'8 Heritage is the perfect Longboard Soft-Top Surfboard for all" +
                    " the soul surfers out there with a sleek frame, round nose and squash tail, this massive foamie paddles easily, catches waves early, and can gain speed quickly. Our unique soft-top shape and added " +
                    "multiple features make it incredibly durable compared to standard soft-top surfboards. The perfect soft-top longboard surfing experience for all ages and surf abilities."
                };

                var hybrid = new Product
                {
                    Name = "6'8 Hybride",
                    Category = surfboards,
                    Price = 390,
                    Description = "6'8 Hybrid Soft Top Surfboard - The Casper has a performance thruster nose with a swallow tail = easy paddling and smooth turns in your " +
                    "surfing. The 68 Casper is a smooth flowing easy surfing soft-top sufboard with great float and paddle ability but is not lacking at all in its ability to turn" +
                    " and carve down the line. Real Bamboo layers protected with a slick hdpe plastic bottom deck + FCS Fin Boxes."
                };

                var prizmaBoardshorts = new Product
                {
                    Name = "Prizma Boardshorts",
                    Category = surfClothing,
                    Price = 60,
                    Description = "Surfers don’t need another boardshort, they need the best boardshort. break through the noise and take your surfing to the next level in our latest high performance trunk."
                };

                var fraserPolo = new Product
                {
                    Name = "Fraser Polo",
                    Category = surfClothing,
                    Price = 35,
                    Description = "O'Neill Men's polo shirt."
                };

                var transferBackpack = new Product
                {
                    Name = "Transfer Backpack",
                    Category = accessories,
                    Price = 45,
                    Description = "O'Neill Men's backpack."
                };

                var lodownHat = new Product
                {
                    Name = "Lodown Hat",
                    Category = accessories,
                    Price = 26,
                    Description = "O'Neill Men's hat."
                };

                var surfingLesson = new Product
                {
                    Name = "Surfing Lesson",
                    Category = services,
                    Price = 80,
                    Description = "Each lesson includes a safe, soft surfboard, booties (footwear) and a protective rash guard."
                };

                var surfboardRental = new Product
                {
                    Name = "Surfboard Rental",
                    Category = services,
                    Price = 12,
                    Description = "Quality soft surfboards for novices and regular hard epoxy surfboards for experienced surfers are available to rent by the hour, day or week."
                };

                context.Products.Add(heritage);
                context.Products.Add(hybrid);
                context.Products.Add(prizmaBoardshorts);
                context.Products.Add(fraserPolo);
                context.Products.Add(transferBackpack);
                context.Products.Add(lodownHat);
                context.Products.Add(surfingLesson);
                context.Products.Add(surfboardRental);

                context.SaveChanges();

                var survivorHero = new News
                {
                    Title = "Survivor ‘Hero' coaches Special Olympics surfing in Brevard",
                    Body = "Sean Poynter blitzed through his semi-final matchup with Poenaiki Raioha, while Zane Schweitzer held off a challenge from the defending ISA SUP Surfing World Champ" +
                    " Luiz Diniz. This setup a blistering finals matchup of two of the most progressive SUP surfers in the world. Once the final buzzer went off, Poynter had bested his Maui-based" +
                    " teammate and the two rode a wave to shore together in a display of friendship and sportsmanship.",
                    Date = new DateTime(2018, 07, 17)
                };

                var surfingReturns = new News
                {
                    Title = "Competitive sup surfing returns at ny sup open",
                    Body = "The New York SUP Open marked the first major competitive SUP surfing event in over a year and was met with anticipation and excitement from fans and athletes alike." +
                    "The APP contest attracted an international field of talent including the likes of Kai Lenny, Zane Schweitzer, Sean Poynter, Izzi Gomez, Nicole Pacelli and many more.",
                    Date = new DateTime(2018, 09, 26)
                };

                context.News.Add(survivorHero);
                context.News.Add(surfingReturns);

                context.SaveChanges();

                //var heritagePicture = new Picture()
                //{
                //    Data = System.IO.File.ReadAllBytes(@"D:\Education\Programming\Repositories\Picture\1.jpg"),
                //    ProductId = 1,
                //    Product = heritage
                //};

                //context.Pictures.Add(heritagePicture);
                //context.SaveChanges();
            }
        }
    }
}
