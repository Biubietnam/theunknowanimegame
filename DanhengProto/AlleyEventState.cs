using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000083 RID: 131
	public enum AlleyEventState
	{
		// Token: 0x04000212 RID: 530
		[OriginalName("ALLEY_STATE_NONE")]
		AlleyStateNone,
		// Token: 0x04000213 RID: 531
		[OriginalName("ALLEY_EVENT_DOING")]
		AlleyEventDoing,
		// Token: 0x04000214 RID: 532
		[OriginalName("ALLEY_EVENT_FINISH")]
		AlleyEventFinish,
		// Token: 0x04000215 RID: 533
		[OriginalName("ALLEY_EVENT_REWARDED")]
		AlleyEventRewarded
	}
}
