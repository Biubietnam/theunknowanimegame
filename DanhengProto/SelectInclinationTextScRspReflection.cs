using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010AC RID: 4268
	public static class SelectInclinationTextScRspReflection
	{
		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600BE52 RID: 48722 RVA: 0x00200AF6 File Offset: 0x001FECF6
		public static FileDescriptor Descriptor
		{
			get
			{
				return SelectInclinationTextScRspReflection.descriptor;
			}
		}

		// Token: 0x04004D56 RID: 19798
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTZWxlY3RJbmNsaW5hdGlvblRleHRTY1JzcC5wcm90byJHChpTZWxlY3RJ" + "bmNsaW5hdGlvblRleHRTY1JzcBIYChB0YWxrX3NlbnRlbmNlX2lkGA8gASgN" + "Eg8KB3JldGNvZGUYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SelectInclinationTextScRsp), SelectInclinationTextScRsp.Parser, new string[]
			{
				"TalkSentenceId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
