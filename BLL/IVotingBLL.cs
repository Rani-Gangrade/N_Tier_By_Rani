using DAL.Model;
namespace BLL
{
    public interface IVotingBLL
    {
        List<Voting> GetAllStudentsFromDAL();
        //Voting GetStudentByIdFromDAL(int id);
        Voting AddStudentToDAL(Voting std);
        Voting DeleteStudentFromDAL(int id);
        Voting UpdateStudentFromDAL(Voting std);
    }
}
