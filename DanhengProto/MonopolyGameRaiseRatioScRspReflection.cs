using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B38 RID: 2872
	public static class MonopolyGameRaiseRatioScRspReflection
	{
		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x06007F25 RID: 32549 RVA: 0x0014FECA File Offset: 0x0014E0CA
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyGameRaiseRatioScRspReflection.descriptor;
			}
		}

		// Token: 0x040030B5 RID: 12469
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNb25vcG9seUdhbWVSYWlzZVJhdGlvU2NSc3AucHJvdG8iPQobTW9ub3Bv" + "bHlHYW1lUmFpc2VSYXRpb1NjUnNwEg8KB3JldGNvZGUYAiABKA0SDQoFUmF0" + "aW8YCyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGameRaiseRatioScRsp), MonopolyGameRaiseRatioScRsp.Parser, new string[]
			{
				"Retcode",
				"Ratio"
			}, null, null, null, null)
		}));
	}
}
