using System;
using System.Collections.Generic;
using System.Text;
using SurfZone.DataAccess.Models;

namespace SurfZone.DataAccess.Services
{
    public class NewsService : INewsService
    {
        private readonly SurfZoneContext dbContext;

        public NewsService()
        {
            this.dbContext = new SurfZoneContext();
        }

        public void Create(News news)
        {
            dbContext.News.Add(news);
            dbContext.SaveChanges();
        }

        public void Delete(int newsId)
        {
            var news = dbContext.News.Find(newsId);
            if (news != null)
            {
                dbContext.News.Remove(news);
                dbContext.SaveChanges();
            }
        }

        public News Get(int newsId)
        {
            var news = dbContext.News.Find(newsId);
            return news;
        }

        public IEnumerable<News> GetAll()
        {
            return dbContext.News;
        }

        public void Update(News updatingNews)
        {
            var news = dbContext.News.Find(updatingNews.Id);
            if (news != null)
            {
                news.Title = updatingNews.Title;
                news.Body = updatingNews.Body;
                news.Picture = updatingNews.Picture;
                news.Date = updatingNews.Date;
                news.UserId = updatingNews.UserId;

                dbContext.SaveChanges();
            }
        }
    }
}
