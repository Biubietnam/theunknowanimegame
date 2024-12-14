using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200018A RID: 394
	public static class CGHBMKAAOGPReflection
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00032A06 File Offset: 0x00030C06
		public static FileDescriptor Descriptor
		{
			get
			{
				return CGHBMKAAOGPReflection.descriptor;
			}
		}

		// Token: 0x04000762 RID: 1890
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDR0hCTUtBQU9HUC5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtDR0hC" + "TUtBQU9HUBIgCgthdmF0YXJfdHlwZRgKIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CGHBMKAAOGP), CGHBMKAAOGP.Parser, new string[]
			{
				"AvatarType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
