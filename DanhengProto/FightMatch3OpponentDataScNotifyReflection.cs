using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200054C RID: 1356
	public static class FightMatch3OpponentDataScNotifyReflection
	{
		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06003C73 RID: 15475 RVA: 0x000A59E9 File Offset: 0x000A3BE9
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightMatch3OpponentDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400183F RID: 6207
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVGaWdodE1hdGNoM09wcG9uZW50RGF0YVNjTm90aWZ5LnByb3RvGhFCTEJK",
			"QkFNRE5CTi5wcm90byKGAQofRmlnaHRNYXRjaDNPcHBvbmVudERhdGFTY05v",
			"dGlmeRITCgtQUEpMTkVETkRBSBgFIAEoDRIKCgJocBgKIAEoDRITCgtETkFN",
			"RE5DTE9KQxgNIAEoDRIQCghzY29yZV9pZBgMIAEoDRIbCgVzdGF0ZRgLIAEo",
			"DjIMLkJMQkpCQU1ETkJOQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			BLBJBAMDNBNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightMatch3OpponentDataScNotify), FightMatch3OpponentDataScNotify.Parser, new string[]
			{
				"PPJLNEDNDAH",
				"Hp",
				"DNAMDNCLOJC",
				"ScoreId",
				"State"
			}, null, null, null, null)
		}));
	}
}
