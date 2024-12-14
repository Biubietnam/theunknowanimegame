using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A6 RID: 4774
	public static class SyncTaskScRspReflection
	{
		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0600D4FD RID: 54525 RVA: 0x0023887E File Offset: 0x00236A7E
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncTaskScRspReflection.descriptor;
			}
		}

		// Token: 0x0400552A RID: 21802
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTeW5jVGFza1NjUnNwLnByb3RvIi0KDVN5bmNUYXNrU2NSc3ASDwoHcmV0" + "Y29kZRgMIAEoDRILCgNrZXkYDyABKAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncTaskScRsp), SyncTaskScRsp.Parser, new string[]
			{
				"Retcode",
				"Key"
			}, null, null, null, null)
		}));
	}
}
