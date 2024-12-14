using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001148 RID: 4424
	public static class SharePunkLordMonsterScRspReflection
	{
		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600C55E RID: 50526 RVA: 0x0021198C File Offset: 0x0020FB8C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SharePunkLordMonsterScRspReflection.descriptor;
			}
		}

		// Token: 0x04004FB2 RID: 20402
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9TaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwLnByb3RvGhdQdW5rTG9yZFNo",
			"YXJlVHlwZS5wcm90byJ1ChlTaGFyZVB1bmtMb3JkTW9uc3RlclNjUnNwEhIK",
			"Cm1vbnN0ZXJfaWQYDiABKA0SDwoHcmV0Y29kZRgNIAEoDRImCgpzaGFyZV90",
			"eXBlGAUgASgOMhIuUHVua0xvcmRTaGFyZVR5cGUSCwoDdWlkGAEgASgNQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PunkLordShareTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SharePunkLordMonsterScRsp), SharePunkLordMonsterScRsp.Parser, new string[]
			{
				"MonsterId",
				"Retcode",
				"ShareType",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
