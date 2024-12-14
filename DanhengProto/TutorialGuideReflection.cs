using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B2 RID: 5042
	public static class TutorialGuideReflection
	{
		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x0600E0E7 RID: 57575 RVA: 0x00256B49 File Offset: 0x00254D49
		public static FileDescriptor Descriptor
		{
			get
			{
				return TutorialGuideReflection.descriptor;
			}
		}

		// Token: 0x0400598B RID: 22923
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNUdXRvcmlhbEd1aWRlLnByb3RvGhRUdXRvcmlhbFN0YXR1cy5wcm90byI8" + "Cg1UdXRvcmlhbEd1aWRlEh8KBlN0YXR1cxgFIAEoDjIPLlR1dG9yaWFsU3Rh" + "dHVzEgoKAmlkGAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			TutorialStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TutorialGuide), TutorialGuide.Parser, new string[]
			{
				"Status",
				"Id"
			}, null, null, null, null)
		}));
	}
}
