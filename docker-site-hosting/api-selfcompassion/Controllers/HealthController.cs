
using System;
using Microsoft.AspNetCore.Mvc;
using MyEmailApiService.Models;
using Azure;
using Azure.Communication.Email;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Security.Authentication;

namespace MyEmailApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        private IConfiguration _configuration;

        public HealthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Post([FromBody] HealthRequest healthRequest)
        {
            return Ok(new
            {
                TimeStamp = DateTime.Now.ToString(), 
                StatusMessage = healthRequest?.StatusMessage ?? "N/A", 
            });

        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                TimeStamp = DateTime.Now.ToString(),
            });

        }

    }
}
