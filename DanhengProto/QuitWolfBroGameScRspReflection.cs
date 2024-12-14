using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D5C RID: 3420
	public static class QuitWolfBroGameScRspReflection
	{
		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x060098D7 RID: 39127 RVA: 0x00196F02 File Offset: 0x00195102
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuitWolfBroGameScRspReflection.descriptor;
			}
		}

		// Token: 0x04003B5D RID: 15197
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpRdWl0V29sZkJyb0dhbWVTY1JzcC5wcm90bxoVV29sZkJyb0dhbWVEYXRh" + "LnByb3RvIlUKFFF1aXRXb2xmQnJvR2FtZVNjUnNwEg8KB3JldGNvZGUYAiAB" + "KA0SLAoSd29sZl9icm9fZ2FtZV9kYXRhGAEgASgLMhAuV29sZkJyb0dhbWVE" + "YXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			WolfBroGameDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuitWolfBroGameScRsp), QuitWolfBroGameScRsp.Parser, new string[]
			{
				"Retcode",
				"WolfBroGameData"
			}, null, null, null, null)
		}));
	}
}
