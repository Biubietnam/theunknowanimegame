using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000EC RID: 236
	public static class BattleOpReflection
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0001ED79 File Offset: 0x0001CF79
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleOpReflection.descriptor;
			}
		}

		// Token: 0x04000459 RID: 1113
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg5CYXR0bGVPcC5wcm90byK5AQoIQmF0dGxlT3ASFAoMdHVybl9jb3VudGVy",
			"GAEgASgNEg0KBXN0YXRlGAIgASgNEhgKEGFjdGlvbl9lbnRpdHlfaWQYAyAB",
			"KA0SGAoQdGFyZ2V0X2VudGl0eV9pZBgEIAEoDRIPCgdvcF90eXBlGAUgASgN",
			"EhMKC3NraWxsX2luZGV4GAYgASgNEhkKEW9wZXJhdGlvbl9jb3VudGVyGAcg",
			"ASgNEhMKC0dQQktPQkVQTUNBGAggASgJQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleOp), BattleOp.Parser, new string[]
			{
				"TurnCounter",
				"State",
				"ActionEntityId",
				"TargetEntityId",
				"OpType",
				"SkillIndex",
				"OperationCounter",
				"GPBKOBEPMCA"
			}, null, null, null, null)
		}));
	}
}
