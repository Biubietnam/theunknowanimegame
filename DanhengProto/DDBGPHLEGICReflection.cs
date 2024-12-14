using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000360 RID: 864
	public static class DDBGPHLEGICReflection
	{
		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x0006C16A File Offset: 0x0006A36A
		public static FileDescriptor Descriptor
		{
			get
			{
				return DDBGPHLEGICReflection.descriptor;
			}
		}

		// Token: 0x04000F99 RID: 3993
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFEREJHUEhMRUdJQy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvInUKC0RE",
			"QkdQSExFR0lDEhMKC0lCUFBQQ01PQUZJGAIgASgIEhUKDW1hZ2ljX3VuaXRf",
			"aWQYCiABKA0SGAoQbWFnaWNfdW5pdF9sZXZlbBgEIAEoDRIgCgljb3N0X2Rh",
			"dGEYDiABKAsyDS5JdGVtQ29zdERhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DDBGPHLEGIC), DDBGPHLEGIC.Parser, new string[]
			{
				"IBPPPCMOAFI",
				"MagicUnitId",
				"MagicUnitLevel",
				"CostData"
			}, null, null, null, null)
		}));
	}
}
