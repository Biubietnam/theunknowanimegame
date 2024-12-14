using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000724 RID: 1828
	public static class GetMissionStatusCsReqReflection
	{
		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x060051B9 RID: 20921 RVA: 0x000DBF2E File Offset: 0x000DA12E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMissionStatusCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400201A RID: 8218
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRNaXNzaW9uU3RhdHVzQ3NSZXEucHJvdG8icQoVR2V0TWlzc2lvblN0",
			"YXR1c0NzUmVxEh0KFW1pc3Npb25fZXZlbnRfaWRfbGlzdBgIIAMoDRIcChRt",
			"YWluX21pc3Npb25faWRfbGlzdBgFIAMoDRIbChNzdWJfbWlzc2lvbl9pZF9s",
			"aXN0GA0gAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionStatusCsReq), GetMissionStatusCsReq.Parser, new string[]
			{
				"MissionEventIdList",
				"MainMissionIdList",
				"SubMissionIdList"
			}, null, null, null, null)
		}));
	}
}
