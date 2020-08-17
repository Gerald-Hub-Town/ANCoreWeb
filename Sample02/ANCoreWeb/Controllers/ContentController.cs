using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ANCoreWeb.Models;
using Microsoft.Extensions.Options;

namespace ANCoreWeb.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        /// <summary>
        /// 如下ContentController对Content产生依赖，Content对象非new创建（正转），而是容器直接传进来（控制反转）
        /// IOptions<Content> option这个对象的东西就是容器
        /// 容器的好处，由容易统一管理实例的创建和销毁，开发者只需关心在怎么用即可
        /// </summary>
        /// <param name="option"></param>
        public ContentController(IOptions<Content> option)//构造函数注入
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, Title = $"{i}的标题", ContentMsg = $"{i}的内容", Status = 1, CreateTime = DateTime.Now.AddDays(-1) });
            //}
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}
