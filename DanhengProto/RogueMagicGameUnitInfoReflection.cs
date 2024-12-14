using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EDA RID: 3802
	public static class RogueMagicGameUnitInfoReflection
	{
		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0600A9FE RID: 43518 RVA: 0x001C9F75 File Offset: 0x001C8175
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameUnitInfoReflection.descriptor;
			}
		}

		// Token: 0x04004568 RID: 17768
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxSb2d1ZU1hZ2ljR2FtZVVuaXRJbmZvLnByb3RvGhhSb2d1ZU1hZ2ljR2Ft",
			"ZVVuaXQucHJvdG8iWQoWUm9ndWVNYWdpY0dhbWVVbml0SW5mbxIsCg9nYW1l",
			"X21hZ2ljX3VuaXQYBiABKAsyEy5Sb2d1ZU1hZ2ljR2FtZVVuaXQSEQoJdW5p",
			"cXVlX2lkGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicGameUnitReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGameUnitInfo), RogueMagicGameUnitInfo.Parser, new string[]
			{
				"GameMagicUnit",
				"UniqueId"
			}, null, null, null, null)
		}));
	}
}
