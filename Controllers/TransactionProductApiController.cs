using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.AspNetCore.Mvc;

namespace simple_pos_backend2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionProductApiController : ControllerBase
    {
        private SqliteConnection _connection = new SqliteConnection("Data source = simple_pos.db");

        // get specified transaction's products
        [HttpGet("GetTransactionProducts")]
        public async Task<ActionResult<TransactionProduct>> GetTransactionProducts(int transactionId){

            const string query = "Select * from TransactionProducts where TransactionId = @TransactionId";
            var result  = await _connection.QueryAsync<TransactionProduct>(query, new {TransactionId = transactionId});
            
            if(result == null)
                return BadRequest("Bad Request");

            return Ok(result);
        }
    }
}