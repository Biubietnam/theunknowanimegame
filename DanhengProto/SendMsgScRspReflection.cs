using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010BC RID: 4284
	public static class SendMsgScRspReflection
	{
		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600BF18 RID: 48920 RVA: 0x00202C1D File Offset: 0x00200E1D
		public static FileDescriptor Descriptor
		{
			get
			{
				return SendMsgScRspReflection.descriptor;
			}
		}

		// Token: 0x04004DA0 RID: 19872
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJTZW5kTXNnU2NSc3AucHJvdG8iMQoMU2VuZE1zZ1NjUnNwEhAKCGVuZF90" + "aW1lGAsgASgEEg8KB3JldGNvZGUYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SendMsgScRsp), SendMsgScRsp.Parser, new string[]
			{
				"EndTime",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
