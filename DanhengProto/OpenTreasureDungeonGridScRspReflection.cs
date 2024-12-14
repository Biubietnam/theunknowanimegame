using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C70 RID: 3184
	public static class OpenTreasureDungeonGridScRspReflection
	{
		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x06008D8B RID: 36235 RVA: 0x00176249 File Offset: 0x00174449
		public static FileDescriptor Descriptor
		{
			get
			{
				return OpenTreasureDungeonGridScRspReflection.descriptor;
			}
		}

		// Token: 0x0400365C RID: 13916
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJPcGVuVHJlYXN1cmVEdW5nZW9uR3JpZFNjUnNwLnByb3RvGhpUcmVhc3Vy",
			"ZUR1bmdlb25MZXZlbC5wcm90byJbChxPcGVuVHJlYXN1cmVEdW5nZW9uR3Jp",
			"ZFNjUnNwEioKC0xISUVDS1BKTkZEGAQgASgLMhUuVHJlYXN1cmVEdW5nZW9u",
			"TGV2ZWwSDwoHcmV0Y29kZRgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			TreasureDungeonLevelReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OpenTreasureDungeonGridScRsp), OpenTreasureDungeonGridScRsp.Parser, new string[]
			{
				"LHIECKPJNFD",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
