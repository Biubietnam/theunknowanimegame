using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF6 RID: 3830
	public static class RogueMagicReviveAvatarCsReqReflection
	{
		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x001CCED6 File Offset: 0x001CB0D6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicReviveAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x040045D7 RID: 17879
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSb2d1ZU1hZ2ljUmV2aXZlQXZhdGFyQ3NSZXEucHJvdG8iXQobUm9ndWVN" + "YWdpY1Jldml2ZUF2YXRhckNzUmVxEiEKGWludGVyYWN0ZWRfcHJvcF9lbnRp" + "dHlfaWQYCiABKA0SGwoTYmFzZV9hdmF0YXJfaWRfbGlzdBgCIAMoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicReviveAvatarCsReq), RogueMagicReviveAvatarCsReq.Parser, new string[]
			{
				"InteractedPropEntityId",
				"BaseAvatarIdList"
			}, null, null, null, null)
		}));
	}
}
