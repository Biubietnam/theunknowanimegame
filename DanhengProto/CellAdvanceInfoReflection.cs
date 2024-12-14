using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000176 RID: 374
	public static class CellAdvanceInfoReflection
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000303CD File Offset: 0x0002E5CD
		public static FileDescriptor Descriptor
		{
			get
			{
				return CellAdvanceInfoReflection.descriptor;
			}
		}

		// Token: 0x04000700 RID: 1792
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVDZWxsQWR2YW5jZUluZm8ucHJvdG8aG0NlbGxNb25zdGVyU2VsZWN0SW5m",
			"by5wcm90bxoaQ2VsbEZpbmFsTW9uc3RlckluZm8ucHJvdG8aFUNlbGxNb25z",
			"dGVySW5mby5wcm90byKdAQoPQ2VsbEFkdmFuY2VJbmZvEigKDmNlbGxfYm9z",
			"c19pbmZvGAsgASgLMhAuQ2VsbE1vbnN0ZXJJbmZvEjAKEHNlbGVjdF9ib3Nz",
			"X2luZm8YDiABKAsyFi5DZWxsTW9uc3RlclNlbGVjdEluZm8SLgoPZmluYWxf",
			"Ym9zc19pbmZvGAggASgLMhUuQ2VsbEZpbmFsTW9uc3RlckluZm9CHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			CellMonsterSelectInfoReflection.Descriptor,
			CellFinalMonsterInfoReflection.Descriptor,
			CellMonsterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CellAdvanceInfo), CellAdvanceInfo.Parser, new string[]
			{
				"CellBossInfo",
				"SelectBossInfo",
				"FinalBossInfo"
			}, null, null, null, null)
		}));
	}
}
