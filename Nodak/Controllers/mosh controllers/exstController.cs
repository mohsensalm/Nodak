using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Nodak.Data;
using Nodak.Models;

namespace Nodak.Controllers.mosh_controllers
{
    public class exstController : ApiController
    {
        private NodakContext _context;

        public exstController()
        {
            _context = new NodakContext();
        }

        public IEnumerable<Student> GeStudents()
        {
            return _context.Students;
        }

        public async Task<Student> GetStudent(Guid id)
        {
            var student = _context.Students.FirstOrDefaultAsync(i => i.Id == id);
            if (student == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return await student;
        }
        [HttpPost]
        public async Task<Student> AddStudent(Student student)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        [HttpPut]
        public void PutStudent(Guid id, Student student)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var studentInDb = _context.Students.SingleOrDefault(i => i.Id == id);
            if (studentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            studentInDb.Family = student.Name;
            studentInDb.Family = student.Family;
             _context.SaveChangesAsync();
               }

        [HttpDelete]
        public void DeleteStudent(Guid id)
        {
            var studentInDb = _context.Students.SingleOrDefault(i => i.Id == id);
            if (studentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Students.Remove(studentInDb);
            _context.SaveChangesAsync();
        }

    }
}
