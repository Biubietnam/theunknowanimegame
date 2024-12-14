using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DAA RID: 3498
	public static class RelicListReflection
	{
		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x06009C6A RID: 40042 RVA: 0x001A0A27 File Offset: 0x0019EC27
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicListReflection.descriptor;
			}
		}

		// Token: 0x04003CCB RID: 15563
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9SZWxpY0xpc3QucHJvdG8iKQoJUmVsaWNMaXN0Eg4KBnNldF9pZBgCIAEo" + "DRIMCgR0eXBlGAwgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RelicList), RelicList.Parser, new string[]
			{
				"SetId",
				"Type"
			}, null, null, null, null)
		}));
	}
}
