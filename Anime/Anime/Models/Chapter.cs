using System;
using System.Collections.Generic;
using System.Text;

namespace Anime.Models
{
    public class Chapter
    {
		#region Properties
		public int Number { get; set; }
		#endregion
		public Chapter(int number) => Number = number;
    }
}
