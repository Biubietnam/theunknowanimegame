using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EFA RID: 3834
	public static class RogueMagicReviveCostUpdateScNotifyReflection
	{
		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0600AB47 RID: 43847 RVA: 0x001CD5D4 File Offset: 0x001CB7D4
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicReviveCostUpdateScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040045E6 RID: 17894
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihSb2d1ZU1hZ2ljUmV2aXZlQ29zdFVwZGF0ZVNjTm90aWZ5LnByb3RvGhJJ",
			"dGVtQ29zdERhdGEucHJvdG8iTgoiUm9ndWVNYWdpY1Jldml2ZUNvc3RVcGRh",
			"dGVTY05vdGlmeRIoChFyb2d1ZV9yZXZpdmVfY29zdBgEIAEoCzINLkl0ZW1D",
			"b3N0RGF0YUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicReviveCostUpdateScNotify), RogueMagicReviveCostUpdateScNotify.Parser, new string[]
			{
				"RogueReviveCost"
			}, null, null, null, null)
		}));
	}
}
