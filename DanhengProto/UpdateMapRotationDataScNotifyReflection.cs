using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013DE RID: 5086
	public static class UpdateMapRotationDataScNotifyReflection
	{
		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x0600E2C2 RID: 58050 RVA: 0x0025B0F0 File Offset: 0x002592F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateMapRotationDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005A29 RID: 23081
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNVcGRhdGVNYXBSb3RhdGlvbkRhdGFTY05vdGlmeS5wcm90bxoRQ2hhcmdl",
			"ckluZm8ucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3RvGhFITUJMSUFETktFTy5w",
			"cm90bxoXUm90YXRlckVuZXJneUluZm8ucHJvdG8i9AEKHVVwZGF0ZU1hcFJv",
			"dGF0aW9uRGF0YVNjTm90aWZ5EhMKC0NISk1PRElNTERBGAIgASgNEh4KCHJv",
			"b21fbWFwGAwgASgLMgwuSE1CTElBRE5LRU8SJwoRcm90YXRlcl9kYXRhX2xp",
			"c3QYBCADKAsyDC5Sb3RhdGVyRGF0YRITCgtIRkpOTkJQRExDSxgIIAEoCBIi",
			"CgxjaGFyZ2VyX2luZm8YAyADKAsyDC5DaGFyZ2VySW5mbxInCgtlbmVyZ3lf",
			"aW5mbxgBIAEoCzISLlJvdGF0ZXJFbmVyZ3lJbmZvEhMKC0lQRk9GSEhLSktQ",
			"GAUgASgFQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			ChargerInfoReflection.Descriptor,
			RotaterDataReflection.Descriptor,
			HMBLIADNKEOReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMapRotationDataScNotify), UpdateMapRotationDataScNotify.Parser, new string[]
			{
				"CHJMODIMLDA",
				"RoomMap",
				"RotaterDataList",
				"HFJNNBPDLCK",
				"ChargerInfo",
				"EnergyInfo",
				"IPFOFHHKJKP"
			}, null, null, null, null)
		}));
	}
}
