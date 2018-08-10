using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DnDManagerApi.Models;

namespace DnDManagerApi.Controllers
{
    public class PartyController : ControllerBase
    {
        [HttpGet]
        public Party Get()
        {
            return new Party();
        }
    }
}
