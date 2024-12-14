using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AD0 RID: 2768
	public static class MGLAPEBCMOOReflection
	{
		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06007AA6 RID: 31398 RVA: 0x00144C08 File Offset: 0x00142E08
		public static FileDescriptor Descriptor
		{
			get
			{
				return MGLAPEBCMOOReflection.descriptor;
			}
		}

		// Token: 0x04002F12 RID: 12050
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFNR0xBUEVCQ01PTy5wcm90bxocUHVua0xvcmRBdHRhY2tlclN0YXR1cy5w",
			"cm90bxoeUHVua0xvcmRCYXR0bGVSZWNvcmRMaXN0LnByb3RvGh5QdW5rTG9y",
			"ZE1vbnN0ZXJCYXNpY0luZm8ucHJvdG8irwEKC01HTEFQRUJDTU9PEi4KC0NE",
			"QUpHTElJQklJGAUgASgLMhkuUHVua0xvcmRCYXR0bGVSZWNvcmRMaXN0Ei0K",
			"CmJhc2ljX2luZm8YCyABKAsyGS5QdW5rTG9yZE1vbnN0ZXJCYXNpY0luZm8S",
			"EwoLRUdETEhIQkJGUEEYDyABKA0SLAoLT1BDTEVET0JJS0sYDCABKA4yFy5Q",
			"dW5rTG9yZEF0dGFja2VyU3RhdHVzQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PunkLordAttackerStatusReflection.Descriptor,
			PunkLordBattleRecordListReflection.Descriptor,
			PunkLordMonsterBasicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MGLAPEBCMOO), MGLAPEBCMOO.Parser, new string[]
			{
				"CDAJGLIIBII",
				"BasicInfo",
				"EGDLHHBBFPA",
				"OPCLEDOBIKK"
			}, null, null, null, null)
		}));
	}
}
