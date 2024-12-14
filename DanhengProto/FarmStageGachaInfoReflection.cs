using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000502 RID: 1282
	public static class FarmStageGachaInfoReflection
	{
		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x0600397A RID: 14714 RVA: 0x0009E288 File Offset: 0x0009C488
		public static FileDescriptor Descriptor
		{
			get
			{
				return FarmStageGachaInfoReflection.descriptor;
			}
		}

		// Token: 0x040016E5 RID: 5861
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGYXJtU3RhZ2VHYWNoYUluZm8ucHJvdG8iTAoSRmFybVN0YWdlR2FjaGFJ" + "bmZvEhIKCmJlZ2luX3RpbWUYCyABKAMSEAoIZ2FjaGFfaWQYBCABKA0SEAoI" + "ZW5kX3RpbWUYDiABKANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FarmStageGachaInfo), FarmStageGachaInfo.Parser, new string[]
			{
				"BeginTime",
				"GachaId",
				"EndTime"
			}, null, null, null, null)
		}));
	}
}
