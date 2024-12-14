using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200004A RID: 74
	public static class AdventureRoomInfoReflection
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00009450 File Offset: 0x00007650
		public static FileDescriptor Descriptor
		{
			get
			{
				return AdventureRoomInfoReflection.descriptor;
			}
		}

		// Token: 0x0400010F RID: 271
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdBZHZlbnR1cmVSb29tSW5mby5wcm90bxoeUm9ndWVBZHZlbnR1cmVSb29t",
			"U3RhdHVzLnByb3RvGitSb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZH",
			"dW5JbmZvLnByb3RvItEBChFBZHZlbnR1cmVSb29tSW5mbxIaChJyZW1haW5f",
			"bW9uc3Rlcl9udW0YDSABKA0SEAoIc2NvcmVfaWQYDiABKA0SKQoGc3RhdHVz",
			"GAYgASgOMhkuUm9ndWVBZHZlbnR1cmVSb29tU3RhdHVzEhoKEmNhdWdodF9t",
			"b25zdGVyX251bRgDIAEoDRI6CgpxdWVyeV9pbmZvGAkgASgLMiYuUm9ndWVB",
			"ZHZlbnR1cmVSb29tR2FtZXBsYXlXb2xmR3VuSW5mbxILCgNzdXMYCCABKAFC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueAdventureRoomStatusReflection.Descriptor,
			RogueAdventureRoomGameplayWolfGunInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AdventureRoomInfo), AdventureRoomInfo.Parser, new string[]
			{
				"RemainMonsterNum",
				"ScoreId",
				"Status",
				"CaughtMonsterNum",
				"QueryInfo",
				"Sus"
			}, null, null, null, null)
		}));
	}
}
