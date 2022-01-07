using LetsTalk.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LetsTalk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalkController : ControllerBase
    {
        private readonly Dictionary<SentenceType, ITalkCreatorService> _talkCreatorServices;

        public TalkController()
        {
            _talkCreatorServices = new Dictionary<SentenceType, ITalkCreatorService>
            {
                { SentenceType.Hi, new HiCreatorService() },
                { SentenceType.HowAreYou, new HowAreYouCreatorService() },
                { SentenceType.Thanks, new ThanksCreatorService() },
                { SentenceType.TakeCare, new TakeCareCreatorService() },
                { SentenceType.SeeYouLater, new SeeYouLaterCreatorService() }
            };
        }

        [HttpPost]
        public string Post([FromBody] Talk talk)
        {
            Enum.TryParse<SentenceType>(talk.sentence, out var type);
            return _talkCreatorServices[type].Say();
        }
    }
}
