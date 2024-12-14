using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200100C RID: 4108
	public static class RogueTournReviveCostUpdateScNotifyReflection
	{
		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600B6CF RID: 46799 RVA: 0x001EA61C File Offset: 0x001E881C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournReviveCostUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004A0A RID: 18954
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihSb2d1ZVRvdXJuUmV2aXZlQ29zdFVwZGF0ZVNjTm90aWZ5LnByb3RvGhJJ",
			"dGVtQ29zdERhdGEucHJvdG8iTgoiUm9ndWVUb3VyblJldml2ZUNvc3RVcGRh",
			"dGVTY05vdGlmeRIoChFyb2d1ZV9yZXZpdmVfY29zdBgIIAEoCzINLkl0ZW1D",
			"b3N0RGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournReviveCostUpdateScNotify), RogueTournReviveCostUpdateScNotify.Parser, new string[]
			{
				"RogueReviveCost"
			}, null, null, null, null)
		}));
	}
}
