using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200135D RID: 4957
	public enum TrackMainMissionUpdateReasonId
	{
		// Token: 0x04005800 RID: 22528
		[OriginalName("TRACK_MAIN_MISSION_UPDATE_NONE")]
		TrackMainMissionUpdateNone,
		// Token: 0x04005801 RID: 22529
		[OriginalName("TRACK_MAIN_MISSION_UPDATE_AUTO")]
		TrackMainMissionUpdateAuto,
		// Token: 0x04005802 RID: 22530
		[OriginalName("TRACK_MAIN_MISSION_UPDATE_MANUAL")]
		TrackMainMissionUpdateManual,
		// Token: 0x04005803 RID: 22531
		[OriginalName("TRACK_MAIN_MISSION_UPDATE_LOGIN_REPORT")]
		TrackMainMissionUpdateLoginReport
	}
}
