using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F2 RID: 1778
	public static class GetLevelRewardScRspReflection
	{
		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x000D6D0D File Offset: 0x000D4F0D
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetLevelRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F5A RID: 8026
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRMZXZlbFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJQ" + "ChNHZXRMZXZlbFJld2FyZFNjUnNwEg0KBWxldmVsGAcgASgNEg8KB3JldGNv" + "ZGUYAyABKA0SGQoGcmV3YXJkGAQgASgLMgkuSXRlbUxpc3RCHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetLevelRewardScRsp), GetLevelRewardScRsp.Parser, new string[]
			{
				"Level",
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
