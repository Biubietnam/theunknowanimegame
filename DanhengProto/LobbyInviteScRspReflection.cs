using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A3E RID: 2622
	public static class LobbyInviteScRspReflection
	{
		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06007463 RID: 29795 RVA: 0x001357AC File Offset: 0x001339AC
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyInviteScRspReflection.descriptor;
			}
		}

		// Token: 0x04002CC6 RID: 11462
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZMb2JieUludml0ZVNjUnNwLnByb3RvIjUKEExvYmJ5SW52aXRlU2NSc3AS" + "DwoHcmV0Y29kZRgGIAEoDRIQCgh1aWRfbGlzdBgEIAMoDUIeqgIbRWdnTGlu" + "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyInviteScRsp), LobbyInviteScRsp.Parser, new string[]
			{
				"Retcode",
				"UidList"
			}, null, null, null, null)
		}));
	}
}
