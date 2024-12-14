using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200023D RID: 573
	public enum ChessRogueLevelStatus
	{
		// Token: 0x04000B05 RID: 2821
		[OriginalName("CHESS_ROGUE_LEVEL_IDLE")]
		ChessRogueLevelIdle,
		// Token: 0x04000B06 RID: 2822
		[OriginalName("CHESS_ROGUE_LEVEL_PROCESSING")]
		ChessRogueLevelProcessing,
		// Token: 0x04000B07 RID: 2823
		[OriginalName("CHESS_ROGUE_LEVEL_PENDING")]
		ChessRogueLevelPending,
		// Token: 0x04000B08 RID: 2824
		[OriginalName("CHESS_ROGUE_LEVEL_FINISH")]
		ChessRogueLevelFinish,
		// Token: 0x04000B09 RID: 2825
		[OriginalName("CHESS_ROGUE_LEVEL_FAILED")]
		ChessRogueLevelFailed,
		// Token: 0x04000B0A RID: 2826
		[OriginalName("CHESS_ROGUE_LEVEL_FORCE_FINISH")]
		ChessRogueLevelForceFinish
	}
}
