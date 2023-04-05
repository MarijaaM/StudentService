using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentListensSub
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public long SubjectId { get; set; }
        public int YearOfStudy { get; set; }
        public PassedOrNot PassedOrNot { get; set; }

    }
}
