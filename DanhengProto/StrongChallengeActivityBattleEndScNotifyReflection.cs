using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011EA RID: 4586
	public static class StrongChallengeActivityBattleEndScNotifyReflection
	{
		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600CCF4 RID: 52468 RVA: 0x0022604C File Offset: 0x0022424C
		public static FileDescriptor Descriptor
		{
			get
			{
				return StrongChallengeActivityBattleEndScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040052A5 RID: 21157
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ci5TdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eUJhdHRsZUVuZFNjTm90aWZ5LnBy",
			"b3RvGhVCYXR0bGVFbmRTdGF0dXMucHJvdG8i3AEKKFN0cm9uZ0NoYWxsZW5n",
			"ZUFjdGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkSEwoLR09DSkZJQUVNS0IYCCAB",
			"KA0SFAoMdG90YWxfZGFtYWdlGA4gASgNEhEKCW1heF9zY29yZRgEIAEoDRIT",
			"CgtFTUdMQkZNRkJMThgHIAEoDRITCgtCSEJFQktGREtFTxgJIAEoDRIQCghz",
			"Y29yZV9pZBgMIAEoDRIQCghzdGFnZV9pZBgCIAEoDRIkCgplbmRfc3RhdHVz",
			"GA0gASgOMhAuQmF0dGxlRW5kU3RhdHVzQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			BattleEndStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StrongChallengeActivityBattleEndScNotify), StrongChallengeActivityBattleEndScNotify.Parser, new string[]
			{
				"GOCJFIAEMKB",
				"TotalDamage",
				"MaxScore",
				"EMGLBFMFBLN",
				"BHBEBKFDKEO",
				"ScoreId",
				"StageId",
				"EndStatus"
			}, null, null, null, null)
		}));
	}
}
