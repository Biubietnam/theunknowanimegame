using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F3A RID: 3898
	public static class RogueMapRotateInfoReflection
	{
		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x001D3A25 File Offset: 0x001D1C25
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMapRotateInfoReflection.descriptor;
			}
		}

		// Token: 0x040046C9 RID: 18121
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZU1hcFJvdGF0ZUluZm8ucHJvdG8aEUNoYXJnZXJJbmZvLnByb3Rv",
			"GhFSb3RhdGVyRGF0YS5wcm90bxoRSE1CTElBRE5LRU8ucHJvdG8aF1JvdGF0",
			"ZXJFbmVyZ3lJbmZvLnByb3RvIucBChJSb2d1ZU1hcFJvdGF0ZUluZm8SIgoM",
			"Y2hhcmdlcl9pbmZvGAkgAygLMgwuQ2hhcmdlckluZm8SJwoRcm90YXRlcl9k",
			"YXRhX2xpc3QYBiADKAsyDC5Sb3RhdGVyRGF0YRITCgtDSEpNT0RJTUxEQRgO",
			"IAEoDRIRCglpc19yb3RhdGUYDyABKAgSHgoIcm9vbV9tYXAYBCABKAsyDC5I",
			"TUJMSUFETktFTxITCgtJUEZPRkhIS0pLUBgIIAEoBRInCgtlbmVyZ3lfaW5m",
			"bxgKIAEoCzISLlJvdGF0ZXJFbmVyZ3lJbmZvQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChargerInfoReflection.Descriptor,
			RotaterDataReflection.Descriptor,
			HMBLIADNKEOReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMapRotateInfo), RogueMapRotateInfo.Parser, new string[]
			{
				"ChargerInfo",
				"RotaterDataList",
				"CHJMODIMLDA",
				"IsRotate",
				"RoomMap",
				"IPFOFHHKJKP",
				"EnergyInfo"
			}, null, null, null, null)
		}));
	}
}
