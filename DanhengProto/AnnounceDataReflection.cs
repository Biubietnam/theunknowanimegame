using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A2 RID: 162
	public static class AnnounceDataReflection
	{
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x000137EC File Offset: 0x000119EC
		public static FileDescriptor Descriptor
		{
			get
			{
				return AnnounceDataReflection.descriptor;
			}
		}

		// Token: 0x0400028B RID: 651
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJBbm5vdW5jZURhdGEucHJvdG8ixQEKDEFubm91bmNlRGF0YRITCgtCTkdE",
			"S0lCSkhNRBgPIAEoCRITCgtDRU5DQUtESEhIQRgFIAEoCRITCgtKT0NKQUZJ",
			"TERHSBgEIAEoCBISCgpiZWdpbl90aW1lGAsgASgDEhMKC0pDTEhQS0lFRElB",
			"GA4gASgNEhAKCGVuZF90aW1lGAcgASgDEhEKCWNvbmZpZ19pZBgJIAEoDRIT",
			"CgtPREJFRUxHQ0VOSRgBIAEoDRITCgtORk9JSUJKUEZGRxgIIAEoCUIeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AnnounceData), AnnounceData.Parser, new string[]
			{
				"BNGDKIBJHMD",
				"CENCAKDHHHA",
				"JOCJAFILDGH",
				"BeginTime",
				"JCLHPKIEDIA",
				"EndTime",
				"ConfigId",
				"ODBEELGCENI",
				"NFOIIBJPFFG"
			}, null, null, null, null)
		}));
	}
}
