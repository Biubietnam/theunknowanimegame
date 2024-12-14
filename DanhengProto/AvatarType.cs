using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000CD RID: 205
	public enum AvatarType
	{
		// Token: 0x040003C1 RID: 961
		[OriginalName("AVATAR_TYPE_NONE")]
		None,
		// Token: 0x040003C2 RID: 962
		[OriginalName("AVATAR_TRIAL_TYPE")]
		AvatarTrialType,
		// Token: 0x040003C3 RID: 963
		[OriginalName("AVATAR_LIMIT_TYPE")]
		AvatarLimitType,
		// Token: 0x040003C4 RID: 964
		[OriginalName("AVATAR_FORMAL_TYPE")]
		AvatarFormalType,
		// Token: 0x040003C5 RID: 965
		[OriginalName("AVATAR_ASSIST_TYPE")]
		AvatarAssistType,
		// Token: 0x040003C6 RID: 966
		[OriginalName("AVATAR_AETHER_DIVIDE_TYPE")]
		AvatarAetherDivideType,
		// Token: 0x040003C7 RID: 967
		[OriginalName("AVATAR_UPGRADE_AVAILABLE_TYPE")]
		AvatarUpgradeAvailableType
	}
}
