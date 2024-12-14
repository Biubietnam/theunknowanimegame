using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DD2 RID: 3538
	public static class RestoreWolfBroGameArchiveScRspReflection
	{
		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x06009E36 RID: 40502 RVA: 0x001A54AA File Offset: 0x001A36AA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RestoreWolfBroGameArchiveScRspReflection.descriptor;
			}
		}

		// Token: 0x04003D77 RID: 15735
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRSZXN0b3JlV29sZkJyb0dhbWVBcmNoaXZlU2NSc3AucHJvdG8aFVdvbGZC",
			"cm9HYW1lRGF0YS5wcm90byJfCh5SZXN0b3JlV29sZkJyb0dhbWVBcmNoaXZl",
			"U2NSc3ASDwoHcmV0Y29kZRgMIAEoDRIsChJ3b2xmX2Jyb19nYW1lX2RhdGEY",
			"CiABKAsyEC5Xb2xmQnJvR2FtZURhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			WolfBroGameDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RestoreWolfBroGameArchiveScRsp), RestoreWolfBroGameArchiveScRsp.Parser, new string[]
			{
				"Retcode",
				"WolfBroGameData"
			}, null, null, null, null)
		}));
	}
}
