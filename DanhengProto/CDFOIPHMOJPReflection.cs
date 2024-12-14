using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000174 RID: 372
	public static class CDFOIPHMOJPReflection
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00030087 File Offset: 0x0002E287
		public static FileDescriptor Descriptor
		{
			get
			{
				return CDFOIPHMOJPReflection.descriptor;
			}
		}

		// Token: 0x040006F9 RID: 1785
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDREZPSVBITU9KUC5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtDREZP" + "SVBITU9KUBIRCglhdmF0YXJfaWQYBiABKA0SIAoLYXZhdGFyX3R5cGUYDSAB" + "KA4yCy5BdmF0YXJUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CDFOIPHMOJP), CDFOIPHMOJP.Parser, new string[]
			{
				"AvatarId",
				"AvatarType"
			}, null, null, null, null)
		}));
	}
}
