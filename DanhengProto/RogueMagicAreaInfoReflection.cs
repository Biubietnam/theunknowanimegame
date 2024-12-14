using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EAA RID: 3754
	public static class RogueMagicAreaInfoReflection
	{
		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600A7BE RID: 42942 RVA: 0x001C3CA8 File Offset: 0x001C1EA8
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicAreaInfoReflection.descriptor;
			}
		}

		// Token: 0x04004494 RID: 17556
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZU1hZ2ljQXJlYUluZm8ucHJvdG8aEU5HUFBNR0tHT0JILnByb3Rv",
			"GhFNSktQQVBNSUxNTC5wcm90byLvAQoSUm9ndWVNYWdpY0FyZWFJbmZvEiYK",
			"HnVubG9ja2VkX3RvdXJuX2RpZmZpY3VsdHlfbGlzdBgBIAMoDRITCgtpc191",
			"bmxvY2tlZBgMIAEoCBIhCgtFQ09OSEdQTkRLSRgNIAEoCzIMLk1KS1BBUE1J",
			"TE1MEhcKD2lzX3Rha2VuX3Jld2FyZBgEIAEoCBITCgtJRUtCTUpFT0lOUBgP",
			"IAEoDRIXCg9pc190b3Vybl9maW5pc2gYCyABKAgSIQoLcmVjb3JkX2luZm8Y",
			"AyABKAsyDC5OR1BQTUdLR09CSBIPCgdhcmVhX2lkGA4gASgNQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			NGPPMGKGOBHReflection.Descriptor,
			MJKPAPMILMLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicAreaInfo), RogueMagicAreaInfo.Parser, new string[]
			{
				"UnlockedTournDifficultyList",
				"IsUnlocked",
				"ECONHGPNDKI",
				"IsTakenReward",
				"IEKBMJEOINP",
				"IsTournFinish",
				"RecordInfo",
				"AreaId"
			}, null, null, null, null)
		}));
	}
}
