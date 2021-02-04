using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Siakad.Models
{
    public class ContactDto
    {
        [Key]
        public string id { get; set; }
        public string Nama { get; set; }
        public string Nim { get; set; }
        public string Fakultas {get;set;}
        public string Jurusan {get;set;}
        public string DosenPembimbing{get;set;}

    }
}
