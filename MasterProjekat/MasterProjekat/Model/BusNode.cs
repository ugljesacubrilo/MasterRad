using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProjekat.Model
{
	public class BusNode
	{
		private long gid;
		private long feeder;

		private long xCoordinate;
		private long yCoordinate;

		public long YCoordinate
		{
			get { return yCoordinate; }
			set { yCoordinate = value; }
		}

		public long XCoordinate
		{
			get { return xCoordinate; }
			set { xCoordinate = value; }
		}

		public long Feeder
		{
			get { return feeder; }
			set { feeder = value; }
		}

		public long Gid
		{
			get { return gid; }
			set { gid = value; }
		}

		public BusNode(long gid, long feeder, long xCoordinates, long yCoordinates)
		{
			this.Gid = gid;
			this.Feeder = feeder;
			this.XCoordinate = xCoordinate;
			this.YCoordinate = yCoordinate;
		}
	}
}
