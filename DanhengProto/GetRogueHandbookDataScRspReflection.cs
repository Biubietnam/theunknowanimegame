using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007BE RID: 1982
	public static class GetRogueHandbookDataScRspReflection
	{
		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x000EC65A File Offset: 0x000EA85A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueHandbookDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002279 RID: 8825
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRSb2d1ZUhhbmRib29rRGF0YVNjUnNwLnByb3RvGhNSb2d1ZUhhbmRi" + "b29rLnByb3RvIlIKGUdldFJvZ3VlSGFuZGJvb2tEYXRhU2NSc3ASJAoMSGFu" + "ZGJvb2tJbmZvGAIgASgLMg4uUm9ndWVIYW5kYm9vaxIPCgdyZXRjb2RlGAgg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueHandbookReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueHandbookDataScRsp), GetRogueHandbookDataScRsp.Parser, new string[]
			{
				"HandbookInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
