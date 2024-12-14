using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE4 RID: 2788
	public static class MissionRewardScNotifyReflection
	{
		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x00146D70 File Offset: 0x00144F70
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionRewardScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04002F5F RID: 12127
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtNaXNzaW9uUmV3YXJkU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
			"ImMKFU1pc3Npb25SZXdhcmRTY05vdGlmeRIWCg5zdWJfbWlzc2lvbl9pZBgN",
			"IAEoDRIXCg9tYWluX21pc3Npb25faWQYCCABKA0SGQoGcmV3YXJkGAMgASgL",
			"MgkuSXRlbUxpc3RCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MissionRewardScNotify), MissionRewardScNotify.Parser, new string[]
			{
				"SubMissionId",
				"MainMissionId",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
