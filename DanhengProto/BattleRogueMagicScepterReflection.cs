using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000FE RID: 254
	public static class BattleRogueMagicScepterReflection
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00021894 File Offset: 0x0001FA94
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicScepterReflection.descriptor;
			}
		}

		// Token: 0x040004C2 RID: 1218
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1CYXR0bGVSb2d1ZU1hZ2ljU2NlcHRlci5wcm90bxoaQmF0dGxlUm9ndWVN",
			"YWdpY1VuaXQucHJvdG8i7AEKF0JhdHRsZVJvZ3VlTWFnaWNTY2VwdGVyEhIK",
			"CnNjZXB0ZXJfaWQYASABKA0SOQoacm9ndWVfbWFnaWNfdW5pdF9pbmZvX2xp",
			"c3QYAiADKAsyFS5CYXR0bGVSb2d1ZU1hZ2ljVW5pdBINCgVsZXZlbBgDIAEo",
			"DRI/Cgx0cmVuY2hfY291bnQYBCADKAsyKS5CYXR0bGVSb2d1ZU1hZ2ljU2Nl",
			"cHRlci5UcmVuY2hDb3VudEVudHJ5GjIKEFRyZW5jaENvdW50RW50cnkSCwoD",
			"a2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			BattleRogueMagicUnitReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicScepter), BattleRogueMagicScepter.Parser, new string[]
			{
				"ScepterId",
				"RogueMagicUnitInfoList",
				"Level",
				"TrenchCount"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
