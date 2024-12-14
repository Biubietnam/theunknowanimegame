using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001167 RID: 4455
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooExchangeItemCsReq : IMessage<SpaceZooExchangeItemCsReq>, IMessage, IEquatable<SpaceZooExchangeItemCsReq>, IDeepCloneable<SpaceZooExchangeItemCsReq>, IBufferMessage
	{
		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600C6C2 RID: 50882 RVA: 0x00215934 File Offset: 0x00213B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooExchangeItemCsReq> Parser
		{
			get
			{
				return SpaceZooExchangeItemCsReq._parser;
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600C6C3 RID: 50883 RVA: 0x0021593B File Offset: 0x00213B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooExchangeItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600C6C4 RID: 50884 RVA: 0x0021594D File Offset: 0x00213B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooExchangeItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600C6C5 RID: 50885 RVA: 0x00215954 File Offset: 0x00213B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooExchangeItemCsReq()
		{
		}

		// Token: 0x0600C6C6 RID: 50886 RVA: 0x0021595C File Offset: 0x00213B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooExchangeItemCsReq(SpaceZooExchangeItemCsReq other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6C7 RID: 50887 RVA: 0x00215981 File Offset: 0x00213B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooExchangeItemCsReq Clone()
		{
			return new SpaceZooExchangeItemCsReq(this);
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x00215989 File Offset: 0x00213B89
		// (set) Token: 0x0600C6C9 RID: 50889 RVA: 0x00215991 File Offset: 0x00213B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x0600C6CA RID: 50890 RVA: 0x0021599A File Offset: 0x00213B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooExchangeItemCsReq);
		}

		// Token: 0x0600C6CB RID: 50891 RVA: 0x002159A8 File Offset: 0x00213BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooExchangeItemCsReq other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6CC RID: 50892 RVA: 0x002159D8 File Offset: 0x00213BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6CD RID: 50893 RVA: 0x00215A17 File Offset: 0x00213C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C6CE RID: 50894 RVA: 0x00215A1F File Offset: 0x00213C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6CF RID: 50895 RVA: 0x00215A28 File Offset: 0x00213C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6D0 RID: 50896 RVA: 0x00215A5C File Offset: 0x00213C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6D1 RID: 50897 RVA: 0x00215A9A File Offset: 0x00213C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooExchangeItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6D2 RID: 50898 RVA: 0x00215ACB File Offset: 0x00213CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x00215AD4 File Offset: 0x00213CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005054 RID: 20564
		private static readonly MessageParser<SpaceZooExchangeItemCsReq> _parser = new MessageParser<SpaceZooExchangeItemCsReq>(() => new SpaceZooExchangeItemCsReq());

		// Token: 0x04005055 RID: 20565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005056 RID: 20566
		public const int ItemIdFieldNumber = 15;

		// Token: 0x04005057 RID: 20567
		private uint itemId_;
	}
}
