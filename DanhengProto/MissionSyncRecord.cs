using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AED RID: 2797
	public enum MissionSyncRecord
	{
		// Token: 0x04002F9A RID: 12186
		[OriginalName("MISSION_SYNC_RECORD_NONE")]
		None,
		// Token: 0x04002F9B RID: 12187
		[OriginalName("MISSION_SYNC_RECORD_MAIN_MISSION_ACCEPT")]
		MainMissionAccept,
		// Token: 0x04002F9C RID: 12188
		[OriginalName("MISSION_SYNC_RECORD_MAIN_MISSION_START")]
		MainMissionStart,
		// Token: 0x04002F9D RID: 12189
		[OriginalName("MISSION_SYNC_RECORD_MAIN_MISSION_FINISH")]
		MainMissionFinish,
		// Token: 0x04002F9E RID: 12190
		[OriginalName("MISSION_SYNC_RECORD_MAIN_MISSION_DELETE")]
		MainMissionDelete,
		// Token: 0x04002F9F RID: 12191
		[OriginalName("MISSION_SYNC_RECORD_MISSION_ACCEPT")]
		MissionAccept = 11,
		// Token: 0x04002FA0 RID: 12192
		[OriginalName("MISSION_SYNC_RECORD_MISSION_START")]
		MissionStart,
		// Token: 0x04002FA1 RID: 12193
		[OriginalName("MISSION_SYNC_RECORD_MISSION_FINISH")]
		MissionFinish,
		// Token: 0x04002FA2 RID: 12194
		[OriginalName("MISSION_SYNC_RECORD_MISSION_DELETE")]
		MissionDelete,
		// Token: 0x04002FA3 RID: 12195
		[OriginalName("MISSION_SYNC_RECORD_MISSION_PROGRESS")]
		MissionProgress
	}
}
