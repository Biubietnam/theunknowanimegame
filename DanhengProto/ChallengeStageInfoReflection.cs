using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001B4 RID: 436
	public static class ChallengeStageInfoReflection
	{
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00038D69 File Offset: 0x00036F69
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeStageInfoReflection.descriptor;
			}
		}

		// Token: 0x0400084C RID: 2124
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDaGFsbGVuZ2VTdGFnZUluZm8ucHJvdG8aF0NoYWxsZW5nZUJvc3NJbmZv" + "LnByb3RvIjsKEkNoYWxsZW5nZVN0YWdlSW5mbxIlCglib3NzX2luZm8YByAB" + "KAsyEi5DaGFsbGVuZ2VCb3NzSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChallengeBossInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStageInfo), ChallengeStageInfo.Parser, new string[]
			{
				"BossInfo"
			}, null, null, null, null)
		}));
	}
}
