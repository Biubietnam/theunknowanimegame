using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A4D RID: 2637
	public enum LobbyModifyType
	{
		// Token: 0x04002CFB RID: 11515
		[OriginalName("LobbyModifyType_None")]
		None,
		// Token: 0x04002CFC RID: 11516
		[OriginalName("LobbyModifyType_Idle")]
		Idle,
		// Token: 0x04002CFD RID: 11517
		[OriginalName("LobbyModifyType_Ready")]
		Ready,
		// Token: 0x04002CFE RID: 11518
		[OriginalName("LobbyModifyType_Operating")]
		Operating,
		// Token: 0x04002CFF RID: 11519
		[OriginalName("LobbyModifyType_CancelMatch")]
		CancelMatch,
		// Token: 0x04002D00 RID: 11520
		[OriginalName("LobbyModifyType_Match")]
		Match,
		// Token: 0x04002D01 RID: 11521
		[OriginalName("LobbyModifyType_QuitLobby")]
		QuitLobby,
		// Token: 0x04002D02 RID: 11522
		[OriginalName("LobbyModifyType_KickOut")]
		KickOut,
		// Token: 0x04002D03 RID: 11523
		[OriginalName("LobbyModifyType_TimeOut")]
		TimeOut,
		// Token: 0x04002D04 RID: 11524
		[OriginalName("LobbyModifyType_JoinLobby")]
		JoinLobby,
		// Token: 0x04002D05 RID: 11525
		[OriginalName("LobbyModifyType_LobbyDismiss")]
		LobbyDismiss,
		// Token: 0x04002D06 RID: 11526
		[OriginalName("LobbyModifyType_MatchTimeOut")]
		MatchTimeOut,
		// Token: 0x04002D07 RID: 11527
		[OriginalName("LobbyModifyType_FightStart")]
		FightStart,
		// Token: 0x04002D08 RID: 11528
		[OriginalName("LobbyModifyType_Logout")]
		Logout,
		// Token: 0x04002D09 RID: 11529
		[OriginalName("LobbyModifyType_FightEnd")]
		FightEnd,
		// Token: 0x04002D0A RID: 11530
		[OriginalName("LobbyModifyType_FightRoomDestroyInInit")]
		FightRoomDestroyInInit
	}
}
