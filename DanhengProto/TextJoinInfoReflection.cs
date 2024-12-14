using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001352 RID: 4946
	public static class TextJoinInfoReflection
	{
		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x0024BBC7 File Offset: 0x00249DC7
		public static FileDescriptor Descriptor
		{
			get
			{
				return TextJoinInfoReflection.descriptor;
			}
		}

		// Token: 0x040057CF RID: 22479
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJUZXh0Sm9pbkluZm8ucHJvdG8ihgEKDFRleHRKb2luSW5mbxITCgtETENL",
			"R0VLREJPThgKIAEoCRITCgtBSU5BT0VOTU9NRRgOIAEoCRIZChF0ZXh0X2pv",
			"aW5faXRlbV9pZBgCIAEoDRIbChN0ZXh0X2l0ZW1fY29uZmlnX2lkGAsgASgN",
			"EhQKDHRleHRfaXRlbV9pZBgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinInfo), TextJoinInfo.Parser, new string[]
			{
				"DLCKGEKDBON",
				"AINAOENMOME",
				"TextJoinItemId",
				"TextItemConfigId",
				"TextItemId"
			}, null, null, null, null)
		}));
	}
}
