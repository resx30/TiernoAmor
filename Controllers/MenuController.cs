using Microsoft.AspNetCore.Mvc;
using TiernoAmor.Models;

namespace TiernoAmor.Controllers;

public class MenuController : Controller
{
    public IActionResult Index() => View(MenuTiernoAmor.Productos);
}