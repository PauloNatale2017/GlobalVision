using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVisionVendor.Domain.BaseEntity
{
    public  class EntityBaseMongo
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public int ID { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public EntityBaseMongo(DateTime dataC,DateTime dataA)
        {          
            DataCriacao = DateTime.Now;
            DataAtualizacao = DateTime.Now;
        }


    }
}
