using NSwagLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NSwagLab.Controllers
{
    /// <summary>
    /// 測試API
    /// </summary>
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        // GET api/values
        /// <summary>
        /// 取得多筆資料
        /// </summary>
        /// <returns></returns>
        [Route("GetAll")]
        [NSwag.Annotations.OpenApiTags("KIM-TAG", "OK")]
        [NSwag.Annotations.OpenApiOperation("取得多筆資料 s", "取得多筆資料 d")]
        [NSwag.Annotations.)]
        public List<TestModel> Get()
        {
            List<TestModel> result = new List<TestModel>();
            result.Add(new TestModel { CreateDate = DateTime.Now, Name = "KIM-1", ID = 1 });
            result.Add(new TestModel { CreateDate = DateTime.Now, Name = "KIM-2", ID = 2 });
            return result;
        }

        // GET api/values/5
        /// <summary>
        /// 取得單筆資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TestModel Get(int id)
        {
            return new TestModel { CreateDate = DateTime.Now, Name = "KIM", ID = id };
        }

        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="value">資料</param>
        // POST api/values
        public void Post([FromBody] TestModel value)
        {
        }




    }
}
