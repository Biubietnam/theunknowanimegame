using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D43 RID: 3395
	public enum QuestStatus
	{
		// Token: 0x04003B04 RID: 15108
		[OriginalName("QUEST_NONE")]
		QuestNone,
		// Token: 0x04003B05 RID: 15109
		[OriginalName("QUEST_DOING")]
		QuestDoing,
		// Token: 0x04003B06 RID: 15110
		[OriginalName("QUEST_FINISH")]
		QuestFinish,
		// Token: 0x04003B07 RID: 15111
		[OriginalName("QUEST_CLOSE")]
		QuestClose,
		// Token: 0x04003B08 RID: 15112
		[OriginalName("QUEST_DELETE")]
		QuestDelete
	}
}
