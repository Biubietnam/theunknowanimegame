using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED9 RID: 3801
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGameUnit : IMessage<RogueMagicGameUnit>, IMessage, IEquatable<RogueMagicGameUnit>, IDeepCloneable<RogueMagicGameUnit>, IBufferMessage
	{
		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x0600A9E9 RID: 43497 RVA: 0x001C9CBC File Offset: 0x001C7EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGameUnit> Parser
		{
			get
			{
				return RogueMagicGameUnit._parser;
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x0600A9EA RID: 43498 RVA: 0x001C9CC3 File Offset: 0x001C7EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameUnitReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x0600A9EB RID: 43499 RVA: 0x001C9CD5 File Offset: 0x001C7ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGameUnit.Descriptor;
			}
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x001C9CDC File Offset: 0x001C7EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnit()
		{
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x001C9CE4 File Offset: 0x001C7EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnit(RogueMagicGameUnit other) : this()
		{
			this.magicUnitId_ = other.magicUnitId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x001C9D15 File Offset: 0x001C7F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnit Clone()
		{
			return new RogueMagicGameUnit(this);
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x0600A9EF RID: 43503 RVA: 0x001C9D1D File Offset: 0x001C7F1D
		// (set) Token: 0x0600A9F0 RID: 43504 RVA: 0x001C9D25 File Offset: 0x001C7F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicUnitId
		{
			get
			{
				return this.magicUnitId_;
			}
			set
			{
				this.magicUnitId_ = value;
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0600A9F1 RID: 43505 RVA: 0x001C9D2E File Offset: 0x001C7F2E
		// (set) Token: 0x0600A9F2 RID: 43506 RVA: 0x001C9D36 File Offset: 0x001C7F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x001C9D3F File Offset: 0x001C7F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGameUnit);
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x001C9D4D File Offset: 0x001C7F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGameUnit other)
		{
			return other != null && (other == this || (this.MagicUnitId == other.MagicUnitId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x001C9D8C File Offset: 0x001C7F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MagicUnitId != 0U)
			{
				num ^= this.MagicUnitId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x001C9DE4 File Offset: 0x001C7FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x001C9DEC File Offset: 0x001C7FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x001C9DF8 File Offset: 0x001C7FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MagicUnitId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MagicUnitId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x001C9E54 File Offset: 0x001C8054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MagicUnitId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicUnitId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x001C9EAC File Offset: 0x001C80AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGameUnit other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MagicUnitId != 0U)
			{
				this.MagicUnitId = other.MagicUnitId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x001C9EFC File Offset: 0x001C80FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x001C9F08 File Offset: 0x001C8108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.MagicUnitId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004562 RID: 17762
		private static readonly MessageParser<RogueMagicGameUnit> _parser = new MessageParser<RogueMagicGameUnit>(() => new RogueMagicGameUnit());

		// Token: 0x04004563 RID: 17763
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004564 RID: 17764
		public const int MagicUnitIdFieldNumber = 3;

		// Token: 0x04004565 RID: 17765
		private uint magicUnitId_;

		// Token: 0x04004566 RID: 17766
		public const int LevelFieldNumber = 5;

		// Token: 0x04004567 RID: 17767
		private uint level_;
	}
}
