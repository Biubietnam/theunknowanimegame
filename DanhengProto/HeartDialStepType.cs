using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008A5 RID: 2213
	public enum HeartDialStepType
	{
		// Token: 0x040025FA RID: 9722
		[OriginalName("HEART_DIAL_STEP_TYPE_MISSING")]
		Missing,
		// Token: 0x040025FB RID: 9723
		[OriginalName("HEART_DIAL_STEP_TYPE_FULL")]
		Full,
		// Token: 0x040025FC RID: 9724
		[OriginalName("HEART_DIAL_STEP_TYPE_LOCK")]
		Lock,
		// Token: 0x040025FD RID: 9725
		[OriginalName("HEART_DIAL_STEP_TYPE_UNLOCK")]
		Unlock,
		// Token: 0x040025FE RID: 9726
		[OriginalName("HEART_DIAL_STEP_TYPE_NORMAL")]
		Normal,
		// Token: 0x040025FF RID: 9727
		[OriginalName("HEART_DIAL_STEP_TYPE_CONTROL")]
		Control
	}
}
