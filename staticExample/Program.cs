using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticExample {
	class Program {
		static void Main(string[] args) {

			Technology Git = new Technology {
				Name = "Git/GitHub",
				Difficulty = 5
			};
			Technology.Counter = 1;

			Technology SQL = new Technology {
				Name = "SQL Server",
				Difficulty = 4
			};
		}
	}
}
