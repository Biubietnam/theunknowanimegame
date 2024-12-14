using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200117A RID: 4474
	public static class SpringRecoverConfigReflection
	{
		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600C7A8 RID: 51112 RVA: 0x00217B2C File Offset: 0x00215D2C
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpringRecoverConfigReflection.descriptor;
			}
		}

		// Token: 0x0400509F RID: 20639
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTcHJpbmdSZWNvdmVyQ29uZmlnLnByb3RvGhRBdmF0YXJQcmVzZXRIcC5w",
			"cm90byJyChNTcHJpbmdSZWNvdmVyQ29uZmlnEhIKCmRlZmF1bHRfaHAYCiAB",
			"KA0SFwoPYXV0b19yZWNvdmVyX2hwGAggASgIEi4KFWF2YXRhcl9wcmVzZXRf",
			"aHBfbGlzdBgDIAMoCzIPLkF2YXRhclByZXNldEhwQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			AvatarPresetHpReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpringRecoverConfig), SpringRecoverConfig.Parser, new string[]
			{
				"DefaultHp",
				"AutoRecoverHp",
				"AvatarPresetHpList"
			}, null, null, null, null)
		}));
	}
}
