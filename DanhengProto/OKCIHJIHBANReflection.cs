using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C5A RID: 3162
	public static class OKCIHJIHBANReflection
	{
		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x001734EA File Offset: 0x001716EA
		public static FileDescriptor Descriptor
		{
			get
			{
				return OKCIHJIHBANReflection.descriptor;
			}
		}

		// Token: 0x040035F2 RID: 13810
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFPS0NJSEpJSEJBTi5wcm90bxoQUmVsaWNBZmZpeC5wcm90byJyCgtPS0NJ",
			"SEpJSEJBThILCgNleHAYBSABKA0SIwoOc3ViX2FmZml4X2xpc3QYCyADKAsy",
			"Cy5SZWxpY0FmZml4EhUKDW1haW5fYWZmaXhfaWQYCSABKA0SDQoFbGV2ZWwY",
			"CiABKA0SCwoDdGlkGAwgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RelicAffixReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OKCIHJIHBAN), OKCIHJIHBAN.Parser, new string[]
			{
				"Exp",
				"SubAffixList",
				"MainAffixId",
				"Level",
				"Tid"
			}, null, null, null, null)
		}));
	}
}
