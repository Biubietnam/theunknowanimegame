using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BB4 RID: 2996
	public static class MultiplayerMatch3FinishScNotifyReflection
	{
		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x06008495 RID: 33941 RVA: 0x0015DDFF File Offset: 0x0015BFFF
		public static FileDescriptor Descriptor
		{
			get
			{
				return MultiplayerMatch3FinishScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040032BF RID: 12991
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVNdWx0aXBsYXllck1hdGNoM0ZpbmlzaFNjTm90aWZ5LnByb3RvGhFESFBJ",
			"RktJQ09QUC5wcm90bxoYTWF0Y2gzRmluaXNoUmVhc29uLnByb3RvIpMBCh9N",
			"dWx0aXBsYXllck1hdGNoM0ZpbmlzaFNjTm90aWZ5EiMKBnJlYXNvbhgBIAEo",
			"DjITLk1hdGNoM0ZpbmlzaFJlYXNvbhITCgtHRExPQ0tLTExJSxgJIAEoDRIh",
			"CgtJTUtFTEtNSE9JSxgIIAEoCzIMLkRIUElGS0lDT1BQEhMKC0dCR0hQRkxI",
			"REJQGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			DHPIFKICOPPReflection.Descriptor,
			Match3FinishReasonReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MultiplayerMatch3FinishScNotify), MultiplayerMatch3FinishScNotify.Parser, new string[]
			{
				"Reason",
				"GDLOCKKLLIK",
				"IMKELKMHOIK",
				"GBGHPFLHDBP"
			}, null, null, null, null)
		}));
	}
}
