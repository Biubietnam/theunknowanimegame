using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006EA RID: 1770
	public static class GetJukeboxDataScRspReflection
	{
		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004F32 RID: 20274 RVA: 0x000D5FC2 File Offset: 0x000D41C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetJukeboxDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F3B RID: 7995
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlHZXRKdWtlYm94RGF0YVNjUnNwLnByb3RvGg9NdXNpY0RhdGEucHJvdG8i",
			"aQoTR2V0SnVrZWJveERhdGFTY1JzcBInChN1bmxvY2tlZF9tdXNpY19saXN0",
			"GAsgAygLMgouTXVzaWNEYXRhEhgKEGN1cnJlbnRfbXVzaWNfaWQYBiABKA0S",
			"DwoHcmV0Y29kZRgFIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MusicDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetJukeboxDataScRsp), GetJukeboxDataScRsp.Parser, new string[]
			{
				"UnlockedMusicList",
				"CurrentMusicId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
