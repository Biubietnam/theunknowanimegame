using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000852 RID: 2130
	public static class GetWolfBroGameDataScRspReflection
	{
		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06005EBA RID: 24250 RVA: 0x000FAA1E File Offset: 0x000F8C1E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetWolfBroGameDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002474 RID: 9332
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXRXb2xmQnJvR2FtZURhdGFTY1JzcC5wcm90bxoVV29sZkJyb0dhbWVE",
			"YXRhLnByb3RvIlgKF0dldFdvbGZCcm9HYW1lRGF0YVNjUnNwEg8KB3JldGNv",
			"ZGUYCyABKA0SLAoSd29sZl9icm9fZ2FtZV9kYXRhGA0gASgLMhAuV29sZkJy",
			"b0dhbWVEYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			WolfBroGameDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetWolfBroGameDataScRsp), GetWolfBroGameDataScRsp.Parser, new string[]
			{
				"Retcode",
				"WolfBroGameData"
			}, null, null, null, null)
		}));
	}
}
