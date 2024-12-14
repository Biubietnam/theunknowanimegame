using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001408 RID: 5128
	public static class UseItemCsReqReflection
	{
		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x0600E4B9 RID: 58553 RVA: 0x002601C2 File Offset: 0x0025E3C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return UseItemCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005AD8 RID: 23256
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJVc2VJdGVtQ3NSZXEucHJvdG8aEEF2YXRhclR5cGUucHJvdG8iqgEKDFVz",
			"ZUl0ZW1Dc1JlcRITCgtDUEZHTElLS0tHTRgNIAEoCBIWCg5iYXNlX2F2YXRh",
			"cl9pZBgKIAEoDRIaChJvcHRpb25hbF9yZXdhcmRfaWQYAyABKA0SEwoLdXNl",
			"X2l0ZW1faWQYDiABKA0SJAoPdXNlX2F2YXRhcl90eXBlGAEgASgOMgsuQXZh",
			"dGFyVHlwZRIWCg51c2VfaXRlbV9jb3VudBgHIAEoDUIeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UseItemCsReq), UseItemCsReq.Parser, new string[]
			{
				"CPFGLIKKKGM",
				"BaseAvatarId",
				"OptionalRewardId",
				"UseItemId",
				"UseAvatarType",
				"UseItemCount"
			}, null, null, null, null)
		}));
	}
}
