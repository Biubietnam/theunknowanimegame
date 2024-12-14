using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001369 RID: 4969
	public enum TrainVisitorStatus
	{
		// Token: 0x04005830 RID: 22576
		[OriginalName("TRAIN_VISITOR_STATUS_NONE")]
		None,
		// Token: 0x04005831 RID: 22577
		[OriginalName("TRAIN_VISITOR_STATUS_INIT")]
		Init,
		// Token: 0x04005832 RID: 22578
		[OriginalName("TRAIN_VISITOR_STATUS_GET_ON")]
		GetOn,
		// Token: 0x04005833 RID: 22579
		[OriginalName("TRAIN_VISITOR_STATUS_GET_OFF")]
		GetOff
	}
}
