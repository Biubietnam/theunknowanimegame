using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000148 RID: 328
	public static class BuyBpLevelScRspReflection
	{
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0002B762 File Offset: 0x00029962
		public static FileDescriptor Descriptor
		{
			get
			{
				return BuyBpLevelScRspReflection.descriptor;
			}
		}

		// Token: 0x0400065A RID: 1626
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCdXlCcExldmVsU2NSc3AucHJvdG8iIgoPQnV5QnBMZXZlbFNjUnNwEg8K" + "B3JldGNvZGUYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BuyBpLevelScRsp), BuyBpLevelScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
