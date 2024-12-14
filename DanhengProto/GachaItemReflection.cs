using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D2 RID: 1490
	public static class GachaItemReflection
	{
		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x000B55E5 File Offset: 0x000B37E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return GachaItemReflection.descriptor;
			}
		}

		// Token: 0x04001A75 RID: 6773
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9HYWNoYUl0ZW0ucHJvdG8aCkl0ZW0ucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
			"InwKCUdhY2hhSXRlbRIlChJ0cmFuc2Zlcl9pdGVtX2xpc3QYDCABKAsyCS5J",
			"dGVtTGlzdBIZCgpnYWNoYV9pdGVtGAMgASgLMgUuSXRlbRIOCgZpc19uZXcY",
			"CSABKAgSHQoKdG9rZW5faXRlbRgOIAEoCzIJLkl0ZW1MaXN0Qh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GachaItem), GachaItem.Parser, new string[]
			{
				"TransferItemList",
				"GachaItem_",
				"IsNew",
				"TokenItem"
			}, null, null, null, null)
		}));
	}
}
