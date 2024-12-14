using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D0 RID: 4304
	public static class SetAvatarPathCsReqReflection
	{
		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600BFF7 RID: 49143 RVA: 0x00204BC4 File Offset: 0x00202DC4
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetAvatarPathCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004DE5 RID: 19941
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRBdmF0YXJQYXRoQ3NSZXEucHJvdG8aGU11bHRpUGF0aEF2YXRhclR5" + "cGUucHJvdG8iPQoSU2V0QXZhdGFyUGF0aENzUmVxEicKCWF2YXRhcl9pZBgB" + "IAEoDjIULk11bHRpUGF0aEF2YXRhclR5cGVCHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetAvatarPathCsReq), SetAvatarPathCsReq.Parser, new string[]
			{
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
