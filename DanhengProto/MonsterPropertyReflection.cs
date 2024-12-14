using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B92 RID: 2962
	public static class MonsterPropertyReflection
	{
		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x06008346 RID: 33606 RVA: 0x0015A7B1 File Offset: 0x001589B1
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonsterPropertyReflection.descriptor;
			}
		}

		// Token: 0x04003235 RID: 12853
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVNb25zdGVyUHJvcGVydHkucHJvdG8iiwEKD01vbnN0ZXJQcm9wZXJ0eRIO",
			"CgZtYXhfaHAYASABKAESDgoGYXR0YWNrGAIgASgBEg8KB2RlZmVuY2UYAyAB",
			"KAESDgoGc2hpZWxkGAQgASgBEg0KBXNwZWVkGAUgASgBEg8KB2xlZnRfaHAY",
			"BiABKAESFwoPZW50ZXJfYmF0dGxlX2hwGAcgASgBQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonsterProperty), MonsterProperty.Parser, new string[]
			{
				"MaxHp",
				"Attack",
				"Defence",
				"Shield",
				"Speed",
				"LeftHp",
				"EnterBattleHp"
			}, null, null, null, null)
		}));
	}
}
