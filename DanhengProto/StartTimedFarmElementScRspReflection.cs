using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011D2 RID: 4562
	public static class StartTimedFarmElementScRspReflection
	{
		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0600CBF2 RID: 52210 RVA: 0x002237A5 File Offset: 0x002219A5
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartTimedFarmElementScRspReflection.descriptor;
			}
		}

		// Token: 0x04005245 RID: 21061
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBTdGFydFRpbWVkRmFybUVsZW1lbnRTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
			"bGVJbmZvLnByb3RvIn4KGlN0YXJ0VGltZWRGYXJtRWxlbWVudFNjUnNwEiUK",
			"C2JhdHRsZV9pbmZvGAIgASgLMhAuU2NlbmVCYXR0bGVJbmZvEhMKC3dvcmxk",
			"X2xldmVsGAEgASgNEhMKC1BPTEtCR0xDQkpEGA8gASgNEg8KB3JldGNvZGUY",
			"CyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartTimedFarmElementScRsp), StartTimedFarmElementScRsp.Parser, new string[]
			{
				"BattleInfo",
				"WorldLevel",
				"POLKBGLCBJD",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
