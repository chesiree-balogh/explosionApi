using System;
using Microsoft.AspNetCore.Mvc;

namespace explosionApi.Mumbling
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("mumbling")]
    public string Accum(string s)
    {
      // s.toLower()
      s = s.ToLower();
      // index = 0
      var timesToRepeatTheLetter = 1;
      var answerString = "";
      // foreach letter in s
      foreach (var letter in s)
      {
        //.  repeat the letter timesToRepeatTheLetter times
        for (var i = 0; i < timesToRepeatTheLetter; i++)
        {
          if (i == 0)
          {
            answerString += letter.ToString().ToUpper();
          }
          else
          {
            answerString += letter;
          }
        }
        answerString += "-";
        timesToRepeatTheLetter++;
      }
      //.  toTitleCase
      //   add to a list
      //.  index++
      return answerString.TrimEnd('-');
    }
  }
}