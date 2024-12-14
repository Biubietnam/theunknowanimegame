using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A50 RID: 2640
	public static class LobbyQuitScRspReflection
	{
		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06007517 RID: 29975 RVA: 0x0013719E File Offset: 0x0013539E
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyQuitScRspReflection.descriptor;
			}
		}

		// Token: 0x04002D0E RID: 11534
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2JieVF1aXRTY1JzcC5wcm90byIhCg5Mb2JieVF1aXRTY1JzcBIPCgdy" + "ZXRjb2RlGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyQuitScRsp), LobbyQuitScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
