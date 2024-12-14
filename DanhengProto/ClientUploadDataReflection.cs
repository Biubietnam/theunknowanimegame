using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002E4 RID: 740
	public static class ClientUploadDataReflection
	{
		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x0005DF1C File Offset: 0x0005C11C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientUploadDataReflection.descriptor;
			}
		}

		// Token: 0x04000DA1 RID: 3489
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZDbGllbnRVcGxvYWREYXRhLnByb3RvIjYKEENsaWVudFVwbG9hZERhdGES" + "EwoLQ0lBRkhGRUZLT0sYASABKAkSDQoFdmFsdWUYAiABKAlCHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientUploadData), ClientUploadData.Parser, new string[]
			{
				"CIAFHFEFKOK",
				"Value"
			}, null, null, null, null)
		}));
	}
}
