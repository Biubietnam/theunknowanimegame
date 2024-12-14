using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E0C RID: 3596
	public static class RogueAvatarReviveCostReflection
	{
		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600A0C3 RID: 41155 RVA: 0x001AF573 File Offset: 0x001AD773
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueAvatarReviveCostReflection.descriptor;
			}
		}

		// Token: 0x040041DD RID: 16861
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZUF2YXRhclJldml2ZUNvc3QucHJvdG8aEkl0ZW1Db3N0RGF0YS5w" + "cm90byJBChVSb2d1ZUF2YXRhclJldml2ZUNvc3QSKAoRcm9ndWVfcmV2aXZl" + "X2Nvc3QYBSABKAsyDS5JdGVtQ29zdERhdGFCHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueAvatarReviveCost), RogueAvatarReviveCost.Parser, new string[]
			{
				"RogueReviveCost"
			}, null, null, null, null)
		}));
	}
}
