using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002DE RID: 734
	public static class ClientObjDownloadDataScNotifyReflection
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x0005D558 File Offset: 0x0005B758
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientObjDownloadDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000D8E RID: 3470
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDbGllbnRPYmpEb3dubG9hZERhdGFTY05vdGlmeS5wcm90bxobQ2xpZW50" + "T2JqRG93bmxvYWREYXRhLnByb3RvIkUKHUNsaWVudE9iakRvd25sb2FkRGF0" + "YVNjTm90aWZ5EiQKBGRhdGEYDiABKAsyFi5DbGllbnRPYmpEb3dubG9hZERh" + "dGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ClientObjDownloadDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientObjDownloadDataScNotify), ClientObjDownloadDataScNotify.Parser, new string[]
			{
				"Data"
			}, null, null, null, null)
		}));
	}
}
