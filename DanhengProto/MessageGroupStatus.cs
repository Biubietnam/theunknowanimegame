using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC3 RID: 2755
	public enum MessageGroupStatus
	{
		// Token: 0x04002EE1 RID: 12001
		[OriginalName("MESSAGE_GROUP_NONE")]
		MessageGroupNone,
		// Token: 0x04002EE2 RID: 12002
		[OriginalName("MESSAGE_GROUP_DOING")]
		MessageGroupDoing,
		// Token: 0x04002EE3 RID: 12003
		[OriginalName("MESSAGE_GROUP_FINISH")]
		MessageGroupFinish,
		// Token: 0x04002EE4 RID: 12004
		[OriginalName("MESSAGE_GROUP_FROZEN")]
		MessageGroupFrozen
	}
}
