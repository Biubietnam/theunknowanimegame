using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200075E RID: 1886
	public static class GetPhoneDataScRspReflection
	{
		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x0600544C RID: 21580 RVA: 0x000E2A32 File Offset: 0x000E0C32
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPhoneDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002115 RID: 8469
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdHZXRQaG9uZURhdGFTY1JzcC5wcm90byKOAQoRR2V0UGhvbmVEYXRhU2NS",
			"c3ASDwoHcmV0Y29kZRgJIAEoDRIaChJvd25lZF9waG9uZV90aGVtZXMYASAD",
			"KA0SGgoSb3duZWRfY2hhdF9idWJibGVzGAcgAygNEhcKD2N1cl9waG9uZV90",
			"aGVtZRgFIAEoDRIXCg9jdXJfY2hhdF9idWJibGUYDSABKA1CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPhoneDataScRsp), GetPhoneDataScRsp.Parser, new string[]
			{
				"Retcode",
				"OwnedPhoneThemes",
				"OwnedChatBubbles",
				"CurPhoneTheme",
				"CurChatBubble"
			}, null, null, null, null)
		}));
	}
}
