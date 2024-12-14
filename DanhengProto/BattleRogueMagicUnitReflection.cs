using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000100 RID: 256
	public static class BattleRogueMagicUnitReflection
	{
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00021D97 File Offset: 0x0001FF97
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicUnitReflection.descriptor;
			}
		}

		// Token: 0x040004CF RID: 1231
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpCYXR0bGVSb2d1ZU1hZ2ljVW5pdC5wcm90byLYAQoUQmF0dGxlUm9ndWVN",
			"YWdpY1VuaXQSFQoNbWFnaWNfdW5pdF9pZBgBIAEoDRINCgVsZXZlbBgCIAEo",
			"DRITCgtEQ0VETkdMQU9KSRgDIAEoCBIUCgxkaWNlX3Nsb3RfaWQYBCABKA0S",
			"OwoLSEdPQ01LTUZOREcYBSADKAsyJi5CYXR0bGVSb2d1ZU1hZ2ljVW5pdC5I",
			"R09DTUtNRk5ER0VudHJ5GjIKEEhHT0NNS01GTkRHRW50cnkSCwoDa2V5GAEg",
			"ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicUnit), BattleRogueMagicUnit.Parser, new string[]
			{
				"MagicUnitId",
				"Level",
				"DCEDNGLAOJI",
				"DiceSlotId",
				"HGOCMKMFNDG"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
