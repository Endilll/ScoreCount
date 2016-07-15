using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount_Endil.Models {
	class Rules {
		public bool IsProblemPredefined { get; }
		public bool IsNTApplied { get; }
		public bool IsNPApplied { get; }
		public bool IsNRApplied { get; }
		public List<Phase> Reglament { get; }
	}
}
