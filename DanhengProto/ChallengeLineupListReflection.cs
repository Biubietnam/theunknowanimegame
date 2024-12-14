using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A8 RID: 424
	public static class ChallengeLineupListReflection
	{
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000374B4 File Offset: 0x000356B4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeLineupListReflection.descriptor;
			}
		}

		// Token: 0x04000814 RID: 2068
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDaGFsbGVuZ2VMaW5ldXBMaXN0LnByb3RvGhlDaGFsbGVuZ2VBdmF0YXJJ" + "bmZvLnByb3RvIkAKE0NoYWxsZW5nZUxpbmV1cExpc3QSKQoLYXZhdGFyX2xp" + "c3QYCSADKAsyFC5DaGFsbGVuZ2VBdmF0YXJJbmZvQh6qAhtFZ2dMaW5rLkRh" + "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ChallengeAvatarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeLineupList), ChallengeLineupList.Parser, new string[]
			{
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
