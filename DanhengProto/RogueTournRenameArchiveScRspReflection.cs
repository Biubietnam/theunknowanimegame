using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001002 RID: 4098
	public static class RogueTournRenameArchiveScRspReflection
	{
		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600B65F RID: 46687 RVA: 0x001E95A1 File Offset: 0x001E77A1
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournRenameArchiveScRspReflection.descriptor;
			}
		}

		// Token: 0x040049E8 RID: 18920
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuUmVuYW1lQXJjaGl2ZVNjUnNwLnByb3RvIlAKHFJvZ3Vl" + "VG91cm5SZW5hbWVBcmNoaXZlU2NSc3ASDAoEbmFtZRgOIAEoCRIPCgdyZXRj" + "b2RlGAYgASgNEhEKCW1heF90aW1lcxgEIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournRenameArchiveScRsp), RogueTournRenameArchiveScRsp.Parser, new string[]
			{
				"Name",
				"Retcode",
				"MaxTimes"
			}, null, null, null, null)
		}));
	}
}
