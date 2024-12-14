using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F1E RID: 3870
	public static class RogueMagicStartCsReqReflection
	{
		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0600ACB5 RID: 44213 RVA: 0x001D0B5D File Offset: 0x001CED5D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicStartCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004660 RID: 18016
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1hZ2ljU3RhcnRDc1JlcS5wcm90byKBAQoUUm9ndWVNYWdpY1N0",
			"YXJ0Q3NSZXESGQoRc2VsZWN0X3N0eWxlX3R5cGUYByABKA0SIAoYc3RhcnRf",
			"ZGlmZmljdWx0eV9pZF9saXN0GAQgAygNEg8KB2FyZWFfaWQYCCABKA0SGwoT",
			"YmFzZV9hdmF0YXJfaWRfbGlzdBgJIAMoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicStartCsReq), RogueMagicStartCsReq.Parser, new string[]
			{
				"SelectStyleType",
				"StartDifficultyIdList",
				"AreaId",
				"BaseAvatarIdList"
			}, null, null, null, null)
		}));
	}
}
