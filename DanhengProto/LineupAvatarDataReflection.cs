using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A10 RID: 2576
	public static class LineupAvatarDataReflection
	{
		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06007268 RID: 29288 RVA: 0x00130609 File Offset: 0x0012E809
		public static FileDescriptor Descriptor
		{
			get
			{
				return LineupAvatarDataReflection.descriptor;
			}
		}

		// Token: 0x04002BF8 RID: 11256
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZMaW5ldXBBdmF0YXJEYXRhLnByb3RvGhBBdmF0YXJUeXBlLnByb3RvIkwK" + "EExpbmV1cEF2YXRhckRhdGESIAoLYXZhdGFyX3R5cGUYAyABKA4yCy5BdmF0" + "YXJUeXBlEgoKAmhwGA4gASgNEgoKAmlkGAkgASgNQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LineupAvatarData), LineupAvatarData.Parser, new string[]
			{
				"AvatarType",
				"Hp",
				"Id"
			}, null, null, null, null)
		}));
	}
}
