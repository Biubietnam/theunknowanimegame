using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001212 RID: 4626
	public static class SwapLineupScRspReflection
	{
		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600CED3 RID: 52947 RVA: 0x0022AB62 File Offset: 0x00228D62
		public static FileDescriptor Descriptor
		{
			get
			{
				return SwapLineupScRspReflection.descriptor;
			}
		}

		// Token: 0x0400534A RID: 21322
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVTd2FwTGluZXVwU2NSc3AucHJvdG8iIgoPU3dhcExpbmV1cFNjUnNwEg8K" + "B3JldGNvZGUYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SwapLineupScRsp), SwapLineupScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
