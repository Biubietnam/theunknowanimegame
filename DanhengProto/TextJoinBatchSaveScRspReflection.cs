using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001350 RID: 4944
	public static class TextJoinBatchSaveScRspReflection
	{
		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x0024B874 File Offset: 0x00249A74
		public static FileDescriptor Descriptor
		{
			get
			{
				return TextJoinBatchSaveScRspReflection.descriptor;
			}
		}

		// Token: 0x040057C7 RID: 22471
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUZXh0Sm9pbkJhdGNoU2F2ZVNjUnNwLnByb3RvGhJUZXh0Sm9pbkluZm8u" + "cHJvdG8iUAoWVGV4dEpvaW5CYXRjaFNhdmVTY1JzcBIPCgdyZXRjb2RlGAsg" + "ASgNEiUKDnRleHRfam9pbl9saXN0GA0gAygLMg0uVGV4dEpvaW5JbmZvQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			TextJoinInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinBatchSaveScRsp), TextJoinBatchSaveScRsp.Parser, new string[]
			{
				"Retcode",
				"TextJoinList"
			}, null, null, null, null)
		}));
	}
}
