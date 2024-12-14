using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F8 RID: 248
	public static class BattleRogueMagicItemInfoReflection
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00020F23 File Offset: 0x0001F123
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicItemInfoReflection.descriptor;
			}
		}

		// Token: 0x040004AE RID: 1198
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5CYXR0bGVSb2d1ZU1hZ2ljSXRlbUluZm8ucHJvdG8aIEJhdHRsZVJvZ3Vl",
			"TWFnaWNSb3VuZENvdW50LnByb3RvGh1CYXR0bGVSb2d1ZU1hZ2ljU2NlcHRl",
			"ci5wcm90byKKAQoYQmF0dGxlUm9ndWVNYWdpY0l0ZW1JbmZvEjcKEmJhdHRs",
			"ZV9yb3VuZF9jb3VudBgBIAEoCzIbLkJhdHRsZVJvZ3VlTWFnaWNSb3VuZENv",
			"dW50EjUKE2JhdHRsZV9zY2VwdGVyX2xpc3QYAiADKAsyGC5CYXR0bGVSb2d1",
			"ZU1hZ2ljU2NlcHRlckIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			BattleRogueMagicRoundCountReflection.Descriptor,
			BattleRogueMagicScepterReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicItemInfo), BattleRogueMagicItemInfo.Parser, new string[]
			{
				"BattleRoundCount",
				"BattleScepterList"
			}, null, null, null, null)
		}));
	}
}
