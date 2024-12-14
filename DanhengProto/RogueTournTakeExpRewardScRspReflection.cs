using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001022 RID: 4130
	public static class RogueTournTakeExpRewardScRspReflection
	{
		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600B7B1 RID: 47025 RVA: 0x001ECDDF File Offset: 0x001EAFDF
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournTakeExpRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04004A6A RID: 19050
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZVRvdXJuVGFrZUV4cFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJ0ChxSb2d1ZVRvdXJuVGFrZUV4cFJld2FyZFNjUnNwEgsKA2V4",
			"cBgPIAEoDRIZCgZyZXdhcmQYBCABKAsyCS5JdGVtTGlzdBIPCgdyZXRjb2Rl",
			"GAkgASgNEhsKE3Rha2VuX2xldmVsX3Jld2FyZHMYAiADKA1CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournTakeExpRewardScRsp), RogueTournTakeExpRewardScRsp.Parser, new string[]
			{
				"Exp",
				"Reward",
				"Retcode",
				"TakenLevelRewards"
			}, null, null, null, null)
		}));
	}
}
