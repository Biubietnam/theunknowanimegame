using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000318 RID: 792
	public static class ComposeItemCsReqReflection
	{
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x00064E67 File Offset: 0x00063067
		public static FileDescriptor Descriptor
		{
			get
			{
				return ComposeItemCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000E96 RID: 3734
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZDb21wb3NlSXRlbUNzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJvdG8i",
			"XwoQQ29tcG9zZUl0ZW1Dc1JlcRINCgVjb3VudBgEIAEoDRISCgpjb21wb3Nl",
			"X2lkGAogASgNEigKEWNvbXBvc2VfaXRlbV9saXN0GAEgASgLMg0uSXRlbUNv",
			"c3REYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ComposeItemCsReq), ComposeItemCsReq.Parser, new string[]
			{
				"Count",
				"ComposeId",
				"ComposeItemList"
			}, null, null, null, null)
		}));
	}
}
