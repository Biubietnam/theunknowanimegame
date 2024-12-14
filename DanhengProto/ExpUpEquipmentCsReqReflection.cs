using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004E8 RID: 1256
	public static class ExpUpEquipmentCsReqReflection
	{
		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x0009A0D5 File Offset: 0x000982D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExpUpEquipmentCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001640 RID: 5696
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFeHBVcEVxdWlwbWVudENzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJv" + "dG8iVAoTRXhwVXBFcXVpcG1lbnRDc1JlcRIbChNlcXVpcG1lbnRfdW5pcXVl" + "X2lkGAEgASgNEiAKCWNvc3RfZGF0YRgOIAEoCzINLkl0ZW1Db3N0RGF0YUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpEquipmentCsReq), ExpUpEquipmentCsReq.Parser, new string[]
			{
				"EquipmentUniqueId",
				"CostData"
			}, null, null, null, null)
		}));
	}
}
