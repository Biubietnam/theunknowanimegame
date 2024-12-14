using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000141 RID: 321
	public enum BpRewardType
	{
		// Token: 0x04000636 RID: 1590
		[OriginalName("BP_REWARAD_TYPE_NONE")]
		BpRewaradTypeNone,
		// Token: 0x04000637 RID: 1591
		[OriginalName("BP_REWARAD_TYPE_FREE")]
		BpRewaradTypeFree,
		// Token: 0x04000638 RID: 1592
		[OriginalName("BP_REWARAD_TYPE_PREMIUM_1")]
		BpRewaradTypePremium1,
		// Token: 0x04000639 RID: 1593
		[OriginalName("BP_REWARAD_TYPE_PREMIUM_2")]
		BpRewaradTypePremium2,
		// Token: 0x0400063A RID: 1594
		[OriginalName("BP_REWARAD_TYPE_PREMIUM_OPTIONAL")]
		BpRewaradTypePremiumOptional
	}
}
