using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ECA RID: 3786
	public static class RogueMagicEnterRoomScRspReflection
	{
		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0600A939 RID: 43321 RVA: 0x001C7AB1 File Offset: 0x001C5CB1
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterRoomScRspReflection.descriptor;
			}
		}

		// Token: 0x04004515 RID: 17685
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5Sb2d1ZU1hZ2ljRW50ZXJSb29tU2NSc3AucHJvdG8aHFJvZ3VlTWFnaWND",
			"dXJTY2VuZUluZm8ucHJvdG8iaAoYUm9ndWVNYWdpY0VudGVyUm9vbVNjUnNw",
			"Eg8KB3JldGNvZGUYDiABKA0SOwoacm9ndWVfdG91cm5fY3VyX3NjZW5lX2lu",
			"Zm8YBCABKAsyFy5Sb2d1ZU1hZ2ljQ3VyU2NlbmVJbmZvQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnterRoomScRsp), RogueMagicEnterRoomScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
