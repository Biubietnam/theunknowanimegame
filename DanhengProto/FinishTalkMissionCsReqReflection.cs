using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200059A RID: 1434
	public static class FinishTalkMissionCsReqReflection
	{
		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x000AE68B File Offset: 0x000AC88B
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishTalkMissionCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400196D RID: 6509
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxGaW5pc2hUYWxrTWlzc2lvbkNzUmVxLnByb3RvGhhNaXNzaW9uQ3VzdG9t",
			"VmFsdWUucHJvdG8icgoWRmluaXNoVGFsa01pc3Npb25Dc1JlcRIQCgh0YWxr",
			"X3N0chgIIAEoCRIuChFjdXN0b21fdmFsdWVfbGlzdBgCIAMoCzITLk1pc3Np",
			"b25DdXN0b21WYWx1ZRIWCg5zdWJfbWlzc2lvbl9pZBgNIAEoDUIeqgIbRWdn",
			"TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MissionCustomValueReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishTalkMissionCsReq), FinishTalkMissionCsReq.Parser, new string[]
			{
				"TalkStr",
				"CustomValueList",
				"SubMissionId"
			}, null, null, null, null)
		}));
	}
}
