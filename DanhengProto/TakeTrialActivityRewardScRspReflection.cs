using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001342 RID: 4930
	public static class TakeTrialActivityRewardScRspReflection
	{
		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x0600DC0B RID: 56331 RVA: 0x00249F36 File Offset: 0x00248136
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeTrialActivityRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04005790 RID: 22416
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJUYWtlVHJpYWxBY3Rpdml0eVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJcChxUYWtlVHJpYWxBY3Rpdml0eVJld2FyZFNjUnNwEg8KB3Jl",
			"dGNvZGUYBSABKA0SEAoIc3RhZ2VfaWQYCSABKA0SGQoGcmV3YXJkGAIgASgL",
			"MgkuSXRlbUxpc3RCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeTrialActivityRewardScRsp), TakeTrialActivityRewardScRsp.Parser, new string[]
			{
				"Retcode",
				"StageId",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
