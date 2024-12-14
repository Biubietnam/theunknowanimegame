using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B9F RID: 2975
	public enum MsgType
	{
		// Token: 0x0400326B RID: 12907
		[OriginalName("MSG_TYPE_NONE")]
		None,
		// Token: 0x0400326C RID: 12908
		[OriginalName("MSG_TYPE_CUSTOM_TEXT")]
		CustomText,
		// Token: 0x0400326D RID: 12909
		[OriginalName("MSG_TYPE_EMOJI")]
		Emoji,
		// Token: 0x0400326E RID: 12910
		[OriginalName("MSG_TYPE_INVITE")]
		Invite
	}
}
