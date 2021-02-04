using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Siakad.Data
{
    public class Contact
    {
        [Key]
        [JsonIgnore]
        public string id { get; set; }
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Jurusan {get;set;}
        public string Fakultas{get;set;}
        public string DosenPembimbing{get;set;}
  
    }
}
