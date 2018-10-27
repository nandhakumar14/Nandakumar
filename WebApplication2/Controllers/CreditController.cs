using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CreditController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        // GET api/values/5
        [HttpGet]
        public List<CreditInfo> Get(int id)
        {

            List<CreditInfo> CreditInfos = new List<CreditInfo>();
            using (StreamReader r = new StreamReader(@"D:\JSON\FileOutput.json"))
            {
                string json = r.ReadToEnd();
                CreditInfos = JsonConvert.DeserializeObject<List<CreditInfo>>(json);
            }
            List<CreditInfo> CreditInfoSearched = new List<CreditInfo>();
            foreach (CreditInfo CrInfo in CreditInfos.Where(C=> C.ApplicationId == id))
            {
                CreditInfo ObjCreditInfo = new CreditInfo();
                ObjCreditInfo.Id = CrInfo.Id;
                ObjCreditInfo.ApplicationId = CrInfo.ApplicationId;
                CreditInfoSearched.Add(CrInfo);
            }
            return CreditInfoSearched.ToList();

        }



        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]CreditInfo ObjCreditInfo)
        {
            

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
