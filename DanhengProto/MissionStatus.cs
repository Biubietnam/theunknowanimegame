using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE7 RID: 2791
	public enum MissionStatus
	{
		// Token: 0x04002F6A RID: 12138
		[OriginalName("MISSION_NONE")]
		MissionNone,
		// Token: 0x04002F6B RID: 12139
		[OriginalName("MISSION_DOING")]
		MissionDoing,
		// Token: 0x04002F6C RID: 12140
		[OriginalName("MISSION_FINISH")]
		MissionFinish,
		// Token: 0x04002F6D RID: 12141
		[OriginalName("MISSION_PREPARED")]
		MissionPrepared
	}
}
