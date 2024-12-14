using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E4E RID: 3662
	public static class RogueCommonDressScepterReflection
	{
		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600A36B RID: 41835 RVA: 0x001B7B2F File Offset: 0x001B5D2F
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonDressScepterReflection.descriptor;
			}
		}

		// Token: 0x040042EE RID: 17134
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1Sb2d1ZUNvbW1vbkRyZXNzU2NlcHRlci5wcm90bxofUm9ndWVNYWdpY0dh",
			"bWVTY2VwdGVySW5mby5wcm90byJSChdSb2d1ZUNvbW1vbkRyZXNzU2NlcHRl",
			"chI3ChN1cGRhdGVfc2NlcHRlcl9pbmZvGA8gASgLMhouUm9ndWVNYWdpY0dh",
			"bWVTY2VwdGVySW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicGameScepterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonDressScepter), RogueCommonDressScepter.Parser, new string[]
			{
				"UpdateScepterInfo"
			}, null, null, null, null)
		}));
	}
}
