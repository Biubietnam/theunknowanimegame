using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FEA RID: 4074
	public static class RogueTournLevelReflection
	{
		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600B55C RID: 46428 RVA: 0x001E6BF3 File Offset: 0x001E4DF3
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournLevelReflection.descriptor;
			}
		}

		// Token: 0x04004989 RID: 18825
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSb2d1ZVRvdXJuTGV2ZWwucHJvdG8aG1JvZ3VlVG91cm5MYXllclN0YXR1",
			"cy5wcm90bxoYUm9ndWVUb3VyblJvb21MaXN0LnByb3RvIqYBCg9Sb2d1ZVRv",
			"dXJuTGV2ZWwSEAoIbGF5ZXJfaWQYAyABKA0SLAoPdG91cm5fcm9vbV9saXN0",
			"GAUgAygLMhMuUm9ndWVUb3VyblJvb21MaXN0EhMKC2xldmVsX2luZGV4GA4g",
			"ASgNEiYKBnN0YXR1cxgPIAEoDjIWLlJvZ3VlVG91cm5MYXllclN0YXR1cxIW",
			"Cg5jdXJfcm9vbV9pbmRleBgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournLayerStatusReflection.Descriptor,
			RogueTournRoomListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLevel), RogueTournLevel.Parser, new string[]
			{
				"LayerId",
				"TournRoomList",
				"LevelIndex",
				"Status",
				"CurRoomIndex"
			}, null, null, null, null)
		}));
	}
}
