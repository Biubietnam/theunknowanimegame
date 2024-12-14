using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D2E RID: 3374
	public static class PunkLordMonsterKilledNotifyReflection
	{
		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x060096BD RID: 38589 RVA: 0x0019120C File Offset: 0x0018F40C
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterKilledNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003A81 RID: 14977
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFQdW5rTG9yZE1vbnN0ZXJLaWxsZWROb3RpZnkucHJvdG8aH0tpbGxlZFB1",
			"bmtMb3JkTW9uc3RlckluZm8ucHJvdG8iTgobUHVua0xvcmRNb25zdGVyS2ls",
			"bGVkTm90aWZ5Ei8KC0hFUElGREZDR0hBGAQgASgLMhouS2lsbGVkUHVua0xv",
			"cmRNb25zdGVySW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			KilledPunkLordMonsterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordMonsterKilledNotify), PunkLordMonsterKilledNotify.Parser, new string[]
			{
				"HEPIFDFCGHA"
			}, null, null, null, null)
		}));
	}
}
