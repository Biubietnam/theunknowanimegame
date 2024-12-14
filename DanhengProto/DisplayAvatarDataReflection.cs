using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003AA RID: 938
	public static class DisplayAvatarDataReflection
	{
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x00073DE5 File Offset: 0x00071FE5
		public static FileDescriptor Descriptor
		{
			get
			{
				return DisplayAvatarDataReflection.descriptor;
			}
		}

		// Token: 0x040010D0 RID: 4304
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEaXNwbGF5QXZhdGFyRGF0YS5wcm90byIzChFEaXNwbGF5QXZhdGFyRGF0" + "YRIRCglhdmF0YXJfaWQYBSABKA0SCwoDcG9zGAggASgNQh6qAhtFZ2dMaW5r" + "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DisplayAvatarData), DisplayAvatarData.Parser, new string[]
			{
				"AvatarId",
				"Pos"
			}, null, null, null, null)
		}));
	}
}
