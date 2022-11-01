using MovieRentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRent.Controllers
{
    public class MovieController : ApiController
    {
        movierent context;

        public MovieController()
        {
           context = new movierent();
        }
        // GET api/<controller>
        public List<Movie> Get()
        {

            return context.Movies.ToList();

        }


        // GET api/<controller>/5
        public Movie Get(int id)
        {
            return context.Movies.ToList().Find(m => m.MovieId == id);
        }

        // POST api/<controller>
        public void Post([FromBody] Movie m)
        {
            context.Movies.Add(m);

            context.SaveChanges();

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            Movie del =context.Movies.ToList().Find(m => m.MovieId == id);

            context.Movies.Remove(del);

            context.SaveChanges();

        }
    }
}