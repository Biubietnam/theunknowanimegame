using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200088E RID: 2190
	public static class HandleRogueCommonPendingActionScRspReflection
	{
		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x060061AD RID: 25005 RVA: 0x00104084 File Offset: 0x00102284
		public static FileDescriptor Descriptor
		{
			get
			{
				return HandleRogueCommonPendingActionScRspReflection.descriptor;
			}
		}

		// Token: 0x04002589 RID: 9609
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilIYW5kbGVSb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb25TY1JzcC5wcm90bxol",
			"Um9ndWVNYWdpY1NjZXB0ZXJTZWxlY3RDYWxsYmFjay5wcm90bxoiUm9ndWVN",
			"YWdpY1VuaXRTZWxlY3RDYWxsYmFjay5wcm90bxogUm9ndWVNaXJhY2xlU2Vs",
			"ZWN0Q2FsbGJhY2sucHJvdG8aJ1JvZ3VlUmVmb3JnZUZvcm11bGFTZWxlY3RD",
			"YWxsYmFjay5wcm90bxoRTU1FTklMTE9QUEoucHJvdG8aJFJvZ3VlQnVmZlJl",
			"Zm9yZ2VTZWxlY3RDYWxsYmFjay5wcm90bxoRRVBHRUNFQ05NR0kucHJvdG8a",
			"HVJvZ3VlQnVmZlJlcm9sbENhbGxiYWNrLnByb3RvGhFMTUFEQ0NKT0NDUC5w",
			"cm90bxoRSU5KTkVMTE1OQUMucHJvdG8aEU9JT0JOQkFJTkdGLnByb3RvGhFO",
			"R0NPR0ZPS0RGRC5wcm90bxoiUm9ndWVIZXhBdmF0YXJTZWxlY3RDYWxsYmFj",
			"ay5wcm90bxoRQ0ZOT0pCSUxLQkcucHJvdG8aHlJvZ3VlQm9udXNTZWxlY3RD",
			"YWxsYmFjay5wcm90bxoRRU1BTURNQ0ZDTEoucHJvdG8aEUdPRUJQTEVKQkFL",
			"LnByb3RvGhFGSUFOSEpPQ0JPTy5wcm90bxoRUEhNQ0lOTkJBREcucHJvdG8a",
			"H1JvZ3VlVG91cm5Gb3JtdWxhQ2FsbGJhY2sucHJvdG8aHVJvZ3VlQnVmZlNl",
			"bGVjdENhbGxiYWNrLnByb3RvGhFJREJQSkJMSEFHTi5wcm90bxoRRUNIUEhC",
			"S0VPTEcucHJvdG8aEUhLSVBFTURPTU1ELnByb3RvIqgKCiNIYW5kbGVSb2d1",
			"ZUNvbW1vblBlbmRpbmdBY3Rpb25TY1JzcBIWCg5xdWV1ZV9wb3NpdGlvbhgD",
			"IAEoDRIWCg5xdWV1ZV9sb2NhdGlvbhgFIAEoDRIPCgdyZXRjb2RlGAwgASgN",
			"EjgKFGJ1ZmZfc2VsZWN0X2NhbGxiYWNrGEUgASgLMhguUm9ndWVCdWZmU2Vs",
			"ZWN0Q2FsbGJhY2tIABIkCgtLT0FHTEdGTkJPQRjNCCABKAsyDC5GSUFOSEpP",
			"Q0JPT0gAEiQKC0pJQ0lQTEpETkFMGIQIIAEoCzIMLkhLSVBFTURPTU1ESAAS",
			"OQoUYnVmZl9yZXJvbGxfY2FsbGJhY2sY9gsgASgLMhguUm9ndWVCdWZmUmVy",
			"b2xsQ2FsbGJhY2tIABJIChxidWZmX3JlZm9yZ2Vfc2VsZWN0X2NhbGxiYWNr",
			"GKINIAEoCzIfLlJvZ3VlQnVmZlJlZm9yZ2VTZWxlY3RDYWxsYmFja0gAEj8K",
			"F21pcmFjbGVfc2VsZWN0X2NhbGxiYWNrGNAIIAEoCzIbLlJvZ3VlTWlyYWNs",
			"ZVNlbGVjdENhbGxiYWNrSAASJAoLQUZCSUlIQUZMT0EY9w4gASgLMgwuRVBH",
			"RUNFQ05NR0lIABIkCgtFQ0tJR1BPQ0dDQRi7DCABKAsyDC5JTkpORUxMTU5B",
			"Q0gAEiQKC0tPRE1JR0dPSktPGM8PIAEoCzIMLkxNQURDQ0pPQ0NQSAASJAoL",
			"R0FGT1BNQktCT0EY1wIgASgLMgwuT0lPQk5CQUlOR0ZIABIkCgtGTUFETklK",
			"T1BIQhj9AyABKAsyDC5NTUVOSUxMT1BQSkgAEkQKGmhleF9hdmF0YXJfc2Vs",
			"ZWN0X2NhbGxiYWNrGOIDIAEoCzIdLlJvZ3VlSGV4QXZhdGFyU2VsZWN0Q2Fs",
			"bGJhY2tIABI7ChVib251c19zZWxlY3RfY2FsbGJhY2sYhQkgASgLMhkuUm9n",
			"dWVCb251c1NlbGVjdENhbGxiYWNrSAASQwoccm9ndWVfdG91cm5fZm9ybXVs",
			"YV9jYWxsYmFjaxjADSABKAsyGi5Sb2d1ZVRvdXJuRm9ybXVsYUNhbGxiYWNr",
			"SAASJAoLRkdKRkdLS0RNSk8YpAkgASgLMgwuQ0ZOT0pCSUxLQkdIABIkCgtF",
			"SkVOTkVQQUhESRjgBSABKAsyDC5FQ0hQSEJLRU9MR0gAEk4KH3JlZm9yZ2Vf",
			"bWlyYWNsZV9zZWxlY3RfY2FsbGJhY2sYrgIgASgLMiIuUm9ndWVSZWZvcmdl",
			"Rm9ybXVsYVNlbGVjdENhbGxiYWNrSAASRAoabWFnaWNfdW5pdF9zZWxlY3Rf",
			"Y2FsbGJhY2sYhQogASgLMh0uUm9ndWVNYWdpY1VuaXRTZWxlY3RDYWxsYmFj",
			"a0gAEkQKF3NjZXB0ZXJfc2VsZWN0X2NhbGxiYWNrGN4EIAEoCzIgLlJvZ3Vl",
			"TWFnaWNTY2VwdGVyU2VsZWN0Q2FsbGJhY2tIABIkCgtHUExFRktGQlBHRhiB",
			"CCABKAsyDC5JREJQSkJMSEFHTkgAEiQKC0dNS0xFSE1KSUlJGO4NIAEoCzIM",
			"LlBITUNJTk5CQURHSAASJAoLS0JFQUpHT1BQREgYsA0gASgLMgwuR09FQlBM",
			"RUpCQUtIABIkCgtDQk1LSkhITEFNSBiABSABKAsyDC5OR0NPR0ZPS0RGREgA",
			"EiQKC0dIT0lQQktERUVKGNYFIAEoCzIMLkVNQU1ETUNGQ0xKSABCCAoGYWN0",
			"aW9uQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicScepterSelectCallbackReflection.Descriptor,
			RogueMagicUnitSelectCallbackReflection.Descriptor,
			RogueMiracleSelectCallbackReflection.Descriptor,
			RogueReforgeFormulaSelectCallbackReflection.Descriptor,
			MMENILLOPPJReflection.Descriptor,
			RogueBuffReforgeSelectCallbackReflection.Descriptor,
			EPGECECNMGIReflection.Descriptor,
			RogueBuffRerollCallbackReflection.Descriptor,
			LMADCCJOCCPReflection.Descriptor,
			INJNELLMNACReflection.Descriptor,
			OIOBNBAINGFReflection.Descriptor,
			NGCOGFOKDFDReflection.Descriptor,
			RogueHexAvatarSelectCallbackReflection.Descriptor,
			CFNOJBILKBGReflection.Descriptor,
			RogueBonusSelectCallbackReflection.Descriptor,
			EMAMDMCFCLJReflection.Descriptor,
			GOEBPLEJBAKReflection.Descriptor,
			FIANHJOCBOOReflection.Descriptor,
			PHMCINNBADGReflection.Descriptor,
			RogueTournFormulaCallbackReflection.Descriptor,
			RogueBuffSelectCallbackReflection.Descriptor,
			IDBPJBLHAGNReflection.Descriptor,
			ECHPHBKEOLGReflection.Descriptor,
			HKIPEMDOMMDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HandleRogueCommonPendingActionScRsp), HandleRogueCommonPendingActionScRsp.Parser, new string[]
			{
				"QueuePosition",
				"QueueLocation",
				"Retcode",
				"BuffSelectCallback",
				"KOAGLGFNBOA",
				"JICIPLJDNAL",
				"BuffRerollCallback",
				"BuffReforgeSelectCallback",
				"MiracleSelectCallback",
				"AFBIIHAFLOA",
				"ECKIGPOCGCA",
				"KODMIGGOJKO",
				"GAFOPMBKBOA",
				"FMADNIJOPHB",
				"HexAvatarSelectCallback",
				"BonusSelectCallback",
				"RogueTournFormulaCallback",
				"FGJFGKKDMJO",
				"EJENNEPAHDI",
				"ReforgeMiracleSelectCallback",
				"MagicUnitSelectCallback",
				"ScepterSelectCallback",
				"GPLEFKFBPGF",
				"GMKLEHMJIII",
				"KBEAJGOPPDH",
				"CBMKJHHLAMH",
				"GHOIPBKDEEJ"
			}, new string[]
			{
				"Action"
			}, null, null, null)
		}));
	}
}
