using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D4E RID: 3406
	public static class QuitRogueCsReqReflection
	{
		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0600983E RID: 38974 RVA: 0x00195B08 File Offset: 0x00193D08
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuitRogueCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003B34 RID: 15156
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRRdWl0Um9ndWVDc1JlcS5wcm90byIhCg5RdWl0Um9ndWVDc1JlcRIPCgdh" + "cmVhX2lkGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuitRogueCsReq), QuitRogueCsReq.Parser, new string[]
			{
				"AreaId"
			}, null, null, null, null)
		}));
	}
}
