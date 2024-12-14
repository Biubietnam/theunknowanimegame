using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB8 RID: 3768
	public static class RogueMagicCurSceneInfoReflection
	{
		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0600A86C RID: 43116 RVA: 0x001C5CBB File Offset: 0x001C3EBB
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicCurSceneInfoReflection.descriptor;
			}
		}

		// Token: 0x040044D8 RID: 17624
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxSb2d1ZU1hZ2ljQ3VyU2NlbmVJbmZvLnByb3RvGhBMaW5ldXBJbmZvLnBy",
			"b3RvGhhSb2d1ZU1hcFJvdGF0ZUluZm8ucHJvdG8aD1NjZW5lSW5mby5wcm90",
			"byJ6ChZSb2d1ZU1hZ2ljQ3VyU2NlbmVJbmZvEhkKBXNjZW5lGA8gASgLMgou",
			"U2NlbmVJbmZvEhsKBmxpbmV1cBgOIAEoCzILLkxpbmV1cEluZm8SKAoLcm90",
			"YXRlX2luZm8YBiABKAsyEy5Sb2d1ZU1hcFJvdGF0ZUluZm9CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor,
			RogueMapRotateInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicCurSceneInfo), RogueMagicCurSceneInfo.Parser, new string[]
			{
				"Scene",
				"Lineup",
				"RotateInfo"
			}, null, null, null, null)
		}));
	}
}
