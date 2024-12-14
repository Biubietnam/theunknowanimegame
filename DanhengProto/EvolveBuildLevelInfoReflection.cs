using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004AE RID: 1198
	public static class EvolveBuildLevelInfoReflection
	{
		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x000937DC File Offset: 0x000919DC
		public static FileDescriptor Descriptor
		{
			get
			{
				return EvolveBuildLevelInfoReflection.descriptor;
			}
		}

		// Token: 0x04001559 RID: 5465
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpFdm9sdmVCdWlsZExldmVsSW5mby5wcm90bxoXRXZvbHZlQnVpbGRBdmF0",
			"YXIucHJvdG8aEkJhdHRsZVRhcmdldC5wcm90bxobRXZvbHZlQnVpbGRCYXR0",
			"bGVJbmZvLnByb3RvItABChRFdm9sdmVCdWlsZExldmVsSW5mbxInCgthdmF0",
			"YXJfbGlzdBgGIAMoCzISLkV2b2x2ZUJ1aWxkQXZhdGFyEhQKDFBlcmlvZElk",
			"TGlzdBgIIAMoDRIqCgpCYXR0bGVJbmZvGAMgASgLMhYuRXZvbHZlQnVpbGRC",
			"YXR0bGVJbmZvEhIKCkN1ckdhbWVFeHAYDSABKA0SEAoIUm91bmRDbnQYAiAB",
			"KA0SJwoQQmF0dGxlVGFyZ2V0TGlzdBgFIAMoCzINLkJhdHRsZVRhcmdldEIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EvolveBuildAvatarReflection.Descriptor,
			BattleTargetReflection.Descriptor,
			EvolveBuildBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildLevelInfo), EvolveBuildLevelInfo.Parser, new string[]
			{
				"AvatarList",
				"PeriodIdList",
				"BattleInfo",
				"CurGameExp",
				"RoundCnt",
				"BattleTargetList"
			}, null, null, null, null)
		}));
	}
}
