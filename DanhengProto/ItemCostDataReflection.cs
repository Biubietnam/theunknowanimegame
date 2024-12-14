using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200094C RID: 2380
	public static class ItemCostDataReflection
	{
		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06006A55 RID: 27221 RVA: 0x0011BD97 File Offset: 0x00119F97
		public static FileDescriptor Descriptor
		{
			get
			{
				return ItemCostDataReflection.descriptor;
			}
		}

		// Token: 0x040028BE RID: 10430
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJJdGVtQ29zdERhdGEucHJvdG8aDkl0ZW1Db3N0LnByb3RvIiwKDEl0ZW1D" + "b3N0RGF0YRIcCglpdGVtX2xpc3QYDSADKAsyCS5JdGVtQ29zdEIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemCostReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ItemCostData), ItemCostData.Parser, new string[]
			{
				"ItemList"
			}, null, null, null, null)
		}));
	}
}
