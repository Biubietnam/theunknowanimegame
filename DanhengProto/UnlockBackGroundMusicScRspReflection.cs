using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013BE RID: 5054
	public static class UnlockBackGroundMusicScRspReflection
	{
		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x0600E158 RID: 57688 RVA: 0x00257B70 File Offset: 0x00255D70
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockBackGroundMusicScRspReflection.descriptor;
			}
		}

		// Token: 0x040059B3 RID: 22963
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBVbmxvY2tCYWNrR3JvdW5kTXVzaWNTY1JzcC5wcm90bxoPTXVzaWNEYXRh",
			"LnByb3RvImwKGlVubG9ja0JhY2tHcm91bmRNdXNpY1NjUnNwEicKE3VubG9j",
			"a2VkX211c2ljX2xpc3QYAiADKAsyCi5NdXNpY0RhdGESFAoMdW5sb2NrZWRf",
			"aWRzGAkgAygNEg8KB3JldGNvZGUYDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MusicDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockBackGroundMusicScRsp), UnlockBackGroundMusicScRsp.Parser, new string[]
			{
				"UnlockedMusicList",
				"UnlockedIds",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
