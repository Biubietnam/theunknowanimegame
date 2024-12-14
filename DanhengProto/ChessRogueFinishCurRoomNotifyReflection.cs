using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000218 RID: 536
	public static class ChessRogueFinishCurRoomNotifyReflection
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00044D8F File Offset: 0x00042F8F
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueFinishCurRoomNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000A23 RID: 2595
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDaGVzc1JvZ3VlRmluaXNoQ3VyUm9vbU5vdGlmeS5wcm90bxoZQ2hlc3NS" + "b2d1ZUxldmVsSW5mby5wcm90byJJCh1DaGVzc1JvZ3VlRmluaXNoQ3VyUm9v" + "bU5vdGlmeRIoCgpsZXZlbF9pbmZvGA4gASgLMhQuQ2hlc3NSb2d1ZUxldmVs" + "SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ChessRogueLevelInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueFinishCurRoomNotify), ChessRogueFinishCurRoomNotify.Parser, new string[]
			{
				"LevelInfo"
			}, null, null, null, null)
		}));
	}
}
