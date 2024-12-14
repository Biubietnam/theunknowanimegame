using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200059C RID: 1436
	public static class FinishTalkMissionScRspReflection
	{
		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x0600401F RID: 16415 RVA: 0x000AEAD6 File Offset: 0x000ACCD6
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishTalkMissionScRspReflection.descriptor;
			}
		}

		// Token: 0x04001977 RID: 6519
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxGaW5pc2hUYWxrTWlzc2lvblNjUnNwLnByb3RvGhhNaXNzaW9uQ3VzdG9t",
			"VmFsdWUucHJvdG8igwEKFkZpbmlzaFRhbGtNaXNzaW9uU2NSc3ASDwoHcmV0",
			"Y29kZRgBIAEoDRIWCg5zdWJfbWlzc2lvbl9pZBgKIAEoDRIQCgh0YWxrX3N0",
			"chgGIAEoCRIuChFjdXN0b21fdmFsdWVfbGlzdBgDIAMoCzITLk1pc3Npb25D",
			"dXN0b21WYWx1ZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			MissionCustomValueReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishTalkMissionScRsp), FinishTalkMissionScRsp.Parser, new string[]
			{
				"Retcode",
				"SubMissionId",
				"TalkStr",
				"CustomValueList"
			}, null, null, null, null)
		}));
	}
}
