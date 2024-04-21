using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrudOperationinNetCore.Controllers.model;

namespace CrudOperationinNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaysCalculateController : ControllerBase
    {

        [HttpPost]
        [Route("DaysCalculate")]
        public string DaysCalculate(DaysCalculate daysCalculate)
        {

            if (daysCalculate.FromDate > daysCalculate.ToDate)
            {
                return "Start date must be before end date.";
            }


            TimeSpan difference = daysCalculate.ToDate - daysCalculate.FromDate;
            return difference.Days.ToString();


         //   return "OK";
        }


    }
}
