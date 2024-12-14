using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001073 RID: 4211
	public enum SceneGroupRefreshType
	{
		// Token: 0x04004C0C RID: 19468
		[OriginalName("SCENE_GROUP_REFRESH_TYPE_NONE")]
		None,
		// Token: 0x04004C0D RID: 19469
		[OriginalName("SCENE_GROUP_REFRESH_TYPE_LOADED")]
		Loaded,
		// Token: 0x04004C0E RID: 19470
		[OriginalName("SCENE_GROUP_REFRESH_TYPE_UNLOAD")]
		Unload
	}
}
