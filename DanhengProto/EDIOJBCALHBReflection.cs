using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003F2 RID: 1010
	public static class EDIOJBCALHBReflection
	{
		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x0007C7D4 File Offset: 0x0007A9D4
		public static FileDescriptor Descriptor
		{
			get
			{
				return EDIOJBCALHBReflection.descriptor;
			}
		}

		// Token: 0x0400121B RID: 4635
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRElPSkJDQUxIQi5wcm90bxoVUm9ndWVDb21tb25CdWZmLnByb3RvIkwK" + "C0VESU9KQkNBTEhCEhYKDnNlbGVjdF9oaW50X2lkGAkgASgNEiUKC0ZDUEpI" + "SUNEQUhPGA4gAygLMhAuUm9ndWVDb21tb25CdWZmQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EDIOJBCALHB), EDIOJBCALHB.Parser, new string[]
			{
				"SelectHintId",
				"FCPJHICDAHO"
			}, null, null, null, null)
		}));
	}
}
