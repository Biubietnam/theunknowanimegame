using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CAE RID: 3246
	public static class PlayerBasicInfoReflection
	{
		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x06009049 RID: 36937 RVA: 0x0017D03F File Offset: 0x0017B23F
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerBasicInfoReflection.descriptor;
			}
		}

		// Token: 0x04003772 RID: 14194
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVQbGF5ZXJCYXNpY0luZm8ucHJvdG8ikgEKD1BsYXllckJhc2ljSW5mbxIQ",
			"CghuaWNrbmFtZRgBIAEoCRINCgVsZXZlbBgCIAEoDRILCgNleHAYAyABKA0S",
			"DwoHc3RhbWluYRgEIAEoDRINCgVtY29pbhgFIAEoDRINCgVoY29pbhgGIAEo",
			"DRINCgVzY29pbhgHIAEoDRITCgt3b3JsZF9sZXZlbBgIIAEoDUIeqgIbRWdn",
			"TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerBasicInfo), PlayerBasicInfo.Parser, new string[]
			{
				"Nickname",
				"Level",
				"Exp",
				"Stamina",
				"Mcoin",
				"Hcoin",
				"Scoin",
				"WorldLevel"
			}, null, null, null, null)
		}));
	}
}
