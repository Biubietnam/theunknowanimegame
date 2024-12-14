using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F22 RID: 3874
	public static class RogueMagicStoryInfoReflection
	{
		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0600ACE7 RID: 44263 RVA: 0x001D14D6 File Offset: 0x001CF6D6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicStoryInfoReflection.descriptor;
			}
		}

		// Token: 0x04004676 RID: 18038
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSb2d1ZU1hZ2ljU3RvcnlJbmZvLnByb3RvIjgKE1JvZ3VlTWFnaWNTdG9y" + "eUluZm8SIQoZZmluaXNoZWRfbWFnaWNfc3RvcnlfbGlzdBgOIAMoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicStoryInfo), RogueMagicStoryInfo.Parser, new string[]
			{
				"FinishedMagicStoryList"
			}, null, null, null, null)
		}));
	}
}
