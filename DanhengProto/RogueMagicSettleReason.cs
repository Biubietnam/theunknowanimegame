using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F1B RID: 3867
	public enum RogueMagicSettleReason
	{
		// Token: 0x0400464F RID: 17999
		[OriginalName("ROGUE_MAGIC_SETTLE_REASON_NONE")]
		None,
		// Token: 0x04004650 RID: 18000
		[OriginalName("ROGUE_MAGIC_SETTLE_REASON_WIN")]
		Win,
		// Token: 0x04004651 RID: 18001
		[OriginalName("ROGUE_MAGIC_SETTLE_REASON_FAIL")]
		Fail,
		// Token: 0x04004652 RID: 18002
		[OriginalName("ROGUE_MAGIC_SETTLE_REASON_INTERRUPT")]
		Interrupt
	}
}
