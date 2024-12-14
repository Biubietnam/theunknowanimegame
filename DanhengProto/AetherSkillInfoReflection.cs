using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000070 RID: 112
	public static class AetherSkillInfoReflection
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000DD8F File Offset: 0x0000BF8F
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherSkillInfoReflection.descriptor;
			}
		}

		// Token: 0x040001BD RID: 445
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVBZXRoZXJTa2lsbEluZm8ucHJvdG8iTgoPQWV0aGVyU2tpbGxJbmZvEg8K" + "B2l0ZW1faWQYByABKA0SCwoDbnVtGAYgASgNEh0KFXNraWxsX2RyZXNzX2F2" + "YXRhcl9pZBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherSkillInfo), AetherSkillInfo.Parser, new string[]
			{
				"ItemId",
				"Num",
				"SkillDressAvatarId"
			}, null, null, null, null)
		}));
	}
}
