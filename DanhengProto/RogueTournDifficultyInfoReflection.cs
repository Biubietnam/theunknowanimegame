using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F98 RID: 3992
	public static class RogueTournDifficultyInfoReflection
	{
		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600B1E7 RID: 45543 RVA: 0x001DE3A0 File Offset: 0x001DC5A0
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournDifficultyInfoReflection.descriptor;
			}
		}

		// Token: 0x0400485B RID: 18523
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZVRvdXJuRGlmZmljdWx0eUluZm8ucHJvdG8iRgoYUm9ndWVUb3Vy" + "bkRpZmZpY3VsdHlJbmZvEhUKDWRpZmZpY3VsdHlfaWQYByABKA0SEwoLaXNf" + "dW5sb2NrZWQYDyABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournDifficultyInfo), RogueTournDifficultyInfo.Parser, new string[]
			{
				"DifficultyId",
				"IsUnlocked"
			}, null, null, null, null)
		}));
	}
}
