using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF1 RID: 4081
	public enum RogueTournLevelStatus
	{
		// Token: 0x040049B1 RID: 18865
		[OriginalName("ROGUE_TOURN_LEVEL_STATUS_NONE")]
		None,
		// Token: 0x040049B2 RID: 18866
		[OriginalName("ROGUE_TOURN_LEVEL_STATUS_PROCESSING")]
		Processing,
		// Token: 0x040049B3 RID: 18867
		[OriginalName("ROGUE_TOURN_LEVEL_STATUS_FINISHED")]
		Finished,
		// Token: 0x040049B4 RID: 18868
		[OriginalName("ROGUE_TOURN_LEVEL_STATUS_SETTLED")]
		Settled
	}
}
