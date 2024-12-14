using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E0B RID: 3595
	public enum RogueAreaStatus
	{
		// Token: 0x040041D9 RID: 16857
		[OriginalName("ROGUE_AREA_STATUS_LOCK")]
		Lock,
		// Token: 0x040041DA RID: 16858
		[OriginalName("ROGUE_AREA_STATUS_UNLOCK")]
		Unlock,
		// Token: 0x040041DB RID: 16859
		[OriginalName("ROGUE_AREA_STATUS_FIRST_PASS")]
		FirstPass,
		// Token: 0x040041DC RID: 16860
		[OriginalName("ROGUE_AREA_STATUS_CLOSE")]
		Close
	}
}
