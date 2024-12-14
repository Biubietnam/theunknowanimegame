using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B3 RID: 1459
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FNJFGLPKKIJ : IMessage<FNJFGLPKKIJ>, IMessage, IEquatable<FNJFGLPKKIJ>, IDeepCloneable<FNJFGLPKKIJ>, IBufferMessage
	{
		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x000B1D00 File Offset: 0x000AFF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FNJFGLPKKIJ> Parser
		{
			get
			{
				return FNJFGLPKKIJ._parser;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x000B1D07 File Offset: 0x000AFF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FNJFGLPKKIJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x000B1D19 File Offset: 0x000AFF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FNJFGLPKKIJ.Descriptor;
			}
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x000B1D20 File Offset: 0x000AFF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FNJFGLPKKIJ()
		{
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000B1D28 File Offset: 0x000AFF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FNJFGLPKKIJ(FNJFGLPKKIJ other) : this()
		{
			this.levelId_ = other.levelId_;
			this.kIFPFCDEAAE_ = other.kIFPFCDEAAE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x000B1D59 File Offset: 0x000AFF59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FNJFGLPKKIJ Clone()
		{
			return new FNJFGLPKKIJ(this);
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x000B1D61 File Offset: 0x000AFF61
		// (set) Token: 0x06004141 RID: 16705 RVA: 0x000B1D69 File Offset: 0x000AFF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x000B1D72 File Offset: 0x000AFF72
		// (set) Token: 0x06004143 RID: 16707 RVA: 0x000B1D7A File Offset: 0x000AFF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KIFPFCDEAAE
		{
			get
			{
				return this.kIFPFCDEAAE_;
			}
			set
			{
				this.kIFPFCDEAAE_ = value;
			}
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x000B1D83 File Offset: 0x000AFF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FNJFGLPKKIJ);
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x000B1D91 File Offset: 0x000AFF91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FNJFGLPKKIJ other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.KIFPFCDEAAE == other.KIFPFCDEAAE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x000B1DD0 File Offset: 0x000AFFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				num ^= this.KIFPFCDEAAE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x000B1E28 File Offset: 0x000B0028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x000B1E30 File Offset: 0x000B0030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x000B1E3C File Offset: 0x000B003C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KIFPFCDEAAE != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.KIFPFCDEAAE);
			}
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x000B1E98 File Offset: 0x000B0098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this.KIFPFCDEAAE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KIFPFCDEAAE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x000B1EF0 File Offset: 0x000B00F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FNJFGLPKKIJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			if (other.KIFPFCDEAAE != 0U)
			{
				this.KIFPFCDEAAE = other.KIFPFCDEAAE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x000B1F40 File Offset: 0x000B0140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000B1F4C File Offset: 0x000B014C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelId = input.ReadUInt32();
					}
				}
				else
				{
					this.KIFPFCDEAAE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040019E9 RID: 6633
		private static readonly MessageParser<FNJFGLPKKIJ> _parser = new MessageParser<FNJFGLPKKIJ>(() => new FNJFGLPKKIJ());

		// Token: 0x040019EA RID: 6634
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019EB RID: 6635
		public const int LevelIdFieldNumber = 15;

		// Token: 0x040019EC RID: 6636
		private uint levelId_;

		// Token: 0x040019ED RID: 6637
		public const int KIFPFCDEAAEFieldNumber = 11;

		// Token: 0x040019EE RID: 6638
		private uint kIFPFCDEAAE_;
	}
}
