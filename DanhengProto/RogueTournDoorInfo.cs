using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F9B RID: 3995
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournDoorInfo : IMessage<RogueTournDoorInfo>, IMessage, IEquatable<RogueTournDoorInfo>, IDeepCloneable<RogueTournDoorInfo>, IBufferMessage
	{
		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600B200 RID: 45568 RVA: 0x001DE755 File Offset: 0x001DC955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournDoorInfo> Parser
		{
			get
			{
				return RogueTournDoorInfo._parser;
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600B201 RID: 45569 RVA: 0x001DE75C File Offset: 0x001DC95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournDoorInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600B202 RID: 45570 RVA: 0x001DE76E File Offset: 0x001DC96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournDoorInfo.Descriptor;
			}
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x001DE775 File Offset: 0x001DC975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDoorInfo()
		{
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x001DE77D File Offset: 0x001DC97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDoorInfo(RogueTournDoorInfo other) : this()
		{
			this.rogueDoorNextRoomType_ = other.rogueDoorNextRoomType_;
			this.fGIHHAAHGDA_ = other.fGIHHAAHGDA_;
			this.enterNextLayer_ = other.enterNextLayer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x001DE7BA File Offset: 0x001DC9BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournDoorInfo Clone()
		{
			return new RogueTournDoorInfo(this);
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600B206 RID: 45574 RVA: 0x001DE7C2 File Offset: 0x001DC9C2
		// (set) Token: 0x0600B207 RID: 45575 RVA: 0x001DE7CA File Offset: 0x001DC9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueDoorNextRoomType
		{
			get
			{
				return this.rogueDoorNextRoomType_;
			}
			set
			{
				this.rogueDoorNextRoomType_ = value;
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600B208 RID: 45576 RVA: 0x001DE7D3 File Offset: 0x001DC9D3
		// (set) Token: 0x0600B209 RID: 45577 RVA: 0x001DE7DB File Offset: 0x001DC9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FGIHHAAHGDA
		{
			get
			{
				return this.fGIHHAAHGDA_;
			}
			set
			{
				this.fGIHHAAHGDA_ = value;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600B20A RID: 45578 RVA: 0x001DE7E4 File Offset: 0x001DC9E4
		// (set) Token: 0x0600B20B RID: 45579 RVA: 0x001DE7EC File Offset: 0x001DC9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnterNextLayer
		{
			get
			{
				return this.enterNextLayer_;
			}
			set
			{
				this.enterNextLayer_ = value;
			}
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x001DE7F5 File Offset: 0x001DC9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournDoorInfo);
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x001DE804 File Offset: 0x001DCA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournDoorInfo other)
		{
			return other != null && (other == this || (this.RogueDoorNextRoomType == other.RogueDoorNextRoomType && this.FGIHHAAHGDA == other.FGIHHAAHGDA && this.EnterNextLayer == other.EnterNextLayer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x001DE860 File Offset: 0x001DCA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueDoorNextRoomType != 0U)
			{
				num ^= this.RogueDoorNextRoomType.GetHashCode();
			}
			if (this.FGIHHAAHGDA != 0U)
			{
				num ^= this.FGIHHAAHGDA.GetHashCode();
			}
			if (this.EnterNextLayer)
			{
				num ^= this.EnterNextLayer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x001DE8D1 File Offset: 0x001DCAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x001DE8D9 File Offset: 0x001DCAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x001DE8E4 File Offset: 0x001DCAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RogueDoorNextRoomType != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RogueDoorNextRoomType);
			}
			if (this.EnterNextLayer)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.EnterNextLayer);
			}
			if (this.FGIHHAAHGDA != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.FGIHHAAHGDA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x001DE95C File Offset: 0x001DCB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueDoorNextRoomType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueDoorNextRoomType);
			}
			if (this.FGIHHAAHGDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FGIHHAAHGDA);
			}
			if (this.EnterNextLayer)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x001DE9C0 File Offset: 0x001DCBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournDoorInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueDoorNextRoomType != 0U)
			{
				this.RogueDoorNextRoomType = other.RogueDoorNextRoomType;
			}
			if (other.FGIHHAAHGDA != 0U)
			{
				this.FGIHHAAHGDA = other.FGIHHAAHGDA;
			}
			if (other.EnterNextLayer)
			{
				this.EnterNextLayer = other.EnterNextLayer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x001DEA24 File Offset: 0x001DCC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x001DEA30 File Offset: 0x001DCC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FGIHHAAHGDA = input.ReadUInt32();
						}
					}
					else
					{
						this.EnterNextLayer = input.ReadBool();
					}
				}
				else
				{
					this.RogueDoorNextRoomType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004863 RID: 18531
		private static readonly MessageParser<RogueTournDoorInfo> _parser = new MessageParser<RogueTournDoorInfo>(() => new RogueTournDoorInfo());

		// Token: 0x04004864 RID: 18532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004865 RID: 18533
		public const int RogueDoorNextRoomTypeFieldNumber = 5;

		// Token: 0x04004866 RID: 18534
		private uint rogueDoorNextRoomType_;

		// Token: 0x04004867 RID: 18535
		public const int FGIHHAAHGDAFieldNumber = 11;

		// Token: 0x04004868 RID: 18536
		private uint fGIHHAAHGDA_;

		// Token: 0x04004869 RID: 18537
		public const int EnterNextLayerFieldNumber = 8;

		// Token: 0x0400486A RID: 18538
		private bool enterNextLayer_;
	}
}
