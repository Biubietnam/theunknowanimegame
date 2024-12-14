using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010B6 RID: 4278
	public static class SellItemCsReqReflection
	{
		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600BECC RID: 48844 RVA: 0x00201E3D File Offset: 0x0020003D
		public static FileDescriptor Descriptor
		{
			get
			{
				return SellItemCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004D82 RID: 19842
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWxsSXRlbUNzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJvdG8iRgoN" + "U2VsbEl0ZW1Dc1JlcRITCgt0b19tYXRlcmlhbBgBIAEoCBIgCgljb3N0X2Rh" + "dGEYDiABKAsyDS5JdGVtQ29zdERhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SellItemCsReq), SellItemCsReq.Parser, new string[]
			{
				"ToMaterial",
				"CostData"
			}, null, null, null, null)
		}));
	}
}
