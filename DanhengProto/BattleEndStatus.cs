using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E1 RID: 225
	public enum BattleEndStatus
	{
		// Token: 0x04000431 RID: 1073
		[OriginalName("BATTLE_END_NONE")]
		BattleEndNone,
		// Token: 0x04000432 RID: 1074
		[OriginalName("BATTLE_END_WIN")]
		BattleEndWin,
		// Token: 0x04000433 RID: 1075
		[OriginalName("BATTLE_END_LOSE")]
		BattleEndLose,
		// Token: 0x04000434 RID: 1076
		[OriginalName("BATTLE_END_QUIT")]
		BattleEndQuit
	}
}
