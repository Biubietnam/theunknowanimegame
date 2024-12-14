using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F6 RID: 246
	public static class BattleRogueMagicInfoReflection
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00020B29 File Offset: 0x0001ED29
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicInfoReflection.descriptor;
			}
		}

		// Token: 0x040004A7 RID: 1191
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpCYXR0bGVSb2d1ZU1hZ2ljSW5mby5wcm90bxogQmF0dGxlUm9ndWVNYWdp",
			"Y0RldGFpbEluZm8ucHJvdG8aIkJhdHRsZVJvZ3VlTWFnaWNNb2RpZmllcklu",
			"Zm8ucHJvdG8igQEKFEJhdHRsZVJvZ3VlTWFnaWNJbmZvEjcKEG1vZGlmaWVy",
			"X2NvbnRlbnQYASABKAsyHS5CYXR0bGVSb2d1ZU1hZ2ljTW9kaWZpZXJJbmZv",
			"EjAKC2RldGFpbF9pbmZvGAIgASgLMhsuQmF0dGxlUm9ndWVNYWdpY0RldGFp",
			"bEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			BattleRogueMagicDetailInfoReflection.Descriptor,
			BattleRogueMagicModifierInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicInfo), BattleRogueMagicInfo.Parser, new string[]
			{
				"ModifierContent",
				"DetailInfo"
			}, null, null, null, null)
		}));
	}
}
