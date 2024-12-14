using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C92 RID: 3218
	public static class PHKMLOMCNMNReflection
	{
		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x0017A4F4 File Offset: 0x001786F4
		public static FileDescriptor Descriptor
		{
			get
			{
				return PHKMLOMCNMNReflection.descriptor;
			}
		}

		// Token: 0x040036FB RID: 14075
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSEtNTE9NQ05NTi5wcm90byJgCgtQSEtNTE9NQ05NThIQCghza2lsbF9p" + "ZBgBIAEoDRITCgtOTE1PQkpDQ0RFTBgCIAEoARIaChJiYXR0bGVfdGFyZ2V0" + "X2xpc3QYAyADKA0SDgoGZGFtYWdlGAQgASgBQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PHKMLOMCNMN), PHKMLOMCNMN.Parser, new string[]
			{
				"SkillId",
				"NLMOBJCCDEL",
				"BattleTargetList",
				"Damage"
			}, null, null, null, null)
		}));
	}
}
