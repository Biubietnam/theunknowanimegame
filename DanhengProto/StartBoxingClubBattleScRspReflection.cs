using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011A2 RID: 4514
	public static class StartBoxingClubBattleScRspReflection
	{
		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600C987 RID: 51591 RVA: 0x0021C64E File Offset: 0x0021A84E
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartBoxingClubBattleScRspReflection.descriptor;
			}
		}

		// Token: 0x04005144 RID: 20804
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBTdGFydEJveGluZ0NsdWJCYXR0bGVTY1JzcC5wcm90bxoVU2NlbmVCYXR0",
			"bGVJbmZvLnByb3RvImoKGlN0YXJ0Qm94aW5nQ2x1YkJhdHRsZVNjUnNwEiUK",
			"C2JhdHRsZV9pbmZvGAcgASgLMhAuU2NlbmVCYXR0bGVJbmZvEg8KB3JldGNv",
			"ZGUYCSABKA0SFAoMY2hhbGxlbmdlX2lkGAogASgNQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartBoxingClubBattleScRsp), StartBoxingClubBattleScRsp.Parser, new string[]
			{
				"BattleInfo",
				"Retcode",
				"ChallengeId"
			}, null, null, null, null)
		}));
	}
}
