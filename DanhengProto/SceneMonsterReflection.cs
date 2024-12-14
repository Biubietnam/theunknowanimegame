using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200107A RID: 4218
	public static class SceneMonsterReflection
	{
		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600BC01 RID: 48129 RVA: 0x001FA96F File Offset: 0x001F8B6F
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneMonsterReflection.descriptor;
			}
		}

		// Token: 0x04004C73 RID: 19571
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJTY2VuZU1vbnN0ZXIucHJvdG8iQgoMU2NlbmVNb25zdGVyEg4KBm1heF9o" + "cBgKIAEoDRIOCgZjdXJfaHAYDiABKA0SEgoKbW9uc3Rlcl9pZBgLIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneMonster), SceneMonster.Parser, new string[]
			{
				"MaxHp",
				"CurHp",
				"MonsterId"
			}, null, null, null, null)
		}));
	}
}
