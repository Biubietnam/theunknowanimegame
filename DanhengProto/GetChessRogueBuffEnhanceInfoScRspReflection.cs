using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000658 RID: 1624
	public static class GetChessRogueBuffEnhanceInfoScRspReflection
	{
		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x000C6F82 File Offset: 0x000C5182
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChessRogueBuffEnhanceInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D10 RID: 7440
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidHZXRDaGVzc1JvZ3VlQnVmZkVuaGFuY2VJbmZvU2NSc3AucHJvdG8aH0No",
			"ZXNzUm9ndWVCdWZmRW5oYW5jZUxpc3QucHJvdG8iawohR2V0Q2hlc3NSb2d1",
			"ZUJ1ZmZFbmhhbmNlSW5mb1NjUnNwEjUKEWJ1ZmZfZW5oYW5jZV9pbmZvGAog",
			"ASgLMhouQ2hlc3NSb2d1ZUJ1ZmZFbmhhbmNlTGlzdBIPCgdyZXRjb2RlGAcg",
			"ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueBuffEnhanceListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueBuffEnhanceInfoScRsp), GetChessRogueBuffEnhanceInfoScRsp.Parser, new string[]
			{
				"BuffEnhanceInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
