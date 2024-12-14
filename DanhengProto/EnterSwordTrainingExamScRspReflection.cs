using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000474 RID: 1140
	public static class EnterSwordTrainingExamScRspReflection
	{
		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x0008BC0E File Offset: 0x00089E0E
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSwordTrainingExamScRspReflection.descriptor;
			}
		}

		// Token: 0x0400143A RID: 5178
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFFbnRlclN3b3JkVHJhaW5pbmdFeGFtU2NSc3AucHJvdG8aFVNjZW5lQmF0",
			"dGxlSW5mby5wcm90byJVChtFbnRlclN3b3JkVHJhaW5pbmdFeGFtU2NSc3AS",
			"DwoHcmV0Y29kZRgPIAEoDRIlCgtiYXR0bGVfaW5mbxgOIAEoCzIQLlNjZW5l",
			"QmF0dGxlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSwordTrainingExamScRsp), EnterSwordTrainingExamScRsp.Parser, new string[]
			{
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
