using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE2 RID: 3554
	public static class RogueActionReflection
	{
		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x06009EE6 RID: 40678 RVA: 0x001A9477 File Offset: 0x001A7677
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueActionReflection.descriptor;
			}
		}

		// Token: 0x0400413A RID: 16698
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFSb2d1ZUFjdGlvbi5wcm90bxoRQkdDTkJBTlBERE0ucHJvdG8aH1JvZ3Vl",
			"Q29tbW9uQnVmZlNlbGVjdEluZm8ucHJvdG8aEUpER0JGTkhMQURQLnByb3Rv",
			"GhFDQkRPRUJKSEVDSC5wcm90bxoRUElLQktKSktIQlAucHJvdG8aEVBCQkJH",
			"QU1KR0lELnByb3RvGh5Sb2d1ZUhleEF2YXRhclNlbGVjdEluZm8ucHJvdG8a",
			"EVBJTUJPQkxDQUpGLnByb3RvGhFCT0VISU9QT1BBRi5wcm90bxoaUm9ndWVC",
			"b251c1NlbGVjdEluZm8ucHJvdG8aEUZCR0NNRkpBTk1ILnByb3RvGiNSb2d1",
			"ZUNvbXBvc2VNaXJhY2xlU2VsZWN0SW5mby5wcm90bxoeUm9ndWVNYWdpY1Vu",
			"aXRTZWxlY3RJbmZvLnByb3RvGhFFRElPSkJDQUxIQi5wcm90bxocUm9ndWVG",
			"b3JtdWxhU2VsZWN0SW5mby5wcm90bxocUm9ndWVNaXJhY2xlU2VsZWN0SW5m",
			"by5wcm90bxomUm9ndWVDb21tb25CdWZmUmVmb3JnZVNlbGVjdEluZm8ucHJv",
			"dG8aIVJvZ3VlTWFnaWNTY2VwdGVyU2VsZWN0SW5mby5wcm90bxoRSU1CTkFO",
			"SUNKTEgucHJvdG8aI1JvZ3VlUmVmb3JnZUZvcm11bGFTZWxlY3RJbmZvLnBy",
			"b3RvGhFFRURISEZOSExCSC5wcm90byKTCgoLUm9ndWVBY3Rpb24SNgoQYnVm",
			"Zl9zZWxlY3RfaW5mbxhwIAEoCzIaLlJvZ3VlQ29tbW9uQnVmZlNlbGVjdElu",
			"Zm9IABIkCgtERktGSkFPTU5MUBijDiABKAsyDC5JTUJOQU5JQ0pMSEgAEiQK",
			"C0VNQ0pFUE9KUEFJGI4FIAEoCzIMLkVESU9KQkNBTEhCSAASRgoYYnVmZl9y",
			"ZWZvcmdlX3NlbGVjdF9pbmZvGKoMIAEoCzIhLlJvZ3VlQ29tbW9uQnVmZlJl",
			"Zm9yZ2VTZWxlY3RJbmZvSAASNwoTbWlyYWNsZV9zZWxlY3RfaW5mbxiyDSAB",
			"KAsyFy5Sb2d1ZU1pcmFjbGVTZWxlY3RJbmZvSAASJAoLQkNIQklCT01FUEUY",
			"uwQgASgLMgwuQk9FSElPUE9QQUZIABIkCgtJQUxGSkdLRFBBSxjkBiABKAsy",
			"DC5QQkJCR0FNSkdJREgAEiQKC0lFT0RORkRHUE9IGIwIIAEoCzIMLkZCR0NN",
			"RkpBTk1ISAASJAoLS0ZNRU9EUExGSUsYrQQgASgLMgwuUElNQk9CTENBSkZI",
			"ABIkCgtNSkdNSkRMTEVKUBj+CCABKAsyDC5FRURISEZOSExCSEgAEkUKG2Nv",
			"bXBvc2VfbWlyYWNsZV9zZWxlY3RfaW5mbxg5IAEoCzIeLlJvZ3VlQ29tcG9z",
			"ZU1pcmFjbGVTZWxlY3RJbmZvSAASPAoWaGV4X2F2YXRhcl9zZWxlY3RfaW5m",
			"bxjsCSABKAsyGS5Sb2d1ZUhleEF2YXRhclNlbGVjdEluZm9IABIzChFib251",
			"c19zZWxlY3RfaW5mbxjSBiABKAsyFS5Sb2d1ZUJvbnVzU2VsZWN0SW5mb0gA",
			"Ej0KGXJvZ3VlX2Zvcm11bGFfc2VsZWN0X2luZm8Y/gYgASgLMhcuUm9ndWVG",
			"b3JtdWxhU2VsZWN0SW5mb0gAEiQKC1BOR0FBTUlBS0FEGLENIAEoCzIMLkJH",
			"Q05CQU5QRERNSAASRgobcmVmb3JnZV9mb3JtdWxhX3NlbGVjdF9pbmZvGPkP",
			"IAEoCzIeLlJvZ3VlUmVmb3JnZUZvcm11bGFTZWxlY3RJbmZvSAASOwoWbWFn",
			"aWNfdW5pdF9zZWxlY3RfaW5mbxgyIAEoCzIZLlJvZ3VlTWFnaWNVbml0U2Vs",
			"ZWN0SW5mb0gAEjwKE3NjZXB0ZXJfc2VsZWN0X2luZm8YjAIgASgLMhwuUm9n",
			"dWVNYWdpY1NjZXB0ZXJTZWxlY3RJbmZvSAASJAoLS0hDQkVGSkpNUEkY/Aog",
			"ASgLMgwuSkRHQkZOSExBRFBIABIxCgtLR0ZMRU5HTkZOUBioAyABKAsyGS5S",
			"b2d1ZU1hZ2ljVW5pdFNlbGVjdEluZm9IABIxCgtLR0lDR01MREdIRBjhCCAB",
			"KAsyGS5Sb2d1ZU1hZ2ljVW5pdFNlbGVjdEluZm9IABIxCgtFSElISEVDTlBH",
			"ThivAyABKAsyGS5Sb2d1ZU1hZ2ljVW5pdFNlbGVjdEluZm9IABIkCgtNUFBP",
			"T0tBRExGTBi2DCABKAsyDC5DQkRPRUJKSEVDSEgAEiQKC0VEREhLQkJIQ0VO",
			"GJkHIAEoCzIMLkNCRE9FQkpIRUNISAASJAoLS0xOSUlKS0pFS0YYigogASgL",
			"MgwuQ0JET0VCSkhFQ0hIABIkCgtLRUJPTUhETUNFQRjPAyABKAsyDC5QSUtC",
			"S0pKS0hCUEgAQggKBmFjdGlvbkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			BGCNBANPDDMReflection.Descriptor,
			RogueCommonBuffSelectInfoReflection.Descriptor,
			JDGBFNHLADPReflection.Descriptor,
			CBDOEBJHECHReflection.Descriptor,
			PIKBKJJKHBPReflection.Descriptor,
			PBBBGAMJGIDReflection.Descriptor,
			RogueHexAvatarSelectInfoReflection.Descriptor,
			PIMBOBLCAJFReflection.Descriptor,
			BOEHIOPOPAFReflection.Descriptor,
			RogueBonusSelectInfoReflection.Descriptor,
			FBGCMFJANMHReflection.Descriptor,
			RogueComposeMiracleSelectInfoReflection.Descriptor,
			RogueMagicUnitSelectInfoReflection.Descriptor,
			EDIOJBCALHBReflection.Descriptor,
			RogueFormulaSelectInfoReflection.Descriptor,
			RogueMiracleSelectInfoReflection.Descriptor,
			RogueCommonBuffReforgeSelectInfoReflection.Descriptor,
			RogueMagicScepterSelectInfoReflection.Descriptor,
			IMBNANICJLHReflection.Descriptor,
			RogueReforgeFormulaSelectInfoReflection.Descriptor,
			EEDHHFNHLBHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueAction), RogueAction.Parser, new string[]
			{
				"BuffSelectInfo",
				"DFKFJAOMNLP",
				"EMCJEPOJPAI",
				"BuffReforgeSelectInfo",
				"MiracleSelectInfo",
				"BCHBIBOMEPE",
				"IALFJGKDPAK",
				"IEODNFDGPOH",
				"KFMEODPLFIK",
				"MJGMJDLLEJP",
				"ComposeMiracleSelectInfo",
				"HexAvatarSelectInfo",
				"BonusSelectInfo",
				"RogueFormulaSelectInfo",
				"PNGAAMIAKAD",
				"ReforgeFormulaSelectInfo",
				"MagicUnitSelectInfo",
				"ScepterSelectInfo",
				"KHCBEFJJMPI",
				"KGFLENGNFNP",
				"KGICGMLDGHD",
				"EHIHHECNPGN",
				"MPPOOKADLFL",
				"EDDHKBBHCEN",
				"KLNIIJKJEKF",
				"KEBOMHDMCEA"
			}, new string[]
			{
				"Action"
			}, null, null, null)
		}));
	}
}
