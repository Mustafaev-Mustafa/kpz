using Microsoft.AspNetCore.Mvc;
using Models;

namespace Mustafaiev.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SongController : Controller
    {
        ExamContext dbContext = new ExamContext();
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Songs);
        }
        [HttpPut]
        public IActionResult Put(string name, string path)
        {
            dbContext.Songs.Add(new Song() { Name = name, Path = path});
            dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Song song = dbContext.Songs.Find(id);
            if(song != null)
            dbContext.Songs.Remove(song);
            foreach(Songs_Playlist songs_Playlist in dbContext.Songs_Playlists)
            {
                if(songs_Playlist.SongId == id)
                    dbContext.Songs_Playlists.Remove(songs_Playlist);
            }
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
