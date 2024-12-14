using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000702 RID: 1794
	public static class GetLoginChatInfoScRspReflection
	{
		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06005032 RID: 20530 RVA: 0x000D8242 File Offset: 0x000D6442
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetLoginChatInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F87 RID: 8071
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRMb2dpbkNoYXRJbmZvU2NSc3AucHJvdG8iQQoVR2V0TG9naW5DaGF0" + "SW5mb1NjUnNwEg8KB3JldGNvZGUYCyABKA0SFwoPY29udGFjdF9pZF9saXN0" + "GAYgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetLoginChatInfoScRsp), GetLoginChatInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"ContactIdList"
			}, null, null, null, null)
		}));
	}
}
