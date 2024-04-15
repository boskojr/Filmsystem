using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using MovieAPI.Data;
using MovieAPI.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TMDBController : ControllerBase
    {

        [HttpGet("Search/Movie/{query}")]
        public async Task <ActionResult> SearchMovie(string query) // Hämtar en film från extern api
        {
            var url = $"https://api.themoviedb.org/3/search/movie?query={query}&api_key=24377ceb837b7c064232689c164ae042";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            var apiResponse = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<TMDBMovieResponse>(apiResponse);

            var resultList = json.Results.Select(x => new TMDBMovieInformation
            {
                Adult = x.Adult,
                BackdropPath = x.BackdropPath,
                ID = x.ID,
                Language = x.Language,
                OrginalTitle = x.OrginalTitle,
                Overview = x.Overview,
                Popularity = x.Popularity,
                PosterPath = x.PosterPath,
                ReleaseDate = x.ReleaseDate,
                Video = x.Video,
                VoteAverage = x.VoteAverage
            }).ToList();

            var tmdMovie = new TMDBMovieResponse
            {
                Page = json.Page,
                Results = resultList,
                TotalPages = json.TotalPages,
                TotalResults = json.TotalResults,
            };
           

            return Ok(tmdMovie);


        }
            
            
        }
       
    }
