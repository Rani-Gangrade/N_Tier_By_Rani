using DAL.Model;
using DAL_Data_Access_Layer_.DbContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VotingDAL : IVotingDAL
    {
        private readonly VotingDBContext _context;
        public VotingDAL(VotingDBContext context)
        {
            _context = context;
        }

        public Voting AddStudentToDB(Voting std)
        {
            _context.Votings.Add(std);
            _context.SaveChanges();
            return std;
        }

        public Voting DeleteStudentFromDB(int id)
        {
            var data = _context.Votings.Find(id);
            if (data != null)
            {
                _context.Votings.Remove(data);
                _context.SaveChanges();
            }
            return data;
        }

        public List<Voting> GetAllStudentFromDB()
        {
            var result = _context.Votings.OrderBy(x => x.Id).ToList();
            return result;
        }

        //public Voting GetStudentByIdFromDB(int id)
        //{
        //    var data = _context.Votings.FirstOrDefault(x => x.Id == id);
        //    return data;
        //}

        public Voting UpdateStudentFromDB(Voting std)
        {

            _context.Votings.Update(std);
            _context.SaveChanges();

            return std;
        }


    }
}