using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CBE RID: 3262
	public static class PlayerHeartBeatScRspReflection
	{
		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x06009145 RID: 37189 RVA: 0x0018083A File Offset: 0x0017EA3A
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerHeartBeatScRspReflection.descriptor;
			}
		}

		// Token: 0x040037F6 RID: 14326
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpQbGF5ZXJIZWFydEJlYXRTY1JzcC5wcm90bxoYQ2xpZW50RG93bmxvYWRE",
			"YXRhLnByb3RvIoMBChRQbGF5ZXJIZWFydEJlYXRTY1JzcBIWCg5zZXJ2ZXJf",
			"dGltZV9tcxgEIAEoBBIPCgdyZXRjb2RlGAwgASgNEioKDWRvd25sb2FkX2Rh",
			"dGEYByABKAsyEy5DbGllbnREb3dubG9hZERhdGESFgoOY2xpZW50X3RpbWVf",
			"bXMYASABKARCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			ClientDownloadDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerHeartBeatScRsp), PlayerHeartBeatScRsp.Parser, new string[]
			{
				"ServerTimeMs",
				"Retcode",
				"DownloadData",
				"ClientTimeMs"
			}, null, null, null, null)
		}));
	}
}
