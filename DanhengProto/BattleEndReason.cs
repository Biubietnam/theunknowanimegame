using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000DF RID: 223
	public enum BattleEndReason
	{
		// Token: 0x0400042C RID: 1068
		[OriginalName("BATTLE_END_REASON_NONE")]
		None,
		// Token: 0x0400042D RID: 1069
		[OriginalName("BATTLE_END_REASON_ALL_DIE")]
		AllDie,
		// Token: 0x0400042E RID: 1070
		[OriginalName("BATTLE_END_REASON_TURN_LIMIT")]
		TurnLimit
	}
}
