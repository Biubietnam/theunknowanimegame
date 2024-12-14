using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000AE RID: 174
	public static class ArchiveWolfBroGameCsReqReflection
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000156BD File Offset: 0x000138BD
		public static FileDescriptor Descriptor
		{
			get
			{
				return ArchiveWolfBroGameCsReqReflection.descriptor;
			}
		}

		// Token: 0x040002D6 RID: 726
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1BcmNoaXZlV29sZkJyb0dhbWVDc1JlcS5wcm90bxoQTW90aW9uSW5mby5w" + "cm90byJCChdBcmNoaXZlV29sZkJyb0dhbWVDc1JlcRIbCgZtb3Rpb24YBCAB" + "KAsyCy5Nb3Rpb25JbmZvEgoKAmlkGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ArchiveWolfBroGameCsReq), ArchiveWolfBroGameCsReq.Parser, new string[]
			{
				"Motion",
				"Id"
			}, null, null, null, null)
		}));
	}
}
