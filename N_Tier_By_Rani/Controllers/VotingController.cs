using BLL;

using DAL.Model;
using Microsoft.AspNetCore.Mvc;
namespace N_Tier_By_Rani.Controllers
{
    public class VotingController : Controller
    {
        private readonly IVotingBLL _votingBLL;
        public VotingController(IVotingBLL votingBLL)
        {
            _votingBLL = votingBLL;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetData()
        {
            var data = _votingBLL.GetAllStudentsFromDAL();
            return Json(data);
        }
        [HttpPost]
        public IActionResult Create(Voting std)
        {
            if (ModelState.IsValid)
            {
                if (std.Age <18)
                {
                    ModelState.AddModelError("Age", "Age must be more then 18");
                }
                else
                {
                    var data = _votingBLL.AddStudentToDAL(std);
                    return Json(data);

                }
                
            }
            return Json(std);
        }

        [HttpPost]
        public IActionResult Edit(Voting std)
        {
            if (ModelState.IsValid)
            {
                var data = _votingBLL.UpdateStudentFromDAL(std);
                return Json(data);
            }
            return Json(std);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (Id > 0)
            {
                var data = _votingBLL.DeleteStudentFromDAL(Id);
                return Json(data);
            }
            return Json(Id);
        }





    }

}
