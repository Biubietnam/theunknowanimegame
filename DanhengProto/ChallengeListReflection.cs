using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001AC RID: 428
	public static class ChallengeListReflection
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x000379AE File Offset: 0x00035BAE
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeListReflection.descriptor;
			}
		}

		// Token: 0x0400081F RID: 2079
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNDaGFsbGVuZ2VMaXN0LnByb3RvIkgKDUNoYWxsZW5nZUxpc3QSFAoMY2hh" + "bGxlbmdlX2lkGAwgASgNEhMKC0NGSU1ESEhNS0RKGA0gASgIEgwKBHN0YXIY" + "AiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeList), ChallengeList.Parser, new string[]
			{
				"ChallengeId",
				"CFIMDHHMKDJ",
				"Star"
			}, null, null, null, null)
		}));
	}
}
