using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000786 RID: 1926
	public static class GetQuestDataScRspReflection
	{
		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06005613 RID: 22035 RVA: 0x000E7026 File Offset: 0x000E5226
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetQuestDataScRspReflection.descriptor;
			}
		}

		// Token: 0x040021B6 RID: 8630
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRRdWVzdERhdGFTY1JzcC5wcm90bxoLUXVlc3QucHJvdG8iXwoRR2V0" + "UXVlc3REYXRhU2NSc3ASDwoHcmV0Y29kZRgPIAEoDRIdChV0b3RhbF9hY2hp" + "ZXZlbWVudF9leHAYByABKA0SGgoKcXVlc3RfbGlzdBgNIAMoCzIGLlF1ZXN0" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			QuestReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetQuestDataScRsp), GetQuestDataScRsp.Parser, new string[]
			{
				"Retcode",
				"TotalAchievementExp",
				"QuestList"
			}, null, null, null, null)
		}));
	}
}
