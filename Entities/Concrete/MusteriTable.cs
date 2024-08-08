using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class MusteriTable: IEntity
    {
        [Key]
        public string TCKN { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string CepTel { get; set; }

        [Required]
        public string Boy { get; set; }

        [Required]
        public string Kilo { get; set; }

    }

}