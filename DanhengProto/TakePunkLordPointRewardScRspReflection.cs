using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001312 RID: 4882
	public static class TakePunkLordPointRewardScRspReflection
	{
		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0600D9D5 RID: 55765 RVA: 0x00244485 File Offset: 0x00242685
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakePunkLordPointRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040056C6 RID: 22214
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJUYWtlUHVua0xvcmRQb2ludFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJuChxUYWtlUHVua0xvcmRQb2ludFJld2FyZFNjUnNwEg0KBWxl",
			"dmVsGAggASgNEg8KB3JldGNvZGUYDyABKA0SGQoGcmV3YXJkGAogASgLMgku",
			"SXRlbUxpc3QSEwoLTUdDSUFDRktCRk0YBCABKAhCHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakePunkLordPointRewardScRsp), TakePunkLordPointRewardScRsp.Parser, new string[]
			{
				"Level",
				"Retcode",
				"Reward",
				"MGCIACFKBFM"
			}, null, null, null, null)
		}));
	}
}
