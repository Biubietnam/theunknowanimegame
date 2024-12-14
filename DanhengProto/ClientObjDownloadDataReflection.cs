using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002DC RID: 732
	public static class ClientObjDownloadDataReflection
	{
		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0005D181 File Offset: 0x0005B381
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientObjDownloadDataReflection.descriptor;
			}
		}

		// Token: 0x04000D87 RID: 3463
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtDbGllbnRPYmpEb3dubG9hZERhdGEucHJvdG8aGENsaWVudERvd25sb2Fk",
			"RGF0YS5wcm90byJjChVDbGllbnRPYmpEb3dubG9hZERhdGESEwoLSlBES0VQ",
			"SExGRU4YASABKAwSNQoYY2xpZW50X29ial9kb3dubG9hZF9kYXRhGAIgASgL",
			"MhMuQ2xpZW50RG93bmxvYWREYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ClientDownloadDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientObjDownloadData), ClientObjDownloadData.Parser, new string[]
			{
				"JPDKEPHLFEN",
				"ClientObjDownloadData_"
			}, null, null, null, null)
		}));
	}
}
