using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001014 RID: 4116
	public static class RogueTournSeasonInfoReflection
	{
		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600B722 RID: 46882 RVA: 0x001EB643 File Offset: 0x001E9843
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournSeasonInfoReflection.descriptor;
			}
		}

		// Token: 0x04004A31 RID: 18993
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZVRvdXJuU2Vhc29uSW5mby5wcm90byJDChRSb2d1ZVRvdXJuU2Vh" + "c29uSW5mbxIUCgxzdWJfdG91cm5faWQYDiABKA0SFQoNbWFpbl90b3Vybl9p" + "ZBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournSeasonInfo), RogueTournSeasonInfo.Parser, new string[]
			{
				"SubTournId",
				"MainTournId"
			}, null, null, null, null)
		}));
	}
}
