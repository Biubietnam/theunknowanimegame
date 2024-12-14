using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011EC RID: 4588
	public static class StrongChallengeActivityDataReflection
	{
		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600CD17 RID: 52503 RVA: 0x002267F2 File Offset: 0x002249F2
		public static FileDescriptor Descriptor
		{
			get
			{
				return StrongChallengeActivityDataReflection.descriptor;
			}
		}

		// Token: 0x040052B8 RID: 21176
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFTdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eURhdGEucHJvdG8aH1N0cm9uZ0No",
			"YWxsZW5nZUF2YXRhckRhdGEucHJvdG8imgEKG1N0cm9uZ0NoYWxsZW5nZUFj",
			"dGl2aXR5RGF0YRIQCghwYW5lbF9pZBgJIAEoDRIQCghzdGFnZV9pZBgFIAEo",
			"DRIvCgtORktCQUZGRkdNTxgNIAEoCzIaLlN0cm9uZ0NoYWxsZW5nZUF2YXRh",
			"ckRhdGESEwoLTEJOREdOTExBREEYCiABKA0SEQoJbWF4X3Njb3JlGA4gASgN",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			StrongChallengeAvatarDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StrongChallengeActivityData), StrongChallengeActivityData.Parser, new string[]
			{
				"PanelId",
				"StageId",
				"NFKBAFFFGMO",
				"LBNDGNLLADA",
				"MaxScore"
			}, null, null, null, null)
		}));
	}
}
