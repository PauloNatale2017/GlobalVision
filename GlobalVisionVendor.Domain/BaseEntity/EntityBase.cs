﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.BaseEntity
{
    public  class EntityBase
    {
        [Key]
        public int ID { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }

        //public EntityBase(DateTime dataC,DateTime dataA)
        //{          
        //    DataCriacao = DateTime.Now;
        //    DataAtualizacao = DateTime.Now;
        //}


    }
}
