using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000708 RID: 1800
	public static class GetMainMissionCustomValueCsReqReflection
	{
		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x000D8EE6 File Offset: 0x000D70E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMainMissionCustomValueCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001FA7 RID: 8103
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHZXRNYWluTWlzc2lvbkN1c3RvbVZhbHVlQ3NSZXEucHJvdG8iPgoeR2V0" + "TWFpbk1pc3Npb25DdXN0b21WYWx1ZUNzUmVxEhwKFG1haW5fbWlzc2lvbl9p" + "ZF9saXN0GAMgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMainMissionCustomValueCsReq), GetMainMissionCustomValueCsReq.Parser, new string[]
			{
				"MainMissionIdList"
			}, null, null, null, null)
		}));
	}
}
