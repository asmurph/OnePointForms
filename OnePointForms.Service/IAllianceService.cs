using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnePointForms.Entity;
namespace OnePointForms.Service
{
    public interface IAllianceService
    {
        Task CreateAsync(AllianceRequest newAllianceRequest);
        AllianceRequest GetById(int ID);
        Task UpdateAsync(AllianceRequest alliance);
        Task UpdateAsync(int ID);
        Task Delete(int ID);
        IEnumerable<SelectListItem> GetDLLocs();
        IEnumerable<SelectListItem> GetUnits();
        IEnumerable<SelectListItem> GetGLDEPTS();
        IEnumerable<SelectListItem> GetNaturalExpense();
        IEnumerable<SelectListItem> GetLocations();
        //public IEnumerable<SelectListItem> GetLocations(string DelivetDeliverToLocationID);
    }
}
