using Construction_ERP.Data;
using Construction_Management_Project_Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction_ERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RollController : ControllerBase
    {
        public readonly Context Context; 

        public RollController(Context Context)
        {
           Context = Context;
        }

        [HttpPost]
        public async Task<IActionResult> RollPost([FromBody] Roll_Model model)
        {
            string strData = "Roll_ID:" + model.Roll_Id
                           + " Roll_Name:" + model.Roll_Name
                           + " Remark:" + model.Remark;

            try
            {
               
                return Ok(new { Message = "Roll saved successfully", Roll_Model = model });
            }
            catch (Exception ex)
            {
                var log = new ErrorLog_Model
                {
                    ErrorLog_Id = 0,
                    ErrorLog_Date = DateTime.Now,
                    controller_name = "RollController",
                    ActionMethodName = "RollPost",
                    Data = strData + "|Exception:" + ex.Message,
                    Flag = 0
                };
                Context.ErrorLog_Table.Add(log);

                return BadRequest(new { Error = ex.Message });
            }
            finally
            {
                
            }

        }
    }
}
