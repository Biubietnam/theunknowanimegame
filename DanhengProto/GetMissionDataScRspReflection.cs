using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200071E RID: 1822
	public static class GetMissionDataScRspReflection
	{
		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x000DB3D2 File Offset: 0x000D95D2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMissionDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001FFE RID: 8190
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlHZXRNaXNzaW9uRGF0YVNjUnNwLnByb3RvGhFNYWluTWlzc2lvbi5wcm90",
			"bxoNTWlzc2lvbi5wcm90byKeAQoTR2V0TWlzc2lvbkRhdGFTY1JzcBITCgtN",
			"Q0NNTEpGT0pJRBgNIAEoCBIeCgxtaXNzaW9uX2xpc3QYCyADKAsyCC5NaXNz",
			"aW9uEhgKEHRyYWNrX21pc3Npb25faWQYAyABKA0SJwoRbWFpbl9taXNzaW9u",
			"X2xpc3QYDyADKAsyDC5NYWluTWlzc2lvbhIPCgdyZXRjb2RlGAwgASgNQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MainMissionReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionDataScRsp), GetMissionDataScRsp.Parser, new string[]
			{
				"MCCMLJFOJID",
				"MissionList",
				"TrackMissionId",
				"MainMissionList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
