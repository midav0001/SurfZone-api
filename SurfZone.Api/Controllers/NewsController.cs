using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SurfZone.DataAccess;
using SurfZone.DataAccess.Services;
using SurfZone.DataAccess.Models;
using SurfZone.Api.DTO;
using AutoMapper;

namespace SurfZone.Api.Controllers
{
    public class NewsController : ApiController
    {
        private readonly INewsService newsService;
        private readonly IMapper mapper;

        public NewsController()
        {
            this.newsService = new NewsService();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<News, NewsDTO>().ReverseMap();
            });
            mapper = config.CreateMapper();
        }

        [HttpPost]
        public IHttpActionResult Create(NewsDTO newsDTO)
        {
            if (newsDTO == null)
            {
                return BadRequest();
            }
            var news = mapper.Map<NewsDTO, News>(newsDTO);
            newsService.Create(news);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            newsService.Delete(id);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var news = newsService.Get(id);
            if (news == null)
            {
                return NotFound();
            }
            var newsDTO = mapper.Map<News, NewsDTO>(news);
            return Ok(newsDTO);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var news = newsService.GetAll();
            var newsDTO = news.Select(p => mapper.Map<News, NewsDTO>(p));
            return Ok(newsDTO);
        }

        [HttpPut]
        public IHttpActionResult Update(NewsDTO newsDTO)
        {
            if (newsDTO == null)
            {
                return BadRequest();
            }
            var news = mapper.Map<NewsDTO, News>(newsDTO);
            newsService.Update(news);
            return Ok();
        }
    }
}
