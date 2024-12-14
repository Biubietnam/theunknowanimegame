using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E86 RID: 3718
	public static class RogueFormulaSelectInfoReflection
	{
		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x001BEB85 File Offset: 0x001BCD85
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueFormulaSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x040043DF RID: 17375
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxSb2d1ZUZvcm11bGFTZWxlY3RJbmZvLnByb3RvGhJJdGVtQ29zdERhdGEu",
			"cHJvdG8i/AEKFlJvZ3VlRm9ybXVsYVNlbGVjdEluZm8SGwoTUm9sbEZvcm11",
			"bGFNYXhDb3VudBgLIAEoDRIjChtIYW5kYm9va1VubG9ja0Zvcm11bGFJZExp",
			"c3QYDCADKA0SGwoTU2VsZWN0Rm9ybXVsYUlkTGlzdBgNIAMoDRIPCgdDYW5S",
			"b2xsGAcgASgIEioKE1JvbGxGb3JtdWxhQ29zdERhdGEYDyABKAsyDS5JdGVt",
			"Q29zdERhdGESDgoGSGludElkGAYgASgNEhwKFFJvbGxGb3JtdWxhRnJlZUNv",
			"dW50GAQgASgNEhgKEFJvbGxGb3JtdWxhQ291bnQYCiABKA1CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueFormulaSelectInfo), RogueFormulaSelectInfo.Parser, new string[]
			{
				"RollFormulaMaxCount",
				"HandbookUnlockFormulaIdList",
				"SelectFormulaIdList",
				"CanRoll",
				"RollFormulaCostData",
				"HintId",
				"RollFormulaFreeCount",
				"RollFormulaCount"
			}, null, null, null, null)
		}));
	}
}
