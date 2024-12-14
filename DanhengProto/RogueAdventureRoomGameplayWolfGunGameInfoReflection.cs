using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE4 RID: 3556
	public static class RogueAdventureRoomGameplayWolfGunGameInfoReflection
	{
		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x06009F2F RID: 40751 RVA: 0x001ABB0B File Offset: 0x001A9D0B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunGameInfoReflection.descriptor;
			}
		}

		// Token: 0x04004159 RID: 16729
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ci9Sb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5HYW1lSW5mby5w",
			"cm90bxotUm9ndWVBZHZlbnR1cmVSb29tR2FtZXBsYXlXb2xmR3VuVGFyZ2V0",
			"LnByb3RvIooBCilSb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5H",
			"YW1lSW5mbxIXCg9nYW1lX3RhcmdldF9udW0YBCABKA0SRAoSYmF0dGxlX3Rh",
			"cmdldF9saXN0GAIgAygLMiguUm9ndWVBZHZlbnR1cmVSb29tR2FtZXBsYXlX",
			"b2xmR3VuVGFyZ2V0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueAdventureRoomGameplayWolfGunTargetReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueAdventureRoomGameplayWolfGunGameInfo), RogueAdventureRoomGameplayWolfGunGameInfo.Parser, new string[]
			{
				"GameTargetNum",
				"BattleTargetList"
			}, null, null, null, null)
		}));
	}
}
