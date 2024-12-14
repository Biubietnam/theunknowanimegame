using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200065C RID: 1628
	public static class GetChessRogueNousStoryInfoScRspReflection
	{
		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06004905 RID: 18693 RVA: 0x000C74E6 File Offset: 0x000C56E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChessRogueNousStoryInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D1A RID: 7450
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVHZXRDaGVzc1JvZ3VlTm91c1N0b3J5SW5mb1NjUnNwLnByb3RvGiBDaGVz",
			"c1JvZ3VlTm91c1N1YlN0b3J5SW5mby5wcm90bxohQ2hlc3NSb2d1ZU5vdXNN",
			"YWluU3RvcnlJbmZvLnByb3RvIrYBCh9HZXRDaGVzc1JvZ3VlTm91c1N0b3J5",
			"SW5mb1NjUnNwEg8KB3JldGNvZGUYBSABKA0SQQobY2hlc3Nfcm9ndWVfbWFp",
			"bl9zdG9yeV9pbmZvGAIgAygLMhwuQ2hlc3NSb2d1ZU5vdXNNYWluU3RvcnlJ",
			"bmZvEj8KGmNoZXNzX3JvZ3VlX3N1Yl9zdG9yeV9pbmZvGAggAygLMhsuQ2hl",
			"c3NSb2d1ZU5vdXNTdWJTdG9yeUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueNousSubStoryInfoReflection.Descriptor,
			ChessRogueNousMainStoryInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueNousStoryInfoScRsp), GetChessRogueNousStoryInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"ChessRogueMainStoryInfo",
				"ChessRogueSubStoryInfo"
			}, null, null, null, null)
		}));
	}
}
