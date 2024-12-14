using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE8 RID: 2792
	public static class MissionStatusBySceneInfoReflection
	{
		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06007BA0 RID: 31648 RVA: 0x00147229 File Offset: 0x00145429
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionStatusBySceneInfoReflection.descriptor;
			}
		}

		// Token: 0x04002F6E RID: 12142
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5NaXNzaW9uU3RhdHVzQnlTY2VuZUluZm8ucHJvdG8aHE1haW5NaXNzaW9u",
			"Q3VzdG9tVmFsdWUucHJvdG8aDU1pc3Npb24ucHJvdG8i9AEKGE1pc3Npb25T",
			"dGF0dXNCeVNjZW5lSW5mbxInCh91bmZpbmlzaGVkX21haW5fbWlzc2lvbl9p",
			"ZF9saXN0GAogAygNEiUKHWRpc2FibGVkX21haW5fbWlzc2lvbl9pZF9saXN0",
			"GAkgAygNEjYKFW1haW5fbWlzc2lvbl9tY3ZfbGlzdBgCIAMoCzIXLk1haW5N",
			"aXNzaW9uQ3VzdG9tVmFsdWUSJQodZmluaXNoZWRfbWFpbl9taXNzaW9uX2lk",
			"X2xpc3QYByADKA0SKQoXc3ViX21pc3Npb25fc3RhdHVzX2xpc3QYDSADKAsy",
			"CC5NaXNzaW9uQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			MainMissionCustomValueReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MissionStatusBySceneInfo), MissionStatusBySceneInfo.Parser, new string[]
			{
				"UnfinishedMainMissionIdList",
				"DisabledMainMissionIdList",
				"MainMissionMcvList",
				"FinishedMainMissionIdList",
				"SubMissionStatusList"
			}, null, null, null, null)
		}));
	}
}
