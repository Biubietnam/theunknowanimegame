using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000380 RID: 896
	public static class DelMailCsReqReflection
	{
		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x0006F183 File Offset: 0x0006D383
		public static FileDescriptor Descriptor
		{
			get
			{
				return DelMailCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400100E RID: 4110
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJEZWxNYWlsQ3NSZXEucHJvdG8iHwoMRGVsTWFpbENzUmVxEg8KB2lkX2xp" + "c3QYBSADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DelMailCsReq), DelMailCsReq.Parser, new string[]
			{
				"IdList"
			}, null, null, null, null)
		}));
	}
}
