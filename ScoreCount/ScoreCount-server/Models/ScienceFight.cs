using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount_Endil.Models {
	class ScienceFight {
		public Rules Rules { get; }
		public List<Team> Teams { get; }
		public List<int> Problems { get; }
		public List<Stage> Stages { get; }
		public Dictionary<Team, int> SumOfPoints { get; }
		public Dictionary<Team, double> CriterionOfVictory { get; }
		public Dictionary<Team, bool> HasRejects { get; }
		public Dictionary<Team, int> NP { get; }
	}
}
