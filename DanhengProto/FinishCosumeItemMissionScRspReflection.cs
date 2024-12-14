using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200056E RID: 1390
	public static class FinishCosumeItemMissionScRspReflection
	{
		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x000A9C1C File Offset: 0x000A7E1C
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishCosumeItemMissionScRspReflection.descriptor;
			}
		}

		// Token: 0x040018CA RID: 6346
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJGaW5pc2hDb3N1bWVJdGVtTWlzc2lvblNjUnNwLnByb3RvIkcKHEZpbmlz" + "aENvc3VtZUl0ZW1NaXNzaW9uU2NSc3ASFgoOc3ViX21pc3Npb25faWQYCSAB" + "KA0SDwoHcmV0Y29kZRgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishCosumeItemMissionScRsp), FinishCosumeItemMissionScRsp.Parser, new string[]
			{
				"SubMissionId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
