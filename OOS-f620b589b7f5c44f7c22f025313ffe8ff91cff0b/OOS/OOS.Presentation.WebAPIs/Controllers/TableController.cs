using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOS.Domain.Tables.Models;
using OOS.Presentation.ApplicationLogic.Tables;

namespace OOS.Presentation.WebAPIs.Controllers
{
    [Route("api/[controller]")]
    public class TableController : Controller
    {
        private readonly ITablesBusinessLogic _tablesBusinessLogic;

        public TableController(ITablesBusinessLogic tablesBusinessLogic)
        {
            _tablesBusinessLogic = tablesBusinessLogic;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _tablesBusinessLogic.GetTables();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var result = _tablesBusinessLogic.GetTable(id);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Table table)
        {
            var result = _tablesBusinessLogic.CreateTable(table);
            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]Table table)
        {
            var result = _tablesBusinessLogic.EditTable(id,table);
            return Ok(result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _tablesBusinessLogic.DeleteTable(id);
            return Ok();
        }


    }
}