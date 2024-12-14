using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000450 RID: 1104
	public static class EnterMapRotationRegionScRspReflection
	{
		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x000870A3 File Offset: 0x000852A3
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterMapRotationRegionScRspReflection.descriptor;
			}
		}

		// Token: 0x04001390 RID: 5008
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFFbnRlck1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aEE1vdGlvbklu",
			"Zm8ucHJvdG8aF1JvdGF0ZXJFbmVyZ3lJbmZvLnByb3RvIroBChtFbnRlck1h",
			"cFJvdGF0aW9uUmVnaW9uU2NSc3ASEwoLQ0hKTU9ESU1MREEYDCABKA0SGwoG",
			"bW90aW9uGAIgASgLMgsuTW90aW9uSW5mbxIPCgdyZXRjb2RlGA8gASgNEicK",
			"C2VuZXJneV9pbmZvGAkgASgLMhIuUm90YXRlckVuZXJneUluZm8SEwoLSVBG",
			"T0ZISEtKS1AYByABKA0SGgoSY2xpZW50X3Bvc192ZXJzaW9uGAsgASgNQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterMapRotationRegionScRsp), EnterMapRotationRegionScRsp.Parser, new string[]
			{
				"CHJMODIMLDA",
				"Motion",
				"Retcode",
				"EnergyInfo",
				"IPFOFHHKJKP",
				"ClientPosVersion"
			}, null, null, null, null)
		}));
	}
}
