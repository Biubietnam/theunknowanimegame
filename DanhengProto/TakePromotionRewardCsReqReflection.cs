using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200130C RID: 4876
	public static class TakePromotionRewardCsReqReflection
	{
		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0600D990 RID: 55696 RVA: 0x00243A86 File Offset: 0x00241C86
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakePromotionRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x040056B1 RID: 22193
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5UYWtlUHJvbW90aW9uUmV3YXJkQ3NSZXEucHJvdG8iRQoYVGFrZVByb21v" + "dGlvblJld2FyZENzUmVxEhYKDmJhc2VfYXZhdGFyX2lkGAkgASgNEhEKCXBy" + "b21vdGlvbhgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakePromotionRewardCsReq), TakePromotionRewardCsReq.Parser, new string[]
			{
				"BaseAvatarId",
				"Promotion"
			}, null, null, null, null)
		}));
	}
}
