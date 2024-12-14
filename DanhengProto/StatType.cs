using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E1 RID: 4577
	public enum StatType
	{
		// Token: 0x0400527E RID: 21118
		[OriginalName("STAT_TYPE_NONE")]
		None,
		// Token: 0x0400527F RID: 21119
		[OriginalName("STAT_TYPE_ART")]
		Art,
		// Token: 0x04005280 RID: 21120
		[OriginalName("STAT_TYPE_CULTURE")]
		Culture,
		// Token: 0x04005281 RID: 21121
		[OriginalName("STAT_TYPE_POPULAR")]
		Popular
	}
}
