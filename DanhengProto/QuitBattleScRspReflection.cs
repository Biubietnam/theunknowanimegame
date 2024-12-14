using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D48 RID: 3400
	public static class QuitBattleScRspReflection
	{
		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x060097ED RID: 38893 RVA: 0x00194D06 File Offset: 0x00192F06
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuitBattleScRspReflection.descriptor;
			}
		}

		// Token: 0x04003B13 RID: 15123
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVRdWl0QmF0dGxlU2NSc3AucHJvdG8iIgoPUXVpdEJhdHRsZVNjUnNwEg8K" + "B3JldGNvZGUYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(QuitBattleScRsp), QuitBattleScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
