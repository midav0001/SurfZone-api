using SurfZone.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurfZone.DataAccess.Services
{
    public interface INewsService
    {
        IEnumerable<News> GetAll();
        News Get(int newsId);
        void Create(News news);
        void Update(News news);
        void Delete(int newsId);
    }
}
