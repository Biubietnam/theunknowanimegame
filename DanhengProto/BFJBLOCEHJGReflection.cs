using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200011A RID: 282
	public static class BFJBLOCEHJGReflection
	{
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000264C9 File Offset: 0x000246C9
		public static FileDescriptor Descriptor
		{
			get
			{
				return BFJBLOCEHJGReflection.descriptor;
			}
		}

		// Token: 0x0400058A RID: 1418
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRkpCTE9DRUhKRy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtCRkpC" + "TE9DRUhKRxIRCglhdmF0YXJfaWQYCSABKA0SIAoLYXZhdGFyX3R5cGUYBiAB" + "KA4yCy5BdmF0YXJUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BFJBLOCEHJG), BFJBLOCEHJG.Parser, new string[]
			{
				"AvatarId",
				"AvatarType"
			}, null, null, null, null)
		}));
	}
}
