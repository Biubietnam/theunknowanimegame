using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E1 RID: 1505
	public enum GameplayCounterUpdateReason
	{
		// Token: 0x04001AA8 RID: 6824
		[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_NONE")]
		None,
		// Token: 0x04001AA9 RID: 6825
		[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_ACTIVATE")]
		Activate,
		// Token: 0x04001AAA RID: 6826
		[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_DEACTIVATE")]
		Deactivate,
		// Token: 0x04001AAB RID: 6827
		[OriginalName("GAMEPLAY_COUNTER_UPDATE_REASON_CHANGE")]
		Change
	}
}
