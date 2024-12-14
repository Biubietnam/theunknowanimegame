using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000748 RID: 1864
	public static class GetNpcMessageGroupCsReqReflection
	{
		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06005364 RID: 21348 RVA: 0x000E0BD1 File Offset: 0x000DEDD1
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetNpcMessageGroupCsReqReflection.descriptor;
			}
		}

		// Token: 0x040020CF RID: 8399
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXROcGNNZXNzYWdlR3JvdXBDc1JlcS5wcm90byIyChdHZXROcGNNZXNz" + "YWdlR3JvdXBDc1JlcRIXCg9jb250YWN0X2lkX2xpc3QYDyADKA1CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcMessageGroupCsReq), GetNpcMessageGroupCsReq.Parser, new string[]
			{
				"ContactIdList"
			}, null, null, null, null)
		}));
	}
}
