using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200017E RID: 382
	public static class CellMonsterInfoReflection
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00031579 File Offset: 0x0002F779
		public static FileDescriptor Descriptor
		{
			get
			{
				return CellMonsterInfoReflection.descriptor;
			}
		}

		// Token: 0x04000725 RID: 1829
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVDZWxsTW9uc3RlckluZm8ucHJvdG8aEUNlbGxNb25zdGVyLnByb3RvImMK",
			"D0NlbGxNb25zdGVySW5mbxIWCg5zZWxlY3RfYm9zc19pZBgMIAEoDRInChFj",
			"ZWxsX21vbnN0ZXJfbGlzdBgDIAMoCzIMLkNlbGxNb25zdGVyEg8KB2NvbmZp",
			"cm0YDSABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			CellMonsterReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CellMonsterInfo), CellMonsterInfo.Parser, new string[]
			{
				"SelectBossId",
				"CellMonsterList",
				"Confirm"
			}, null, null, null, null)
		}));
	}
}
