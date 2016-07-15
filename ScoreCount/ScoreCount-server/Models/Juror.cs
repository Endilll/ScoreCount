using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount_Endil.Models {
	class Juror {
		public string Name { get; }
		public string Surname { get; }
		//public Country { get;}
		public bool IsPresent { get; set; }
		public bool IsIndependent { get; set; }
	}
}
