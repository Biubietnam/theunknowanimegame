using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F78 RID: 3960
	public static class RogueTalentInfoReflection
	{
		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600B073 RID: 45171 RVA: 0x001DA071 File Offset: 0x001D8271
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTalentInfoReflection.descriptor;
			}
		}

		// Token: 0x040047CA RID: 18378
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSb2d1ZVRhbGVudEluZm8ucHJvdG8aGVJvZ3VlVW5sb2NrUHJvZ3Jlc3Mu",
			"cHJvdG8aF1JvZ3VlVGFsZW50U3RhdHVzLnByb3RvIoIBCg9Sb2d1ZVRhbGVu",
			"dEluZm8SEQoJdGFsZW50X2lkGAogASgNEjgKGnJvZ3VlX3VubG9ja19wcm9n",
			"cmVzc19saXN0GAggAygLMhQuUm9ndWVVbmxvY2tQcm9ncmVzcxIiCgZzdGF0",
			"dXMYASABKA4yEi5Sb2d1ZVRhbGVudFN0YXR1c0IeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueUnlockProgressReflection.Descriptor,
			RogueTalentStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTalentInfo), RogueTalentInfo.Parser, new string[]
			{
				"TalentId",
				"RogueUnlockProgressList",
				"Status"
			}, null, null, null, null)
		}));
	}
}
