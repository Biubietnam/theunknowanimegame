using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000FA RID: 250
	public static class BattleRogueMagicModifierInfoReflection
	{
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000212EE File Offset: 0x0001F4EE
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicModifierInfoReflection.descriptor;
			}
		}

		// Token: 0x040004B6 RID: 1206
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJCYXR0bGVSb2d1ZU1hZ2ljTW9kaWZpZXJJbmZvLnByb3RvIkAKHEJhdHRs" + "ZVJvZ3VlTWFnaWNNb2RpZmllckluZm8SIAoYcm9ndWVfbWFnaWNfYmF0dGxl" + "X2NvbnN0GAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicModifierInfo), BattleRogueMagicModifierInfo.Parser, new string[]
			{
				"RogueMagicBattleConst"
			}, null, null, null, null)
		}));
	}
}
