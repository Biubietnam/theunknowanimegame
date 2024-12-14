using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009DB RID: 2523
	public enum LAKKMDLDAGD
	{
		// Token: 0x04002B39 RID: 11065
		[OriginalName("MATCH3_STATE_IDLE")]
		Match3StateIdle,
		// Token: 0x04002B3A RID: 11066
		[OriginalName("MATCH3_STATE_START")]
		Match3StateStart,
		// Token: 0x04002B3B RID: 11067
		[OriginalName("MATCH3_STATE_MATCH")]
		Match3StateMatch,
		// Token: 0x04002B3C RID: 11068
		[OriginalName("MATCH3_STATE_GAME")]
		Match3StateGame,
		// Token: 0x04002B3D RID: 11069
		[OriginalName("MATCH3_STATE_HALFTIME")]
		Match3StateHalftime,
		// Token: 0x04002B3E RID: 11070
		[OriginalName("MATCH3_STATE_OVER")]
		Match3StateOver
	}
}
