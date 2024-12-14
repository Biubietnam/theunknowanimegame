using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200029E RID: 670
	public static class ChessRogueStartCsReqReflection
	{
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x00055754 File Offset: 0x00053954
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueStartCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000C6D RID: 3181
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlU3RhcnRDc1JlcS5wcm90byLBAQoUQ2hlc3NSb2d1ZVN0",
			"YXJ0Q3NSZXESEQoJYnJhbmNoX2lkGAkgASgNEhwKFHRyaWFsX2F2YXRhcl9p",
			"ZF9saXN0GAQgAygNEhwKFGRpc2FibGVfYWVvbl9pZF9saXN0GAYgAygNEiAK",
			"GHN0YXJ0X2RpZmZpY3VsdHlfaWRfbGlzdBgPIAMoDRIKCgJpZBgKIAEoDRIb",
			"ChNiYXNlX2F2YXRhcl9pZF9saXN0GAEgAygNEg8KB2Flb25faWQYByABKA1C",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueStartCsReq), ChessRogueStartCsReq.Parser, new string[]
			{
				"BranchId",
				"TrialAvatarIdList",
				"DisableAeonIdList",
				"StartDifficultyIdList",
				"Id",
				"BaseAvatarIdList",
				"AeonId"
			}, null, null, null, null)
		}));
	}
}
