using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200107C RID: 4220
	public static class SceneMonsterWaveReflection
	{
		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600BC1A RID: 48154 RVA: 0x001FAD5C File Offset: 0x001F8F5C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneMonsterWaveReflection.descriptor;
			}
		}

		// Token: 0x04004C7C RID: 19580
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZTY2VuZU1vbnN0ZXJXYXZlLnByb3RvGhJTY2VuZU1vbnN0ZXIucHJvdG8a",
			"Dkl0ZW1MaXN0LnByb3RvGhtTY2VuZU1vbnN0ZXJXYXZlUGFyYW0ucHJvdG8i",
			"tQEKEFNjZW5lTW9uc3RlcldhdmUSFgoOYmF0dGxlX3dhdmVfaWQYByABKA0S",
			"HAoJZHJvcF9saXN0GAsgAygLMgkuSXRlbUxpc3QSIwoMbW9uc3Rlcl9saXN0",
			"GAkgAygLMg0uU2NlbmVNb25zdGVyEi0KDW1vbnN0ZXJfcGFyYW0YBiABKAsy",
			"Fi5TY2VuZU1vbnN0ZXJXYXZlUGFyYW0SFwoPYmF0dGxlX3N0YWdlX2lkGAIg",
			"ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SceneMonsterReflection.Descriptor,
			ItemListReflection.Descriptor,
			SceneMonsterWaveParamReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneMonsterWave), SceneMonsterWave.Parser, new string[]
			{
				"BattleWaveId",
				"DropList",
				"MonsterList",
				"MonsterParam",
				"BattleStageId"
			}, null, null, null, null)
		}));
	}
}
