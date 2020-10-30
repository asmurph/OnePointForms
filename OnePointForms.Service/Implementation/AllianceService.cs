using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnePointForms.Entity;
using OnePointForms.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnePointForms.Service.Implementation
{
    public class AllianceService : IAllianceService
    {
        private readonly OnePointDbContext _context;
        public AllianceService(OnePointDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(AllianceRequest newAllianceRequest)
        {
           await _context.AllianceRequests.AddAsync(newAllianceRequest);
           await _context.SaveChangesAsync();
        }

        public Task Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public AllianceRequest GetById(int ID)
        {
            throw new NotImplementedException();
        }

        //}
        public IEnumerable<SelectListItem> GetDLLocs()
        {
           
                List<SelectListItem> dlto = _context.DeliverToLocations.AsNoTracking()
                    .OrderBy(n => n.Choice)
                        .Select(n =>
                        new SelectListItem
                        {
                            Value = n.DeliverToLocationID.ToString(),
                            Text = n.Choice
                        }).ToList();
                var countrytip = new SelectListItem()
                {
                    Value = null,
                    Text = "--- select DeliverToLocation ---"
                };
                dlto.Insert(0, countrytip);
                return new SelectList(dlto, "Value", "Text");
            
        }
        public IEnumerable<SelectListItem> GetGLDEPTS()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetLocations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetNaturalExpense()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetUnits()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AllianceRequest alliance)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
