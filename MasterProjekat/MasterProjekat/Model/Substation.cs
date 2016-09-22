using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterProjekat.Model
{
	public class Substation
	{
		private long gid;
		private List<long> childFeeders;
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
		public List<long> ChildFeeders
		{
			get { return childFeeders; }
			set { childFeeders = value; }
		}

		public long Gid
		{
			get { return gid; }
			set { gid = value; }
		}

		public Substation(long gid, List<long> childFeeders, long xCoordinate, long yCoordinate)
		{
			this.Gid = gid;
			this.ChildFeeders = childFeeders;
			this.XCoordinate = xCoordinate;
			this.YCoordinate = yCoordinate;
		}
	}
}
