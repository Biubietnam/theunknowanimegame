using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200094E RID: 2382
	public static class ItemListReflection
	{
		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06006A69 RID: 27241 RVA: 0x0011C010 File Offset: 0x0011A210
		public static FileDescriptor Descriptor
		{
			get
			{
				return ItemListReflection.descriptor;
			}
		}

		// Token: 0x040028C4 RID: 10436
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5JdGVtTGlzdC5wcm90bxoKSXRlbS5wcm90byIkCghJdGVtTGlzdBIYCglp" + "dGVtX2xpc3QYDCADKAsyBS5JdGVtQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ItemList), ItemList.Parser, new string[]
			{
				"ItemList_"
			}, null, null, null, null)
		}));
	}
}
