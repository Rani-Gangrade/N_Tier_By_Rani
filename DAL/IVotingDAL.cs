using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IVotingDAL
    {
        List<Voting> GetAllStudentFromDB();
        //Voting GetStudentByIdFromDB(int id);
        Voting AddStudentToDB(Voting std);
        Voting DeleteStudentFromDB(int id);
        Voting UpdateStudentFromDB(Voting std);
    }
}
