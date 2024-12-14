using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000040 RID: 64
	public static class AddBlacklistCsReqReflection
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00008219 File Offset: 0x00006419
		public static FileDescriptor Descriptor
		{
			get
			{
				return AddBlacklistCsReqReflection.descriptor;
			}
		}

		// Token: 0x040000EA RID: 234
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdBZGRCbGFja2xpc3RDc1JlcS5wcm90byIgChFBZGRCbGFja2xpc3RDc1Jl" + "cRILCgN1aWQYCiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AddBlacklistCsReq), AddBlacklistCsReq.Parser, new string[]
			{
				"Uid"
			}, null, null, null, null)
		}));
	}
}
