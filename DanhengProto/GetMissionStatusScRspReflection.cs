using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000726 RID: 1830
	public static class GetMissionStatusScRspReflection
	{
		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x000DC351 File Offset: 0x000DA551
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMissionStatusScRspReflection.descriptor;
			}
		}

		// Token: 0x04002026 RID: 8230
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRNaXNzaW9uU3RhdHVzU2NSc3AucHJvdG8aHE1haW5NaXNzaW9uQ3Vz",
			"dG9tVmFsdWUucHJvdG8aDU1pc3Npb24ucHJvdG8imgIKFUdldE1pc3Npb25T",
			"dGF0dXNTY1JzcBIPCgdyZXRjb2RlGAMgASgNEjMKEk1haW5NaXNzaW9uTWN2",
			"TGlzdBgGIAMoCzIXLk1haW5NaXNzaW9uQ3VzdG9tVmFsdWUSIQoZRmluaXNo",
			"ZWRNYWluTWlzc2lvbklkTGlzdBgHIAMoDRImChRTdWJNaXNzaW9uU3RhdHVz",
			"TGlzdBgEIAMoCzIILk1pc3Npb24SKAoWTWlzc2lvbkV2ZW50U3RhdHVzTGlz",
			"dBgMIAMoCzIILk1pc3Npb24SIwobVW5maW5pc2hlZE1haW5NaXNzaW9uSWRM",
			"aXN0GAsgAygNEiEKGURpc2FibGVkTWFpbk1pc3Npb25JZExpc3QYASADKA1C",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MainMissionCustomValueReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionStatusScRsp), GetMissionStatusScRsp.Parser, new string[]
			{
				"Retcode",
				"MainMissionMcvList",
				"FinishedMainMissionIdList",
				"SubMissionStatusList",
				"MissionEventStatusList",
				"UnfinishedMainMissionIdList",
				"DisabledMainMissionIdList"
			}, null, null, null, null)
		}));
	}
}
