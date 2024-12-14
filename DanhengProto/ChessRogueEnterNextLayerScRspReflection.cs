using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000214 RID: 532
	public static class ChessRogueEnterNextLayerScRspReflection
	{
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00044081 File Offset: 0x00042281
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterNextLayerScRspReflection.descriptor;
			}
		}

		// Token: 0x04000A09 RID: 2569
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNDaGVzc1JvZ3VlRW50ZXJOZXh0TGF5ZXJTY1JzcC5wcm90bxobQ2hlc3NS",
			"b2d1ZUN1cnJlbnRJbmZvLnByb3RvGhRDaGVzc1JvZ3VlSW5mby5wcm90bxol",
			"Q2hlc3NSb2d1ZUxheWVySW5pdGlhbEV2ZW50SW5mby5wcm90bxoYQ2hlc3NS",
			"b2d1ZUdhbWVJbmZvLnByb3RvIvMBCh1DaGVzc1JvZ3VlRW50ZXJOZXh0TGF5",
			"ZXJTY1JzcBIPCgdyZXRjb2RlGA8gASgNEjIKEnJvZ3VlX2N1cnJlbnRfaW5m",
			"bxgKIAEoCzIWLkNoZXNzUm9ndWVDdXJyZW50SW5mbxIjCgpzdGFnZV9pbmZv",
			"GAQgASgLMg8uQ2hlc3NSb2d1ZUluZm8SOgoQYm9hcmRfZXZlbnRfaW5mbxgO",
			"IAEoCzIgLkNoZXNzUm9ndWVMYXllckluaXRpYWxFdmVudEluZm8SLAoPcm9n",
			"dWVfZ2FtZV9pbmZvGAMgASgLMhMuQ2hlc3NSb2d1ZUdhbWVJbmZvQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueCurrentInfoReflection.Descriptor,
			ChessRogueInfoReflection.Descriptor,
			ChessRogueLayerInitialEventInfoReflection.Descriptor,
			ChessRogueGameInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterNextLayerScRsp), ChessRogueEnterNextLayerScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueCurrentInfo",
				"StageInfo",
				"BoardEventInfo",
				"RogueGameInfo"
			}, null, null, null, null)
		}));
	}
}
