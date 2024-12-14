using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005A2 RID: 1442
	public static class FinishTutorialGuideScRspReflection
	{
		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x000AF4B6 File Offset: 0x000AD6B6
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishTutorialGuideScRspReflection.descriptor;
			}
		}

		// Token: 0x0400198D RID: 6541
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5GaW5pc2hUdXRvcmlhbEd1aWRlU2NSc3AucHJvdG8aE1R1dG9yaWFsR3Vp",
			"ZGUucHJvdG8aDkl0ZW1MaXN0LnByb3RvIm0KGEZpbmlzaFR1dG9yaWFsR3Vp",
			"ZGVTY1JzcBIZCgZyZXdhcmQYDSABKAsyCS5JdGVtTGlzdBIlCg1UdXRvcmlh",
			"bEd1aWRlGAkgASgLMg4uVHV0b3JpYWxHdWlkZRIPCgdyZXRjb2RlGAsgASgN",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			TutorialGuideReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishTutorialGuideScRsp), FinishTutorialGuideScRsp.Parser, new string[]
			{
				"Reward",
				"TutorialGuide",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
