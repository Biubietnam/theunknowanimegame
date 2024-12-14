using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000166 RID: 358
	public static class CancelMarkItemNotifyReflection
	{
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x0002E9C5 File Offset: 0x0002CBC5
		public static FileDescriptor Descriptor
		{
			get
			{
				return CancelMarkItemNotifyReflection.descriptor;
			}
		}

		// Token: 0x040006C8 RID: 1736
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDYW5jZWxNYXJrSXRlbU5vdGlmeS5wcm90byInChRDYW5jZWxNYXJrSXRl" + "bU5vdGlmeRIPCgdpdGVtX2lkGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CancelMarkItemNotify), CancelMarkItemNotify.Parser, new string[]
			{
				"ItemId"
			}, null, null, null, null)
		}));
	}
}
