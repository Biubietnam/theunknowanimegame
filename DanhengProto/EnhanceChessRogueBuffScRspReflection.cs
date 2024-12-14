using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000420 RID: 1056
	public static class EnhanceChessRogueBuffScRspReflection
	{
		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x00081A06 File Offset: 0x0007FC06
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnhanceChessRogueBuffScRspReflection.descriptor;
			}
		}

		// Token: 0x040012D3 RID: 4819
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBFbmhhbmNlQ2hlc3NSb2d1ZUJ1ZmZTY1JzcC5wcm90bxoVUm9ndWVDb21t",
			"b25CdWZmLnByb3RvGh9DaGVzc1JvZ3VlQnVmZkVuaGFuY2VMaXN0LnByb3Rv",
			"Ip4BChpFbmhhbmNlQ2hlc3NSb2d1ZUJ1ZmZTY1JzcBIkCgpyb2d1ZV9idWZm",
			"GAEgASgLMhAuUm9ndWVDb21tb25CdWZmEjUKEWJ1ZmZfZW5oYW5jZV9pbmZv",
			"GAIgASgLMhouQ2hlc3NSb2d1ZUJ1ZmZFbmhhbmNlTGlzdBIPCgdyZXRjb2Rl",
			"GAYgASgNEhIKCmlzX3N1Y2Nlc3MYDCABKAhCHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor,
			ChessRogueBuffEnhanceListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnhanceChessRogueBuffScRsp), EnhanceChessRogueBuffScRsp.Parser, new string[]
			{
				"RogueBuff",
				"BuffEnhanceInfo",
				"Retcode",
				"IsSuccess"
			}, null, null, null, null)
		}));
	}
}
