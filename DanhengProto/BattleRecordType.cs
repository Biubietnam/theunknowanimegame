using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F1 RID: 241
	public enum BattleRecordType
	{
		// Token: 0x0400048B RID: 1163
		[OriginalName("BATTLE_RECORD_NONE")]
		BattleRecordNone,
		// Token: 0x0400048C RID: 1164
		[OriginalName("BATTLE_RECORD_CHALLENGE")]
		BattleRecordChallenge,
		// Token: 0x0400048D RID: 1165
		[OriginalName("BATTLE_RECORD_ROGUE")]
		BattleRecordRogue
	}
}
