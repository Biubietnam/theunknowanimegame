using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200070E RID: 1806
	public static class GetMapRotationDataScRspReflection
	{
		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x060050B9 RID: 20665 RVA: 0x000D967A File Offset: 0x000D787A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMapRotationDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001FB8 RID: 8120
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1HZXRNYXBSb3RhdGlvbkRhdGFTY1JzcC5wcm90bxoRQ2hhcmdlckluZm8u",
			"cHJvdG8aEVJvdGF0ZXJEYXRhLnByb3RvGhFITUJMSUFETktFTy5wcm90bxoX",
			"Um90YXRlckVuZXJneUluZm8ucHJvdG8i/wEKF0dldE1hcFJvdGF0aW9uRGF0",
			"YVNjUnNwEh4KCHJvb21fbWFwGAYgASgLMgwuSE1CTElBRE5LRU8SEwoLSEZK",
			"Tk5CUERMQ0sYCyABKAgSDwoHcmV0Y29kZRgNIAEoDRIiCgxjaGFyZ2VyX2lu",
			"Zm8YBSADKAsyDC5DaGFyZ2VySW5mbxITCgtDSEpNT0RJTUxEQRgEIAEoDRIn",
			"ChFyb3RhdGVyX2RhdGFfbGlzdBgOIAMoCzIMLlJvdGF0ZXJEYXRhEhMKC0lQ",
			"Rk9GSEhLSktQGAEgASgFEicKC2VuZXJneV9pbmZvGAcgASgLMhIuUm90YXRl",
			"ckVuZXJneUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			ChargerInfoReflection.Descriptor,
			RotaterDataReflection.Descriptor,
			HMBLIADNKEOReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMapRotationDataScRsp), GetMapRotationDataScRsp.Parser, new string[]
			{
				"RoomMap",
				"HFJNNBPDLCK",
				"Retcode",
				"ChargerInfo",
				"CHJMODIMLDA",
				"RotaterDataList",
				"IPFOFHHKJKP",
				"EnergyInfo"
			}, null, null, null, null)
		}));
	}
}
