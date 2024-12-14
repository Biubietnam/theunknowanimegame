using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EFF RID: 3839
	public enum RogueMagicRoomStatus
	{
		// Token: 0x040045F8 RID: 17912
		[OriginalName("ROGUE_MAGIC_ROOM_STATUS_NONE")]
		None,
		// Token: 0x040045F9 RID: 17913
		[OriginalName("ROGUE_MAGIC_ROOM_STATUS_INITED")]
		Inited,
		// Token: 0x040045FA RID: 17914
		[OriginalName("ROGUE_MAGIC_ROOM_STATUS_PROCESSING")]
		Processing,
		// Token: 0x040045FB RID: 17915
		[OriginalName("ROGUE_MAGIC_ROOM_STATUS_FINISH")]
		Finish
	}
}
