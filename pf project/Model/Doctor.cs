using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pf_project.Model
{
    public class Doctor
    {
        public int id;
        public string name;
        public int age;
        public string qualification;
        public string specialist;

        public Doctor(int _id, string _name, int _age, string _qualification, string _specialist)
        {
            this.id = _id;
            this.name = _name;
            this.age = _age;
            this.qualification = _qualification;
            this.specialist = _specialist;
        }


    }
}
