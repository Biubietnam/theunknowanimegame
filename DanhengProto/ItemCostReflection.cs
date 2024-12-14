using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200094A RID: 2378
	public static class ItemCostReflection
	{
		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x06006A3C RID: 27196 RVA: 0x0011B954 File Offset: 0x00119B54
		public static FileDescriptor Descriptor
		{
			get
			{
				return ItemCostReflection.descriptor;
			}
		}

		// Token: 0x040028B5 RID: 10421
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5JdGVtQ29zdC5wcm90bxoOUGlsZUl0ZW0ucHJvdG8iXgoISXRlbUNvc3QS" + "HAoJcGlsZV9pdGVtGAYgASgLMgkuUGlsZUl0ZW0SGwoTZXF1aXBtZW50X3Vu" + "aXF1ZV9pZBgCIAEoDRIXCg9yZWxpY191bmlxdWVfaWQYDiABKA1CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			PileItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ItemCost), ItemCost.Parser, new string[]
			{
				"PileItem",
				"EquipmentUniqueId",
				"RelicUniqueId"
			}, null, null, null, null)
		}));
	}
}
