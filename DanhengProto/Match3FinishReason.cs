using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A95 RID: 2709
	public enum Match3FinishReason
	{
		// Token: 0x04002E1B RID: 11803
		[OriginalName("MATCH3_FINISH_REASON_DEFAULT")]
		Default,
		// Token: 0x04002E1C RID: 11804
		[OriginalName("MATCH3_FINISH_REASON_LEAVE")]
		Leave,
		// Token: 0x04002E1D RID: 11805
		[OriginalName("MATCH3_FINISH_REASON_DIE")]
		Die,
		// Token: 0x04002E1E RID: 11806
		[OriginalName("MATCH3_FINISH_REASON_GAMEEND")]
		Gameend,
		// Token: 0x04002E1F RID: 11807
		[OriginalName("MATCH3_FINISH_REASON_KICKOUT")]
		Kickout
	}
}
