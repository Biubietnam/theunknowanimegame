using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A2 RID: 1698
	public static class GetFightActivityDataScRspReflection
	{
		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x000CE4B6 File Offset: 0x000CC6B6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFightActivityDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E15 RID: 7701
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9HZXRGaWdodEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhhGaWdodEFjdGl2",
			"aXR5R3JvdXAucHJvdG8i9gEKGUdldEZpZ2h0QWN0aXZpdHlEYXRhU2NSc3AS",
			"DwoHcmV0Y29kZRgOIAEoDRIoCgtEUEZLUEtES09OUBgIIAMoCzITLkZpZ2h0",
			"QWN0aXZpdHlHcm91cBITCgtBR0dNSERPS0RQTRgCIAEoCBJACgtKRE5IQ05I",
			"QU1NTBgHIAMoCzIrLkdldEZpZ2h0QWN0aXZpdHlEYXRhU2NSc3AuSkROSENO",
			"SEFNTUxFbnRyeRITCgt3b3JsZF9sZXZlbBgFIAEoDRoyChBKRE5IQ05IQU1N",
			"TEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			FightActivityGroupReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFightActivityDataScRsp), GetFightActivityDataScRsp.Parser, new string[]
			{
				"Retcode",
				"DPFKPKDKONP",
				"AGGMHDOKDPM",
				"JDNHCNHAMML",
				"WorldLevel"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
