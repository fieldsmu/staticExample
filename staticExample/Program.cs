using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticExample {
	class Program {
		static void Main(string[] args) {

			Technology Git = new Technology() {
				Name = "Git/GitHub",
				Difficulty = Technology.DifficultyType.Easy
			};

			Technology SQL = new Technology() {
				Name = "SQL Server",
				Difficulty = Technology.DifficultyType.Easy
			};

			Technology CSharp = new Technology("CSharp Language", Technology.DifficultyType.Normal) {
			};

			Technology EF = new Technology("Entity Framework", Technology.DifficultyType.Easy) {
			};
		}
	}
}
