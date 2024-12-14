using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F90 RID: 3984
	public static class RogueTournCurSceneInfoReflection
	{
		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600B18E RID: 45454 RVA: 0x001DD692 File Offset: 0x001DB892
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournCurSceneInfoReflection.descriptor;
			}
		}

		// Token: 0x04004840 RID: 18496
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxSb2d1ZVRvdXJuQ3VyU2NlbmVJbmZvLnByb3RvGhBMaW5ldXBJbmZvLnBy",
			"b3RvGhhSb2d1ZU1hcFJvdGF0ZUluZm8ucHJvdG8aD1NjZW5lSW5mby5wcm90",
			"byJ6ChZSb2d1ZVRvdXJuQ3VyU2NlbmVJbmZvEhkKBXNjZW5lGAcgASgLMgou",
			"U2NlbmVJbmZvEigKC3JvdGF0ZV9pbmZvGAEgASgLMhMuUm9ndWVNYXBSb3Rh",
			"dGVJbmZvEhsKBmxpbmV1cBgFIAEoCzILLkxpbmV1cEluZm9CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor,
			RogueMapRotateInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournCurSceneInfo), RogueTournCurSceneInfo.Parser, new string[]
			{
				"Scene",
				"RotateInfo",
				"Lineup"
			}, null, null, null, null)
		}));
	}
}
