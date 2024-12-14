using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC9 RID: 2761
	public enum MessageSectionStatus
	{
		// Token: 0x04002EFD RID: 12029
		[OriginalName("MESSAGE_SECTION_NONE")]
		MessageSectionNone,
		// Token: 0x04002EFE RID: 12030
		[OriginalName("MESSAGE_SECTION_DOING")]
		MessageSectionDoing,
		// Token: 0x04002EFF RID: 12031
		[OriginalName("MESSAGE_SECTION_FINISH")]
		MessageSectionFinish,
		// Token: 0x04002F00 RID: 12032
		[OriginalName("MESSAGE_SECTION_FROZEN")]
		MessageSectionFrozen
	}
}
