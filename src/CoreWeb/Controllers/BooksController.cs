using System.Collections.Generic;
using Arkdj.Chronicle.Model;
using Marten;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Arkdj.Chronicle.Web.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private ILogger _logger;
        private readonly IDocumentStore _documentStore;
                
        public BooksController(ILoggerFactory loggerFactory, IDocumentStore documentStore)
        {
            _logger = loggerFactory.CreateLogger(nameof(BooksController));
            _documentStore = documentStore;
        }
        // GET api/book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            _logger.LogDebug("Getting books.");
            using(var session = _documentStore.QuerySession())
            {
                return session.Query<Book>();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            var me = new User()
            {
                FirstName = "Dan",
                LastName = "Frank",
                Email = "danthehitman@gmail.com"
            };

            var book = new Book()
            {
                Name = "Test Book",
                Description = "This is a description of the amazing Test Book"
            };

            var pages = new List<Page>
            {
                new Page() {
                    Description = "Page discription.",
                    Author = me,
                    Title = "Test page.",
                    Entries = new List<Entry>()
                    {
                        new Entry()
                        {
                            Title = "Test entry.", Category = EntryCategory.Article, Text = "This is some test text.  An article maybe.",
                            Comments = new List<Comment>()
                            {
                                new Comment()
                                {
                                    Title = "This is a comment.", Body = "This is my comment.", Author = me
                                
                                }
                            }
                        }
                    }
                }
            };
            book.Pages = pages;
            using (var session = _documentStore.OpenSession())
            {
                session.Store(me);
                session.Store(book);
                session.SaveChanges();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
