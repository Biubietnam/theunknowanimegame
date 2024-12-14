using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001097 RID: 4247
	public enum SecretKeyType
	{
		// Token: 0x04004D02 RID: 19714
		[OriginalName("SECRET_KEY_NONE")]
		SecretKeyNone,
		// Token: 0x04004D03 RID: 19715
		[OriginalName("SECRET_KEY_SERVER_CHECK")]
		SecretKeyServerCheck,
		// Token: 0x04004D04 RID: 19716
		[OriginalName("SECRET_KEY_VIDEO")]
		SecretKeyVideo,
		// Token: 0x04004D05 RID: 19717
		[OriginalName("SECRET_KEY_BATTLE_TIME")]
		SecretKeyBattleTime
	}
}
