using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001000 RID: 4096
	public static class RogueTournRenameArchiveCsReqReflection
	{
		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600B648 RID: 46664 RVA: 0x001E9234 File Offset: 0x001E7434
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournRenameArchiveCsReqReflection.descriptor;
			}
		}

		// Token: 0x040049E1 RID: 18913
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuUmVuYW1lQXJjaGl2ZUNzUmVxLnByb3RvIj8KHFJvZ3Vl" + "VG91cm5SZW5hbWVBcmNoaXZlQ3NSZXESDAoEbmFtZRgJIAEoCRIRCgltYXhf" + "dGltZXMYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournRenameArchiveCsReq), RogueTournRenameArchiveCsReq.Parser, new string[]
			{
				"Name",
				"MaxTimes"
			}, null, null, null, null)
		}));
	}
}
