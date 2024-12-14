using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F0C RID: 3852
	public static class RogueMagicScepterSelectInfoReflection
	{
		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0600ABFF RID: 44031 RVA: 0x001CF01A File Offset: 0x001CD21A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x04004622 RID: 17954
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSb2d1ZU1hZ2ljU2NlcHRlclNlbGVjdEluZm8ucHJvdG8aF1JvZ3VlTWFn",
			"aWNTY2VwdGVyLnByb3RvImIKG1JvZ3VlTWFnaWNTY2VwdGVyU2VsZWN0SW5m",
			"bxIrCg9zZWxlY3Rfc2NlcHRlcnMYCyADKAsyEi5Sb2d1ZU1hZ2ljU2NlcHRl",
			"chIWCg5zZWxlY3RfaGludF9pZBgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicScepterReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicScepterSelectInfo), RogueMagicScepterSelectInfo.Parser, new string[]
			{
				"SelectScepters",
				"SelectHintId"
			}, null, null, null, null)
		}));
	}
}
