using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF1 RID: 3825
	public enum RogueMagicLevelStatus
	{
		// Token: 0x040045C7 RID: 17863
		[OriginalName("ROGUE_MAGIC_LEVEL_STATUS_NONE")]
		None,
		// Token: 0x040045C8 RID: 17864
		[OriginalName("ROGUE_MAGIC_LEVEL_STATUS_PROCESSING")]
		Processing,
		// Token: 0x040045C9 RID: 17865
		[OriginalName("ROGUE_MAGIC_LEVEL_STATUS_FINISHED")]
		Finished,
		// Token: 0x040045CA RID: 17866
		[OriginalName("ROGUE_MAGIC_LEVEL_STATUS_SETTLED")]
		Settled
	}
}
