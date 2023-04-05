using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudyProgramExams
    {
        public long StudyProgramId { get; set; }
        public long SubjectId { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public Subject Subject { get; set; }
        public long Id { get; set; }

    }
}
