using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001011 RID: 4113
	public enum RogueTournRoomStatus
	{
		// Token: 0x04004A1C RID: 18972
		[OriginalName("ROGUE_TOURN_ROOM_STATUS_NONE")]
		None,
		// Token: 0x04004A1D RID: 18973
		[OriginalName("ROGUE_TOURN_ROOM_STATUS_INITED")]
		Inited,
		// Token: 0x04004A1E RID: 18974
		[OriginalName("ROGUE_TOURN_ROOM_STATUS_PROCESSING")]
		Processing,
		// Token: 0x04004A1F RID: 18975
		[OriginalName("ROGUE_TOURN_ROOM_STATUS_FINISH")]
		Finish
	}
}
