using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED6 RID: 3798
	public static class RogueMagicGameScepterInfoReflection
	{
		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x0600A9CF RID: 43471 RVA: 0x001C96CB File Offset: 0x001C78CB
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameScepterInfoReflection.descriptor;
			}
		}

		// Token: 0x04004553 RID: 17747
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9Sb2d1ZU1hZ2ljR2FtZVNjZXB0ZXJJbmZvLnByb3RvGiBSb2d1ZU1hZ2lj",
			"U2NlcHRlckRyZXNzSW5mby5wcm90bxoYUm9ndWVNYWdpY0dhbWVVbml0LnBy",
			"b3RvGhdSb2d1ZU1hZ2ljU2NlcHRlci5wcm90byKuAgoZUm9ndWVNYWdpY0dh",
			"bWVTY2VwdGVySW5mbxJBCgx0cmVuY2hfY291bnQYBCADKAsyKy5Sb2d1ZU1h",
			"Z2ljR2FtZVNjZXB0ZXJJbmZvLlRyZW5jaENvdW50RW50cnkSMwoWbG9ja2Vk",
			"X21hZ2ljX3VuaXRfbGlzdBgKIAMoCzITLlJvZ3VlTWFnaWNHYW1lVW5pdBIs",
			"ChBtb2RpZmllcl9jb250ZW50GAggASgLMhIuUm9ndWVNYWdpY1NjZXB0ZXIS",
			"NwoSc2NlcHRlcl9kcmVzc19pbmZvGAUgAygLMhsuUm9ndWVNYWdpY1NjZXB0",
			"ZXJEcmVzc0luZm8aMgoQVHJlbmNoQ291bnRFbnRyeRILCgNrZXkYASABKA0S",
			"DQoFdmFsdWUYAiABKA06AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicScepterDressInfoReflection.Descriptor,
			RogueMagicGameUnitReflection.Descriptor,
			RogueMagicScepterReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGameScepterInfo), RogueMagicGameScepterInfo.Parser, new string[]
			{
				"TrenchCount",
				"LockedMagicUnitList",
				"ModifierContent",
				"ScepterDressInfo"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
