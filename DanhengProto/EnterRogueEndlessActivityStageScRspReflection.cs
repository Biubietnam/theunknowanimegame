using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000456 RID: 1110
	public static class EnterRogueEndlessActivityStageScRspReflection
	{
		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x00087DFB File Offset: 0x00085FFB
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterRogueEndlessActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x040013AE RID: 5038
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilFbnRlclJvZ3VlRW5kbGVzc0FjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxob",
			"Um9ndWVFbmRsZXNzTGF5ZXJJbmZvLnByb3RvGhVTY2VuZUJhdHRsZUluZm8u",
			"cHJvdG8iigEKI0VudGVyUm9ndWVFbmRsZXNzQWN0aXZpdHlTdGFnZVNjUnNw",
			"EisKC0hDTUhHS0lKS0ZJGAYgASgLMhYuUm9ndWVFbmRsZXNzTGF5ZXJJbmZv",
			"Eg8KB3JldGNvZGUYBCABKA0SJQoLYmF0dGxlX2luZm8YDSABKAsyEC5TY2Vu",
			"ZUJhdHRsZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueEndlessLayerInfoReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueEndlessActivityStageScRsp), EnterRogueEndlessActivityStageScRsp.Parser, new string[]
			{
				"HCMHGKIJKFI",
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
