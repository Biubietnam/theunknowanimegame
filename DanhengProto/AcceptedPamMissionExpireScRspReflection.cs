using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000012 RID: 18
	public static class AcceptedPamMissionExpireScRspReflection
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000034E2 File Offset: 0x000016E2
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptedPamMissionExpireScRspReflection.descriptor;
			}
		}

		// Token: 0x04000037 RID: 55
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNBY2NlcHRlZFBhbU1pc3Npb25FeHBpcmVTY1JzcC5wcm90byJJCh1BY2Nl" + "cHRlZFBhbU1pc3Npb25FeHBpcmVTY1JzcBIPCgdyZXRjb2RlGA8gASgNEhcK" + "D21haW5fbWlzc2lvbl9pZBgFIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptedPamMissionExpireScRsp), AcceptedPamMissionExpireScRsp.Parser, new string[]
			{
				"Retcode",
				"MainMissionId"
			}, null, null, null, null)
		}));
	}
}
