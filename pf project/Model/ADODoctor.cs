using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pf_project.Model
{
    class ADODoctor
    {
        SqlConnection _sqlConn = new SqlConnection(@"Data Source=DESKTOP-VE0AM6G\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand _cmd;


        public List<Doctor> GetAllData()
        {
            _sqlConn.Open();
            _cmd = new SqlCommand("SELECT * FROM DOCTORS", _sqlConn);
            SqlDataReader _reader = _cmd.ExecuteReader();

            List<Doctor> _data = new List<Doctor>();

            while (_reader.Read())
            {
                _data.Add(new Doctor(_reader.GetInt32(0), _reader.GetString(1), _reader.GetInt32(2), _reader.GetString(3), _reader.GetString(4) ) ) ;
            }
            _sqlConn.Close();
            return _data;
        }

        public void EnterDoctor(string name , int age , string qualific, string special)
        {
            _sqlConn.Open();
            _cmd = new SqlCommand("INSERT INTO DOCTORS VALUES(@NAME, @AGE, @QUALIFICATION, @SPECIALIST)");
            _cmd.Parameters.Add("@NAME", name);
            _cmd.Parameters.Add("@AGE", age);
            _cmd.Parameters.Add("@QUALIFICATION", qualific);
            _cmd.Parameters.Add("@SPECIALIST", special);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();
        }


    }
}
