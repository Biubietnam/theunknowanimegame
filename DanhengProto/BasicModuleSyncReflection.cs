using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000CE RID: 206
	public static class BasicModuleSyncReflection
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0001B4FF File Offset: 0x000196FF
		public static FileDescriptor Descriptor
		{
			get
			{
				return BasicModuleSyncReflection.descriptor;
			}
		}

		// Token: 0x040003C8 RID: 968
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCYXNpY01vZHVsZVN5bmMucHJvdG8iRgoPQmFzaWNNb2R1bGVTeW5jEiIK" + "GndlZWtfY29jb29uX2ZpbmlzaGVkX2NvdW50GAogASgNEg8KB3N0YW1pbmEY" + "DyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BasicModuleSync), BasicModuleSync.Parser, new string[]
			{
				"WeekCocoonFinishedCount",
				"Stamina"
			}, null, null, null, null)
		}));
	}
}
