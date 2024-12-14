using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000207 RID: 519
	public enum ChessRogueDiceStatus
	{
		// Token: 0x040009DC RID: 2524
		[OriginalName("CHESS_ROGUE_DICE_IDLE")]
		ChessRogueDiceIdle,
		// Token: 0x040009DD RID: 2525
		[OriginalName("CHESS_ROGUE_DICE_ROLLED")]
		ChessRogueDiceRolled,
		// Token: 0x040009DE RID: 2526
		[OriginalName("CHESS_ROGUE_DICE_CONFIRMED")]
		ChessRogueDiceConfirmed,
		// Token: 0x040009DF RID: 2527
		[OriginalName("CHESS_ROGUE_DICE_GIVEUP")]
		ChessRogueDiceGiveup
	}
}
