using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A80 RID: 2688
	public static class MarkAvatarCsReqReflection
	{
		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x0600772E RID: 30510 RVA: 0x0013C30A File Offset: 0x0013A50A
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002DC7 RID: 11719
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVNYXJrQXZhdGFyQ3NSZXEucHJvdG8iNwoPTWFya0F2YXRhckNzUmVxEhEK" + "CWlzX21hcmtlZBgKIAEoCBIRCglhdmF0YXJfaWQYBSABKA1CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkAvatarCsReq), MarkAvatarCsReq.Parser, new string[]
			{
				"IsMarked",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
