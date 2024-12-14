using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F2 RID: 4594
	public static class StrongChallengeAvatarDataReflection
	{
		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600CD5F RID: 52575 RVA: 0x002273B9 File Offset: 0x002255B9
		public static FileDescriptor Descriptor
		{
			get
			{
				return StrongChallengeAvatarDataReflection.descriptor;
			}
		}

		// Token: 0x040052D2 RID: 21202
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9TdHJvbmdDaGFsbGVuZ2VBdmF0YXJEYXRhLnByb3RvGhtTdHJvbmdDaGFs",
			"bGVuZ2VBdmF0YXIucHJvdG8iWwoZU3Ryb25nQ2hhbGxlbmdlQXZhdGFyRGF0",
			"YRIRCglidWZmX2xpc3QYDSADKA0SKwoLYXZhdGFyX2xpc3QYCyADKAsyFi5T",
			"dHJvbmdDaGFsbGVuZ2VBdmF0YXJCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			StrongChallengeAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StrongChallengeAvatarData), StrongChallengeAvatarData.Parser, new string[]
			{
				"BuffList",
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
