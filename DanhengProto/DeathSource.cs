using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200036B RID: 875
	public enum DeathSource
	{
		// Token: 0x04000FC2 RID: 4034
		[OriginalName("UNKNOWN")]
		Unknown,
		// Token: 0x04000FC3 RID: 4035
		[OriginalName("KILLED_BY_OTHERS")]
		KilledByOthers,
		// Token: 0x04000FC4 RID: 4036
		[OriginalName("KILLED_BY_SELF")]
		KilledBySelf,
		// Token: 0x04000FC5 RID: 4037
		[OriginalName("ESCAPE")]
		Escape
	}
}
