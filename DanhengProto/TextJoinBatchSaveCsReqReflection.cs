using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200134E RID: 4942
	public static class TextJoinBatchSaveCsReqReflection
	{
		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x0600DC9A RID: 56474 RVA: 0x0024B5F8 File Offset: 0x002497F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return TextJoinBatchSaveCsReqReflection.descriptor;
			}
		}

		// Token: 0x040057C1 RID: 22465
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUZXh0Sm9pbkJhdGNoU2F2ZUNzUmVxLnByb3RvGhJUZXh0Sm9pbkluZm8u" + "cHJvdG8iPwoWVGV4dEpvaW5CYXRjaFNhdmVDc1JlcRIlCg50ZXh0X2pvaW5f" + "bGlzdBgOIAMoCzINLlRleHRKb2luSW5mb0IeqgIbRWdnTGluay5EYW5oZW5n" + "U2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			TextJoinInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinBatchSaveCsReq), TextJoinBatchSaveCsReq.Parser, new string[]
			{
				"TextJoinList"
			}, null, null, null, null)
		}));
	}
}
