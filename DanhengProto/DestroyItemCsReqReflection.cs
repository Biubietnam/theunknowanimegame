using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200038A RID: 906
	public static class DestroyItemCsReqReflection
	{
		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000701D6 File Offset: 0x0006E3D6
		public static FileDescriptor Descriptor
		{
			get
			{
				return DestroyItemCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001031 RID: 4145
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEZXN0cm95SXRlbUNzUmVxLnByb3RvIk8KEERlc3Ryb3lJdGVtQ3NSZXES" + "FgoOY3VyX2l0ZW1fY291bnQYByABKA0SDwoHaXRlbV9pZBgPIAEoDRISCgpp" + "dGVtX2NvdW50GAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DestroyItemCsReq), DestroyItemCsReq.Parser, new string[]
			{
				"CurItemCount",
				"ItemId",
				"ItemCount"
			}, null, null, null, null)
		}));
	}
}
