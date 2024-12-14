using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001019 RID: 4121
	public enum RogueTournSettleReason
	{
		// Token: 0x04004A3D RID: 19005
		[OriginalName("ROGUE_TOURN_SETTLE_REASON_NONE")]
		None,
		// Token: 0x04004A3E RID: 19006
		[OriginalName("ROGUE_TOURN_SETTLE_REASON_WIN")]
		Win,
		// Token: 0x04004A3F RID: 19007
		[OriginalName("ROGUE_TOURN_SETTLE_REASON_FAIL")]
		Fail,
		// Token: 0x04004A40 RID: 19008
		[OriginalName("ROGUE_TOURN_SETTLE_REASON_INTERRUPT")]
		Interrupt
	}
}
