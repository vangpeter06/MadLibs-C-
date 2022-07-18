using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/home")]
      public ActionResult Home() {return View(); }

    [Route("/story")]
    public ActionResult Story(string name, string verb, string place, string noun)
    {
      Winnie helloWinnie = new Winnie();
      helloWinnie.Name = name;
      helloWinnie.Verb = verb;
      helloWinnie.Place = place;
      helloWinnie.Noun = noun;
      return View(helloWinnie);
    }

    [Route("/form")]
    public ActionResult Form() {return View(); }
    
    [Route("/storyTwo")]
    public ActionResult StoryTwo(string name, string verb, string place)
    {
      Winnie helloWinnie = new Winnie();
      helloWinnie.Name = name;
      helloWinnie.Verb = verb;
      helloWinnie.Place = place;
      return View(helloWinnie);
    }

    [Route("/formTwo")]
    public ActionResult FormTwo() {return View(); }
  }
}