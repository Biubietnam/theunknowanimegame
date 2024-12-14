using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200019A RID: 410
	public static class ChallengeBossPhaseSettleNotifyReflection
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x000350A9 File Offset: 0x000332A9
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossPhaseSettleNotifyReflection.descriptor;
			}
		}

		// Token: 0x040007BE RID: 1982
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRDaGFsbGVuZ2VCb3NzUGhhc2VTZXR0bGVOb3RpZnkucHJvdG8aEkJhdHRs",
			"ZVRhcmdldC5wcm90byL/AQoeQ2hhbGxlbmdlQm9zc1BoYXNlU2V0dGxlTm90",
			"aWZ5Eg4KBmlzX3dpbhgOIAEoCBIRCglpc19yZXdhcmQYByABKAgSDAoEc3Rh",
			"chgFIAEoDRIpChJiYXR0bGVfdGFyZ2V0X2xpc3QYBCADKAsyDS5CYXR0bGVU",
			"YXJnZXQSEQoJc2NvcmVfdHdvGAwgASgNEhcKD2NoYWxsZW5nZV9zY29yZRgJ",
			"IAEoDRIbChNpc19yZW1haW5pbmdfYWN0aW9uGAYgASgIEhQKDGNoYWxsZW5n",
			"ZV9pZBgDIAEoDRITCgtPR01QRExDREpETBgIIAEoDRINCgVwaGFzZRgBIAEo",
			"DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			BattleTargetReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossPhaseSettleNotify), ChallengeBossPhaseSettleNotify.Parser, new string[]
			{
				"IsWin",
				"IsReward",
				"Star",
				"BattleTargetList",
				"ScoreTwo",
				"ChallengeScore",
				"IsRemainingAction",
				"ChallengeId",
				"OGMPDLCDJDL",
				"Phase"
			}, null, null, null, null)
		}));
	}
}
