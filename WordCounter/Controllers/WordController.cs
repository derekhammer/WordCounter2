using Microsoft.AspNetCore.Mvc;
using WordCounter;

namespace WordCounter.Controllers
{
  public class WordController : Controller
{
  [HttpGet("/Word/index")]
  public ActionResult Index()
  {
    words newWords = new words();
    return View(newWords.GetScore());
  }
  [HttpPost("/Word/index")]
  public ActionResult Count()
  {
    words newWords = new words();
    newWords.SetParagraph(Request.Form["inputPara"]);
    newWords.SetWord(Request.Form["inputWord"]);
    newWords.Compare();
    return View("index", newWords.GetScore());
  }
}
}
