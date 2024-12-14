using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D00 RID: 3328
	public static class PrivacySettingsReflection
	{
		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x060094B0 RID: 38064 RVA: 0x0018B3B1 File Offset: 0x001895B1
		public static FileDescriptor Descriptor
		{
			get
			{
				return PrivacySettingsReflection.descriptor;
			}
		}

		// Token: 0x04003994 RID: 14740
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVQcml2YWN5U2V0dGluZ3MucHJvdG8iegoPUHJpdmFjeVNldHRpbmdzEhMK",
			"C1BKSUxFTU1CTEZHGAIgASgIEhMKC05NSkRCT0lQRklDGA4gASgIEhMKC05F",
			"TkdFSUlKSkNCGAggASgIEhMKC0NQRUVFUERCQlBIGAwgASgIEhMKC0dOT0hO",
			"UEpCRkpDGAUgASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PrivacySettings), PrivacySettings.Parser, new string[]
			{
				"PJILEMMBLFG",
				"NMJDBOIPFIC",
				"NENGEIIJJCB",
				"CPEEEPDBBPH",
				"GNOHNPJBFJC"
			}, null, null, null, null)
		}));
	}
}
