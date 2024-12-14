using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EBA RID: 3770
	public static class RogueMagicDifficultyInfoReflection
	{
		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x0600A885 RID: 43141 RVA: 0x001C61AF File Offset: 0x001C43AF
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicDifficultyInfoReflection.descriptor;
			}
		}

		// Token: 0x040044E1 RID: 17633
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZU1hZ2ljRGlmZmljdWx0eUluZm8ucHJvdG8iRgoYUm9ndWVNYWdp" + "Y0RpZmZpY3VsdHlJbmZvEhMKC2lzX3VubG9ja2VkGAogASgIEhUKDWRpZmZp" + "Y3VsdHlfaWQYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicDifficultyInfo), RogueMagicDifficultyInfo.Parser, new string[]
			{
				"IsUnlocked",
				"DifficultyId"
			}, null, null, null, null)
		}));
	}
}
