using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000170 RID: 368
	public static class CCHCPNLPBDKReflection
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0002F6F5 File Offset: 0x0002D8F5
		public static FileDescriptor Descriptor
		{
			get
			{
				return CCHCPNLPBDKReflection.descriptor;
			}
		}

		// Token: 0x040006E4 RID: 1764
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFDQ0hDUE5MUEJESy5wcm90bxoRQkNFQ0NNT0FETEUucHJvdG8aEU1GS09C",
			"UExNUElOLnByb3RvGhFQR0RBQ05JQkZNUC5wcm90byJ0CgtDQ0hDUE5MUEJE",
			"SxIgCgpiYXNpY19pbmZvGAEgASgLMgwuQkNFQ0NNT0FETEUSIQoLRUFIREJF",
			"SUlPRUYYAiABKAsyDC5NRktPQlBMTVBJThIgCgpzdGFnZV9pbmZvGAMgASgL",
			"MgwuUEdEQUNOSUJGTVBCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			BCECCMOADLEReflection.Descriptor,
			MFKOBPLMPINReflection.Descriptor,
			PGDACNIBFMPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CCHCPNLPBDK), CCHCPNLPBDK.Parser, new string[]
			{
				"BasicInfo",
				"EAHDBEIIOEF",
				"StageInfo"
			}, null, null, null, null)
		}));
	}
}
