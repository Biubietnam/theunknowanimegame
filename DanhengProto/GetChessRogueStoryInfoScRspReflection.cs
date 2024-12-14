using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000664 RID: 1636
	public static class GetChessRogueStoryInfoScRspReflection
	{
		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x000C8186 File Offset: 0x000C6386
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChessRogueStoryInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D37 RID: 7479
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFHZXRDaGVzc1JvZ3VlU3RvcnlJbmZvU2NSc3AucHJvdG8aEUNDQUpGT0pH",
			"TEJJLnByb3RvGhFOQkFOTk9LSUdLQS5wcm90byKTAQobR2V0Q2hlc3NSb2d1",
			"ZVN0b3J5SW5mb1NjUnNwEjEKG2NoZXNzX3JvZ3VlX21haW5fc3RvcnlfaW5m",
			"bxgOIAMoCzIMLkNDQUpGT0pHTEJJEjAKGmNoZXNzX3JvZ3VlX3N1Yl9zdG9y",
			"eV9pbmZvGA0gAygLMgwuTkJBTk5PS0lHS0ESDwoHcmV0Y29kZRgKIAEoDUIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			CCAJFOJGLBIReflection.Descriptor,
			NBANNOKIGKAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueStoryInfoScRsp), GetChessRogueStoryInfoScRsp.Parser, new string[]
			{
				"ChessRogueMainStoryInfo",
				"ChessRogueSubStoryInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
