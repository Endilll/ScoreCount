using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ScoreCount_Endil.Models {
	class Team {
		public int ID { get; }
		public string Name { get; }
		public RegionInfo Country { get; }
		public List<TeamMember> Members { get; }
		public Juror Tutor { get; }
		public int RejectsTotal { get; }
	}
}
