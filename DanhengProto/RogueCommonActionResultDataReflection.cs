using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E30 RID: 3632
	public static class RogueCommonActionResultDataReflection
	{
		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x001B1D5C File Offset: 0x001AFF5C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonActionResultDataReflection.descriptor;
			}
		}

		// Token: 0x0400423A RID: 16954
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSb2d1ZUNvbW1vbkFjdGlvblJlc3VsdERhdGEucHJvdG8aEU5DQklBREhM",
			"S0dOLnByb3RvGhhSb2d1ZUNvbW1vbktleXdvcmQucHJvdG8aEUlDUE9NT0hM",
			"Q01ELnByb3RvGiBSb2d1ZUNvbW1vbkNvbnRyYWN0Rm9ybXVsYS5wcm90bxoY",
			"Um9ndWVDb21tb25NaXJhY2xlLnByb3RvGhFMSkZCREhIRFBPTS5wcm90bxod",
			"Um9ndWVDb21tb25EcmVzc1NjZXB0ZXIucHJvdG8aEU5QR0RBS0dGR0pPLnBy",
			"b3RvGhtSb2d1ZUNvbW1vbkdldFNjZXB0ZXIucHJvdG8aHFJvZ3VlTWFnaWNH",
			"YW1lVW5pdEluZm8ucHJvdG8aHlJvZ3VlQ29tbW9uUmVtb3ZlRm9ybXVsYS5w",
			"cm90bxoeUm9ndWVDb21tb25SZW1vdmVLZXl3b3JkLnByb3RvGhFDR0hCTUtB",
			"QU9HUC5wcm90bxofUm9ndWVNYWdpY0dhbWVTY2VwdGVySW5mby5wcm90bxoY",
			"Um9ndWVDb21tb25Gb3JtdWxhLnByb3RvGiBSb2d1ZUNvbW1vbkV4cGFuZGVk",
			"Rm9ybXVsYS5wcm90bxoZUm9ndWVDb21tb25QYXRoQnVmZi5wcm90bxoVUm9n",
			"dWVDb21tb25CdWZmLnByb3RvGhFFS0tIRExLR01ESC5wcm90bxoeUm9ndWVD",
			"b21tb25SZW1vdmVNaXJhY2xlLnByb3RvGhZSb2d1ZUNvbW1vbk1vbmV5LnBy",
			"b3RvGhFISUVCTU5MQ0ZCQi5wcm90byLUCgobUm9ndWVDb21tb25BY3Rpb25S",
			"ZXN1bHREYXRhEioKDWdldF9pdGVtX2xpc3QYDiABKAsyES5Sb2d1ZUNvbW1v",
			"bk1vbmV5SAASLQoQcmVtb3ZlX2l0ZW1fbGlzdBgJIAEoCzIRLlJvZ3VlQ29t",
			"bW9uTW9uZXlIABIpCg1nZXRfYnVmZl9saXN0GGEgASgLMhAuUm9ndWVDb21t",
			"b25CdWZmSAASLQoQcmVtb3ZlX2J1ZmZfbGlzdBiaASABKAsyEC5Sb2d1ZUNv",
			"bW1vbkJ1ZmZIABIwChBnZXRfbWlyYWNsZV9saXN0GJAIIAEoCzITLlJvZ3Vl",
			"Q29tbW9uTWlyYWNsZUgAEjkKE3JlbW92ZV9taXJhY2xlX2xpc3QYzgwgASgL",
			"MhkuUm9ndWVDb21tb25SZW1vdmVNaXJhY2xlSAASJAoLSEJQUEFQSU9GQkMY",
			"1QwgASgLMgwuRUtLSERMS0dNREhIABIkCgtQT0NCQ0pMTEdBQhjWDiABKAsy",
			"DC5ISUVCTU5MQ0ZCQkgAEiQKC0ZHTUNDRkZHRkZLGKUHIAEoCzIMLkxKRkJE",
			"SEhEUE9NSAASJAoLRE5JQ09GRkZERUoYxQogASgLMgwuTlBHREFLR0ZHSk9I",
			"ABIkCgtFTE9BTlBKQkZKSBjVBCABKAsyDC5DR0hCTUtBQU9HUEgAEjAKEGdl",
			"dF9mb3JtdWxhX2xpc3QYmg8gASgLMhMuUm9ndWVDb21tb25Gb3JtdWxhSAAS",
			"OQoTcmVtb3ZlX2Zvcm11bGFfbGlzdBioAiABKAsyGS5Sb2d1ZUNvbW1vblJl",
			"bW92ZUZvcm11bGFIABI6ChNleHBhbmRfZm9ybXVsYV9saXN0GEEgASgLMhsu",
			"Um9ndWVDb21tb25FeHBhbmRlZEZvcm11bGFIABI9ChVjb250cmFjdF9mb3Jt",
			"dWxhX2xpc3QY8A4gASgLMhsuUm9ndWVDb21tb25Db250cmFjdEZvcm11bGFI",
			"ABIvCg5wYXRoX2J1ZmZfbGlzdBizDyABKAsyFC5Sb2d1ZUNvbW1vblBhdGhC",
			"dWZmSAASMAoQZ2V0X2tleXdvcmRfbGlzdBiLDyABKAsyEy5Sb2d1ZUNvbW1v",
			"bktleXdvcmRIABI5ChNyZW1vdmVfa2V5d29yZF9saXN0GKgKIAEoCzIZLlJv",
			"Z3VlQ29tbW9uUmVtb3ZlS2V5d29yZEgAEjcKEmRyZXNzX3NjZXB0ZXJfbGlz",
			"dBjjBiABKAsyGC5Sb2d1ZUNvbW1vbkRyZXNzU2NlcHRlckgAEjMKEGdldF9z",
			"Y2VwdGVyX2xpc3QYqwkgASgLMhYuUm9ndWVDb21tb25HZXRTY2VwdGVySAAS",
			"JAoLQkpNRkxBRklLSkIY7wggASgLMgwuTkNCSUFESExLR05IABI3ChNnZXRf",
			"bWFnaWNfdW5pdF9saXN0GIkGIAEoCzIXLlJvZ3VlTWFnaWNHYW1lVW5pdElu",
			"Zm9IABI6ChZyZW1vdmVfbWFnaWNfdW5pdF9saXN0GLEPIAEoCzIXLlJvZ3Vl",
			"TWFnaWNHYW1lVW5pdEluZm9IABIvCgtPQ01CTkRLQkFQSRiUAiABKAsyFy5S",
			"b2d1ZU1hZ2ljR2FtZVVuaXRJbmZvSAASMgoLTUFGRUNOQ05PQ0IYsgsgASgL",
			"MhouUm9ndWVNYWdpY0dhbWVTY2VwdGVySW5mb0gAElIKOVJPR1VFX0NPTU1P",
			"Tl9BQ1RJT05fUkVTVUxUX1NPVVJDRV9UWVBFX01BR0lDX1VOSVRfQ09NUE9T",
			"RRiHBCABKAsyDC5JQ1BPTU9ITENNREgAQg0KC3Jlc3VsdF9kYXRhQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			NCBIADHLKGNReflection.Descriptor,
			RogueCommonKeywordReflection.Descriptor,
			ICPOMOHLCMDReflection.Descriptor,
			RogueCommonContractFormulaReflection.Descriptor,
			RogueCommonMiracleReflection.Descriptor,
			LJFBDHHDPOMReflection.Descriptor,
			RogueCommonDressScepterReflection.Descriptor,
			NPGDAKGFGJOReflection.Descriptor,
			RogueCommonGetScepterReflection.Descriptor,
			RogueMagicGameUnitInfoReflection.Descriptor,
			RogueCommonRemoveFormulaReflection.Descriptor,
			RogueCommonRemoveKeywordReflection.Descriptor,
			CGHBMKAAOGPReflection.Descriptor,
			RogueMagicGameScepterInfoReflection.Descriptor,
			RogueCommonFormulaReflection.Descriptor,
			RogueCommonExpandedFormulaReflection.Descriptor,
			RogueCommonPathBuffReflection.Descriptor,
			RogueCommonBuffReflection.Descriptor,
			EKKHDLKGMDHReflection.Descriptor,
			RogueCommonRemoveMiracleReflection.Descriptor,
			RogueCommonMoneyReflection.Descriptor,
			HIEBMNLCFBBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonActionResultData), RogueCommonActionResultData.Parser, new string[]
			{
				"GetItemList",
				"RemoveItemList",
				"GetBuffList",
				"RemoveBuffList",
				"GetMiracleList",
				"RemoveMiracleList",
				"HBPPAPIOFBC",
				"POCBCJLLGAB",
				"FGMCCFFGFFK",
				"DNICOFFFDEJ",
				"ELOANPJBFJH",
				"GetFormulaList",
				"RemoveFormulaList",
				"ExpandFormulaList",
				"ContractFormulaList",
				"PathBuffList",
				"GetKeywordList",
				"RemoveKeywordList",
				"DressScepterList",
				"GetScepterList",
				"BJMFLAFIKJB",
				"GetMagicUnitList",
				"RemoveMagicUnitList",
				"OCMBNDKBAPI",
				"MAFECNCNOCB",
				"ROGUECOMMONACTIONRESULTSOURCETYPEMAGICUNITCOMPOSE"
			}, new string[]
			{
				"ResultData"
			}, null, null, null)
		}));
	}
}
