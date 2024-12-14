using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200032D RID: 813
	public enum ContentPackageStatus
	{
		// Token: 0x04000EE6 RID: 3814
		[OriginalName("ContentPackageStatus_None")]
		None,
		// Token: 0x04000EE7 RID: 3815
		[OriginalName("ContentPackageStatus_Init")]
		Init,
		// Token: 0x04000EE8 RID: 3816
		[OriginalName("ContentPackageStatus_Doing")]
		Doing,
		// Token: 0x04000EE9 RID: 3817
		[OriginalName("ContentPackageStatus_Finished")]
		Finished,
		// Token: 0x04000EEA RID: 3818
		[OriginalName("ContentPackageStatus_Release")]
		Release
	}
}
