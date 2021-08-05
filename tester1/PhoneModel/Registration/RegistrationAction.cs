using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Data;
using tester1.Models;

namespace tester1.PhoneModel.Registration
{
    public class RegistrationAction
    {
        private readonly ApplicationDbContext _context;
        public RegistrationAction(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ApplicationUser> AddUpdateFullName(Registration1PM registration1PM)
        {
            if (string.IsNullOrEmpty(registration1PM.UserId))
            {
                ApplicationUser user = new ApplicationUser() { Name = registration1PM.FullName };
                await _context.ApplicationUsers.AddAsync(user);
                _context.SaveChanges();
                return user;
            }
            else
            {
                ApplicationUser user = _context.ApplicationUsers.FirstOrDefault(x => x.Id == registration1PM.UserId);
                user.Name = registration1PM.FullName;
                _context.SaveChanges();
                return user;
            }

        }

        public async Task<Registration1PM> GetFullName(string UserId)
        {
            if (!string.IsNullOrEmpty(UserId))
            {
                var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == UserId);
                return new Registration1PM() { FullName = user.Name, UserId = user.Id };
            }
            else
            {
                return new Registration1PM();
            }
        }

        public async Task<Registration2PM> UpdateCountry(Registration2PM reg)
        {
            if (string.IsNullOrEmpty(reg.Country))
            {
                var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == reg.UserId);
                user.Country = reg.Country;
                _context.SaveChanges();

            }
            return reg;
        }

        public async Task<Registration2PM> GetCountry(string UserId)
        {
            if (!string.IsNullOrEmpty(UserId))
            {
                var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == UserId);
                return new Registration2PM() { Country = user.Country, UserId = user.Id };

            }
            return new Registration2PM();
        }

        public async Task<Registration3PM> AddUpdateGender(Registration3PM reg3pm)
        {
            if (string.IsNullOrEmpty(reg3pm.Gender))
            {
                var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == reg3pm.UserId);
                user.Gender = reg3pm.Gender;
                _context.SaveChanges();
            }
            return reg3pm;

        }

        public async Task<Registration3PM> GetGender(string UserId)
        {
            if (!string.IsNullOrEmpty(UserId))
            {
                var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == UserId);
                return new Registration3PM() { Gender = user.Gender, UserId = user.Id };

            }
            return new Registration3PM();
        }

        public async Task<Registration4PM> AddUpdateDOB(Registration4PM registration)
        {
            var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == registration.UserId);
            if (user != null)
            {
                user.Dob = registration.DateOfBirth;
            }
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<Registration4PM> GetDateOfBirth(string UserId)
        {
            var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == UserId);
            return new Registration4PM { DateOfBirth = (DateTime)user.Dob, UserId = user.Id };
        }




        public async Task<Registration5PM> AddUpdateHeight(Registration5PM registration)
        {
            var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == registration.UserId);
            if (user != null)
            {
                user.Height = registration.Height;
            }
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<Registration5PM> GetHeight(string UserId)
        {
            var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == UserId);
            return new Registration5PM { Height =(int)user.Height, UserId = user.Id };
        }


        public async Task<Registration6PM> AddUpdateWeight(Registration6PM registration)
        {
            var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == registration.UserId);
            if (user != null)
            {
                user.Weight= registration.Weight;
            }
            await _context.SaveChangesAsync();
            return registration;
        }

        public async Task<Registration6PM> GetWeight(string UserId)
        {
            var user = await _context.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == UserId);
            return new Registration6PM { Weight = (int)user.Weight, UserId = user.Id };
        }






    }
}
