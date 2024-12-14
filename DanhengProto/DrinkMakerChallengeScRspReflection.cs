using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003E0 RID: 992
	public static class DrinkMakerChallengeScRspReflection
	{
		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002C2E RID: 11310 RVA: 0x0007A9FC File Offset: 0x00078BFC
		public static FileDescriptor Descriptor
		{
			get
			{
				return DrinkMakerChallengeScRspReflection.descriptor;
			}
		}

		// Token: 0x040011D7 RID: 4567
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5Ecmlua01ha2VyQ2hhbGxlbmdlU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnBy",
			"b3RvInAKGERyaW5rTWFrZXJDaGFsbGVuZ2VTY1JzcBIPCgdyZXRjb2RlGAog",
			"ASgNEhIKCmlzX3N1Y2Nlc3MYBiABKAgSGQoGcmV3YXJkGAIgASgLMgkuSXRl",
			"bUxpc3QSFAoMY2hhbGxlbmdlX2lkGA0gASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerChallengeScRsp), DrinkMakerChallengeScRsp.Parser, new string[]
			{
				"Retcode",
				"IsSuccess",
				"Reward",
				"ChallengeId"
			}, null, null, null, null)
		}));
	}
}
