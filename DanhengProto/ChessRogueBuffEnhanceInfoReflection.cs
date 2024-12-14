using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E6 RID: 486
	public static class ChessRogueBuffEnhanceInfoReflection
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0003E8D0 File Offset: 0x0003CAD0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffEnhanceInfoReflection.descriptor;
			}
		}

		// Token: 0x04000931 RID: 2353
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlQnVmZkVuaGFuY2VJbmZvLnByb3RvGhJJdGVtQ29zdERh" + "dGEucHJvdG8iTgoZQ2hlc3NSb2d1ZUJ1ZmZFbmhhbmNlSW5mbxIPCgdidWZm" + "X2lkGAogASgNEiAKCWNvc3RfZGF0YRgOIAEoCzINLkl0ZW1Db3N0RGF0YUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueBuffEnhanceInfo), ChessRogueBuffEnhanceInfo.Parser, new string[]
			{
				"BuffId",
				"CostData"
			}, null, null, null, null)
		}));
	}
}
