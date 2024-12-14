using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200063C RID: 1596
	public static class GetChallengeGroupStatisticsCsReqReflection
	{
		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x000C4232 File Offset: 0x000C2432
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChallengeGroupStatisticsCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001CAC RID: 7340
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZHZXRDaGFsbGVuZ2VHcm91cFN0YXRpc3RpY3NDc1JlcS5wcm90byI0CiBH" + "ZXRDaGFsbGVuZ2VHcm91cFN0YXRpc3RpY3NDc1JlcRIQCghncm91cF9pZBgI" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeGroupStatisticsCsReq), GetChallengeGroupStatisticsCsReq.Parser, new string[]
			{
				"GroupId"
			}, null, null, null, null)
		}));
	}
}
