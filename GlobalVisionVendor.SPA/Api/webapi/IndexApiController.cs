using GlobalVisionVendor.Domain.Core.Repository;
using GlobalVisionVendor.Domain.MapEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace GlobalVisionVendor.SPA.Api.webapi
{
    public class IndexApiController : ApiController 
    {

        private readonly GlobalVisionVendor.Domain.Core.Repository.CadastroEnderecoRepository _rep = new Domain.Core.Repository.CadastroEnderecoRepository();
        private readonly GlobalVisionVendor.Domain.Core.Repository.CadastroLatLngRepository _repLatLng = new Domain.Core.Repository.CadastroLatLngRepository();


        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            // Pernambucanas.Processamentos.Threads.ProcessaEspelho.QuebraArquivo();

            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
        
     
        // POST api/<controller>
        public void Post(CadastroEndereco value)
        {
            value.DataAtualizacao = DateTime.Now;
            value.DataCriacao = DateTime.Now;
            _rep.Add(value);
        }

        //
        [AcceptVerbs("POST")]
        public void PostLatLng(CadastroLatLng value)
        {
            value.DataAtualizacao = DateTime.Now;
            value.DataCriacao = DateTime.Now;
            _repLatLng.Add(value);           
        }

        [AcceptVerbs("GET")]
        public List<CadastroLatLng> GET_PLOTARPONTOS(CadastroLatLng value)
        {           
            return _repLatLng.GetAll().ToList();
        }


        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
            
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }





    }
}