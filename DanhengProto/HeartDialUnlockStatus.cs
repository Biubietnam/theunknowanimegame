using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008AB RID: 2219
	public enum HeartDialUnlockStatus
	{
		// Token: 0x0400260E RID: 9742
		[OriginalName("HEART_DIAL_UNLOCK_STATUS_LOCK")]
		Lock,
		// Token: 0x0400260F RID: 9743
		[OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_SINGLE")]
		UnlockSingle,
		// Token: 0x04002610 RID: 9744
		[OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_ALL")]
		UnlockAll
	}
}
