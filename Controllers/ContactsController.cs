using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Couchbase.Core;
using Couchbase.Linq;
using Siakad.Data;
using Siakad.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Siakad.Controllers
{
    public class ContactsController : Controller
    {
        private BucketContext _bucketContext;
        public ContactsController(BucketContext bucketContext)
        {
            _bucketContext = bucketContext;
        }

        // GET: Contacts
        public ActionResult Index()
        {            
            var allContacts = _bucketContext
                .Query<Contact>()
                .Select(x => new ContactDto
                {
                   id = N1QlFunctions.Meta(x).Id,
                    Nama = x.Nama,
                    Nim = x.Nim,
                    Jurusan = x.Jurusan,
                    Fakultas=x.Fakultas,
                    DosenPembimbing=x.DosenPembimbing
                })
                .ToList();

            return View(allContacts);
        }

        // GET: Contacts/Details/5
        public ActionResult Details(string id)
        {
            var contact = _bucketContext
                .Query<Contact>()
                .Select(x => new ContactDto
                {
                    id = N1QlFunctions.Meta(x).Id,
                    Nama = x.Nama,
                    Nim = x.Nim,
                    Jurusan = x.Jurusan,
                    Fakultas=x.Fakultas,
                    DosenPembimbing=x.DosenPembimbing
                })
                .FirstOrDefault(x => x.id == id);
            return View(contact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactDto contactDto)
        {
            try
            {
                // TODO: Add insert logic here
                //contactsModel.Id = Guid.NewGuid().ToString();
                var contact = new Contact { id = Guid.NewGuid().ToString(), Nama = contactDto.Nama, Nim = contactDto.Nim ,Jurusan = contactDto.Jurusan,
                    Fakultas=contactDto.Fakultas,
                    DosenPembimbing=contactDto.DosenPembimbing };                
                _bucketContext.Save(contact);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.TryAddModelException("exception", e);
                return View();
            }
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(string id)
        {
            var contact = _bucketContext
                .Query<Contact>()
                .Select(x => new ContactDto
                {
                    id = N1QlFunctions.Meta(x).Id,
                    Nama = x.Nama,
                    Nim = x.Nim,
                    Jurusan = x.Jurusan,
                    Fakultas=x.Fakultas,
                    DosenPembimbing=x.DosenPembimbing
                })
                .FirstOrDefault(x => x.id == id);
            return View(contact);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, ContactDto contact)
        {
            try
            {
                // TODO: Add update logic here                
                _bucketContext.Save(new Contact { id =id, Nama = contact.Nama, Nim = contact.Nim ,Jurusan = contact.Jurusan,
                    Fakultas=contact.Fakultas,
                    DosenPembimbing=contact.DosenPembimbing }); 
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.TryAddModelException("exception", e);
                return View();
            }
        }

        // GET: Contacts/Delete/5                
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string id)
        {
            var contact = _bucketContext
                .Query<Contact>()
                .Select(x => new ContactDto
                {
                    id = N1QlFunctions.Meta(x).Id,
                    Nama = x.Nama,
                    Nim = x.Nim,
                    Jurusan = x.Jurusan,
                    Fakultas=x.Fakultas,
                    DosenPembimbing=x.DosenPembimbing
                })
                .FirstOrDefault(x => x.id == id);
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id)
        {
            try
            {
                // TODO: Add delete logic here
                var contact = _bucketContext.Query<Contact>().FirstOrDefault(x => N1QlFunctions.Meta(x).Id == id);
                if (contact == null)
                    return NotFound();
                contact.id = id;
                _bucketContext.Remove(contact);
                _bucketContext.SubmitChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                ModelState.AddModelError("error", e.Message);
                return View();
            }
        }
    }
}