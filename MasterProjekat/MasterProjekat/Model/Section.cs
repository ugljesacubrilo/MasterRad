using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProjekat.Model
{
	public class Section
	{
		private long gid;
		private long circuit;
		private List<Vertice> coordinates;

		public List<Vertice> Coordinates
		{
			get { return coordinates; }
			set { coordinates = value; }
		}

		public long Circuit
		{
			get { return circuit; }
			set { circuit = value; }
		}

		public long Gid
		{
			get { return gid; }
			set { gid = value; }
		}

		public Section(long gid, long circuit, List<Vertice> coordinates)
		{
			this.gid = gid;
			this.circuit = circuit;
			this.coordinates = coordinates;
		}
	}
}
