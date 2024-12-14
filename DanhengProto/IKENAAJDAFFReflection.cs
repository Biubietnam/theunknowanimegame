using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000926 RID: 2342
	public static class IKENAAJDAFFReflection
	{
		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06006884 RID: 26756 RVA: 0x00117201 File Offset: 0x00115401
		public static FileDescriptor Descriptor
		{
			get
			{
				return IKENAAJDAFFReflection.descriptor;
			}
		}

		// Token: 0x04002819 RID: 10265
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFJS0VOQUFKREFGRi5wcm90bxoPU2NlbmVJbmZvLnByb3RvGhhSb2d1ZU1h",
			"cFJvdGF0ZUluZm8ucHJvdG8aEExpbmV1cEluZm8ucHJvdG8ibwoLSUtFTkFB",
			"SkRBRkYSKAoLcm90YXRlX2luZm8YBSABKAsyEy5Sb2d1ZU1hcFJvdGF0ZUlu",
			"Zm8SGwoGbGluZXVwGAkgASgLMgsuTGluZXVwSW5mbxIZCgVzY2VuZRgBIAEo",
			"CzIKLlNjZW5lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor,
			RogueMapRotateInfoReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(IKENAAJDAFF), IKENAAJDAFF.Parser, new string[]
			{
				"RotateInfo",
				"Lineup",
				"Scene"
			}, null, null, null, null)
		}));
	}
}
