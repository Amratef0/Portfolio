using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;
using Portfolio.Interfaces;

namespace Portfolio.Repositories.ReservationSyst.Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly Applicationdbcontext _context;

        public ContactRepository(Applicationdbcontext context)
        {
            _context = context;
        }

        public void Add(ContactUs contact)
        {
            _context.ContactUs.Add(contact);
            _context.SaveChanges();
        }
    }
}
