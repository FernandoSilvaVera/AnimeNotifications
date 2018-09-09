using System.Collections.Generic;

namespace Anime.Models
{
    public class Anime
    {
		public string Nombre { get; set; }

		public int Capitulos { get; set; }

		public string Descripcion { get; set; }

		public List<Chapter> Chapters { get; set; }

	}
}
