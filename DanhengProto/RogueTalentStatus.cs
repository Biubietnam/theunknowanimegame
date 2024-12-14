using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F7D RID: 3965
	public enum RogueTalentStatus
	{
		// Token: 0x040047DC RID: 18396
		[OriginalName("ROGUE_TALENT_STATUS_LOCK")]
		Lock,
		// Token: 0x040047DD RID: 18397
		[OriginalName("ROGUE_TALENT_STATUS_UNLOCK")]
		Unlock,
		// Token: 0x040047DE RID: 18398
		[OriginalName("ROGUE_TALENT_STATUS_ENABLE")]
		Enable
	}
}
