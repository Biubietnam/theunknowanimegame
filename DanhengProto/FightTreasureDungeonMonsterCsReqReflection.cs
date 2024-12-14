using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200055A RID: 1370
	public static class FightTreasureDungeonMonsterCsReqReflection
	{
		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x000A7609 File Offset: 0x000A5809
		public static FileDescriptor Descriptor
		{
			get
			{
				return FightTreasureDungeonMonsterCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001879 RID: 6265
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZGaWdodFRyZWFzdXJlRHVuZ2Vvbk1vbnN0ZXJDc1JlcS5wcm90bxobVHJl",
			"YXN1cmVEdW5nZW9uQXZhdGFyLnByb3RvInkKIEZpZ2h0VHJlYXN1cmVEdW5n",
			"ZW9uTW9uc3RlckNzUmVxEhMKC05DRkFKUEFNQkdEGAkgASgNEisKC2F2YXRh",
			"cl9saXN0GAIgAygLMhYuVHJlYXN1cmVEdW5nZW9uQXZhdGFyEhMKC0VFRUFC",
			"SkNOS0RPGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			TreasureDungeonAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FightTreasureDungeonMonsterCsReq), FightTreasureDungeonMonsterCsReq.Parser, new string[]
			{
				"NCFAJPAMBGD",
				"AvatarList",
				"EEEABJCNKDO"
			}, null, null, null, null)
		}));
	}
}
