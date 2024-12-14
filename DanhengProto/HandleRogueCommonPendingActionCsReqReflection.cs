using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200088C RID: 2188
	public static class HandleRogueCommonPendingActionCsReqReflection
	{
		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x0600615C RID: 24924 RVA: 0x00101487 File Offset: 0x000FF687
		public static FileDescriptor Descriptor
		{
			get
			{
				return HandleRogueCommonPendingActionCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002565 RID: 9573
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilIYW5kbGVSb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb25Dc1JlcS5wcm90bxoR",
			"Q0dESU5NSUpITEIucHJvdG8aEU5GRkpNRkdOSEtPLnByb3RvGiVSb2d1ZVJl",
			"Zm9yZ2VGb3JtdWxhU2VsZWN0UmVzdWx0LnByb3RvGhFHRE5NTUJPR0xESS5w",
			"cm90bxoRTkJET0pISUpKR0QucHJvdG8aG1JvZ3VlQnVmZlNlbGVjdFJlc3Vs",
			"dC5wcm90bxoRQk1KSkNCSU5HQksucHJvdG8aIFJvZ3VlTWFnaWNVbml0U2Vs",
			"ZWN0UmVzdWx0LnByb3RvGhFIQUNFTEpEUE5JRy5wcm90bxocUm9ndWVCb251",
			"c1NlbGVjdFJlc3VsdC5wcm90bxoRSUdLRENPRU9QTUQucHJvdG8aEUFDR09C",
			"S0dJR0lDLnByb3RvGhtSb2d1ZUJ1ZmZSZXJvbGxSZXN1bHQucHJvdG8aIlJv",
			"Z3VlQnVmZlJlZm9yZ2VTZWxlY3RSZXN1bHQucHJvdG8aEUhQSENBQUFFT01P",
			"LnByb3RvGh5Sb2d1ZU1pcmFjbGVTZWxlY3RSZXN1bHQucHJvdG8aEUxNT0lM",
			"TE1HSEJPLnByb3RvGh1Sb2d1ZVRvdXJuRm9ybXVsYVJlc3VsdC5wcm90bxoR",
			"S0lBRkVBTURGT0UucHJvdG8aI1JvZ3VlTWFnaWNTY2VwdGVyU2VsZWN0UmVz",
			"dWx0LnByb3RvGhFLRElFT0FLT0ZPUC5wcm90bxogUm9ndWVIZXhBdmF0YXJT",
			"ZWxlY3RSZXN1bHQucHJvdG8aEUtNR0FPUEJMQkRFLnByb3RvGhFISkhGTkVM",
			"S0VPSS5wcm90byLJCwojSGFuZGxlUm9ndWVDb21tb25QZW5kaW5nQWN0aW9u",
			"Q3NSZXESFgoOcXVldWVfbG9jYXRpb24YCCABKA0SNQoSYnVmZl9zZWxlY3Rf",
			"cmVzdWx0GO4EIAEoCzIWLlJvZ3VlQnVmZlNlbGVjdFJlc3VsdEgAEiQKC0ZP",
			"RUpMQkdJSEtEGIIJIAEoCzIMLkhBQ0VMSkRQTklHSAASJAoLS0xNRkFDT0NK",
			"TEkYhQYgASgLMgwuTkZGSk1GR05IS09IABI8ChlidWZmX3Jlcm9sbF9zZWxl",
			"Y3RfcmVzdWx0GMMLIAEoCzIWLlJvZ3VlQnVmZlJlcm9sbFJlc3VsdEgAEkQK",
			"GmJ1ZmZfcmVmb3JnZV9zZWxlY3RfcmVzdWx0GLQFIAEoCzIdLlJvZ3VlQnVm",
			"ZlJlZm9yZ2VTZWxlY3RSZXN1bHRIABI7ChVtaXJhY2xlX3NlbGVjdF9yZXN1",
			"bHQYiQsgASgLMhkuUm9ndWVNaXJhY2xlU2VsZWN0UmVzdWx0SAASJAoLQ0VO",
			"T0hESFBKS04YnwIgASgLMgwuTkJET0pISUpKR0RIABIjCgtBRUdKRVBNT0lH",
			"RhhRIAEoCzIMLkNHRElOTUlKSExCSAASJAoLQk1KQUpHRUFHS0sY0wcgASgL",
			"MgwuR0ROTU1CT0dMRElIABIkCgtET0dHTE5KUFBPRhiwByABKAsyDC5MTU9J",
			"TExNR0hCT0gAEiMKC05CSEFORUlFTk1HGEAgASgLMgwuSUdLRENPRU9QTURI",
			"ABJAChhoZXhfYXZhdGFyX3NlbGVjdF9yZXN1bHQY5wggASgLMhsuUm9ndWVI",
			"ZXhBdmF0YXJTZWxlY3RSZXN1bHRIABI3ChNib251c19zZWxlY3RfcmVzdWx0",
			"GPgEIAEoCzIXLlJvZ3VlQm9udXNTZWxlY3RSZXN1bHRIABI/Chpyb2d1ZV90",
			"b3Vybl9mb3JtdWxhX3Jlc3VsdBiGCCABKAsyGC5Sb2d1ZVRvdXJuRm9ybXVs",
			"YVJlc3VsdEgAEiQKC01LQU1ITU5ISkdDGJwCIAEoCzIMLkFDR09CS0dJR0lD",
			"SAASJAoLSEhQSUVFRkFKR00YgwQgASgLMgwuQk1KSkNCSU5HQktIABJKCh1y",
			"ZWZvcmdlX21pcmFjbGVfc2VsZWN0X3Jlc3VsdBjbDSABKAsyIC5Sb2d1ZVJl",
			"Zm9yZ2VGb3JtdWxhU2VsZWN0UmVzdWx0SAASPwoYbWFnaWNfdW5pdF9zZWxl",
			"Y3RfcmVzdWx0GCIgASgLMhsuUm9ndWVNYWdpY1VuaXRTZWxlY3RSZXN1bHRI",
			"ABJAChVzY2VwdGVyX3NlbGVjdF9yZXN1bHQYwwMgASgLMh4uUm9ndWVNYWdp",
			"Y1NjZXB0ZXJTZWxlY3RSZXN1bHRIABIkCgtCRkFKQU5QSkNKRBjmBiABKAsy",
			"DC5LSUFGRUFNREZPRUgAEjMKC0RDTUJLTU5IT0xOGKIPIAEoCzIbLlJvZ3Vl",
			"TWFnaWNVbml0U2VsZWN0UmVzdWx0SAASMwoLSUJOTUNFUEtHREIY4QkgASgL",
			"MhsuUm9ndWVNYWdpY1VuaXRTZWxlY3RSZXN1bHRIABIzCgtDRElKR0ZMRkRI",
			"QRj3ASABKAsyGy5Sb2d1ZU1hZ2ljVW5pdFNlbGVjdFJlc3VsdEgAEiQKC0pM",
			"TkVDQkxDSklQGMoHIAEoCzIMLktESUVPQUtPRk9QSAASJAoLS05CSEpMTlBC",
			"S0cY3QggASgLMgwuS0RJRU9BS09GT1BIABIkCgtITElPTU5OT1BHQxjGCyAB",
			"KAsyDC5LRElFT0FLT0ZPUEgAEiQKC0RBTEZIQUZNQkRCGI0KIAEoCzIMLktN",
			"R0FPUEJMQkRFSAASJQoLSENPTEZNSUhOS08Y0NkNIAEoCzIMLkhKSEZORUxL",
			"RU9JSAASJQoLR0lHRElCSUZEQ0EY2fANIAEoCzIMLkhQSENBQUFFT01PSABC",
			"CAoGYWN0aW9uQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			CGDINMIJHLBReflection.Descriptor,
			NFFJMFGNHKOReflection.Descriptor,
			RogueReforgeFormulaSelectResultReflection.Descriptor,
			GDNMMBOGLDIReflection.Descriptor,
			NBDOJHIJJGDReflection.Descriptor,
			RogueBuffSelectResultReflection.Descriptor,
			BMJJCBINGBKReflection.Descriptor,
			RogueMagicUnitSelectResultReflection.Descriptor,
			HACELJDPNIGReflection.Descriptor,
			RogueBonusSelectResultReflection.Descriptor,
			IGKDCOEOPMDReflection.Descriptor,
			ACGOBKGIGICReflection.Descriptor,
			RogueBuffRerollResultReflection.Descriptor,
			RogueBuffReforgeSelectResultReflection.Descriptor,
			HPHCAAAEOMOReflection.Descriptor,
			RogueMiracleSelectResultReflection.Descriptor,
			LMOILLMGHBOReflection.Descriptor,
			RogueTournFormulaResultReflection.Descriptor,
			KIAFEAMDFOEReflection.Descriptor,
			RogueMagicScepterSelectResultReflection.Descriptor,
			KDIEOAKOFOPReflection.Descriptor,
			RogueHexAvatarSelectResultReflection.Descriptor,
			KMGAOPBLBDEReflection.Descriptor,
			HJHFNELKEOIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HandleRogueCommonPendingActionCsReq), HandleRogueCommonPendingActionCsReq.Parser, new string[]
			{
				"QueueLocation",
				"BuffSelectResult",
				"FOEJLBGIHKD",
				"KLMFACOCJLI",
				"BuffRerollSelectResult",
				"BuffReforgeSelectResult",
				"MiracleSelectResult",
				"CENOHDHPJKN",
				"AEGJEPMOIGF",
				"BMJAJGEAGKK",
				"DOGGLNJPPOF",
				"NBHANEIENMG",
				"HexAvatarSelectResult",
				"BonusSelectResult",
				"RogueTournFormulaResult",
				"MKAMHMNHJGC",
				"HHPIEEFAJGM",
				"ReforgeMiracleSelectResult",
				"MagicUnitSelectResult",
				"ScepterSelectResult",
				"BFAJANPJCJD",
				"DCMBKMNHOLN",
				"IBNMCEPKGDB",
				"CDIJGFLFDHA",
				"JLNECBLCJIP",
				"KNBHJLNPBKG",
				"HLIOMNNOPGC",
				"DALFHAFMBDB",
				"HCOLFMIHNKO",
				"GIGDIBIFDCA"
			}, new string[]
			{
				"Action"
			}, null, null, null)
		}));
	}
}
