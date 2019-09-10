using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Winap.Controllers
{
    public abstract class WinnerController<T> : ControllerBase
    {
        [HttpGet("all")]
        public abstract ActionResult<List<T>> GetAll();
        
        [HttpPost] 
        public abstract int Create(T entity);
    }
}