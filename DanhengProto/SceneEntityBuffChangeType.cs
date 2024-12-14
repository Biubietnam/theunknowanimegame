using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200105F RID: 4191
	public enum SceneEntityBuffChangeType
	{
		// Token: 0x04004BAE RID: 19374
		[OriginalName("SCENE_ENTITY_BUFF_CHANGE_TYPE_DEFAULT")]
		Default,
		// Token: 0x04004BAF RID: 19375
		[OriginalName("SCENE_ENTITY_BUFF_CHANGE_TYPE_ADD_MAZEBUFF")]
		AddMazebuff,
		// Token: 0x04004BB0 RID: 19376
		[OriginalName("SCENE_ENTITY_BUFF_CHANGE_TYPE_ADD_ADV_MODIFIER")]
		AddAdvModifier
	}
}
