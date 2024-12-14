using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BCB RID: 3019
	public enum MuseumRandomEventState
	{
		// Token: 0x04003330 RID: 13104
		[OriginalName("MUSEUM_RANDOM_EVENT_STATE_NONE")]
		None,
		// Token: 0x04003331 RID: 13105
		[OriginalName("MUSEUM_RANDOM_EVENT_STATE_START")]
		Start,
		// Token: 0x04003332 RID: 13106
		[OriginalName("MUSEUM_RANDOM_EVENT_STATE_PROCESSING")]
		Processing,
		// Token: 0x04003333 RID: 13107
		[OriginalName("MUSEUM_RANDOM_EVENT_STATE_FINISH")]
		Finish
	}
}
