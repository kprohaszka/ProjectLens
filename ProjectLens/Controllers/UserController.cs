using el_proyecte_grande_sprint_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
public class UserController : Controller
{

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }



    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult SignUp()
    {
        return View();
    }

}
