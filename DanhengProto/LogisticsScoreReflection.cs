using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A6A RID: 2666
	public static class LogisticsScoreReflection
	{
		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x00139AD1 File Offset: 0x00137CD1
		public static FileDescriptor Descriptor
		{
			get
			{
				return LogisticsScoreReflection.descriptor;
			}
		}

		// Token: 0x04002D6B RID: 11627
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRMb2dpc3RpY3NTY29yZS5wcm90bxoOSXRlbUxpc3QucHJvdG8iowEKDkxv",
			"Z2lzdGljc1Njb3JlEhQKDHVubG9ja19sZXZlbBgBIAEoDRIRCgltYXhfc2Nv",
			"cmUYAyABKA0SFgoObGFzdF9tYXhfc2NvcmUYDyABKA0SEgoKbGFzdF9sZXZl",
			"bBgFIAEoDRIOCgZtYXBfaWQYDSABKA0SGQoGcmV3YXJkGA4gASgLMgkuSXRl",
			"bUxpc3QSEQoJY3VyX3Njb3JlGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LogisticsScore), LogisticsScore.Parser, new string[]
			{
				"UnlockLevel",
				"MaxScore",
				"LastMaxScore",
				"LastLevel",
				"MapId",
				"Reward",
				"CurScore"
			}, null, null, null, null)
		}));
	}
}
