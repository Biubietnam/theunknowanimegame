using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000448 RID: 1096
	public static class EnterFeverTimeActivityStageScRspReflection
	{
		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x00085D40 File Offset: 0x00083F40
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterFeverTimeActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04001363 RID: 4963
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZFbnRlckZldmVyVGltZUFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxoVU2Nl",
			"bmVCYXR0bGVJbmZvLnByb3RvImYKIEVudGVyRmV2ZXJUaW1lQWN0aXZpdHlT",
			"dGFnZVNjUnNwEg8KB3JldGNvZGUYCyABKA0SJQoLYmF0dGxlX2luZm8YAiAB",
			"KAsyEC5TY2VuZUJhdHRsZUluZm8SCgoCaWQYAyABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterFeverTimeActivityStageScRsp), EnterFeverTimeActivityStageScRsp.Parser, new string[]
			{
				"Retcode",
				"BattleInfo",
				"Id"
			}, null, null, null, null)
		}));
	}
}
