using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC6 RID: 3270
	public static class PlayerLoginFinishScRspReflection
	{
		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x060091D1 RID: 37329 RVA: 0x00182AC2 File Offset: 0x00180CC2
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerLoginFinishScRspReflection.descriptor;
			}
		}

		// Token: 0x04003842 RID: 14402
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxQbGF5ZXJMb2dpbkZpbmlzaFNjUnNwLnByb3RvIikKFlBsYXllckxvZ2lu" + "RmluaXNoU2NSc3ASDwoHcmV0Y29kZRgKIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerLoginFinishScRsp), PlayerLoginFinishScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
