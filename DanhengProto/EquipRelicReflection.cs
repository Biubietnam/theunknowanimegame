using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200049A RID: 1178
	public static class EquipRelicReflection
	{
		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003483 RID: 13443 RVA: 0x000902D9 File Offset: 0x0008E4D9
		public static FileDescriptor Descriptor
		{
			get
			{
				return EquipRelicReflection.descriptor;
			}
		}

		// Token: 0x040014D9 RID: 5337
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBFcXVpcFJlbGljLnByb3RvIjMKCkVxdWlwUmVsaWMSDAoEdHlwZRgCIAEo" + "DRIXCg9yZWxpY191bmlxdWVfaWQYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EquipRelic), EquipRelic.Parser, new string[]
			{
				"Type",
				"RelicUniqueId"
			}, null, null, null, null)
		}));
	}
}
