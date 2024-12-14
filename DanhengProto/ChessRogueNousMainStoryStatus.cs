using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200025F RID: 607
	public enum ChessRogueNousMainStoryStatus
	{
		// Token: 0x04000B76 RID: 2934
		[OriginalName("CHESS_ROGUE_NOUS_MAIN_STORY_STATUS_NONE")]
		None,
		// Token: 0x04000B77 RID: 2935
		[OriginalName("CHESS_ROGUE_NOUS_MAIN_STORY_STATUS_UNLOCK")]
		Unlock,
		// Token: 0x04000B78 RID: 2936
		[OriginalName("CHESS_ROGUE_NOUS_MAIN_STORY_STATUS_FINISH")]
		Finish,
		// Token: 0x04000B79 RID: 2937
		[OriginalName("CHESS_ROGUE_NOUS_MAIN_STORY_STATUS_CAN_TRIGGER")]
		CanTrigger
	}
}
