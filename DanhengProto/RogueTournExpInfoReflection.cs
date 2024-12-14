using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB0 RID: 4016
	public static class RogueTournExpInfoReflection
	{
		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x001E0E42 File Offset: 0x001DF042
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournExpInfoReflection.descriptor;
			}
		}

		// Token: 0x040048B4 RID: 18612
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSb2d1ZVRvdXJuRXhwSW5mby5wcm90byI9ChFSb2d1ZVRvdXJuRXhwSW5m" + "bxILCgNleHAYDSABKA0SGwoTdGFrZW5fbGV2ZWxfcmV3YXJkcxgEIAMoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournExpInfo), RogueTournExpInfo.Parser, new string[]
			{
				"Exp",
				"TakenLevelRewards"
			}, null, null, null, null)
		}));
	}
}
