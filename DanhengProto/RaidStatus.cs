using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D71 RID: 3441
	public enum RaidStatus
	{
		// Token: 0x04003BBB RID: 15291
		[OriginalName("RAID_STATUS_NONE")]
		None,
		// Token: 0x04003BBC RID: 15292
		[OriginalName("RAID_STATUS_DOING")]
		Doing,
		// Token: 0x04003BBD RID: 15293
		[OriginalName("RAID_STATUS_FINISH")]
		Finish,
		// Token: 0x04003BBE RID: 15294
		[OriginalName("RAID_STATUS_FAILED")]
		Failed
	}
}
