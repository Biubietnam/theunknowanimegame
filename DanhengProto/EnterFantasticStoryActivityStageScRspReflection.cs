using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000444 RID: 1092
	public static class EnterFantasticStoryActivityStageScRspReflection
	{
		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x0008535A File Offset: 0x0008355A
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterFantasticStoryActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x0400134C RID: 4940
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitFbnRlckZhbnRhc3RpY1N0b3J5QWN0aXZpdHlTdGFnZVNjUnNwLnByb3Rv",
			"GhVTY2VuZUJhdHRsZUluZm8ucHJvdG8ihwEKJUVudGVyRmFudGFzdGljU3Rv",
			"cnlBY3Rpdml0eVN0YWdlU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRITCgtLTEFO",
			"RUFCS0VMRBgPIAEoDRIlCgtiYXR0bGVfaW5mbxgEIAEoCzIQLlNjZW5lQmF0",
			"dGxlSW5mbxIRCgliYXR0bGVfaWQYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterFantasticStoryActivityStageScRsp), EnterFantasticStoryActivityStageScRsp.Parser, new string[]
			{
				"Retcode",
				"KLANEABKELD",
				"BattleInfo",
				"BattleId"
			}, null, null, null, null)
		}));
	}
}
