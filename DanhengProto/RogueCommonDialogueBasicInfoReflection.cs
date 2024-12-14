using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E40 RID: 3648
	public static class RogueCommonDialogueBasicInfoReflection
	{
		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600A2BC RID: 41660 RVA: 0x001B5B45 File Offset: 0x001B3D45
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueBasicInfoReflection.descriptor;
			}
		}

		// Token: 0x040042AB RID: 17067
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZUNvbW1vbkRpYWxvZ3VlQmFzaWNJbmZvLnByb3RvIk4KHFJvZ3Vl" + "Q29tbW9uRGlhbG9ndWVCYXNpY0luZm8SGAoQdGFsa19kaWFsb2d1ZV9pZBgH" + "IAEoDRIUCgxhZW9uX3RhbGtfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonDialogueBasicInfo), RogueCommonDialogueBasicInfo.Parser, new string[]
			{
				"TalkDialogueId",
				"AeonTalkId"
			}, null, null, null, null)
		}));
	}
}
