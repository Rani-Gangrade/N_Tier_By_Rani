using DAL;
using DAL.Model;

namespace BLL
{

    public class VotingBLL : IVotingBLL
    {
        private readonly IVotingDAL _votingDAL;
        public VotingBLL(IVotingDAL votingDAL)
        {
            _votingDAL = votingDAL;
        }

        public Voting AddStudentToDAL(Voting std)
        {
            var data = _votingDAL.AddStudentToDB(std);
            return data;
        }

        public Voting DeleteStudentFromDAL(int id)
        {
            var data = _votingDAL.DeleteStudentFromDB(id);
            return data;
        }

        public List<Voting> GetAllStudentsFromDAL()
        {
            return _votingDAL.GetAllStudentFromDB();
        }

        //public Voting GetStudentByIdFromDAL(int id)
        //{
        //    var data = _votingDAL.GetStudentByIdFromDB(id);
        //    return data;
        //}

        public Voting UpdateStudentFromDAL(Voting std)
        {
            var data = _votingDAL.UpdateStudentFromDB(std);
            return data;
        }



    }
}










