using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000320 RID: 800
	public static class ComposeSelectedRelicCsReqReflection
	{
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00065D11 File Offset: 0x00063F11
		public static FileDescriptor Descriptor
		{
			get
			{
				return ComposeSelectedRelicCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000EB5 RID: 3765
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Db21wb3NlU2VsZWN0ZWRSZWxpY0NzUmVxLnByb3RvGhJJdGVtQ29zdERh",
			"dGEucHJvdG8imQEKGUNvbXBvc2VTZWxlY3RlZFJlbGljQ3NSZXESEgoKY29t",
			"cG9zZV9pZBgJIAEoDRIYChBjb21wb3NlX3JlbGljX2lkGAQgASgNEigKEWNv",
			"bXBvc2VfaXRlbV9saXN0GA0gASgLMg0uSXRlbUNvc3REYXRhEg0KBWNvdW50",
			"GAcgASgNEhUKDW1haW5fYWZmaXhfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ComposeSelectedRelicCsReq), ComposeSelectedRelicCsReq.Parser, new string[]
			{
				"ComposeId",
				"ComposeRelicId",
				"ComposeItemList",
				"Count",
				"MainAffixId"
			}, null, null, null, null)
		}));
	}
}
