using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F5C RID: 3932
	public static class RogueNpcDisappearCsReqReflection
	{
		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600AF50 RID: 44880 RVA: 0x001D71FC File Offset: 0x001D53FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueNpcDisappearCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004753 RID: 18259
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZU5wY0Rpc2FwcGVhckNzUmVxLnByb3RvIjkKFlJvZ3VlTnBjRGlz" + "YXBwZWFyQ3NSZXESHwoXZGlzYXBwZWFyX25wY19lbnRpdHlfaWQYAyABKA1C" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueNpcDisappearCsReq), RogueNpcDisappearCsReq.Parser, new string[]
			{
				"DisappearNpcEntityId"
			}, null, null, null, null)
		}));
	}
}
