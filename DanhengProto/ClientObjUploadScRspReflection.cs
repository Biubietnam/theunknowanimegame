using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002E2 RID: 738
	public static class ClientObjUploadScRspReflection
	{
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x0005DB85 File Offset: 0x0005BD85
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientObjUploadScRspReflection.descriptor;
			}
		}

		// Token: 0x04000D9A RID: 3482
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDbGllbnRPYmpVcGxvYWRTY1JzcC5wcm90bxobQ2xpZW50T2JqRG93bmxv" + "YWREYXRhLnByb3RvIk0KFENsaWVudE9ialVwbG9hZFNjUnNwEiQKBGRhdGEY" + "CCABKAsyFi5DbGllbnRPYmpEb3dubG9hZERhdGESDwoHcmV0Y29kZRgDIAEo" + "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ClientObjDownloadDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientObjUploadScRsp), ClientObjUploadScRsp.Parser, new string[]
			{
				"Data",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
