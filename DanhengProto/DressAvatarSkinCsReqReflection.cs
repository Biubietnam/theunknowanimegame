using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D4 RID: 980
	public static class DressAvatarSkinCsReqReflection
	{
		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000797C6 File Offset: 0x000779C6
		public static FileDescriptor Descriptor
		{
			get
			{
				return DressAvatarSkinCsReqReflection.descriptor;
			}
		}

		// Token: 0x040011B0 RID: 4528
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEcmVzc0F2YXRhclNraW5Dc1JlcS5wcm90byI6ChREcmVzc0F2YXRhclNr" + "aW5Dc1JlcRIRCglhdmF0YXJfaWQYAyABKA0SDwoHc2tpbl9pZBgMIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DressAvatarSkinCsReq), DressAvatarSkinCsReq.Parser, new string[]
			{
				"AvatarId",
				"SkinId"
			}, null, null, null, null)
		}));
	}
}
