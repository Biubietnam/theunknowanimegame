using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000618 RID: 1560
	public static class GetArchiveDataScRspReflection
	{
		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x000BF936 File Offset: 0x000BDB36
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetArchiveDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001BF7 RID: 7159
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRBcmNoaXZlRGF0YVNjUnNwLnByb3RvGhFBcmNoaXZlRGF0YS5wcm90" + "byJKChNHZXRBcmNoaXZlRGF0YVNjUnNwEg8KB3JldGNvZGUYCyABKA0SIgoM" + "YXJjaGl2ZV9kYXRhGAQgASgLMgwuQXJjaGl2ZURhdGFCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ArchiveDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetArchiveDataScRsp), GetArchiveDataScRsp.Parser, new string[]
			{
				"Retcode",
				"ArchiveData"
			}, null, null, null, null)
		}));
	}
}
