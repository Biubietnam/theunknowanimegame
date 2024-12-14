using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E12 RID: 3602
	public static class RogueBonusSelectResultReflection
	{
		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x001AFC5C File Offset: 0x001ADE5C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueBonusSelectResultReflection.descriptor;
			}
		}

		// Token: 0x040041EB RID: 16875
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZUJvbnVzU2VsZWN0UmVzdWx0LnByb3RvIioKFlJvZ3VlQm9udXNT" + "ZWxlY3RSZXN1bHQSEAoIYm9udXNfaWQYDCABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueBonusSelectResult), RogueBonusSelectResult.Parser, new string[]
			{
				"BonusId"
			}, null, null, null, null)
		}));
	}
}
