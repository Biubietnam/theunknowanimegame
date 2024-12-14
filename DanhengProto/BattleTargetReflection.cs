using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000108 RID: 264
	public static class BattleTargetReflection
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00023FD8 File Offset: 0x000221D8
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleTargetReflection.descriptor;
			}
		}

		// Token: 0x04000538 RID: 1336
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJCYXR0bGVUYXJnZXQucHJvdG8iRAoMQmF0dGxlVGFyZ2V0EgoKAmlkGAEg" + "ASgNEhAKCHByb2dyZXNzGAIgASgNEhYKDnRvdGFsX3Byb2dyZXNzGAMgASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleTarget), BattleTarget.Parser, new string[]
			{
				"Id",
				"Progress",
				"TotalProgress"
			}, null, null, null, null)
		}));
	}
}
