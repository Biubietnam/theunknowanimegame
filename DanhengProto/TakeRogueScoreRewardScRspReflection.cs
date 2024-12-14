using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001332 RID: 4914
	public static class TakeRogueScoreRewardScRspReflection
	{
		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x0024817F File Offset: 0x0024637F
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeRogueScoreRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005751 RID: 22353
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9UYWtlUm9ndWVTY29yZVJld2FyZFNjUnNwLnByb3RvGhpSb2d1ZVNjb3Jl",
			"UmV3YXJkSW5mby5wcm90bxoOSXRlbUxpc3QucHJvdG8ikAEKGVRha2VSb2d1",
			"ZVNjb3JlUmV3YXJkU2NSc3ASDwoHcG9vbF9pZBgMIAEoDRI2Chdyb2d1ZV9z",
			"Y29yZV9yZXdhcmRfaW5mbxgFIAEoCzIVLlJvZ3VlU2NvcmVSZXdhcmRJbmZv",
			"Eg8KB3JldGNvZGUYCiABKA0SGQoGcmV3YXJkGAYgASgLMgkuSXRlbUxpc3RC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueScoreRewardInfoReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueScoreRewardScRsp), TakeRogueScoreRewardScRsp.Parser, new string[]
			{
				"PoolId",
				"RogueScoreRewardInfo",
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
