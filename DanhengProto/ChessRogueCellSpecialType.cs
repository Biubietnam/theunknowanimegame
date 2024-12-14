using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001EF RID: 495
	public enum ChessRogueCellSpecialType
	{
		// Token: 0x04000961 RID: 2401
		[OriginalName("CHESS_ROGUE_CELL_SPECIAL_TYPE_NONE")]
		None,
		// Token: 0x04000962 RID: 2402
		[OriginalName("CHESS_ROGUE_CELL_SPECIAL_TYPE_LOCKED")]
		Locked,
		// Token: 0x04000963 RID: 2403
		[OriginalName("CHESS_ROGUE_CELL_SPECIAL_TYPE_REPLICATE")]
		Replicate,
		// Token: 0x04000964 RID: 2404
		[OriginalName("CHESS_ROGUE_CELL_SPECIAL_TYPE_PROTECTED")]
		Protected,
		// Token: 0x04000965 RID: 2405
		[OriginalName("CHESS_ROGUE_CELL_SPECIAL_TYPE_SEED")]
		Seed,
		// Token: 0x04000966 RID: 2406
		[OriginalName("CHESS_ROGUE_CELL_SPECIAL_TYPE_STAMP")]
		Stamp
	}
}
