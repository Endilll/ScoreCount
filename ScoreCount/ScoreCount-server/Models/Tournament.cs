using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount_Endil.Models {
	class Tournament {
		public List<Juror> Jury { get; }
		public List<Team> Teams { get; }
		public Introduction Introduction { get; }
		public List<ScienceFight> ScienceFights { get; }
	}
}
