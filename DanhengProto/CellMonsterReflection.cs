using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200017C RID: 380
	public static class CellMonsterReflection
	{
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00031242 File Offset: 0x0002F442
		public static FileDescriptor Descriptor
		{
			get
			{
				return CellMonsterReflection.descriptor;
			}
		}

		// Token: 0x0400071E RID: 1822
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDZWxsTW9uc3Rlci5wcm90byI4CgtDZWxsTW9uc3RlchIVCg1ib3NzX2Rl" + "Y2F5X2lkGAMgASgNEhIKCm1vbnN0ZXJfaWQYAiABKA1CHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CellMonster), CellMonster.Parser, new string[]
			{
				"BossDecayId",
				"MonsterId"
			}, null, null, null, null)
		}));
	}
}
