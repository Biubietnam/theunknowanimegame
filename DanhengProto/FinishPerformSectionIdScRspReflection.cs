using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000588 RID: 1416
	public static class FinishPerformSectionIdScRspReflection
	{
		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06003F39 RID: 16185 RVA: 0x000AC903 File Offset: 0x000AAB03
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishPerformSectionIdScRspReflection.descriptor;
			}
		}

		// Token: 0x0400192D RID: 6445
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFGaW5pc2hQZXJmb3JtU2VjdGlvbklkU2NSc3AucHJvdG8aEU1lc3NhZ2VJ",
			"dGVtLnByb3RvGg5JdGVtTGlzdC5wcm90byJ+ChtGaW5pc2hQZXJmb3JtU2Vj",
			"dGlvbklkU2NSc3ASGQoGcmV3YXJkGAQgASgLMgkuSXRlbUxpc3QSHwoJaXRl",
			"bV9saXN0GAsgAygLMgwuTWVzc2FnZUl0ZW0SDwoHcmV0Y29kZRgOIAEoDRIS",
			"CgpzZWN0aW9uX2lkGAwgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MessageItemReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishPerformSectionIdScRsp), FinishPerformSectionIdScRsp.Parser, new string[]
			{
				"Reward",
				"ItemList",
				"Retcode",
				"SectionId"
			}, null, null, null, null)
		}));
	}
}
