using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProjekat.Model
{
	public class Switch
	{
		private long gid;
		private long switchCircuit;
		private long xCoordinate;
		private long yCoordinate;

		public long Gid
		{
			get { return gid; }
			set { gid = value; }
		}

		public long SwitchCircuit
		{
			get { return switchCircuit; }
			set { switchCircuit = value; }
		}

		public long XCoordinate
		{
			get { return xCoordinate; }
			set { xCoordinate = value; }
		}

		public long YCoordinate
		{
			get { return yCoordinate; }
			set { yCoordinate = value; }
		}

		public Switch() { }

		public Switch(long gid, long switchCircuit, long xCoordinate, long yCoordinate)
		{
			this.Gid = gid;
			this.SwitchCircuit = switchCircuit;
			this.XCoordinate = xCoordinate;
			this.YCoordinate = yCoordinate;
		}
	}
}
