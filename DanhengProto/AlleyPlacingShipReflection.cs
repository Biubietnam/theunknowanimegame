using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000090 RID: 144
	public static class AlleyPlacingShipReflection
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00011CB9 File Offset: 0x0000FEB9
		public static FileDescriptor Descriptor
		{
			get
			{
				return AlleyPlacingShipReflection.descriptor;
			}
		}

		// Token: 0x04000252 RID: 594
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBbGxleVBsYWNpbmdTaGlwLnByb3RvGhFJTkFNT09KSEVBSi5wcm90byJF" + "ChBBbGxleVBsYWNpbmdTaGlwEg8KB3NoaXBfaWQYByABKA0SIAoKZ29vZHNf" + "bGlzdBgNIAMoCzIMLklOQU1PT0pIRUFKQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			INAMOOJHEAJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AlleyPlacingShip), AlleyPlacingShip.Parser, new string[]
			{
				"ShipId",
				"GoodsList"
			}, null, null, null, null)
		}));
	}
}
