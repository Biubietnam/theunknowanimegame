using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E8E RID: 3726
	public static class RogueGambleMazeInfoReflection
	{
		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0600A673 RID: 42611 RVA: 0x001C0231 File Offset: 0x001BE431
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGambleMazeInfoReflection.descriptor;
			}
		}

		// Token: 0x04004417 RID: 17431
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlSb2d1ZUdhbWJsZU1hemVJbmZvLnByb3RvGhFFTkhIR0FNRUtNQi5wcm90",
			"bxoRT01QRUJEQU9GSUcucHJvdG8igQEKE1JvZ3VlR2FtYmxlTWF6ZUluZm8S",
			"DwoHbWF6ZV9pZBgOIAEoDRITCgttYXplX2VuYWJsZRgJIAEoCBIhCgtCS05H",
			"Q0JJQlBGSxgDIAEoCzIMLkVOSEhHQU1FS01CEiEKC0FITEFLS0dQSEdEGA0g",
			"ASgLMgwuT01QRUJEQU9GSUdCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ENHHGAMEKMBReflection.Descriptor,
			OMPEBDAOFIGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGambleMazeInfo), RogueGambleMazeInfo.Parser, new string[]
			{
				"MazeId",
				"MazeEnable",
				"BKNGCBIBPFK",
				"AHLAKKGPHGD"
			}, null, null, null, null)
		}));
	}
}
