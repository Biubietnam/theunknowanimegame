using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D78 RID: 3448
	public static class RankUpEquipmentCsReqReflection
	{
		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x06009A14 RID: 39444 RVA: 0x0019A36E File Offset: 0x0019856E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RankUpEquipmentCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003BD6 RID: 15318
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSYW5rVXBFcXVpcG1lbnRDc1JlcS5wcm90bxoSSXRlbUNvc3REYXRhLnBy" + "b3RvIlUKFFJhbmtVcEVxdWlwbWVudENzUmVxEiAKCWNvc3RfZGF0YRgIIAEo" + "CzINLkl0ZW1Db3N0RGF0YRIbChNlcXVpcG1lbnRfdW5pcXVlX2lkGAMgASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RankUpEquipmentCsReq), RankUpEquipmentCsReq.Parser, new string[]
			{
				"CostData",
				"EquipmentUniqueId"
			}, null, null, null, null)
		}));
	}
}
