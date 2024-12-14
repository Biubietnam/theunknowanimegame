using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E3D RID: 3645
	public enum RogueCommonBuffSelectSourceType
	{
		// Token: 0x040042A1 RID: 17057
		[OriginalName("ROGUE_COMMON_BUFF_SELECT_SOURCE_TYPE_NONE")]
		None,
		// Token: 0x040042A2 RID: 17058
		[OriginalName("ROGUE_COMMON_BUFF_SELECT_SOURCE_TYPE_DICE_ROLL")]
		DiceRoll,
		// Token: 0x040042A3 RID: 17059
		[OriginalName("ROGUE_COMMON_BUFF_SELECT_SOURCE_TYPE_AEON")]
		Aeon,
		// Token: 0x040042A4 RID: 17060
		[OriginalName("ROGUE_COMMON_BUFF_SELECT_SOURCE_TYPE_BOARD_EVENT")]
		BoardEvent,
		// Token: 0x040042A5 RID: 17061
		[OriginalName("ROGUE_COMMON_BUFF_SELECT_SOURCE_TYPE_LEVEL_MECHANISM")]
		LevelMechanism
	}
}
