using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data;
using BackEnd.Repository;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly SpeakerRepository _speakerRepository;

        public SpeakersController(ApplicationDbContext context, SpeakerRepository speakerRepository)
        {
            _context = context;
            _speakerRepository = speakerRepository;
        }

        // GET: api/Speakers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConferenceDTO.SpeakerResponse>>> GetSpeakers()
        {
            var speakersList = await _speakerRepository.ListAsync();
            var speakers = speakersList.Select(s => s.MapSpeakerResponse()).ToList();
            return speakers;
        }

        // GET: api/Speakers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConferenceDTO.SpeakerResponse>> GetSpeaker(int id)
        {
            var speaker = await _speakerRepository.GetByIdAsync<Speaker>(id);
            if (speaker == null)
            {
                return NotFound();
            }
            return speaker.MapSpeakerResponse();
        }

    }
}
