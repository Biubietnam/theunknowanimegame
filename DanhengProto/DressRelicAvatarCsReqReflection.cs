using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003D8 RID: 984
	public static class DressRelicAvatarCsReqReflection
	{
		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x00079D6A File Offset: 0x00077F6A
		public static FileDescriptor Descriptor
		{
			get
			{
				return DressRelicAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x040011BC RID: 4540
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEcmVzc1JlbGljQXZhdGFyQ3NSZXEucHJvdG8aFURyZXNzUmVsaWNQYXJh" + "bS5wcm90byJRChVEcmVzc1JlbGljQXZhdGFyQ3NSZXESEQoJYXZhdGFyX2lk" + "GA0gASgNEiUKC3N3aXRjaF9saXN0GAIgAygLMhAuRHJlc3NSZWxpY1BhcmFt" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			DressRelicParamReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DressRelicAvatarCsReq), DressRelicAvatarCsReq.Parser, new string[]
			{
				"AvatarId",
				"SwitchList"
			}, null, null, null, null)
		}));
	}
}
