using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000143 RID: 323
	public enum BpTierType
	{
		// Token: 0x0400063D RID: 1597
		[OriginalName("BP_TIER_TYPE_NONE")]
		None,
		// Token: 0x0400063E RID: 1598
		[OriginalName("BP_TIER_TYPE_FREE")]
		Free,
		// Token: 0x0400063F RID: 1599
		[OriginalName("BP_TIER_TYPE_PREMIUM_1")]
		Premium1,
		// Token: 0x04000640 RID: 1600
		[OriginalName("BP_TIER_TYPE_PREMIUM_2")]
		Premium2
	}
}
