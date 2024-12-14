using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BA3 RID: 2979
	public enum MultiPathAvatarType
	{
		// Token: 0x04003280 RID: 12928
		[OriginalName("MultiPathAvatarTypeNone")]
		None,
		// Token: 0x04003281 RID: 12929
		[OriginalName("Mar_7thKnightType")]
		Mar7ThKnightType = 1001,
		// Token: 0x04003282 RID: 12930
		[OriginalName("Mar_7thRogueType")]
		Mar7ThRogueType = 1224,
		// Token: 0x04003283 RID: 12931
		[OriginalName("BoyWarriorType")]
		BoyWarriorType = 8001,
		// Token: 0x04003284 RID: 12932
		[OriginalName("GirlWarriorType")]
		GirlWarriorType,
		// Token: 0x04003285 RID: 12933
		[OriginalName("BoyKnightType")]
		BoyKnightType,
		// Token: 0x04003286 RID: 12934
		[OriginalName("GirlKnightType")]
		GirlKnightType,
		// Token: 0x04003287 RID: 12935
		[OriginalName("BoyShamanType")]
		BoyShamanType,
		// Token: 0x04003288 RID: 12936
		[OriginalName("GirlShamanType")]
		GirlShamanType
	}
}
