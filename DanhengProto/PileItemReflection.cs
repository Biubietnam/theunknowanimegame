using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C9C RID: 3228
	public static class PileItemReflection
	{
		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x06008F92 RID: 36754 RVA: 0x0017B60E File Offset: 0x0017980E
		public static FileDescriptor Descriptor
		{
			get
			{
				return PileItemReflection.descriptor;
			}
		}

		// Token: 0x04003725 RID: 14117
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5QaWxlSXRlbS5wcm90byItCghQaWxlSXRlbRIPCgdpdGVtX2lkGAIgASgN" + "EhAKCGl0ZW1fbnVtGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PileItem), PileItem.Parser, new string[]
			{
				"ItemId",
				"ItemNum"
			}, null, null, null, null)
		}));
	}
}
