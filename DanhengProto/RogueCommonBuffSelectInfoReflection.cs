using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E3A RID: 3642
	public static class RogueCommonBuffSelectInfoReflection
	{
		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0600A27B RID: 41595 RVA: 0x001B4C1F File Offset: 0x001B2E1F
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonBuffSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x0400427F RID: 17023
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Sb2d1ZUNvbW1vbkJ1ZmZTZWxlY3RJbmZvLnByb3RvGhVSb2d1ZUNvbW1v",
			"bkJ1ZmYucHJvdG8aEkl0ZW1Db3N0RGF0YS5wcm90bxolUm9ndWVDb21tb25C",
			"dWZmU2VsZWN0U291cmNlVHlwZS5wcm90byKjAwoZUm9ndWVDb21tb25CdWZm",
			"U2VsZWN0SW5mbxIoCg5TZWxlY3RCdWZmTGlzdBgDIAMoCzIQLlJvZ3VlQ29t",
			"bW9uQnVmZhIPCgdDYW5Sb2xsGAsgASgIEhkKEUZpcnN0QnVmZlR5cGVMaXN0",
			"GAcgAygNEhUKDVJvbGxCdWZmQ291bnQYBCABKA0SFAoMU291cmNlSGludElk",
			"GAggASgNEicKEFJvbGxCdWZmQ29zdERhdGEYBSABKAsyDS5JdGVtQ29zdERh",
			"dGESGAoQUm9sbEJ1ZmZNYXhDb3VudBgBIAEoDRIYChBTb3VyY2VUb3RhbENv",
			"dW50GA4gASgNEjQKClNvdXJjZVR5cGUYDCABKA4yIC5Sb2d1ZUNvbW1vbkJ1",
			"ZmZTZWxlY3RTb3VyY2VUeXBlEhYKDlNvdXJjZUN1ckNvdW50GAYgASgNEhkK",
			"EVJvbGxCdWZmRnJlZUNvdW50GA0gASgNEhsKE0NlcnRhaW5TZWxlY3RCdWZm",
			"SWQYAiABKA0SIAoYSGFuZGJvb2tVbmxvY2tCdWZmSWRMaXN0GA8gAygNQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor,
			ItemCostDataReflection.Descriptor,
			RogueCommonBuffSelectSourceTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonBuffSelectInfo), RogueCommonBuffSelectInfo.Parser, new string[]
			{
				"SelectBuffList",
				"CanRoll",
				"FirstBuffTypeList",
				"RollBuffCount",
				"SourceHintId",
				"RollBuffCostData",
				"RollBuffMaxCount",
				"SourceTotalCount",
				"SourceType",
				"SourceCurCount",
				"RollBuffFreeCount",
				"CertainSelectBuffId",
				"HandbookUnlockBuffIdList"
			}, null, null, null, null)
		}));
	}
}
