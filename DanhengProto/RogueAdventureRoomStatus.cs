using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DEB RID: 3563
	public enum RogueAdventureRoomStatus
	{
		// Token: 0x04004173 RID: 16755
		[OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_NONE")]
		None,
		// Token: 0x04004174 RID: 16756
		[OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_PREPARE")]
		Prepare,
		// Token: 0x04004175 RID: 16757
		[OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_STARTED")]
		Started,
		// Token: 0x04004176 RID: 16758
		[OriginalName("ROGUE_ADVENTURE_ROOM_STATUS_STOPPED")]
		Stopped
	}
}
