using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000812 RID: 2066
	public static class GetStrongChallengeActivityDataScRspReflection
	{
		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x06005C1F RID: 23583 RVA: 0x000F4E02 File Offset: 0x000F3002
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetStrongChallengeActivityDataScRspReflection.descriptor;
			}
		}

		// Token: 0x0400239E RID: 9118
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilHZXRTdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eURhdGFTY1JzcC5wcm90bxoh",
			"U3Ryb25nQ2hhbGxlbmdlQWN0aXZpdHlJbmZvLnByb3RvImkKI0dldFN0cm9u",
			"Z0NoYWxsZW5nZUFjdGl2aXR5RGF0YVNjUnNwEg8KB3JldGNvZGUYAyABKA0S",
			"MQoLSUFPR05HREJOQkcYASABKAsyHC5TdHJvbmdDaGFsbGVuZ2VBY3Rpdml0",
			"eUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			StrongChallengeActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetStrongChallengeActivityDataScRsp), GetStrongChallengeActivityDataScRsp.Parser, new string[]
			{
				"Retcode",
				"IAOGNGDBNBG"
			}, null, null, null, null)
		}));
	}
}
