using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001078 RID: 4216
	public static class SceneMapInfoReflection
	{
		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x001F9DA1 File Offset: 0x001F7FA1
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneMapInfoReflection.descriptor;
			}
		}

		// Token: 0x04004C4F RID: 19535
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJTY2VuZU1hcEluZm8ucHJvdG8aD01hemVHcm91cC5wcm90bxoRQktDRUtF",
			"S0hKQ0EucHJvdG8aE01hemVQcm9wU3RhdGUucHJvdG8aD0NoZXN0SW5mby5w",
			"cm90byLSAwoMU2NlbmVNYXBJbmZvEh4KCmNoZXN0X2xpc3QYCyADKAsyCi5D",
			"aGVzdEluZm8SEgoKY29udGVudF9pZBgBIAEoDRIcChRsaWdodGVuX3NlY3Rp",
			"b25fbGlzdBgPIAMoDRImCg5tYXplX3Byb3BfbGlzdBgFIAMoCzIOLk1hemVQ",
			"cm9wU3RhdGUSFAoMZGltZW5zaW9uX2lkGAIgASgNEhAKCGVudHJ5X2lkGAog",
			"ASgNEjsKEGZsb29yX3NhdmVkX2RhdGEYCCADKAsyIS5TY2VuZU1hcEluZm8u",
			"Rmxvb3JTYXZlZERhdGFFbnRyeRIhCgtHQ0VMSERBQ0FKSxgJIAMoCzIMLkJL",
			"Q0VLRUtISkNBEhwKFHVubG9ja190ZWxlcG9ydF9saXN0GAYgAygNEhsKE2Vu",
			"dHJ5X3N0b3J5X2xpbmVfaWQYDSABKA0SIwoPbWF6ZV9ncm91cF9saXN0GAMg",
			"AygLMgouTWF6ZUdyb3VwEg8KB3JldGNvZGUYDCABKA0SGAoQY3VyX21hcF9l",
			"bnRyeV9pZBgEIAEoDRo1ChNGbG9vclNhdmVkRGF0YUVudHJ5EgsKA2tleRgB",
			"IAEoCRINCgV2YWx1ZRgCIAEoBToCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MazeGroupReflection.Descriptor,
			BKCEKEKHJCAReflection.Descriptor,
			MazePropStateReflection.Descriptor,
			ChestInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneMapInfo), SceneMapInfo.Parser, new string[]
			{
				"ChestList",
				"ContentId",
				"LightenSectionList",
				"MazePropList",
				"DimensionId",
				"EntryId",
				"FloorSavedData",
				"GCELHDACAJK",
				"UnlockTeleportList",
				"EntryStoryLineId",
				"MazeGroupList",
				"Retcode",
				"CurMapEntryId"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
