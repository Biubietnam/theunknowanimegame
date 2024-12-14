using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FAC RID: 4012
	public static class RogueTournEnterRoomScRspReflection
	{
		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x001E05E5 File Offset: 0x001DE7E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterRoomScRspReflection.descriptor;
			}
		}

		// Token: 0x040048A4 RID: 18596
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5Sb2d1ZVRvdXJuRW50ZXJSb29tU2NSc3AucHJvdG8aHFJvZ3VlVG91cm5D",
			"dXJTY2VuZUluZm8ucHJvdG8iaAoYUm9ndWVUb3VybkVudGVyUm9vbVNjUnNw",
			"EjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGAIgASgLMhcuUm9ndWVU",
			"b3VybkN1clNjZW5lSW5mbxIPCgdyZXRjb2RlGAUgASgNQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterRoomScRsp), RogueTournEnterRoomScRsp.Parser, new string[]
			{
				"RogueTournCurSceneInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
