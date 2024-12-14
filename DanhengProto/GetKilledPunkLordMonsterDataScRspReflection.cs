using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006EE RID: 1774
	public static class GetKilledPunkLordMonsterDataScRspReflection
	{
		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x000D659A File Offset: 0x000D479A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetKilledPunkLordMonsterDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F48 RID: 8008
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidHZXRLaWxsZWRQdW5rTG9yZE1vbnN0ZXJEYXRhU2NSc3AucHJvdG8aGFB1",
			"bmtMb3JkTW9uc3RlcktleS5wcm90bxofS2lsbGVkUHVua0xvcmRNb25zdGVy",
			"SW5mby5wcm90byKPAQohR2V0S2lsbGVkUHVua0xvcmRNb25zdGVyRGF0YVNj",
			"UnNwEigKC0tORkRLUEZPSUpIGA8gAygLMhMuUHVua0xvcmRNb25zdGVyS2V5",
			"Eg8KB3JldGNvZGUYDSABKA0SLwoLSEVDTk1HTU5BQ0MYAiADKAsyGi5LaWxs",
			"ZWRQdW5rTG9yZE1vbnN0ZXJJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PunkLordMonsterKeyReflection.Descriptor,
			KilledPunkLordMonsterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetKilledPunkLordMonsterDataScRsp), GetKilledPunkLordMonsterDataScRsp.Parser, new string[]
			{
				"KNFDKPFOIJH",
				"Retcode",
				"HECNMGMNACC"
			}, null, null, null, null)
		}));
	}
}
