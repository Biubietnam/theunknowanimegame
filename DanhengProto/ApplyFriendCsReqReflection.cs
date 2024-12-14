using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A8 RID: 168
	public static class ApplyFriendCsReqReflection
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00014A82 File Offset: 0x00012C82
		public static FileDescriptor Descriptor
		{
			get
			{
				return ApplyFriendCsReqReflection.descriptor;
			}
		}

		// Token: 0x040002B6 RID: 694
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBcHBseUZyaWVuZENzUmVxLnByb3RvGhdGcmllbmRBcHBseVNvdXJjZS5w" + "cm90byJDChBBcHBseUZyaWVuZENzUmVxEiIKBnNvdXJjZRgEIAEoDjISLkZy" + "aWVuZEFwcGx5U291cmNlEgsKA3VpZBgHIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			FriendApplySourceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ApplyFriendCsReq), ApplyFriendCsReq.Parser, new string[]
			{
				"Source",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
