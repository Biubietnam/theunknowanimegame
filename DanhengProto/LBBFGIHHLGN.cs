using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009E3 RID: 2531
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LBBFGIHHLGN : IMessage<LBBFGIHHLGN>, IMessage, IEquatable<LBBFGIHHLGN>, IDeepCloneable<LBBFGIHHLGN>, IBufferMessage
	{
		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x0012BF8C File Offset: 0x0012A18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LBBFGIHHLGN> Parser
		{
			get
			{
				return LBBFGIHHLGN._parser;
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06007078 RID: 28792 RVA: 0x0012BF93 File Offset: 0x0012A193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LBBFGIHHLGNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x0012BFA5 File Offset: 0x0012A1A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LBBFGIHHLGN.Descriptor;
			}
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x0012BFAC File Offset: 0x0012A1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LBBFGIHHLGN()
		{
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x0012BFB4 File Offset: 0x0012A1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LBBFGIHHLGN(LBBFGIHHLGN other) : this()
		{
			this.queuePosition_ = other.queuePosition_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x0012BFE5 File Offset: 0x0012A1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LBBFGIHHLGN Clone()
		{
			return new LBBFGIHHLGN(this);
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x0012BFED File Offset: 0x0012A1ED
		// (set) Token: 0x0600707E RID: 28798 RVA: 0x0012BFF5 File Offset: 0x0012A1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QueuePosition
		{
			get
			{
				return this.queuePosition_;
			}
			set
			{
				this.queuePosition_ = value;
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x0012BFFE File Offset: 0x0012A1FE
		// (set) Token: 0x06007080 RID: 28800 RVA: 0x0012C006 File Offset: 0x0012A206
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

		// Token: 0x06007081 RID: 28801 RVA: 0x0012C00F File Offset: 0x0012A20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LBBFGIHHLGN);
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x0012C01D File Offset: 0x0012A21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LBBFGIHHLGN other)
		{
			return other != null && (other == this || (this.QueuePosition == other.QueuePosition && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x0012C05C File Offset: 0x0012A25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QueuePosition != 0U)
			{
				num ^= this.QueuePosition.GetHashCode();
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

		// Token: 0x06007084 RID: 28804 RVA: 0x0012C0B4 File Offset: 0x0012A2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x0012C0BC File Offset: 0x0012A2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x0012C0C8 File Offset: 0x0012A2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QueuePosition != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.QueuePosition);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x0012C124 File Offset: 0x0012A324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QueuePosition != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QueuePosition);
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

		// Token: 0x06007088 RID: 28808 RVA: 0x0012C17C File Offset: 0x0012A37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LBBFGIHHLGN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QueuePosition != 0U)
			{
				this.QueuePosition = other.QueuePosition;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x0012C1CC File Offset: 0x0012A3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x0012C1D8 File Offset: 0x0012A3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 120U)
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
					this.QueuePosition = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B5E RID: 11102
		private static readonly MessageParser<LBBFGIHHLGN> _parser = new MessageParser<LBBFGIHHLGN>(() => new LBBFGIHHLGN());

		// Token: 0x04002B5F RID: 11103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B60 RID: 11104
		public const int QueuePositionFieldNumber = 8;

		// Token: 0x04002B61 RID: 11105
		private uint queuePosition_;

		// Token: 0x04002B62 RID: 11106
		public const int LevelFieldNumber = 15;

		// Token: 0x04002B63 RID: 11107
		private uint level_;
	}
}
