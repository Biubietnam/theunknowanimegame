using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B0 RID: 176
	public static class ArchiveWolfBroGameScRspReflection
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00015A54 File Offset: 0x00013C54
		public static FileDescriptor Descriptor
		{
			get
			{
				return ArchiveWolfBroGameScRspReflection.descriptor;
			}
		}

		// Token: 0x040002DD RID: 733
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1BcmNoaXZlV29sZkJyb0dhbWVTY1JzcC5wcm90bxoVV29sZkJyb0dhbWVE",
			"YXRhLnByb3RvIlgKF0FyY2hpdmVXb2xmQnJvR2FtZVNjUnNwEg8KB3JldGNv",
			"ZGUYBCABKA0SLAoSd29sZl9icm9fZ2FtZV9kYXRhGAUgASgLMhAuV29sZkJy",
			"b0dhbWVEYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			WolfBroGameDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ArchiveWolfBroGameScRsp), ArchiveWolfBroGameScRsp.Parser, new string[]
			{
				"Retcode",
				"WolfBroGameData"
			}, null, null, null, null)
		}));
	}
}
