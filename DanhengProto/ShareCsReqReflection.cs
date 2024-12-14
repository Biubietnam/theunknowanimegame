using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001142 RID: 4418
	public static class ShareCsReqReflection
	{
		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600C519 RID: 50457 RVA: 0x00210FD0 File Offset: 0x0020F1D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ShareCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004F9D RID: 20381
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBTaGFyZUNzUmVxLnByb3RvIiEKClNoYXJlQ3NSZXESEwoLUEJES09LRUxH" + "SEwYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ShareCsReq), ShareCsReq.Parser, new string[]
			{
				"PBDKOKELGHL"
			}, null, null, null, null)
		}));
	}
}
