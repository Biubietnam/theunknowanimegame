using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200036C RID: 876
	public static class DeleteBlacklistCsReqReflection
	{
		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x0006D2D1 File Offset: 0x0006B4D1
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeleteBlacklistCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000FC6 RID: 4038
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEZWxldGVCbGFja2xpc3RDc1JlcS5wcm90byIjChREZWxldGVCbGFja2xp" + "c3RDc1JlcRILCgN1aWQYCyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeleteBlacklistCsReq), DeleteBlacklistCsReq.Parser, new string[]
			{
				"Uid"
			}, null, null, null, null)
		}));
	}
}
