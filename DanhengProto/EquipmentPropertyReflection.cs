using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000498 RID: 1176
	public static class EquipmentPropertyReflection
	{
		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x0008FE31 File Offset: 0x0008E031
		public static FileDescriptor Descriptor
		{
			get
			{
				return EquipmentPropertyReflection.descriptor;
			}
		}

		// Token: 0x040014CE RID: 5326
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdFcXVpcG1lbnRQcm9wZXJ0eS5wcm90byJPChFFcXVpcG1lbnRQcm9wZXJ0" + "eRIKCgJpZBgBIAEoDRIMCgRyYW5rGAIgASgNEhEKCXByb21vdGlvbhgDIAEo" + "DRINCgVsZXZlbBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EquipmentProperty), EquipmentProperty.Parser, new string[]
			{
				"Id",
				"Rank",
				"Promotion",
				"Level"
			}, null, null, null, null)
		}));
	}
}
