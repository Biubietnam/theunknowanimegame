using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200018E RID: 398
	public static class ChallengeAvatarInfoReflection
	{
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x0003351D File Offset: 0x0003171D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeAvatarInfoReflection.descriptor;
			}
		}

		// Token: 0x0400077C RID: 1916
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlDaGFsbGVuZ2VBdmF0YXJJbmZvLnByb3RvGhBBdmF0YXJUeXBlLnByb3Rv",
			"ImEKE0NoYWxsZW5nZUF2YXRhckluZm8SIAoLYXZhdGFyX3R5cGUYDyABKA4y",
			"Cy5BdmF0YXJUeXBlEgoKAmlkGAQgASgNEg0KBWxldmVsGAogASgNEg0KBWlu",
			"ZGV4GAwgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeAvatarInfo), ChallengeAvatarInfo.Parser, new string[]
			{
				"AvatarType",
				"Id",
				"Level",
				"Index"
			}, null, null, null, null)
		}));
	}
}
