using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WhosInSpace {
	[Serializable]
	class Astros {
		[JsonPropertyName("message")]
		public string Message { get; set; }

		[JsonPropertyName("people")]
		public List<Astronaut> Astronauts { get; set; }

		[JsonPropertyName("number")]
		public int Number { get; set; }

		public static Astros CreateExample() {
			Astros astros = new Astros();
			astros.Astronauts.Add(new Astronaut() {
				Name = "Ozzy",
				Craft = "ISS"
			});
			astros.Astronauts.Add(new Astronaut() {
				Name = "Clove",
				Craft = "ISS"
			});
			astros.Astronauts.Add(new Astronaut() {
				Name = "Nooki",
				Craft = "ISS"
			});
			astros.Astronauts.Add(new Astronaut() {
				Name = "Jack",
				Craft = "ISS"
			});
			astros.Astronauts.Add(new Astronaut() {
				Name = "Jake",
				Craft = "ISS"
			});
			return astros;
		}

		public Astros() {
			Astronauts = new List<Astronaut>();
		}

		public override string ToString() {
			return string.Format("<Astros {0}>", Astronauts.Count);
		}
	}

	[Serializable]
	class Astronaut {
		[JsonPropertyName("craft")]
		public string Craft { get; set; }
		[JsonPropertyName("name")]
		public string Name { get; set; }

		public override string ToString() {
			return string.Format("<Astronaut {0} {1}>", Name, Craft);
		}
	}
}
