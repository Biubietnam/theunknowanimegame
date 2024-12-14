using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE8 RID: 3560
	public static class RogueAdventureRoomGameplayWolfGunTargetReflection
	{
		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x001AC171 File Offset: 0x001AA371
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunTargetReflection.descriptor;
			}
		}

		// Token: 0x04004166 RID: 16742
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ci1Sb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5UYXJnZXQucHJv",
			"dG8aJVJvZ3VlQWR2ZW50dXJlUm9vbVRhcmdldE1pcmFjbGUucHJvdG8aJVJv",
			"Z3VlQWR2ZW50dXJlUm9vbVRhcmdldFJ1YW5tZWkucHJvdG8aIlJvZ3VlQWR2",
			"ZW50dXJlUm9vbVRhcmdldENvaW4ucHJvdG8aIlJvZ3VlQWR2ZW50dXJlUm9v",
			"bVRhcmdldE5vbmUucHJvdG8igQIKJ1JvZ3VlQWR2ZW50dXJlUm9vbUdhbWVw",
			"bGF5V29sZkd1blRhcmdldBIxCgpUYXJnZXROb25lGAogASgLMh0uUm9ndWVB",
			"ZHZlbnR1cmVSb29tVGFyZ2V0Tm9uZRIxCgpUYXJnZXRDb2luGAcgASgLMh0u",
			"Um9ndWVBZHZlbnR1cmVSb29tVGFyZ2V0Q29pbhI3Cg1UYXJnZXRNaXJhY2xl",
			"GAMgASgLMiAuUm9ndWVBZHZlbnR1cmVSb29tVGFyZ2V0TWlyYWNsZRI3Cg1U",
			"YXJnZXRSdWFubWVpGAUgASgLMiAuUm9ndWVBZHZlbnR1cmVSb29tVGFyZ2V0",
			"UnVhbm1laUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			RogueAdventureRoomTargetMiracleReflection.Descriptor,
			RogueAdventureRoomTargetRuanmeiReflection.Descriptor,
			RogueAdventureRoomTargetCoinReflection.Descriptor,
			RogueAdventureRoomTargetNoneReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueAdventureRoomGameplayWolfGunTarget), RogueAdventureRoomGameplayWolfGunTarget.Parser, new string[]
			{
				"TargetNone",
				"TargetCoin",
				"TargetMiracle",
				"TargetRuanmei"
			}, null, null, null, null)
		}));
	}
}
