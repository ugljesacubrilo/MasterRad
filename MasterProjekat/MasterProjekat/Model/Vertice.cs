using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProjekat.Model
{
	public class Vertice
	{
		private long x;
		private long y;

		public long Y
		{
			get { return y; }
			set { y = value; }
		}

		public long X
		{
			get { return x; }
			set { x = value; }
		}

		public Vertice(long x, long y)
		{
			this.x = x;
			this.y = y;
		}
	}
}
