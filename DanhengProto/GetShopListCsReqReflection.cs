using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F4 RID: 2036
	public static class GetShopListCsReqReflection
	{
		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x000F201A File Offset: 0x000F021A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetShopListCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002339 RID: 9017
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRTaG9wTGlzdENzUmVxLnByb3RvIiUKEEdldFNob3BMaXN0Q3NSZXES" + "EQoJc2hvcF90eXBlGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetShopListCsReq), GetShopListCsReq.Parser, new string[]
			{
				"ShopType"
			}, null, null, null, null)
		}));
	}
}
