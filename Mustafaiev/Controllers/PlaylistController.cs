using Microsoft.AspNetCore.Mvc;
using Models;

namespace Mustafaiev.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlaylistController : Controller
    {
        ExamContext dbContext = new ExamContext();

        [HttpPut]
        public IActionResult Put(string name, List<int> songs)
        {
            Playlist playlist = new Playlist() { Name = name };
            dbContext.Playlists.Add(playlist);
            int i = dbContext.Playlists.OrderBy(x=>x.Id).Last().Id+1;
            foreach(var song in songs)
            {
                dbContext.Songs_Playlists.Add(new Songs_Playlist() {PlaylistId = i, SongId = song});
            }
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
