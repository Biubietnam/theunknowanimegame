using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A0 RID: 160
	public static class AMMDINMBHPFReflection
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00013455 File Offset: 0x00011655
		public static FileDescriptor Descriptor
		{
			get
			{
				return AMMDINMBHPFReflection.descriptor;
			}
		}

		// Token: 0x04000284 RID: 644
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTU1ESU5NQkhQRi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIkMKC0FN" + "TURJTk1CSFBGEiAKCWNvc3RfZGF0YRgNIAEoCzINLkl0ZW1Db3N0RGF0YRIS" + "CgpzY2VwdGVyX2lkGAwgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AMMDINMBHPF), AMMDINMBHPF.Parser, new string[]
			{
				"CostData",
				"ScepterId"
			}, null, null, null, null)
		}));
	}
}
