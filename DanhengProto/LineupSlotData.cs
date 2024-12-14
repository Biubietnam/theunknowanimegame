using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A15 RID: 2581
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LineupSlotData : IMessage<LineupSlotData>, IMessage, IEquatable<LineupSlotData>, IDeepCloneable<LineupSlotData>, IBufferMessage
	{
		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x060072AE RID: 29358 RVA: 0x001316E5 File Offset: 0x0012F8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LineupSlotData> Parser
		{
			get
			{
				return LineupSlotData._parser;
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x060072AF RID: 29359 RVA: 0x001316EC File Offset: 0x0012F8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LineupSlotDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x060072B0 RID: 29360 RVA: 0x001316FE File Offset: 0x0012F8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineupSlotData.Descriptor;
			}
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x00131705 File Offset: 0x0012F905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupSlotData()
		{
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x0013170D File Offset: 0x0012F90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupSlotData(LineupSlotData other) : this()
		{
			this.slot_ = other.slot_;
			this.id_ = other.id_;
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x0013174A File Offset: 0x0012F94A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupSlotData Clone()
		{
			return new LineupSlotData(this);
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x060072B4 RID: 29364 RVA: 0x00131752 File Offset: 0x0012F952
		// (set) Token: 0x060072B5 RID: 29365 RVA: 0x0013175A File Offset: 0x0012F95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x060072B6 RID: 29366 RVA: 0x00131763 File Offset: 0x0012F963
		// (set) Token: 0x060072B7 RID: 29367 RVA: 0x0013176B File Offset: 0x0012F96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x060072B8 RID: 29368 RVA: 0x00131774 File Offset: 0x0012F974
		// (set) Token: 0x060072B9 RID: 29369 RVA: 0x0013177C File Offset: 0x0012F97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x00131785 File Offset: 0x0012F985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineupSlotData);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x00131794 File Offset: 0x0012F994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineupSlotData other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && this.Id == other.Id && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x001317F0 File Offset: 0x0012F9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x00131867 File Offset: 0x0012FA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x0013186F File Offset: 0x0012FA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x00131878 File Offset: 0x0012FA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.Slot != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Slot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x001318F0 File Offset: 0x0012FAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x00131960 File Offset: 0x0012FB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineupSlotData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x001319C4 File Offset: 0x0012FBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x001319D0 File Offset: 0x0012FBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Slot = input.ReadUInt32();
						}
					}
					else
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002C25 RID: 11301
		private static readonly MessageParser<LineupSlotData> _parser = new MessageParser<LineupSlotData>(() => new LineupSlotData());

		// Token: 0x04002C26 RID: 11302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C27 RID: 11303
		public const int SlotFieldNumber = 13;

		// Token: 0x04002C28 RID: 11304
		private uint slot_;

		// Token: 0x04002C29 RID: 11305
		public const int IdFieldNumber = 3;

		// Token: 0x04002C2A RID: 11306
		private uint id_;

		// Token: 0x04002C2B RID: 11307
		public const int AvatarTypeFieldNumber = 10;

		// Token: 0x04002C2C RID: 11308
		private AvatarType avatarType_;
	}
}
