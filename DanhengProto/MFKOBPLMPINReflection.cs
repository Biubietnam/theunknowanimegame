using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ACE RID: 2766
	public static class MFKOBPLMPINReflection
	{
		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06007A8F RID: 31375 RVA: 0x0014489A File Offset: 0x00142A9A
		public static FileDescriptor Descriptor
		{
			get
			{
				return MFKOBPLMPINReflection.descriptor;
			}
		}

		// Token: 0x04002F0B RID: 12043
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFNRktPQlBMTVBJTi5wcm90bxoYTG9iYnlDaGFyYWN0ZXJUeXBlLnByb3Rv",
			"GhpMb2JieUNoYXJhY3RlclN0YXR1cy5wcm90byJeCgtNRktPQlBMTVBJThIo",
			"CgtCSkJBS0pHRkJHQRgBIAEoDjITLkxvYmJ5Q2hhcmFjdGVyVHlwZRIlCgZz",
			"dGF0dXMYAiABKA4yFS5Mb2JieUNoYXJhY3RlclN0YXR1c0IeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			LobbyCharacterTypeReflection.Descriptor,
			LobbyCharacterStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MFKOBPLMPIN), MFKOBPLMPIN.Parser, new string[]
			{
				"BJBAKJGFBGA",
				"Status"
			}, null, null, null, null)
		}));
	}
}
