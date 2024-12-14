using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F0 RID: 1776
	public static class GetLevelRewardCsReqReflection
	{
		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004F74 RID: 20340 RVA: 0x000D69D4 File Offset: 0x000D4BD4
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetLevelRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001F53 RID: 8019
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRMZXZlbFJld2FyZENzUmVxLnByb3RvIkcKE0dldExldmVsUmV3YXJk" + "Q3NSZXESIQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0eV9pZBgHIAEoDRINCgVs" + "ZXZlbBgDIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetLevelRewardCsReq), GetLevelRewardCsReq.Parser, new string[]
			{
				"InteractedPropEntityId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
