using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticExample {

	class Technology {
		public enum DifficultyType {
			BabyStuff = 1, Easy, Normal, Hard, Excruciating
		}

		public static int Counter { get; set; } = 0;
		public int Id { get; set; }
		public string Name { get; set; }
		public DifficultyType Difficulty { get; set; }

		private void Initialization() {
			this.Id = ++Counter;
			this.Difficulty = DifficultyType.Normal;
		}

		//this is called a constructor
		public Technology() {
			Initialization();
		}

		//this is another (different) constructor
		public Technology(string Name) {
			Initialization();
			this.Name = Name;
		}

		//this is yet another (different) constructor
		public Technology(string Name, DifficultyType Difficulty) {
			Initialization();
			this.Name = Name;
			this.Difficulty = Difficulty;
		}
	}
}
