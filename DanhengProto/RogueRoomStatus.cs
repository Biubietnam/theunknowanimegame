using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F6F RID: 3951
	public enum RogueRoomStatus
	{
		// Token: 0x0400479C RID: 18332
		[OriginalName("ROGUE_ROOM_STATUS_NONE")]
		None,
		// Token: 0x0400479D RID: 18333
		[OriginalName("ROGUE_ROOM_STATUS_LOCK")]
		Lock,
		// Token: 0x0400479E RID: 18334
		[OriginalName("ROGUE_ROOM_STATUS_UNLOCK")]
		Unlock,
		// Token: 0x0400479F RID: 18335
		[OriginalName("ROGUE_ROOM_STATUS_PLAY")]
		Play,
		// Token: 0x040047A0 RID: 18336
		[OriginalName("ROGUE_ROOM_STATUS_FINISH")]
		Finish
	}
}
