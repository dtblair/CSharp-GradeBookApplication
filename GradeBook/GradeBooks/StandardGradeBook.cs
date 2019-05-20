using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {

        //constructor
        public StandardGradeBook(string name) :base(name)
        {
            this.Type = Enums.GradeBookType.Standard;
        }
    }
}
