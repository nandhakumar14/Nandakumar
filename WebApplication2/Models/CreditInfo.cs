using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace WebApplication2.Models
{

    public class CreditInfo
    {
        public string Id;
        public int ApplicationId;
        public string Type;
        public string Summary;
        public float Amount;
        public string PostingDate;
        public bool IsCleared;
        public string ClearedDate;
    }

    //public List<CreditInfo> LoadJsonFromFile()
    //{
    //    List<CreditInfo> CreditInfos = new List<CreditInfo>();
    //    using (StreamReader r = new StreamReader(@"D:\JSON\FileOutput.json"))
    //    {
    //        string json = r.ReadToEnd();
    //        CreditInfos = JsonConvert.DeserializeObject<List<CreditInfo>>(json);
    //    }
    //    return CreditInfos.ToList();
    //}
}