using System.Linq;
using QTCC_QuanLyBenhVien.Model.DTO;
using QTCC_QuanLyBenhVien.Lib;
namespace QTCC_QuanLyBenhVien.Model.DAO
{
    // ReSharper disable once InconsistentNaming
    public class UserDAO
    {
        private readonly QLBenhVienDBContext _db;

        public UserDAO()
        {
            _db = new QLBenhVienDBContext();
        }

        public int Login(string username,string pwd)
        {
            var user = _db.Users.SingleOrDefault(x => x.Username == username);
            if (user != null)
            {
                if (user.Password.Equals(CustomMd5.MD5Hash(pwd)))
                {
                    return 1;
                }
                return 0;
            }
            return -1;
        }
    }
}
