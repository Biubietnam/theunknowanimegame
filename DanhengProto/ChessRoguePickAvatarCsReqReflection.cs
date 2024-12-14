using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000264 RID: 612
	public static class ChessRoguePickAvatarCsReqReflection
	{
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0004EC66 File Offset: 0x0004CE66
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRoguePickAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000B84 RID: 2948
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlUGlja0F2YXRhckNzUmVxLnByb3RvIlAKGUNoZXNzUm9n" + "dWVQaWNrQXZhdGFyQ3NSZXESFgoOcHJvcF9lbnRpdHlfaWQYDSABKA0SGwoT" + "YmFzZV9hdmF0YXJfaWRfbGlzdBgCIAMoDUIeqgIbRWdnTGluay5EYW5oZW5n" + "U2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRoguePickAvatarCsReq), ChessRoguePickAvatarCsReq.Parser, new string[]
			{
				"PropEntityId",
				"BaseAvatarIdList"
			}, null, null, null, null)
		}));
	}
}
