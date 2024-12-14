using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B6 RID: 5046
	public static class UnlockAvatarPathCsReqReflection
	{
		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x0600E100 RID: 57600 RVA: 0x00256EE9 File Offset: 0x002550E9
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockAvatarPathCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005997 RID: 22935
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtVbmxvY2tBdmF0YXJQYXRoQ3NSZXEucHJvdG8aGU11bHRpUGF0aEF2YXRh" + "clR5cGUucHJvdG8iQAoVVW5sb2NrQXZhdGFyUGF0aENzUmVxEicKCWF2YXRh" + "cl9pZBgOIAEoDjIULk11bHRpUGF0aEF2YXRhclR5cGVCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockAvatarPathCsReq), UnlockAvatarPathCsReq.Parser, new string[]
			{
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
