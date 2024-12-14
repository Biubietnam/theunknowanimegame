using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009AD RID: 2477
	public enum KickType
	{
		// Token: 0x04002A85 RID: 10885
		[OriginalName("KICK_SQUEEZED")]
		KickSqueezed,
		// Token: 0x04002A86 RID: 10886
		[OriginalName("KICK_BLACK")]
		KickBlack,
		// Token: 0x04002A87 RID: 10887
		[OriginalName("KICK_CHANGE_PWD")]
		KickChangePwd,
		// Token: 0x04002A88 RID: 10888
		[OriginalName("KICK_LOGIN_WHITE_TIMEOUT")]
		KickLoginWhiteTimeout,
		// Token: 0x04002A89 RID: 10889
		[OriginalName("KICK_ACE_ANTI_CHEATER")]
		KickAceAntiCheater,
		// Token: 0x04002A8A RID: 10890
		[OriginalName("KICK_BY_GM")]
		KickByGm
	}
}
