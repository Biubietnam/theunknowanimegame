using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D74 RID: 3444
	public static class RankUpAvatarCsReqReflection
	{
		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x060099E6 RID: 39398 RVA: 0x00199CBC File Offset: 0x00197EBC
		public static FileDescriptor Descriptor
		{
			get
			{
				return RankUpAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003BC8 RID: 15304
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSYW5rVXBBdmF0YXJDc1JlcS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3Rv" + "IlYKEVJhbmtVcEF2YXRhckNzUmVxEgwKBHJhbmsYCyABKA0SIAoJY29zdF9k" + "YXRhGA0gASgLMg0uSXRlbUNvc3REYXRhEhEKCWF2YXRhcl9pZBgOIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RankUpAvatarCsReq), RankUpAvatarCsReq.Parser, new string[]
			{
				"Rank",
				"CostData",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
