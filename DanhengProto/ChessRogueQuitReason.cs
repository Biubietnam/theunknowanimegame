using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000283 RID: 643
	public enum ChessRogueQuitReason
	{
		// Token: 0x04000BFC RID: 3068
		[OriginalName("CHESS_ROGUE_ACCOUNT_BY_NONE")]
		ChessRogueAccountByNone,
		// Token: 0x04000BFD RID: 3069
		[OriginalName("CHESS_ROGUE_ACCOUNT_BY_NORMAL_FINISH")]
		ChessRogueAccountByNormalFinish,
		// Token: 0x04000BFE RID: 3070
		[OriginalName("CHESS_ROGUE_ACCOUNT_BY_NORMAL_QUIT")]
		ChessRogueAccountByNormalQuit,
		// Token: 0x04000BFF RID: 3071
		[OriginalName("CHESS_ROGUE_ACCOUNT_BY_DIALOG")]
		ChessRogueAccountByDialog,
		// Token: 0x04000C00 RID: 3072
		[OriginalName("CHESS_ROGUE_ACCOUNT_BY_FAILED")]
		ChessRogueAccountByFailed,
		// Token: 0x04000C01 RID: 3073
		[OriginalName("CHESS_ROGUE_ACCOUNT_BY_CUSTOM_OP")]
		ChessRogueAccountByCustomOp
	}
}
