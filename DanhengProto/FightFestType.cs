using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200052D RID: 1325
	public enum FightFestType
	{
		// Token: 0x040017D9 RID: 6105
		[OriginalName("FIGHT_FEST_TYPE_NONE")]
		None,
		// Token: 0x040017DA RID: 6106
		[OriginalName("FIGHT_FEST_TYPE_MAIN")]
		Main,
		// Token: 0x040017DB RID: 6107
		[OriginalName("FIGHT_FEST_TYPE_SCORE")]
		Score,
		// Token: 0x040017DC RID: 6108
		[OriginalName("FIGHT_FEST_TYPE_CHALLENGE")]
		Challenge,
		// Token: 0x040017DD RID: 6109
		[OriginalName("FIGHT_FEST_TYPE_TEACH")]
		Teach
	}
}
