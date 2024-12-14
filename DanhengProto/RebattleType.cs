using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D81 RID: 3457
	public enum RebattleType
	{
		// Token: 0x04003BF0 RID: 15344
		[OriginalName("REBATTLE_TYPE_NONE")]
		None,
		// Token: 0x04003BF1 RID: 15345
		[OriginalName("REBATTLE_TYPE_REBATTLE_MIDWAY")]
		RebattleMidway,
		// Token: 0x04003BF2 RID: 15346
		[OriginalName("REBATTLE_TYPE_REBATTLE_LOSE")]
		RebattleLose,
		// Token: 0x04003BF3 RID: 15347
		[OriginalName("REBATTLE_TYPE_REBATTLE_MIDWAY_LINEUP")]
		RebattleMidwayLineup,
		// Token: 0x04003BF4 RID: 15348
		[OriginalName("REBATTLE_TYPE_REBATTLE_LOSE_LINEUP")]
		RebattleLoseLineup,
		// Token: 0x04003BF5 RID: 15349
		[OriginalName("REBATTLE_TYPE_QUIT_MIDWAY")]
		QuitMidway,
		// Token: 0x04003BF6 RID: 15350
		[OriginalName("REBATTLE_TYPE_QUIT_LOSE")]
		QuitLose
	}
}
