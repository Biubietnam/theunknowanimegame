using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001279 RID: 4729
	public enum SyncLineupReason
	{
		// Token: 0x04005487 RID: 21639
		[OriginalName("SYNC_REASON_NONE")]
		SyncReasonNone,
		// Token: 0x04005488 RID: 21640
		[OriginalName("SYNC_REASON_MP_ADD")]
		SyncReasonMpAdd,
		// Token: 0x04005489 RID: 21641
		[OriginalName("SYNC_REASON_MP_ADD_PROP_HIT")]
		SyncReasonMpAddPropHit,
		// Token: 0x0400548A RID: 21642
		[OriginalName("SYNC_REASON_HP_ADD")]
		SyncReasonHpAdd,
		// Token: 0x0400548B RID: 21643
		[OriginalName("SYNC_REASON_HP_ADD_PROP_HIT")]
		SyncReasonHpAddPropHit
	}
}
