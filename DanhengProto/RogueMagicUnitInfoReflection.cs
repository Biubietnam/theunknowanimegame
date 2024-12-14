using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F2C RID: 3884
	public static class RogueMagicUnitInfoReflection
	{
		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0600AD50 RID: 44368 RVA: 0x001D224A File Offset: 0x001D044A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitInfoReflection.descriptor;
			}
		}

		// Token: 0x04004693 RID: 18067
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZU1hZ2ljVW5pdEluZm8ucHJvdG8iRQoSUm9ndWVNYWdpY1VuaXRJ" + "bmZvEhUKDW1hZ2ljX3VuaXRfaWQYByABKA0SGAoQbWFnaWNfdW5pdF9sZXZl" + "bBgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicUnitInfo), RogueMagicUnitInfo.Parser, new string[]
			{
				"MagicUnitId",
				"MagicUnitLevel"
			}, null, null, null, null)
		}));
	}
}
