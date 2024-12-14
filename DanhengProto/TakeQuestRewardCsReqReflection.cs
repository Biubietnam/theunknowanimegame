using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001318 RID: 4888
	public static class TakeQuestRewardCsReqReflection
	{
		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x0600DA20 RID: 55840 RVA: 0x00245112 File Offset: 0x00243312
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeQuestRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x040056E1 RID: 22241
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpUYWtlUXVlc3RSZXdhcmRDc1JlcS5wcm90byItChRUYWtlUXVlc3RSZXdh" + "cmRDc1JlcRIVCg1xdWVzdF9pZF9saXN0GAUgAygNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestRewardCsReq), TakeQuestRewardCsReq.Parser, new string[]
			{
				"QuestIdList"
			}, null, null, null, null)
		}));
	}
}
