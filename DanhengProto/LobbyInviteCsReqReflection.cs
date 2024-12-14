using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A3A RID: 2618
	public static class LobbyInviteCsReqReflection
	{
		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06007436 RID: 29750 RVA: 0x00135122 File Offset: 0x00133322
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyInviteCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002CB7 RID: 11447
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZMb2JieUludml0ZUNzUmVxLnByb3RvIiQKEExvYmJ5SW52aXRlQ3NSZXES" + "EAoIdWlkX2xpc3QYASADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyInviteCsReq), LobbyInviteCsReq.Parser, new string[]
			{
				"UidList"
			}, null, null, null, null)
		}));
	}
}
