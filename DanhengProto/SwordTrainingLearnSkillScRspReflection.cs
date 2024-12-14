using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001236 RID: 4662
	public static class SwordTrainingLearnSkillScRspReflection
	{
		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0600D048 RID: 53320 RVA: 0x0022DCF6 File Offset: 0x0022BEF6
		public static FileDescriptor Descriptor
		{
			get
			{
				return SwordTrainingLearnSkillScRspReflection.descriptor;
			}
		}

		// Token: 0x040053BC RID: 21436
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nTGVhcm5Ta2lsbFNjUnNwLnByb3RvIkEKHFN3b3Jk" + "VHJhaW5pbmdMZWFyblNraWxsU2NSc3ASEAoIc2tpbGxfaWQYCyABKA0SDwoH" + "cmV0Y29kZRgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingLearnSkillScRsp), SwordTrainingLearnSkillScRsp.Parser, new string[]
			{
				"SkillId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
