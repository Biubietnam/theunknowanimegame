using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AAA RID: 2730
	public static class MaterialReflection
	{
		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06007909 RID: 30985 RVA: 0x00140C41 File Offset: 0x0013EE41
		public static FileDescriptor Descriptor
		{
			get
			{
				return MaterialReflection.descriptor;
			}
		}

		// Token: 0x04002E75 RID: 11893
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5NYXRlcmlhbC5wcm90byI5CghNYXRlcmlhbBILCgN0aWQYDyABKA0SCwoD" + "bnVtGAogASgNEhMKC2V4cGlyZV90aW1lGAYgASgEQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Material), Material.Parser, new string[]
			{
				"Tid",
				"Num",
				"ExpireTime"
			}, null, null, null, null)
		}));
	}
}
