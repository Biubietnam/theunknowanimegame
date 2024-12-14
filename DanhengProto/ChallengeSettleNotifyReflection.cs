using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B2 RID: 434
	public static class ChallengeSettleNotifyReflection
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00038389 File Offset: 0x00036589
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeSettleNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000834 RID: 2100
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtDaGFsbGVuZ2VTZXR0bGVOb3RpZnkucHJvdG8aEU9NUERKSUpOTkJQLnBy",
			"b3RvGg5JdGVtTGlzdC5wcm90bxoSQ3VyQ2hhbGxlbmdlLnByb3RvIoUCChVD",
			"aGFsbGVuZ2VTZXR0bGVOb3RpZnkSJAoNY3VyX2NoYWxsZW5nZRgEIAEoCzIN",
			"LkN1ckNoYWxsZW5nZRITCgtHR0JDUE5DRE1GQRgBIAEoDRIhCgtDQktMTUZP",
			"QUFGShgLIAEoCzIMLk9NUERKSUpOTkJQEhEKCXNjb3JlX3R3bxgJIAEoDRIX",
			"Cg9jaGFsbGVuZ2Vfc2NvcmUYCiABKA0SGQoGcmV3YXJkGAMgASgLMgkuSXRl",
			"bUxpc3QSFAoMY2hhbGxlbmdlX2lkGAcgASgNEgwKBHN0YXIYDSABKA0SDgoG",
			"aXNfd2luGAIgASgIEhMKC0dMQkpHSUxEQkFLGA8gAygNQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			OMPDJIJNNBPReflection.Descriptor,
			ItemListReflection.Descriptor,
			CurChallengeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeSettleNotify), ChallengeSettleNotify.Parser, new string[]
			{
				"CurChallenge",
				"GGBCPNCDMFA",
				"CBKLMFOAAFJ",
				"ScoreTwo",
				"ChallengeScore",
				"Reward",
				"ChallengeId",
				"Star",
				"IsWin",
				"GLBJGILDBAK"
			}, null, null, null, null)
		}));
	}
}
