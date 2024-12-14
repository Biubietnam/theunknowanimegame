using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C88 RID: 3208
	public static class PDMHACNANPFReflection
	{
		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x06008EA7 RID: 36519 RVA: 0x00179044 File Offset: 0x00177244
		public static FileDescriptor Descriptor
		{
			get
			{
				return PDMHACNANPFReflection.descriptor;
			}
		}

		// Token: 0x040036CC RID: 14028
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFQRE1IQUNOQU5QRi5wcm90bxoRQ09CREhBR0ZFSEQucHJvdG8aIFJvZ3Vl",
			"U3luY0NvbnRleHRCb2FyZEV2ZW50LnByb3RvImIKC1BETUhBQ05BTlBGEjAK",
			"C0pHT0dMTEtEQkJBGAUgASgLMhsuUm9ndWVTeW5jQ29udGV4dEJvYXJkRXZl",
			"bnQSIQoLQkZCQUZEQ0FFUEQYDSABKAsyDC5DT0JESEFHRkVIREIeqgIbRWdn",
			"TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			COBDHAGFEHDReflection.Descriptor,
			RogueSyncContextBoardEventReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PDMHACNANPF), PDMHACNANPF.Parser, new string[]
			{
				"JGOGLLKDBBA",
				"BFBAFDCAEPD"
			}, null, null, null, null)
		}));
	}
}
