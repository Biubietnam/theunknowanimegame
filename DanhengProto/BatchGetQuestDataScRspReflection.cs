using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000D2 RID: 210
	public static class BatchGetQuestDataScRspReflection
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		public static FileDescriptor Descriptor
		{
			get
			{
				return BatchGetQuestDataScRspReflection.descriptor;
			}
		}

		// Token: 0x040003D5 RID: 981
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxCYXRjaEdldFF1ZXN0RGF0YVNjUnNwLnByb3RvGgtRdWVzdC5wcm90byJF" + "ChZCYXRjaEdldFF1ZXN0RGF0YVNjUnNwEg8KB3JldGNvZGUYBCABKA0SGgoK" + "cXVlc3RfbGlzdBgNIAMoCzIGLlF1ZXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			QuestReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BatchGetQuestDataScRsp), BatchGetQuestDataScRsp.Parser, new string[]
			{
				"Retcode",
				"QuestList"
			}, null, null, null, null)
		}));
	}
}
