using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A4 RID: 4516
	public static class StartChallengeCsReqReflection
	{
		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600C9A0 RID: 51616 RVA: 0x0021CAAB File Offset: 0x0021ACAB
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartChallengeCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400514D RID: 20813
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTdGFydENoYWxsZW5nZUNzUmVxLnByb3RvGhdDaGFsbGVuZ2VCdWZmSW5m",
			"by5wcm90byKAAQoTU3RhcnRDaGFsbGVuZ2VDc1JlcRIVCg1zZWNvbmRfbGlu",
			"ZXVwGAwgAygNEhQKDGNoYWxsZW5nZV9pZBgEIAEoDRImCgpzdGFnZV9pbmZv",
			"GAUgASgLMhIuQ2hhbGxlbmdlQnVmZkluZm8SFAoMZmlyc3RfbGluZXVwGAkg",
			"AygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChallengeBuffInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartChallengeCsReq), StartChallengeCsReq.Parser, new string[]
			{
				"SecondLineup",
				"ChallengeId",
				"StageInfo",
				"FirstLineup"
			}, null, null, null, null)
		}));
	}
}
