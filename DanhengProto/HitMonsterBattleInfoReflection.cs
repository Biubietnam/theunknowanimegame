using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008EE RID: 2286
	public static class HitMonsterBattleInfoReflection
	{
		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x00110921 File Offset: 0x0010EB21
		public static FileDescriptor Descriptor
		{
			get
			{
				return HitMonsterBattleInfoReflection.descriptor;
			}
		}

		// Token: 0x04002734 RID: 10036
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpIaXRNb25zdGVyQmF0dGxlSW5mby5wcm90bxoXTW9uc3RlckJhdHRsZVR5",
			"cGUucHJvdG8iaQoUSGl0TW9uc3RlckJhdHRsZUluZm8SLwoTbW9uc3Rlcl9i",
			"YXR0bGVfdHlwZRgKIAEoDjISLk1vbnN0ZXJCYXR0bGVUeXBlEiAKGHRhcmdl",
			"dF9tb25zdGVyX2VudGl0eV9pZBgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MonsterBattleTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HitMonsterBattleInfo), HitMonsterBattleInfo.Parser, new string[]
			{
				"MonsterBattleType",
				"TargetMonsterEntityId"
			}, null, null, null, null)
		}));
	}
}
