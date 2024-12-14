using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D66 RID: 3430
	public static class RaidCollectionEnterNextRaidCsReqReflection
	{
		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x06009947 RID: 39239 RVA: 0x00197F3F File Offset: 0x0019613F
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidCollectionEnterNextRaidCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003B7F RID: 15231
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZSYWlkQ29sbGVjdGlvbkVudGVyTmV4dFJhaWRDc1JlcS5wcm90byJzCiBS",
			"YWlkQ29sbGVjdGlvbkVudGVyTmV4dFJhaWRDc1JlcRIUCgxpc19zYXZlX2Rh",
			"dGEYCyABKA0SDwoHcmFpZF9pZBgOIAEoDRITCgthdmF0YXJfbGlzdBgCIAMo",
			"DRITCgt3b3JsZF9sZXZlbBgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionEnterNextRaidCsReq), RaidCollectionEnterNextRaidCsReq.Parser, new string[]
			{
				"IsSaveData",
				"RaidId",
				"AvatarList",
				"WorldLevel"
			}, null, null, null, null)
		}));
	}
}
