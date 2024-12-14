using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A31 RID: 2609
	public enum LobbyCharacterType
	{
		// Token: 0x04002C8F RID: 11407
		[OriginalName("LobbyCharacter_None")]
		LobbyCharacterNone,
		// Token: 0x04002C90 RID: 11408
		[OriginalName("LobbyCharacter_Leader")]
		LobbyCharacterLeader,
		// Token: 0x04002C91 RID: 11409
		[OriginalName("LobbyCharacter_Member")]
		LobbyCharacterMember,
		// Token: 0x04002C92 RID: 11410
		[OriginalName("LobbyCharacter_Watcher")]
		LobbyCharacterWatcher
	}
}
