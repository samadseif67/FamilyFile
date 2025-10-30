using FamilyFile.Application.Dto;
using FamilyFile.Application.Services.FamilyMemberUseCase;
using FamilyFile.Application.Services.PersonnelUseCase;
using FamilyFile.Domain.Interfaces;
using FamilyFile.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FamilyFile.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFamilyMemberService _familyMemberService;
        private readonly IPersonnelService _personnelService;
        public HomeController(IFamilyMemberService familyMemberService, IPersonnelService personnelService)
        {
            _familyMemberService = familyMemberService;
            _personnelService = personnelService;
        }

        public IActionResult Index()
        {
            return View();
        }


        #region Personnel
        public ActionResult GetAllPersonnel()
        {
            var result = _personnelService.GetAllPersonnel();
            return Ok(result);
        }

        public ActionResult GetPersonnel(Guid personnelId)
        {
            var result = _personnelService.GetPersonnel(personnelId);
            return Ok(result);
        }

        public async Task<ActionResult> SavePersonnel(PersonnelData personnelData)
        {
            var result =await _personnelService.SavePersonnel(personnelData);
            return Ok(result);
        }


        public ActionResult DeletePersonnel(Guid personnelId)
        {
            var result = _personnelService.DeletePersonnel(personnelId);
            return Ok(result);
        }
        #endregion Personnel

        #region FamilyMember

        public ActionResult GetAllFamilyMember(Guid personnelId)
        {
            var result = _familyMemberService.GetAllFamilyMember(personnelId);
            return Ok(result);
        }

        public ActionResult GetFamilyMember(Guid familyMemberId)
        {
            var result = _familyMemberService.GetFamilyMember(familyMemberId);
            return Ok(result);
        }

        public ActionResult DeleteFamilyMember(Guid familyMemberId)
        {
            var result = _familyMemberService.DeleteFamilyMember(familyMemberId);
            return Ok(result);
        }

        public async Task<ActionResult> SaveFamilyMember(FamilyMemberData familyMemberData)
        {
            var result =await _familyMemberService.SaveFamilyMember(familyMemberData);
            return Ok(result);
        }
        #endregion FamilyMember



    }
}
