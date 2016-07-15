using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount_Endil.Models {
	class Stage {
		public List<Juror> Jury { get; }
		public int Problem { get; }
		public List<int> Rejects { get; }
		public TeamMember Reporter { get; }
		public TeamMember Opponent { get; }
		public TeamMember Reviewer { get; }
		public Grades ReporterGrades { get; }
		public Grades OpponentGrades { get; }
		public Grades ReviewerGrades { get; }

	}
}
