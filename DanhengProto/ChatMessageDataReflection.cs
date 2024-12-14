using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D8 RID: 472
	public static class ChatMessageDataReflection
	{
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0003CB25 File Offset: 0x0003AD25
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChatMessageDataReflection.descriptor;
			}
		}

		// Token: 0x040008DF RID: 2271
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVDaGF0TWVzc2FnZURhdGEucHJvdG8aEUxGQ0tQUERMSUpJLnByb3RvGg1N",
			"c2dUeXBlLnByb3RvIp8BCg9DaGF0TWVzc2FnZURhdGESIQoLQk5BQk5DQ01J",
			"TE0YAyABKAsyDC5MRkNLUFBETElKSRIQCghleHRyYV9pZBgNIAEoDRIRCglz",
			"ZW5kZXJfaWQYByABKA0SDwoHY29udGVudBgEIAEoCRITCgtjcmVhdGVfdGlt",
			"ZRgOIAEoBBIeCgxtZXNzYWdlX3R5cGUYCyABKA4yCC5Nc2dUeXBlQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			LFCKPPDLIJIReflection.Descriptor,
			MsgTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChatMessageData), ChatMessageData.Parser, new string[]
			{
				"BNABNCCMILM",
				"ExtraId",
				"SenderId",
				"Content",
				"CreateTime",
				"MessageType"
			}, null, null, null, null)
		}));
	}
}
