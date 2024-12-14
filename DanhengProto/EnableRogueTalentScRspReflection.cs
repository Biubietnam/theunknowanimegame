using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000416 RID: 1046
	public static class EnableRogueTalentScRspReflection
	{
		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x000804FE File Offset: 0x0007E6FE
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnableRogueTalentScRspReflection.descriptor;
			}
		}

		// Token: 0x040012A7 RID: 4775
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxFbmFibGVSb2d1ZVRhbGVudFNjUnNwLnByb3RvGhlSb2d1ZVRhbGVudElu",
			"Zm9MaXN0LnByb3RvIlkKFkVuYWJsZVJvZ3VlVGFsZW50U2NSc3ASDwoHcmV0",
			"Y29kZRgLIAEoDRIuChB0YWxlbnRfaW5mb19saXN0GA8gASgLMhQuUm9ndWVU",
			"YWxlbnRJbmZvTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTalentInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnableRogueTalentScRsp), EnableRogueTalentScRsp.Parser, new string[]
			{
				"Retcode",
				"TalentInfoList"
			}, null, null, null, null)
		}));
	}
}
