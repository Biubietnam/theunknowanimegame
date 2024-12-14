using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F75 RID: 3957
	public enum RogueStatus
	{
		// Token: 0x040047BE RID: 18366
		[OriginalName("ROGUE_STATUS_NONE")]
		None,
		// Token: 0x040047BF RID: 18367
		[OriginalName("ROGUE_STATUS_DOING")]
		Doing,
		// Token: 0x040047C0 RID: 18368
		[OriginalName("ROGUE_STATUS_PENDING")]
		Pending,
		// Token: 0x040047C1 RID: 18369
		[OriginalName("ROGUE_STATUS_ENDLESS")]
		Endless,
		// Token: 0x040047C2 RID: 18370
		[OriginalName("ROGUE_STATUS_FINISH")]
		Finish
	}
}
