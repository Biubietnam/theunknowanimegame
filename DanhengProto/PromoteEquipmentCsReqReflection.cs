using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D0C RID: 3340
	public static class PromoteEquipmentCsReqReflection
	{
		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x0600952D RID: 38189 RVA: 0x0018C846 File Offset: 0x0018AA46
		public static FileDescriptor Descriptor
		{
			get
			{
				return PromoteEquipmentCsReqReflection.descriptor;
			}
		}

		// Token: 0x040039D3 RID: 14803
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQcm9tb3RlRXF1aXBtZW50Q3NSZXEucHJvdG8aEkl0ZW1Db3N0RGF0YS5w" + "cm90byJWChVQcm9tb3RlRXF1aXBtZW50Q3NSZXESGwoTZXF1aXBtZW50X3Vu" + "aXF1ZV9pZBgKIAEoDRIgCgljb3N0X2RhdGEYDiABKAsyDS5JdGVtQ29zdERh" + "dGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PromoteEquipmentCsReq), PromoteEquipmentCsReq.Parser, new string[]
			{
				"EquipmentUniqueId",
				"CostData"
			}, null, null, null, null)
		}));
	}
}
