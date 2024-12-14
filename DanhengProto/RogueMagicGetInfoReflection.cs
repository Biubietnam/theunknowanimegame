using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EDC RID: 3804
	public static class RogueMagicGetInfoReflection
	{
		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0600AA15 RID: 43541 RVA: 0x001CA324 File Offset: 0x001C8524
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGetInfoReflection.descriptor;
			}
		}

		// Token: 0x0400456F RID: 17775
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdSb2d1ZU1hZ2ljR2V0SW5mby5wcm90bxoZUm9ndWVNYWdpY1N0b3J5SW5m",
			"by5wcm90bxoaUm9ndWVNYWdpY1RhbGVudEluZm8ucHJvdG8aHlJvZ3VlTWFn",
			"aWNEaWZmaWN1bHR5SW5mby5wcm90bxoYUm9ndWVNYWdpY1VuaXRJbmZvLnBy",
			"b3RvGhtSb2d1ZU1hZ2ljU2NlcHRlckluZm8ucHJvdG8aGFJvZ3VlTWFnaWNB",
			"cmVhSW5mby5wcm90byLhAgoRUm9ndWVNYWdpY0dldEluZm8SKAoKc3Rvcnlf",
			"aW5mbxgDIAEoCzIULlJvZ3VlTWFnaWNTdG9yeUluZm8SMgoVcm9ndWVfdG91",
			"cm5fYXJlYV9pbmZvGAUgAygLMhMuUm9ndWVNYWdpY0FyZWFJbmZvEjYKF3Jv",
			"Z3VlX21hZ2ljX3RhbGVudF9pbmZvGAogASgLMhUuUm9ndWVNYWdpY1RhbGVu",
			"dEluZm8SPQodcm9ndWVfbWFnaWNfc2NlcHRlcl9pbmZvX2xpc3QYCCADKAsy",
			"Fi5Sb2d1ZU1hZ2ljU2NlcHRlckluZm8SNwoacm9ndWVfbWFnaWNfdW5pdF9p",
			"bmZvX2xpc3QYBiADKAsyEy5Sb2d1ZU1hZ2ljVW5pdEluZm8SPgobcm9ndWVf",
			"dG91cm5fZGlmZmljdWx0eV9pbmZvGAkgAygLMhkuUm9ndWVNYWdpY0RpZmZp",
			"Y3VsdHlJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicStoryInfoReflection.Descriptor,
			RogueMagicTalentInfoReflection.Descriptor,
			RogueMagicDifficultyInfoReflection.Descriptor,
			RogueMagicUnitInfoReflection.Descriptor,
			RogueMagicScepterInfoReflection.Descriptor,
			RogueMagicAreaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGetInfo), RogueMagicGetInfo.Parser, new string[]
			{
				"StoryInfo",
				"RogueTournAreaInfo",
				"RogueMagicTalentInfo",
				"RogueMagicScepterInfoList",
				"RogueMagicUnitInfoList",
				"RogueTournDifficultyInfo"
			}, null, null, null, null)
		}));
	}
}
