using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A2F RID: 2607
	public enum LobbyCharacterStatus
	{
		// Token: 0x04002C86 RID: 11398
		[OriginalName("LobbyCharacterStatus_None")]
		None,
		// Token: 0x04002C87 RID: 11399
		[OriginalName("LobbyCharacterStatus_Idle")]
		Idle,
		// Token: 0x04002C88 RID: 11400
		[OriginalName("LobbyCharacterStatus_Operating")]
		Operating,
		// Token: 0x04002C89 RID: 11401
		[OriginalName("LobbyCharacterStatus_Ready")]
		Ready,
		// Token: 0x04002C8A RID: 11402
		[OriginalName("LobbyCharacterStatus_Fighting")]
		Fighting,
		// Token: 0x04002C8B RID: 11403
		[OriginalName("LobbyCharacterStatus_Watching")]
		Watching,
		// Token: 0x04002C8C RID: 11404
		[OriginalName("LobbyCharacterStatus_Matching")]
		Matching
	}
}
