using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D0 RID: 208
	public static class BatchGetQuestDataCsReqReflection
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0001B835 File Offset: 0x00019A35
		public static FileDescriptor Descriptor
		{
			get
			{
				return BatchGetQuestDataCsReqReflection.descriptor;
			}
		}

		// Token: 0x040003CF RID: 975
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxCYXRjaEdldFF1ZXN0RGF0YUNzUmVxLnByb3RvIiwKFkJhdGNoR2V0UXVl" + "c3REYXRhQ3NSZXESEgoKcXVlc3RfbGlzdBgDIAMoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BatchGetQuestDataCsReq), BatchGetQuestDataCsReq.Parser, new string[]
			{
				"QuestList"
			}, null, null, null, null)
		}));
	}
}
