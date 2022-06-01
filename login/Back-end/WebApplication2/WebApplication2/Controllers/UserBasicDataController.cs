using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBasicDataController : ControllerBase
    {
        /*private string StringConnection = "Data Source=DESKTOP-DSIKKRM\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected SqlConnection DbConnection()
        {
            return new SqlConnection(StringConnection);
        }*/

        [HttpGet]
        public async Task<IActionResult> Get() //async Task<IActionResult> Get()
        {
            try
            {

                var db = new SqlConnection("Data Source=DESKTOP-DSIKKRM\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                var sql = @"
                            SELECT UserEmail, UserKeyword FROM UserBasicData";

                var listUsuarios = await db.QueryAsync<UserBasicData>(sql.ToString(), new { });

                return Ok(listUsuarios);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{useremail}")]
        public async Task<IActionResult> Get(string useremail)
        {
            try
            {

                var db = new SqlConnection("Data Source=DESKTOP-DSIKKRM\\SQLEXPRESS;Initial Catalog=TestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                var sql = @"
                            SELECT UserEmail, UserKeyword 
                              FROM UserBasicData
                             WHERE UserEmail = @useremail";
                               //AND UserKeyword = @userkeyword";

                var listUsuarios = await db.QueryAsync<UserBasicData>(sql.ToString(), new { UserEmail = useremail });

                /*if(listUsuarios.Count() > 0)
                {*/
                    return Ok(listUsuarios);
                //}
                /*else
                {
                    return BadRequest();
                }*/
                

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }

}
