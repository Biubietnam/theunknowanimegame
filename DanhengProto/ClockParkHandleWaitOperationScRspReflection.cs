using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002F4 RID: 756
	public static class ClockParkHandleWaitOperationScRspReflection
	{
		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x000608F7 File Offset: 0x0005EAF7
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClockParkHandleWaitOperationScRspReflection.descriptor;
			}
		}

		// Token: 0x04000DFE RID: 3582
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidDbG9ja1BhcmtIYW5kbGVXYWl0T3BlcmF0aW9uU2NSc3AucHJvdG8aFVNj",
			"ZW5lQmF0dGxlSW5mby5wcm90bxoZQ2xvY2tQYXJrUGxheVN0YXR1cy5wcm90",
			"byLFAQohQ2xvY2tQYXJrSGFuZGxlV2FpdE9wZXJhdGlvblNjUnNwEikKC0tF",
			"TE1EREtETkpBGAYgASgOMhQuQ2xvY2tQYXJrUGxheVN0YXR1cxIPCgdyZXRj",
			"b2RlGA0gASgNEhMKC0hJQUdFSU5MQUhMGAggASgNEiUKC2JhdHRsZV9pbmZv",
			"GAkgASgLMhAuU2NlbmVCYXR0bGVJbmZvEhMKC0ZHQlBBTkNCTEVDGAogASgN",
			"EhMKC0JMUE1ES0VQTUpCGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor,
			ClockParkPlayStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkHandleWaitOperationScRsp), ClockParkHandleWaitOperationScRsp.Parser, new string[]
			{
				"KELMDDKDNJA",
				"Retcode",
				"HIAGEINLAHL",
				"BattleInfo",
				"FGBPANCBLEC",
				"BLPMDKEPMJB"
			}, null, null, null, null)
		}));
	}
}
