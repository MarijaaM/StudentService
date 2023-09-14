using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Model
{
    public class Exam
    {
        public long Id { get; set; }
        public string ClassRoom { get; set; }
        public Subject Subject { get; set; }
        public long SubjectId { get; set; }
        public DateTime Date { get; set; }
        public string ExaminationPeriod { get; set; }
    }
}
