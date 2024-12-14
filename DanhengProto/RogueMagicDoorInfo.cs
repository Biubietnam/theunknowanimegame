using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EBD RID: 3773
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicDoorInfo : IMessage<RogueMagicDoorInfo>, IMessage, IEquatable<RogueMagicDoorInfo>, IDeepCloneable<RogueMagicDoorInfo>, IBufferMessage
	{
		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600A89E RID: 43166 RVA: 0x001C6565 File Offset: 0x001C4765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicDoorInfo> Parser
		{
			get
			{
				return RogueMagicDoorInfo._parser;
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600A89F RID: 43167 RVA: 0x001C656C File Offset: 0x001C476C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicDoorInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600A8A0 RID: 43168 RVA: 0x001C657E File Offset: 0x001C477E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicDoorInfo.Descriptor;
			}
		}

		// Token: 0x0600A8A1 RID: 43169 RVA: 0x001C6585 File Offset: 0x001C4785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicDoorInfo()
		{
		}

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x001C658D File Offset: 0x001C478D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicDoorInfo(RogueMagicDoorInfo other) : this()
		{
			this.rogueDoorNextRoomType_ = other.rogueDoorNextRoomType_;
			this.fGIHHAAHGDA_ = other.fGIHHAAHGDA_;
			this.enterNextLayer_ = other.enterNextLayer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x001C65CA File Offset: 0x001C47CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicDoorInfo Clone()
		{
			return new RogueMagicDoorInfo(this);
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0600A8A4 RID: 43172 RVA: 0x001C65D2 File Offset: 0x001C47D2
		// (set) Token: 0x0600A8A5 RID: 43173 RVA: 0x001C65DA File Offset: 0x001C47DA
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

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600A8A6 RID: 43174 RVA: 0x001C65E3 File Offset: 0x001C47E3
		// (set) Token: 0x0600A8A7 RID: 43175 RVA: 0x001C65EB File Offset: 0x001C47EB
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

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x0600A8A8 RID: 43176 RVA: 0x001C65F4 File Offset: 0x001C47F4
		// (set) Token: 0x0600A8A9 RID: 43177 RVA: 0x001C65FC File Offset: 0x001C47FC
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

		// Token: 0x0600A8AA RID: 43178 RVA: 0x001C6605 File Offset: 0x001C4805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicDoorInfo);
		}

		// Token: 0x0600A8AB RID: 43179 RVA: 0x001C6614 File Offset: 0x001C4814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicDoorInfo other)
		{
			return other != null && (other == this || (this.RogueDoorNextRoomType == other.RogueDoorNextRoomType && this.FGIHHAAHGDA == other.FGIHHAAHGDA && this.EnterNextLayer == other.EnterNextLayer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8AC RID: 43180 RVA: 0x001C6670 File Offset: 0x001C4870
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

		// Token: 0x0600A8AD RID: 43181 RVA: 0x001C66E1 File Offset: 0x001C48E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x001C66E9 File Offset: 0x001C48E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x001C66F4 File Offset: 0x001C48F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FGIHHAAHGDA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.FGIHHAAHGDA);
			}
			if (this.EnterNextLayer)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.EnterNextLayer);
			}
			if (this.RogueDoorNextRoomType != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.RogueDoorNextRoomType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x001C676C File Offset: 0x001C496C
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

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x001C67D0 File Offset: 0x001C49D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicDoorInfo other)
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

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x001C6834 File Offset: 0x001C4A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x001C6840 File Offset: 0x001C4A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RogueDoorNextRoomType = input.ReadUInt32();
						}
					}
					else
					{
						this.EnterNextLayer = input.ReadBool();
					}
				}
				else
				{
					this.FGIHHAAHGDA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040044E9 RID: 17641
		private static readonly MessageParser<RogueMagicDoorInfo> _parser = new MessageParser<RogueMagicDoorInfo>(() => new RogueMagicDoorInfo());

		// Token: 0x040044EA RID: 17642
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044EB RID: 17643
		public const int RogueDoorNextRoomTypeFieldNumber = 14;

		// Token: 0x040044EC RID: 17644
		private uint rogueDoorNextRoomType_;

		// Token: 0x040044ED RID: 17645
		public const int FGIHHAAHGDAFieldNumber = 12;

		// Token: 0x040044EE RID: 17646
		private uint fGIHHAAHGDA_;

		// Token: 0x040044EF RID: 17647
		public const int EnterNextLayerFieldNumber = 13;

		// Token: 0x040044F0 RID: 17648
		private bool enterNextLayer_;
	}
}
