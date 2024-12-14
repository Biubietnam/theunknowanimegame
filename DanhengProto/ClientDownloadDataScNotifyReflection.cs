using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D6 RID: 726
	public static class ClientDownloadDataScNotifyReflection
	{
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0005C113 File Offset: 0x0005A313
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientDownloadDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000D61 RID: 3425
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDbGllbnREb3dubG9hZERhdGFTY05vdGlmeS5wcm90bxoYQ2xpZW50RG93" + "bmxvYWREYXRhLnByb3RvIkgKGkNsaWVudERvd25sb2FkRGF0YVNjTm90aWZ5" + "EioKDWRvd25sb2FkX2RhdGEYByABKAsyEy5DbGllbnREb3dubG9hZERhdGFC" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ClientDownloadDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientDownloadDataScNotify), ClientDownloadDataScNotify.Parser, new string[]
			{
				"DownloadData"
			}, null, null, null, null)
		}));
	}
}
