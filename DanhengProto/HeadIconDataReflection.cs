using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000896 RID: 2198
	public static class HeadIconDataReflection
	{
		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06006226 RID: 25126 RVA: 0x00106CF6 File Offset: 0x00104EF6
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeadIconDataReflection.descriptor;
			}
		}

		// Token: 0x040025BF RID: 9663
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJIZWFkSWNvbkRhdGEucHJvdG8iGgoMSGVhZEljb25EYXRhEgoKAmlkGAUg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeadIconData), HeadIconData.Parser, new string[]
			{
				"Id"
			}, null, null, null, null)
		}));
	}
}
