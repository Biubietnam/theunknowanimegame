using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010AE RID: 4270
	public static class SelectPhoneThemeCsReqReflection
	{
		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600BE69 RID: 48745 RVA: 0x00200E31 File Offset: 0x001FF031
		public static FileDescriptor Descriptor
		{
			get
			{
				return SelectPhoneThemeCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004D5D RID: 19805
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZWxlY3RQaG9uZVRoZW1lQ3NSZXEucHJvdG8iKQoVU2VsZWN0UGhvbmVU" + "aGVtZUNzUmVxEhAKCHRoZW1lX2lkGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SelectPhoneThemeCsReq), SelectPhoneThemeCsReq.Parser, new string[]
			{
				"ThemeId"
			}, null, null, null, null)
		}));
	}
}
